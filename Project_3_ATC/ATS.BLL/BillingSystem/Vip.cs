using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_ATC.BillingSystem
{
    public class Vip : TariffPlan
    {
        private double CostMinute;
        private double SubscriberPay;
        public Vip(DateTime connection)
        {
            this.DateConnection = connection;
        }

        public Vip(DateTime connection, double costMinute, double subscriberPay)
        {
            this.CostMinute = costMinute;
            this.SubscriberPay = subscriberPay;
            this.DateConnection = connection;
        }


    }
}
