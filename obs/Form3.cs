using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obs
{
    public partial class Form3 : Form
    {
        public Form3(Ogrenci ogr, List<Not> notlar)
        {
            InitializeComponent();
            this.Text = "Transkript";
            label1.Text = $"{ogr.Numara}";
            label3.Text = $"{ogr.adSoyad}";

            dataGridView1.DataSource = notlar.Select(n => new
            {
                Kod = n.Ders.dersKodu,
                Ad = n.Ders.dersAdi,
                Kredi = n.Ders.Kredi,
                Vize = n.Vize,
                Final = n.Final,
                Ortalama = n.Ort,
            }).ToList();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            double gano = 0;
            int tkredi = 0;
            foreach (var n in notlar)
            {
                gano += n.Ort * n.Ders.Kredi;
                tkredi += n.Ders.Kredi;
            }
            gano = tkredi > 0 ? gano / tkredi : 0;
            label2.Text = $"{gano}";


        }

        private void Form3_Load(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e){}
    }
}
