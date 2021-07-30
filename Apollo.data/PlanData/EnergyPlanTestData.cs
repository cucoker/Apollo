using Apollo.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Apollo.data.PlanData
{
    public class EnergyPlanTestData : IEnergyPlanData
    {
        public List<EnergyPlan> Plans;

        public EnergyPlanTestData()
        {
            Plans = new List<EnergyPlan>()
            {
               new EnergyPlan
                {
                    EnergyPlanID = 1,
                     
                   Description = "BGE One Year Plan",
                    Price = .092M,
                    Duration = 1,
                    PlanLDC = LDC.BGE,
                    PlanUOM = PlanUOM.CentsKwh,
                    StartDate = Convert.ToDateTime("01/01/2020"), 
                    EndDate = Convert.ToDateTime("01/01/2022")
                },
                new EnergyPlan
                {
                    EnergyPlanID = 2,
                    Description = "BGE two Year Plan",
                    Price = .098M,
                    Duration = 2,
                    PlanLDC = LDC.BGE,
                    PlanUOM = PlanUOM.CentsKwh,
                    StartDate = Convert.ToDateTime("01/01/2020"),
                    EndDate = Convert.ToDateTime("01/01/2022")
                },
                new EnergyPlan
                {
                    EnergyPlanID = 2,
                    Description = "BGE three Year Plan",
                    Price = .101M,
                    Duration = 3,
                    PlanLDC = LDC.BGE,
                    PlanUOM = PlanUOM.CentsKwh,
                    StartDate = Convert.ToDateTime("01/01/2020"),
                    EndDate = Convert.ToDateTime("01/01/2022")
                }

            };
        }

        public IEnumerable<EnergyPlan> GetAll()
        {
            return from r in Plans orderby r.EnergyPlanID select r;
        }
    }
}
