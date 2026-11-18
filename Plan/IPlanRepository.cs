using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Plan
{
    internal interface IPlanRepository
    {
        void Save(Plan plan);
        void Update(Plan plan);
        void DeactivateById(int planId);
        IEnumerable<Plan> GetAll();
    }
}
