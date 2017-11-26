using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_ATC.BillingSystem
{
    public class Business : TariffPlan
    {
        public Business(DateTime connection, double outCostMinute)
            : base(connection, outCostMinute)
        {
        }
    }
}
