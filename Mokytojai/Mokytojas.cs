using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokytojoKlasesObjektas
{
    internal class Mokytojas
    {
        string vardas;
        string pavarde;
        int klase;
        string pareigos;
        int stazas;
        string issilavinimas;

        public Mokytojas(string vardas, string pavarde, int klase, string pareigos, int stazas, string issilavinimas)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.klase = klase;
            this.pareigos = pareigos;
            this.stazas = stazas;
            this.issilavinimas = issilavinimas;
        }
    }
}
