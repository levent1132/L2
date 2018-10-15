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
    public partial class Form9 : Form
    {
        public Form1 frm1;
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=; pooling = false; convert zero datetime=True");
        MySqlDataAdapter Adaptor;
        DataSet ds;
        BindingSource bs;
        MySqlCommand komut;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT * FROM `musteri` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "veri");
            bs.DataSource = ds.Tables["veri"];
            dataGridView1.DataSource = bs;

            textguncelle();


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Mail";
            dataGridView1.Columns[4].HeaderText = "GSM";
            dataGridView1.Columns[5].HeaderText = "Adres";
            dataGridView1.Columns[6].HeaderText = "Şirket";
            dataGridView1.Columns[7].HeaderText = "Şifre";

            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 85;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 75;
            dataGridView1.Columns[7].Width = 85;




            button_musduzenle.Visible = false;
            button_musekle.Visible = false;
            button_mussil.Visible = false;

            Bagla.Close();



        }
        public void textguncelle()
        {


            mus_idbox.Text = ds.Tables[0].Rows[0]["m_ID"].ToString();
            mus_adbox.Text = ds.Tables[0].Rows[0]["m_ad"].ToString();
            mus_soyadbox.Text = ds.Tables[0].Rows[0]["m_soyad"].ToString();
            mus_epostabox.Text = ds.Tables[0].Rows[0]["m_mail"].ToString();
            mus_gsmbox.Text = ds.Tables[0].Rows[0]["m_gsm"].ToString();
            mus_adresbox.Text = ds.Tables[0].Rows[0]["m_adres"].ToString();
            mus_sirketbox.Text = ds.Tables[0].Rows[0]["m_sirket"].ToString();
            mus_sifrebox.Text = ds.Tables[0].Rows[0]["m_sifre"].ToString();


        }
        public void dataguncelle()
        {

            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT * FROM `musteri` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "veri2");
            bs.DataSource = ds.Tables["veri2"];
            dataGridView1.DataSource = bs;
            Bagla.Close();

        }
        public void texttemizle()
        {
            mus_idbox.Clear();
            mus_adbox.Clear();
            mus_soyadbox.Clear();
            mus_epostabox.Clear();
            mus_gsmbox.Clear();
            mus_adresbox.Clear();
            mus_sirketbox.Clear();
            mus_sifrebox.Clear();

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_mussil.Visible = false;
            button_musduzenle.Visible = false;
            button_musekle.Visible = true;
            texttemizle();
            dataguncelle();
        }

        private void button_musekle_Click(object sender, EventArgs e)
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
                    komut.CommandText = ("INSERT INTO musteri (m_ad,m_soyad,m_mail,m_gsm,m_adres,m_sirket,m_sifre) VALUES " + "('" + mus_adbox.Text + "','" + mus_soyadbox.Text + "','" + mus_epostabox.Text + "','" + mus_gsmbox.Text + "','" + mus_adresbox.Text + "','" + mus_sirketbox.Text + "','" + mus_sifrebox.Text + "')");
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

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_musekle.Visible = false;
            button_mussil.Visible = false;
            button_musduzenle.Visible = true;

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_musekle.Visible = false;
            button_mussil.Visible = true;
            button_musduzenle.Visible = false;
        }

        private void mus_gsmbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void button_musduzenle_Click(object sender, EventArgs e)
        {
            Bagla.Open();



            komut = new MySqlCommand(" UPDATE `musteri` SET `m_ad` = '" + mus_adbox.Text + "', `m_soyad` = '"
                + mus_soyadbox.Text + "', `m_mail` = '" + mus_epostabox.Text + "', `m_gsm` = '"
                + mus_gsmbox.Text + "', `m_adres` = '" + mus_adresbox.Text + "', `m_sirket` = '"
                + mus_sirketbox.Text + "',  `m_sifre` = '" + mus_sifrebox.Text + "' WHERE `m_ID` = '"
                + mus_idbox.Text + "'", Bagla);



            komut.ExecuteNonQuery();

            Bagla.Close();

            MessageBox.Show("musteri Id " + mus_idbox.Text + " Başarlı bir şekilde güncellendi...");

            dataguncelle();
            textguncelle();
        }

        private void button_mussil_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    Bagla.Open();
                    komut = new MySqlCommand("delete from musteri where m_ID='" + mus_idbox.Text + "' ", Bagla);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Silme işlemi tamamlandı !");
                    Bagla.Close();
                    dataguncelle();
                    textguncelle();
                }
                else
                {
                    MessageBox.Show("Listeden seçim yapınız !");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz.. !");

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int satir;
            for (satir = 0; satir < dataGridView1.Rows.Count; satir++)
            {

                if (dataGridView1.Rows[satir].Cells[0].Selected == true || dataGridView1.Rows[satir].Cells[1].Selected == true || dataGridView1.Rows[satir].Cells[2].Selected == true || dataGridView1.Rows[satir].Cells[3].Selected == true || dataGridView1.Rows[satir].Cells[4].Selected == true || dataGridView1.Rows[satir].Cells[5].Selected == true || dataGridView1.Rows[satir].Cells[6].Selected == true || dataGridView1.Rows[satir].Cells[7].Selected == true)
                {
                    break;

                }
            }


            mus_idbox.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            mus_adbox.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            mus_soyadbox.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            mus_epostabox.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            mus_gsmbox.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            mus_adresbox.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            mus_sirketbox.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
            mus_sifrebox.Text = dataGridView1.Rows[satir].Cells[7].Value.ToString();

        }



    }
}
