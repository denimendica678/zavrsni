using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaZavrsniRad
{
    class Brod
    {
        int imo;
        float duzina, sirina, gaz;
        string zastava, vrsta, ime;

        public Brod(int imo, float duzina, float sirina, float gaz, string zastava, string vrsta, string ime)
        {
            this.imo = imo;
            this.duzina = duzina;
            this.sirina = sirina;
            this.gaz = gaz;
            this.zastava = zastava;
            this.vrsta = vrsta;
            this.ime = ime;
        }

        public int Imo { get => imo; set => imo = value; }
        public float Duzina { get => duzina; set => duzina = value; }
        public float Sirina { get => sirina; set => sirina = value; }
        public float Gaz { get => gaz; set => gaz = value; }
        public string Zastava { get => zastava; set => zastava = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string Ime { get => ime; set => ime = value; }
    }
}
