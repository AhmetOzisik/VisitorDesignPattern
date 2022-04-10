using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
   public abstract class IVisitorYazıcıÖzellik
    {
        public abstract void Accept(IPrinter printer);
        
        
    }
}
