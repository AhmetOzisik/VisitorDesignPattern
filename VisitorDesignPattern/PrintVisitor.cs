using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class PrintVisitor : IVisitorYazıcıÖzellik
    {
        public override void Accept(IPrinter printer)
        {
            if (printer.Marka() == "Hp")
            {
                Console.WriteLine("Hp markasında yazdırma zaten calısıyo.");

            }
            else if (printer.Marka() == "Latex")
            {
                Console.WriteLine("Latex markasında yazdırma zaten calısıyo.");
            }
            else
            {
                Console.WriteLine("Marka hatası");
            }
        }
    }
}
