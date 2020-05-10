using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda_Ifadeleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Rastgele 1 ile 50 arası 10 sayı tutan liste:
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int olusan_sayi = rnd.Next(0, 51);
                sayilar[i] = olusan_sayi;
            }
            // Sayılar listesi içerisindeki çift sayıları bulma:
            List<int> cift_sayilar = sayilar.Where(c => c % 2 == 0).ToList();
        }
    }
}
// Lambda operatörü: =>
// Daha basit ve sade linq ifadeleri geliştirmeye yarar.