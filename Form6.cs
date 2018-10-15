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
    public partial class Form6 : Form
    {
        public Form1 frm1;
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=");
        MySqlDataAdapter Adaptor;
        DataSet ds;
        BindingSource bs;
        //MySqlCommand komut;
       // Form5 frm5 = new Form5();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataguncelle();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
        public void dataguncelle()
        {

            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT p_ID, p_ad, p_soyad,p_GSM,p_adres,p_unvan FROM `personel` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "s_durum");
            bs.DataSource = ds.Tables["s_durum"];
            dataGridView1.DataSource = bs;

            dataGridView1.Columns[0].HeaderText = "Personel No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "GSM";
            dataGridView1.Columns[4].HeaderText = "Adres";
            dataGridView1.Columns[5].HeaderText = "Ünvan";


            dataGridView1.Columns[0].Width = 105;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 105;
            dataGridView1.Columns[5].Width = 100;
            Bagla.Close();

        }
    }
}
