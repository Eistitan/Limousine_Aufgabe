using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verervung_Aufgabe
{
    internal class Fahrzeug
    {
        protected int max_personen;

        public Fahrzeug(int max_personen)
        {
            this.max_personen = max_personen;
        }
    }
}
