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
    public partial class Form11 : Form
    {
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=");
        MySqlDataAdapter Adaptor;
        DataSet ds;
        BindingSource bs;
       // MySqlCommand komut;
        public Form11()
        {
            InitializeComponent();
        }
        public void dataguncelle()
        {

            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT m_ID, m_ad, m_soyad,m_GSM,m_adres,m_sirket FROM `musteri` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "m_durum");
            bs.DataSource = ds.Tables["m_durum"];
            dataGridView1.DataSource = bs;

            dataGridView1.Columns[0].HeaderText = "Müşteri No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "GSM";
            dataGridView1.Columns[4].HeaderText = "Adres";
            dataGridView1.Columns[5].HeaderText = "Şirket";


            dataGridView1.Columns[0].Width = 105;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 105;
            dataGridView1.Columns[5].Width = 100;
            Bagla.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            dataguncelle();
        }
    }
}
