using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Plan
{
    internal class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DurationInDays { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }
    }
}
