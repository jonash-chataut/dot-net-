using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_electronic_device
{
    interface IElectronicDevice
    {
        void ON();
        void OFF();
        void VolumeUp();
        void VolumeDown();
    }
}
