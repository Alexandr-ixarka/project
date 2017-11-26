using System;
using Project_3_ATC.BillingSystem;
using Project_3_ATC.EventArgsChildren;

namespace Project_3_ATC.ATSModel
{
    public class Terminal
    {
        public TerminalState State { get; set; }

        public Terminal()
        {
            this.State = TerminalState.InitialState;
        }
    }
}
