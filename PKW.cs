using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verervung_Aufgabe
{
    internal class PKW : Auto
    {
        protected string hersteller;

        public PKW(string hersteller, string motorleistung, int max_personen) : base(motorleistung, max_personen)
        {
            this.hersteller = hersteller;
        }
    }
}
