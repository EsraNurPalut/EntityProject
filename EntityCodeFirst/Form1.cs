using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCodeFirst.Entity;
namespace EntityCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Context c = new Context();
            //c.Database.Create();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri go = new Musteri();
            go.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kategori go = new Kategori();
            go.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunler go = new urunler();
            go.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            magaza go = new magaza();
            go.Show();
            this.Hide();
        }
    }
}
