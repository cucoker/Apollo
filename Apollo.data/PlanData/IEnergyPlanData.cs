using Apollo.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.data.PlanData
{
    public interface IEnergyPlanData
    {
        IEnumerable<EnergyPlan> GetAll();
    }
}
