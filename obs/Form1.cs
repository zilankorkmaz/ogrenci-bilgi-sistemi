using System.Security.Cryptography;

namespace obs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //kayýt ekle
        {
            string ad = textBox1.Text;
            int no = Convert.ToInt32(textBox2.Text);

            Ogrenci ogr= new Ogrenci { adSoyad = ad, Numara=no };
            MessageBox.Show("Öðrenci Eklendi");
            Form2 fr= new Form2(ogr);
            fr.Show();
            this.Hide();
        }
    }
}