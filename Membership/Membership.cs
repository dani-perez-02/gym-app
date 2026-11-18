namespace gym_app.Membership
{
    internal class Membership
    {
        public int MembershipId { get; set; }
        public int MemberId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = "VIGENTE";

        // las fk para luego poder visualizar datos de otras tablas con join
        public string MemberRut { get; set; } = string.Empty;
        public string MemberName { get; set; } = string.Empty;
        public string PlanName { get; set; } = string.Empty;
    }
}