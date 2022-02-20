using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaliczenie
{
    public partial class Form1 : Form
    {
        List<Kurs> ListaPrzejazdow = new List<Kurs>();
        public Form1()
        {
            InitializeComponent();
            Kierowca k1 = new Kierowca();
            k1.Imie = "Andrzej";
            k1.Nazwisko = "Nowak";
            k1.Pesel = 90010107130;
            k1.Stawkah = 16;
            k1.Stawkakm = 6;
            k1.DataUrodzenia = "01-01-1990";

            Kierowca k2 = new Kierowca();
            k2.Imie = "Jan";
            k2.Nazwisko = "Kowalski";
            k2.Pesel = 90010107130;
            k2.Stawkah = 14;
            k2.Stawkakm = 5;
            k2.DataUrodzenia = "01-01-1990";

            Kierowca k3 = new Kierowca();
            k3.Imie = "Janusz";
            k3.Nazwisko = "Kowalczyk";
            k3.Pesel = 90010107130;
            k3.Stawkah = 14;
            k3.Stawkakm = 5;
            k3.DataUrodzenia = "01-01-1990";

            Kierowca k4 = new Kierowca();
            k4.Imie = "January";
            k4.Nazwisko = "Kowal";
            k4.Pesel = 90010107130;
            k4.Stawkah = 14;
            k4.Stawkakm = 5;
            k4.DataUrodzenia = "01-01-1990";

            Kierowca k5 = new Kierowca();
            k5.Imie = "Mariusz";
            k5.Nazwisko = "Nowak";
            k5.Pesel = 90010107130;
            k5.Stawkah = 14;
            k5.Stawkakm = 5;
            k5.DataUrodzenia = "01-01-1990";

            List<Kierowca> ListaKierowcow = new List<Kierowca>();

            ListaKierowcow.Add(k1);
            ListaKierowcow.Add(k2);
            ListaKierowcow.Add(k3);
            ListaKierowcow.Add(k4);
            ListaKierowcow.Add(k5);


            comboBox1.DataSource = ListaKierowcow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kierowca k = new Kierowca();
            k = (Kierowca)comboBox1.SelectedItem;

            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0)
            {
                MessageBox.Show("Nie zostały wpisane wartości!");
                return;
            }

            Kurs p1 = new Kurs();
            p1.Wyjazd = monthCalendar1.SelectionStart;
            p1.Powrot = monthCalendar1.SelectionEnd;
            p1.Dystans = (double)numericUpDown1.Value;
            p1.Czas = (int)numericUpDown2.Value;
            p1.K = k;
            ListaPrzejazdow.Add(p1);

          

            var binding = new BindingSource();
            binding.DataSource = ListaPrzejazdow;
            dataGridView1.DataSource = binding;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
