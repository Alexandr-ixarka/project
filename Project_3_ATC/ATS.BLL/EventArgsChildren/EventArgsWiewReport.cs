
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_ATC.EventArgsChildren 
{
    public class EventArgsWiewReport : EventArgs
    {
        public int NumberMonth { get; set; }

        public EventArgsWiewReport(int month)
        {
            this.NumberMonth = month;
        }
    }
}
