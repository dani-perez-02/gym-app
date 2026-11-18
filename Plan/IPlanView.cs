namespace gym_app.Plan
{
    internal interface IPlanView
    {
       
        int PlanId { get; set; }
        string PlanName { get; set; }
        string PlanDuration { get; set; }
        string PlanPrice { get; set; }

    
        event EventHandler SaveEvent;
        event EventHandler DisableEvent;
        event EventHandler ClearEvent;
        event EventHandler<Plan> PlanSelectedEvent;

        void DisplayPlans(IEnumerable<Plan> plans);
        void ShowPlan(Plan plan);
        void ShowMessage(string msg, bool isError = false);
        void ClearInputs();
    }
}