using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_electronic_device
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
