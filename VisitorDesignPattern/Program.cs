using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
   public class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new Hp();
            IPrinter printer2 = new Latex();
            IVisitorYazıcıÖzellik visitorYazıcıÖzellik = new PrintVisitor();
            visitorYazıcıÖzellik.Accept(printer);
            visitorYazıcıÖzellik.Accept(printer2);
            IVisitorYazıcıÖzellik visitorYazıcıÖzellik2 = new FaxVisitor();
            visitorYazıcıÖzellik2.Accept(printer);
            visitorYazıcıÖzellik2.Accept(printer2);
            Console.ReadLine();
        }
    }
}
