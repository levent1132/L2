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
    public partial class Form4 : Form
    {
        Form10 frm10 = new Form10();
        public Form1 frm1;
        MySqlConnection connect = new MySqlConnection("server=localhost; database=lutop; user=root; password=");
        MySqlDataAdapter adapter;
        DataSet tablo;
        BindingSource acces;
        MySqlCommand komut;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
          

            connect.Open();
            adapter = new MySqlDataAdapter("SELECT `s_ID`, `m_ID`, `u_ID`, `s_adet` FROM `siparis` ", connect);
            tablo = new DataSet();
            acces = new BindingSource();
            adapter.Fill(tablo, "veri2");
            acces.DataSource = tablo.Tables["veri2"];
            dataGridView1.DataSource = acces;
            connect.Close();
            dataGridView1.Columns[0].HeaderText = "Sipariş NO";
            dataGridView1.Columns[1].HeaderText = "Müşteri NO";
            dataGridView1.Columns[2].HeaderText = "Ürün NO";
            dataGridView1.Columns[3].HeaderText = "Sipariş Adet";
            

            dataGridView1.Columns[0].Width = 105;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 100;
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gösterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        private void button_geridon_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
        }

        private void gzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView1.Visible = true;
        }

        private void button_siparisduzenle_Click(object sender, EventArgs e)
        {
            connect.Open();



            komut = new MySqlCommand(" UPDATE `siparis` SET `s_ID` = '" + siparisidbox.Text + "', `m_ID` = '"
                + musteriidbox.Text + "', `u_ID` = '" + urunidbox.Text + "', `s_adet` = '"
                + siparisadetbox.Text + "' WHERE `s_ID` = '"
                + siparisidbox.Text + "'", connect);
            komut.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Sipariş NO " + siparisidbox.Text + " Başarlı bir şekilde güncellendi...");

            dataguncelle();
            textguncelle();
        }
        public void textguncelle()
        {
           

            siparisidbox.Text = tablo.Tables[0].Rows[0]["s_ID"].ToString();
            musteriidbox.Text = tablo.Tables[0].Rows[0]["m_ID"].ToString();
            urunidbox.Text = tablo.Tables[0].Rows[0]["u_ID"].ToString();
            siparisadetbox.Text = tablo.Tables[0].Rows[0]["s_adet"].ToString();
            
        }
        public void dataguncelle()
        {

            connect.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM `siparis_durum` ", connect);
            komut = new MySqlCommand("SELECT * FROM `siparis_durum` ", connect);
            tablo = new DataSet();
            acces = new BindingSource();
            adapter.Fill(tablo, "s_durum");
            acces.DataSource = tablo.Tables["s_durum"];
            dataGridView1.DataSource = acces;
            connect.Close();

        }

        private void gösterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void gösterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girişPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

            this.Hide();
            frm10.Hide();

        }
    }
}
