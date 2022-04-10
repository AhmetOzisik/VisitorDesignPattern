using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Latex : IPrinter
    {
        public string Marka()
        {
            return "Latex";
        }
    }
}
