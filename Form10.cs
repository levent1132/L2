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
    public partial class Form10 : Form
    {
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=; pooling = false; convert zero datetime=True");
        MySqlDataAdapter Adaptor;
        DataSet ds;
        BindingSource bs;
        MySqlCommand komut;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_siparisdurumduzenle_Click(object sender, EventArgs e)
        {
            Bagla.Open();



            komut = new MySqlCommand(" UPDATE `siparis_durum` SET `s_ID` = '" + siparisnobox.Text + "', `m_ID` = '"
                + musterinobox.Text + "', `p_ID` = '" + pernobox.Text + "', `u_ID` = '"
                + urunnobox.Text + "', `u_durum` = '" + comboBox1.Text + "', `u_teslim_tarih` = '"
                + dateTimePicker1.Text + "', `u_cikis_tarih` = '" + dateTimePicker2.Text +  "' WHERE `s_ID` = '"
                + siparisnobox.Text + "'", Bagla);
                komut.ExecuteNonQuery();
                Bagla.Close();

            MessageBox.Show("Urun NO " + urunnobox.Text + " Başarlı bir şekilde güncellendi...");

            dataguncelle();
            textguncelle();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public void textguncelle()
        {
            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker2.CustomFormat = "yyyy.MM.dd";

            siparisnobox.Text = ds.Tables[0].Rows[0]["s_ID"].ToString();
            musterinobox.Text = ds.Tables[0].Rows[0]["m_ID"].ToString();
            pernobox.Text = ds.Tables[0].Rows[0]["p_ID"].ToString();
            urunnobox.Text = ds.Tables[0].Rows[0]["u_ID"].ToString();
            comboBox1.Text =ds.Tables[0].Rows[0]["u_durum"].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0]["u_teslim_tarih"].ToString();
            dateTimePicker2.Text = ds.Tables[0].Rows[0]["u_cikis_tarih"].ToString();
           
        }
        public void dataguncelle()
        {

            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT * FROM `siparis_durum` ", Bagla);
            komut = new MySqlCommand("SELECT * FROM `siparis_durum` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "s_durum");
            bs.DataSource = ds.Tables["s_durum"];
            dataGridView2.DataSource = bs;
            MySqlDataReader oku;
            int durum;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                durum = comboBox1.FindString(oku[0].ToString());
                if (durum == -1) comboBox1.Items.Add(oku[4].ToString());


            }
            Bagla.Close();
            oku.Dispose();

        }

        private void Form10_Load(object sender, EventArgs e)
        {




            button_sipdurekle.Visible = false;
            siparisnobox.Enabled = false;
            musterinobox.Enabled = false;
            pernobox.Enabled = false;
            urunnobox.Enabled = false;
            button_sdurum.Visible = false;
            dataguncelle();
            textguncelle();


            dataGridView2.Columns[0].HeaderText = "Sipariş NO";
            dataGridView2.Columns[1].HeaderText = "Müşteri NO";
            dataGridView2.Columns[2].HeaderText = "Personel NO";
            dataGridView2.Columns[3].HeaderText = "Ürün NO";
            dataGridView2.Columns[4].HeaderText = "Ürün Durum";
            dataGridView2.Columns[5].HeaderText = "Teslim Tarihi";
            dataGridView2.Columns[6].HeaderText = "Çıkış Tarihi";


            dataGridView2.Columns[0].Width = 90;
            dataGridView2.Columns[1].Width = 90;
            dataGridView2.Columns[2].Width = 95;
            dataGridView2.Columns[3].Width = 80;
            dataGridView2.Columns[4].Width = 95;
            dataGridView2.Columns[5].Width = 105;
            dataGridView2.Columns[6].Width = 105;
            
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int satir;
            for (satir = 0; satir < dataGridView2.Rows.Count; satir++)
            {

                if (dataGridView2.Rows[satir].Cells[0].Selected == true || dataGridView2.Rows[satir].Cells[1].Selected == true || dataGridView2.Rows[satir].Cells[2].Selected == true 
                    || dataGridView2.Rows[satir].Cells[3].Selected == true 
                    || dataGridView2.Rows[satir].Cells[4].Selected == true 
                    || dataGridView2.Rows[satir].Cells[5].Selected == true || dataGridView2.Rows[satir].Cells[6].Selected == true)
                {
                    break;

                }
            }


            siparisnobox.Text = dataGridView2.Rows[satir].Cells[0].Value.ToString();
            musterinobox.Text = dataGridView2.Rows[satir].Cells[1].Value.ToString();
            pernobox.Text = dataGridView2.Rows[satir].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView2.Rows[satir].Cells[5].Value.ToString();
            dateTimePicker2.Text = dataGridView2.Rows[satir].Cells[6].Value.ToString();
            urunnobox.Text = dataGridView2.Rows[satir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[satir].Cells[4].Value.ToString();
            
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisnobox.Enabled = true;
            musterinobox.Enabled = true;
            pernobox.Enabled = true;
            button_sipdurekle.Visible = false;
            button_sdurum.Visible = true;
        }
        public void texttemizle()
        {
            siparisnobox.Clear();
            musterinobox.Clear();
            pernobox.Clear();
            urunnobox.Clear();
            
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();

        }

        private void button_sipdurekle_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Kaydetmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    Bagla.Open();
                    MySqlCommand komut = new MySqlCommand();
                    komut.Connection = Bagla;
                    komut.CommandText = ("INSERT INTO urun_durum (s_ID,m_ID,p_ID,u_ID,u_durum,u_teslim_tarih,u_cikis_tarih) VALUES " + "('" + siparisnobox.Text + "','" + musterinobox.Text + "','" + pernobox.Text + "','" + urunnobox.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')");
                    komut.ExecuteNonQuery();
                    Bagla.Close();
                    dataguncelle();


                    MessageBox.Show("Kayıt işlemi tamamlandı !");
                    texttemizle();
                }
                else
                {
                    MessageBox.Show("Listeden seçim yapınız !");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz.. !");
                texttemizle();
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_sdurum.Visible = false;
            button_sipdurekle.Visible = true;
            siparisnobox.Enabled = true;
            musterinobox.Enabled = true;
            pernobox.Enabled = true;
            urunnobox.Enabled = true;
        }

        private void seçkeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
    }
}
