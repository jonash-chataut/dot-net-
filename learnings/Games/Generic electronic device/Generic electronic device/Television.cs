using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_electronic_device
{
    class Television : IElectronicDevice
    {
        public int volume { get; set; }
        public void OFF()
        {
            Console.WriteLine("TV is Off");
        }

        public void ON()
        {
            Console.WriteLine("TV is ON");
        }

        public void VolumeDown()
        {
            if (volume != 0) volume--;
            Console.WriteLine($"Volume is at {volume}");
        }

        public void VolumeUp()
        {
            if (volume != 100) volume++;
            Console.WriteLine($"Volume is at {volume}");
        }
    }
}
