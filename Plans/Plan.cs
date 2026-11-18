using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Plans
{
    internal class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }
        public decimal price { get; set; }

    }
}
