using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_electronic_device
{
    internal class PowerBUtton : ICommand
    {
        IElectronicDevice device;
        public PowerBUtton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.ON();
        }

        public void Undo()
        {
            device.OFF();
        }
    }
}
