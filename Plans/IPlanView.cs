using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Plans
{
    internal interface IPlanView
    {
        // Propiedades

        int PlanId { get; set; }
        string PlanName { get; set; }
        string PlanDescription { get; set; }
        string PlanDuration { get; set; }
        string PlanPrice { get; set; }


        // Eventos

        event EventHandler SaveEvent;
        event EventHandler DisableEvent;
        event EventHandler ClearEvent;
        event EventHandler<Plan> PlanSelectedEvent;


        // Métodos

        void DisplayPlans(IEnumerable<Plan> plans);
        void ShowPlan(Plan plan);
        void ShowMessage(string msg, bool isError = false);
        void ClearInputs();
    }
}

