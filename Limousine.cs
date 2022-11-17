using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verervung_Aufgabe
{
    internal class Limousine : PKW
    {
        protected string modell;

        public Limousine(string modell, string hersteller, string motorleistung, int max_personen) : base(hersteller, motorleistung, max_personen)
        {
            this.modell = modell;
        }

        public override string ToString()
        {
            string ausgabe = $"Die Limousine {modell} von {hersteller}\nAusgelegt für maximal {max_personen} Personen\nMit {motorleistung} kW Motorleistung\n";

            return ausgabe;
        }

    }
}
