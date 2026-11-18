namespace gym_app.Membership
{
    internal interface IMembershipView
    {
        int MembershipId { get; set; }
        int SelectedMemberId { get; set; }
        int SelectedPlanId { get; set; }
        DateTime StartDate { get; set; }
        string EndDatePreview { set; }

        event EventHandler SaveEvent;
        event EventHandler CancelMembershipEvent;
        event EventHandler ClearEvent;
        event EventHandler PlanOrDateChangedEvent;
        event EventHandler<Membership> MembershipSelectedEvent;

        void LoadMembers(IEnumerable<Member.Member> members);
        void LoadPlans(IEnumerable<Plan.Plan> plans);
        void DisplayMemberships(IEnumerable<Membership> memberships);
        void ShowMembership(Membership membership);
        void ShowMessage(string msg, bool isError = false);
        void ClearInputs();
    }
}