using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Plans
{
    internal class IPlanRepository
    {
        void Save(Plan plan);

        void Update(Plan plan);

        void DeactivateById(int planId);

        IEnumerable<Plan> GetAll();

        Plan GetPlanById(int planId);

        Plan GetPlanByName(string name);
    }
}
