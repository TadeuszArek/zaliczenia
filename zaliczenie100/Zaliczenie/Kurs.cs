using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    class Kurs
    {
        private DateTime wyjazd, powrot;
        private string imie, nazwisko;
        private Kierowca k;
        private double wynagrodzenie, dystans;

        private int czas;

        internal Kierowca K { get => k; set => k = value; }

        public string Imie { get => k.Imie; }

        public string Nazwisko { get => k.Nazwisko; }

        public DateTime Wyjazd { get => wyjazd; set => wyjazd = value; }

        public DateTime Powrot { get => powrot; set => powrot = value; }

        public int Czas { get => czas; set => czas = value; }

        public double Wynagrodzenie { get => (k.Stawkah * Czas) + (k.Stawkakm * dystans); }

        public double Dystans { get => dystans; set => dystans = value; }
        
    }
}
