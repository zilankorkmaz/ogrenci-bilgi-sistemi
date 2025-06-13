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
    public partial class Form2 : Form
    {
        Ogrenci ogrenci;
        List<Not> notlar = new List<Not>();
        List<Ders> dersler = new List<Ders>();
        public Form2(Ogrenci yeniogr)
        {
            InitializeComponent();
            ogrenci = yeniogr;
            this.Text = $"Not Girişi - {yeniogr.adSoyad}";

            dersler.Add(new Zorunlu { dersKodu = "AİT210", dersAdi = "İnkılap II", Kredi = 4 });
            dersler.Add(new Zorunlu { dersKodu = "BMÜ222", dersAdi = "Yapay Zeka", Kredi = 5 });
            dersler.Add(new Zorunlu { dersKodu = "BMÜ234", dersAdi = "BOT", Kredi = 4 });
            dersler.Add(new Secmeli { dersKodu = "BMÜ256", dersAdi = "Makine Öğrenmesi", Kredi = 4 });
            dersler.Add(new Zorunlu { dersKodu = "BMÜ260", dersAdi = "NTP", Kredi = 4 });
            dersler.Add(new Zorunlu { dersKodu = "İST234", dersAdi = "İstatistik", Kredi = 4 });
            dersler.Add(new Zorunlu { dersKodu = "MAT272", dersAdi = "Diferansiyel", Kredi = 4 });

            comboBox1.Items.AddRange(dersler.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){ }

        private void button1_Click(object sender, EventArgs e) //ders ve not ekle
        {
            Ders dsec = (Ders)comboBox1.SelectedItem;
            int vize = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            Not n = new Not
            {
                Ogrenci = ogrenci,
                Ders = dsec,
                Vize = vize,
                Final = final,
            };
            notlar.Add(n);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = notlar.Select(n => new
            {
                Ders = n.Ders.dersAdi,
                Kredi=n.Ders.Kredi,
                Tür=(n.Ders is Zorunlu) ? "Zorunlu" : "Seçmeli",
                Vize=n.Vize,
                Final=n.Final,
                
            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e) //transkript yazdır
        {
            Form f3 = new Form3(ogrenci, notlar);
            f3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
    }
}
