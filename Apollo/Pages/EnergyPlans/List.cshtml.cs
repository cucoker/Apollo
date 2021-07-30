using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apollo.Core;
using Apollo.data.PlanData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apollo.Pages.EnergyPlans
{
    public class ListModel : PageModel
    {
        private IEnergyPlanData EnergyPlanData;
        public IEnumerable<EnergyPlan> Plans;

        public ListModel(IEnergyPlanData Plans)
        {
            EnergyPlanData = Plans;
        }

        public void OnGet()
        {
            Plans = EnergyPlanData.GetAll();
        }
    }
}
