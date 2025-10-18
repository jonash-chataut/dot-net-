using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_electronic_device
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerBUtton powbt = new PowerBUtton(TV);
            powbt.Execute();
            powbt.Undo();


        }
    }
}
