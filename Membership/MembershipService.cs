using gym_app.Member;
using gym_app.Plan;

namespace gym_app.Membership
{
    internal class MembershipService
    {
        private readonly IMembershipRepository _membershipRepo;
        private readonly IMemberRepository _memberRepo;
        private readonly IPlanRepository _planRepo;

        public MembershipService(
            IMembershipRepository membershipRepo,
            IMemberRepository memberRepo,
            IPlanRepository planRepo)
        {
            _membershipRepo = membershipRepo;
            _memberRepo = memberRepo;
            _planRepo = planRepo;
        }

        public IEnumerable<Membership> GetAllMemberships()
        {
            _membershipRepo.ExpireOutdatedMemberships();
            return _membershipRepo.GetAll();
        }

        public IEnumerable<Member.Member> GetActiveMembers()
            => _memberRepo.GetAll(MemberFilter.MembersFilter.Activo);

        public IEnumerable<Plan.Plan> GetActivePlans()
            => _planRepo.GetAll();

        public DateTime CalculateEndDate(DateTime startDate, int durationInDays)
            => startDate.Date.AddDays(durationInDays);

        public Membership RegisterMembership(int memberId, int planId, DateTime startDate)
        {
            if (memberId <= 0)
                throw new InvalidOperationException("Debe seleccionar un socio válido.");

            if (planId <= 0)
                throw new InvalidOperationException("Debe seleccionar un plan válido.");

            _membershipRepo.ExpireOutdatedMemberships();

            if (_membershipRepo.HasActiveMembership(memberId))
                throw new InvalidOperationException("El socio ya cuenta con una suscripción vigente.");

            var plan = _planRepo.GetAll().FirstOrDefault(p => p.PlanId == planId)
                ?? throw new InvalidOperationException("El plan seleccionado no existe o está inactivo.");

            var membership = new Membership
            {
                MemberId = memberId,
                PlanId = planId,
                StartDate = startDate.Date,
                EndDate = CalculateEndDate(startDate, plan.DurationInDays),
                Status = "VIGENTE"
            };

            _membershipRepo.Save(membership);
            return membership;
        }

        public void CancelMembership(int membershipId)
        {
            if (membershipId <= 0)
                throw new InvalidOperationException("Seleccione una suscripción de la tabla para cancelar.");

            _membershipRepo.UpdateStatus(membershipId, "CANCELADA");
        }
    }
}