using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.Core
{
    public class EnergyPlan
    {
        public int EnergyPlanID { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public LDC PlanLDC { get; set; }

        public PlanUOM PlanUOM {get; set;}

    }


}
