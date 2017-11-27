using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_ATC.EventArgsChildren
{
    public class EventArgsCall : EventArgs
    {
        public int InPhoneNumber { get; set; }

        public int OutPhoneNumber { get; set; }

        public DateTime StartCall { get; set; }

        public DateTime EndCall { get; set; }
    }
}
