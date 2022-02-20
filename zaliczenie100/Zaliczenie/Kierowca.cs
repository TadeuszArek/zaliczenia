using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    class Kierowca
    {
        private string imie, nazwisko, dataUrodzenia;
        private int stawkakm, stawkah;
        private long pesel;


        public string Imie { get => imie; set => imie = value; }

        public string Nazwisko { get => nazwisko; set => nazwisko = value; }

        public string DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }

        public int Stawkakm { get => stawkakm; set => stawkakm = value; }

        public int Stawkah { get => stawkah; set => stawkah = value; }

        public long Pesel { get => pesel; set => pesel = value; }

        public override string ToString()
        {
            return imie + " " + nazwisko;
        }
    }
}
