using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace luttop_co
{
    public partial class Form5 : Form
    {
        public Form1 frm1;
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=");
        MySqlDataAdapter Adaptor;
        DataSet ds;
        BindingSource bs;
        
        public Form5()
        {
            InitializeComponent();
        }

        
        public void siparisgöster () {
        
        
            
        
        
        
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 urunnekle = new Form8();
            this.Hide();
            urunnekle.Show();
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form9 musteriekle = new Form9();
            this.Hide();
            musteriekle.Show();

        }

        private void düzenleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void siparişDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

            


            dataGridView1.Visible = false;
            dataGridView2.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gösterToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            dataGridView2.Visible = true;
            


            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT * FROM `siparis_durum` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "veri1");
            bs.DataSource = ds.Tables["veri1"];
            dataGridView2.DataSource = bs;
            dataGridView2.Columns[0].HeaderText = "Sipariş No";
            dataGridView2.Columns[1].HeaderText = "Müşteri No";
            dataGridView2.Columns[2].HeaderText = "Personel No";
            dataGridView2.Columns[3].HeaderText = "Ürün No";
            dataGridView2.Columns[4].HeaderText = "Ürün Durum";
            dataGridView2.Columns[5].HeaderText = "Ürün Teslim Tarih";
            dataGridView2.Columns[6].HeaderText = "Ürün Çıkış Tarih";
            

            dataGridView2.Columns[0].Width = 85;
            dataGridView2.Columns[1].Width = 85;
            dataGridView2.Columns[2].Width = 85;
            dataGridView2.Columns[3].Width = 75;
            dataGridView2.Columns[4].Width = 85;
            dataGridView2.Columns[5].Width = 105;
            dataGridView2.Columns[6].Width = 105;
            
            Bagla.Close();
        }

        private void gizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void gösterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            

           
            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT * FROM `siparis` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "veri2");
            bs.DataSource = ds.Tables["veri2"];
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "Sipariş No";
            dataGridView1.Columns[1].HeaderText = "Müşteri No";
            dataGridView1.Columns[2].HeaderText = "Ürün No";
            dataGridView1.Columns[3].HeaderText = "Sipariş Adeti";

            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 100;
            Bagla.Close();
            
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 seckepersonelekle = new Form7();
            this.Hide();
            seckepersonelekle.Show();
        }

        private void girişPANELİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kârZararTabosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
