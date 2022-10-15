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
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void button6_Click(object sender, EventArgs e)
        {
            DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
            dataGridView1.DataSource = db.derslertablo.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //var query = from item in  db.notlartablo select new (item.)
            
            dataGridView1.DataSource = db.notlartablo.ToList();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.ogrencitablo.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            int İd = Convert.ToInt32(textBox1.Text);
            var x = db.ogrencitablo.Find(İd);
            x.AD = textBox2.Text;
            x.SOYAD = textBox3.Text;
            x.FOTOGRAF = textBox4.Text;
            db.SaveChanges();
            MessageBox.Show("ÖĞRENCİ BİLGİLERİ BAŞARIYLA GÜNCELLENDİ...");
        }

        private void button10_Click(object sender, EventArgs e) //prosedür butonu
        {
            dataGridView1.DataSource = db.notlistele();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ogrencitablo.Where(x => x.AD == textBox2.Text).ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox2.Text;
            var degerler = from item in db.ogrencitablo
                           where item.AD.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                //asc: ascending
                List<ogrencitablo> liste1 = db.ogrencitablo.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked==true)
            {
                //desc:descending
                List<ogrencitablo> liste2 = db.ogrencitablo.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton3.Checked==true)   //İLK 3 KİŞİ İÇİN 
            {
                List<ogrencitablo> liste3 = db.ogrencitablo.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
