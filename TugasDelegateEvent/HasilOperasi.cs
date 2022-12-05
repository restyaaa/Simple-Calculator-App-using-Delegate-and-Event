using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TugasDelegateEvent
{
    public partial class HasilOperasi : Form
    {
        public HasilOperasi()
        {
            InitializeComponent();
        }

        private void Tulis(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', 'x', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            OutputHasil.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}" );
        }

        private void Menghitung(object sender, EventArgs e)
        {
            Kalkulator hitung = new Kalkulator();

            hitung.OnProses += Tulis;   // daftarkan event handler
            hitung.ShowDialog();
        }
    }
}
