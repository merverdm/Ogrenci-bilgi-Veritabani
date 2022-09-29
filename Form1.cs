using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OgrenciEntities db = new OgrenciEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Table_1OgrenciTablosu.ToList();//Listele
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table_1OgrenciTablosu t = new Table_1OgrenciTablosu();
            t.AD = textBox1.Text;
            t.SOYAD = textBox2.Text;
            db.Table_1OgrenciTablosu.Add(t);//Öğrenciyi Ekle
            db.SaveChanges();//Değişiklikleri Kaydet
            MessageBox.Show("Öğrenci Kaydedildi.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);//textbox'a girilen id de ki öğrenciyi bul
            var x = db.Table_1OgrenciTablosu.Find(id);
            db.Table_1OgrenciTablosu.Remove(x); //ID olan öğrenciyi sil
            db.SaveChanges();//Değişiklikleri Kaydet
            MessageBox.Show("Öğrenci Silindi.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
            var y = db.Table_1OgrenciTablosu.Find(id);//Güncelle
            y.AD = textBox1.Text;
            y.SOYAD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi.");
        }
    }
}
