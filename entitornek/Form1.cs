using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entitornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            dataGridView1.DataSource = db.derslertablo.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //var query = from item in  db.notlartablo select new (item.)
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            dataGridView1.DataSource = db.notlartablo.ToList();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            dataGridView1.DataSource = db.ogrencitablo.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            ogrencitablo t = new ogrencitablo();
            t.AD = textBox2.Text;
            t.SOYAD = textBox3.Text;
            db.ogrencitablo.Add(t);
            db.SaveChanges();
            MessageBox.Show("ÖĞRENCİ LİSTEYE EKLENMİŞTİR...");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            int İd = Convert.ToInt32(textBox1.Text);
            var x = db.ogrencitablo.Find(İd);
            db.ogrencitablo.Remove(x);
            db.SaveChanges();
            MessageBox.Show("ÖĞRENCİ SİSTEMDEN SİLİNDİ...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            int İd = Convert.ToInt32(textBox1.Text);
            var x = db.ogrencitablo.Find(İd);
            x.AD = textBox2.Text;
            x.SOYAD = textBox3.Text;
            x.FOTOGRAF = textBox4.Text;
            db.SaveChanges();
            MessageBox.Show("ÖĞRENCİ BİLGİLERİ BAŞARIYLA GÜNCELLENDİ...");
        }
    }
}
