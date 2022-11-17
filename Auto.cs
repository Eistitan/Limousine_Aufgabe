using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verervung_Aufgabe
{
    internal class Auto : Fahrzeug
    {
        protected string motorleistung;

        public Auto(string motorleistung, int max_personen) : base(max_personen)
        {
            this.motorleistung = motorleistung;
        }
    }
}
