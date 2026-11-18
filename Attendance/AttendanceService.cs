using gym_app.Member;
using gym_app.Membership;

namespace gym_app.Attendance
{
    internal class AttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepo;
        private readonly IMemberRepository _memberRepo;
        private readonly IMembershipRepository _membershipRepo;

        public AttendanceService(
            IAttendanceRepository attendanceRepo,
            IMemberRepository memberRepo,
            IMembershipRepository membershipRepo)
        {
            _attendanceRepo = attendanceRepo;
            _memberRepo = memberRepo;
            _membershipRepo = membershipRepo;
        }

        public IEnumerable<Attendance> GetTodayAttendance()
            => _attendanceRepo.GetTodayAttendance();

        public CheckInResult RegisterCheckIn(string rut)
        {
            var cleanRut = rut?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(cleanRut))
            {
                return new CheckInResult
                {
                    IsAllowed = false,
                    Title = "INGRESE UN RUT",
                    MemberName = "Campo vacío",
                    Detail = "Escriba o escanee el RUT del socio para validar su acceso."
                };
            }

            var member = _memberRepo.GetMemberByRut(cleanRut);
            if (member == null)
            {
                return new CheckInResult
                {
                    IsAllowed = false,
                    Title = "✖ ACCESO DENEGADO",
                    MemberName = "Socio no encontrado",
                    Detail = $"No existe un socio activo con el RUT {cleanRut}."
                };
            }

            _membershipRepo.ExpireOutdatedMemberships();

            var activeMembership = _membershipRepo.GetAll()
                .FirstOrDefault(ms =>
                    ms.MemberId == member.MemberId &&
                    ms.Status == "VIGENTE" &&
                    ms.EndDate.Date >= DateTime.Today);

            if (activeMembership == null)
            {
                return new CheckInResult
                {
                    IsAllowed = false,
                    Title = "✖ ACCESO DENEGADO",
                    MemberName = member.Name,
                    Detail = "No cuenta con una suscripción vigente."
                };
            }

            _attendanceRepo.Save(member.MemberId);

            int daysLeft = (activeMembership.EndDate.Date - DateTime.Today).Days;
            string expirationText = daysLeft == 0
                ? "Vence hoy"
                : $"Vence en {daysLeft} {(daysLeft == 1 ? "día" : "días")}";

            return new CheckInResult
            {
                IsAllowed = true,
                Title = "✔ ACCESO PERMITIDO",
                MemberName = member.Name,
                Detail = $"{activeMembership.PlanName} · {expirationText}"
            };
        }
    }
}