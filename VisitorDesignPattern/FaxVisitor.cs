using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class FaxVisitor : IVisitorYazıcıÖzellik
    {
        public override void Accept(IPrinter printer)
        {
            if (printer.Marka() == "Hp")
            {
                Console.WriteLine("Hp markasında fax çalıstığı için ekleme yapildi.");

            }else if (printer.Marka() == "Latex")
            {
                Console.WriteLine("Latex markasında fax calısmadığı için ekleme yapilmadi");
            }
            else
            {
                Console.WriteLine("Marka hatası");
            }
        }
    }
}
