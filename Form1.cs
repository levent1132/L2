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
    public partial class Form1 : Form
    {
        public Form1 frm1;
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;
        public Form7 frm7;
        public Form8 frm8;
        public Form9 frm9;
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=");
       // MySqlDataAdapter Adaptor;
       // DataSet Ds;
        //BindingSource bs;
        //MySqlCommand komut;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm6 = new Form6();
            frm7 = new Form7();
            frm8 = new Form8();
            frm9 = new Form9();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
            frm6.frm1 = this;
            frm7.frm1 = this;
            frm8.frm1 = this;
            frm9.frm1 = this;
        }

        private void bttn_per_Click(object sender, EventArgs e)
        {
            
        }

        private void bttn_admin_Click(object sender, EventArgs e)
        {
           
        }

        private void bttn_cikis_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
       
    }
}