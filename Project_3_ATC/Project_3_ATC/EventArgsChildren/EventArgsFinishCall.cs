using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_ATC.EventArgsChildren
{
    public class EventArgsFinishCall : EventArgs
    {
        public CallInfo CallInfo { get; set; }
    }
}
