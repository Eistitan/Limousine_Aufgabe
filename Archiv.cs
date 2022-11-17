using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verervung_Aufgabe
{
    internal class Archiv
    {
        static Limousine limo1 = new("Keko", "Yuyuki", "50", 3);
        static Limousine limo2 = new("Batmobile", "Wayne Ind.", "over 9000", 1);
        static Limousine limo3 = new("Ente", "Citroen", "1", 1);

        public static void Ausgabe()
        {
            Console.WriteLine(limo1);
            Console.WriteLine(limo2);
            Console.WriteLine(limo3);
        }
    }
}
