using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Hp : IPrinter
    {
        public string Marka()
        {
            return "Hp";
        }
    }
}
