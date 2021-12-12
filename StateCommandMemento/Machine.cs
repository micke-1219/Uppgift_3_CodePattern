using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class Machine : IMachineState
    {
        public IMachineState machineState;
        public Machine()
        {
            machineState = new MachineOffState();
        }
        public void PowerSwitch()
        {
            machineState.PowerSwitch();
            if (machineState is MachineOffState)
            {
                machineState = new MachineOnState();
            }
            else
            {
                machineState = new MachineOffState();
            }
        }
    }
}
