using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_ATC.BillingSystem
{
    public abstract class TariffPlan
    {
        public double OutCallCostMinute { get; set; }

        public DateTime DateConnection { get; set; }

        public TariffPlan()
        {

        }

        protected TariffPlan(DateTime connection, double outCostMinute)
        {
            this.OutCallCostMinute = outCostMinute;
            this.DateConnection = connection;
        }
    }
}