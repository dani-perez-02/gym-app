namespace gym_app.Membership
{
    internal interface IMembershipRepository
    {
        void Save(Membership membership);
        void UpdateStatus(int membershipId, string status);
        void ExpireOutdatedMemberships();
        bool HasActiveMembership(int memberId);
        IEnumerable<Membership> GetAll();
    }
}