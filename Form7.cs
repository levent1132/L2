using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
// gel senide ekleyelim neye veritabanınahayırrr banane 

namespace luttop_co
{
    public partial class Form7 : Form
    {
        public Form1 frm1;
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=; pooling = false; convert zero datetime=True");
        MySqlDataAdapter Adaptor;
        DataSet ds;
        BindingSource bs;
        MySqlCommand komut;
        public Form7()
        {
            InitializeComponent();
                
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT * FROM `personel` ", Bagla);
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
            dataGridView1.Columns[6].HeaderText = "Maaş";
            dataGridView1.Columns[7].HeaderText = "Ünvan";
            dataGridView1.Columns[8].HeaderText = "Şifre";

            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 85;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 75;
            dataGridView1.Columns[7].Width = 85;
            dataGridView1.Columns[8].Width = 85;



            button_perekle.Visible = false;
            button_perduzenle.Visible = false;
            button_persil.Visible = false;

            Bagla.Close();

            

          
        }

        private void button_geridon_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }
        public void textguncelle()
        {
            per_idbox.Text = ds.Tables[0].Rows[0]["p_ID"].ToString();
            per_adbox.Text = ds.Tables[0].Rows[0]["p_ad"].ToString();
            per_soyadbox.Text = ds.Tables[0].Rows[0]["p_soyad"].ToString();
            per_epostabox.Text = ds.Tables[0].Rows[0]["p_mail"].ToString();
            per_gsmbox.Text = ds.Tables[0].Rows[0]["p_GSM"].ToString();
            per_adresbox.Text = ds.Tables[0].Rows[0]["p_adres"].ToString();
            per_maasbox.Text = ds.Tables[0].Rows[0]["p_maas"].ToString();
            per_unvanbox.Text = ds.Tables[0].Rows[0]["p_unvan"].ToString();
            per_sifrebox.Text = ds.Tables[0].Rows[0]["p_sifre"].ToString();

        }
        public void dataguncelle()
        {

            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT * FROM `personel` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "veri2");
            bs.DataSource = ds.Tables["veri2"];
            dataGridView1.DataSource = bs;
            Bagla.Close();
        
        }
        public void texttemizle()
        {
            per_idbox.Clear();
            per_adbox.Clear();
            per_soyadbox.Clear();
            per_epostabox.Clear();
            per_gsmbox.Clear();
            per_adresbox.Clear();
            per_maasbox.Clear();
            per_unvanbox.Clear();
            per_sifrebox.Clear();

        }


        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            button_persil.Visible = false;
            button_perduzenle.Visible = false;
            button_perekle.Visible = true;
            texttemizle();
            dataguncelle();


        }

        private void button_perekle_Click(object sender, EventArgs e)
        {
           try{


                DialogResult cevap;
                cevap = MessageBox.Show("Kaydetmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    Bagla.Open();
                    MySqlCommand komut = new MySqlCommand();
                    komut.Connection = Bagla;
                    komut.CommandText = ("INSERT INTO personel (p_ad,p_soyad,p_mail,p_GSM,p_adres,p_maas,p_unvan,p_sifre) VALUES " + "('" + per_adbox.Text + "','" + per_soyadbox.Text + "','" + per_epostabox.Text + "','" + per_gsmbox.Text + "','" + per_adresbox.Text + "','" + per_maasbox.Text + "','" + per_unvanbox.Text + "','" + per_sifrebox.Text + "')");
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
            button_perekle.Visible = false;
            button_persil.Visible = false;
            button_perduzenle.Visible = true;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_perekle.Visible = false;
            button_persil.Visible = true;
            button_perduzenle.Visible = false;
        }

        private void per_gsmbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        
        }

        private void per_maasbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        
        }

        private void button_perduzenle_Click(object sender, EventArgs e)
        {
            Bagla.Open();



            komut = new MySqlCommand(" UPDATE `personel` SET `p_ad` = '" + per_adbox.Text + "', `p_soyad` = '"
                + per_soyadbox.Text + "', `p_mail` = '" + per_epostabox.Text + "', `p_GSM` = '"
                + per_gsmbox.Text + "', `p_adres` = '" + per_adresbox.Text + "', `p_maas` = '"
                + per_maasbox.Text + "', `p_unvan` = '" + per_unvanbox.Text + "', `p_sifre` = '" + per_sifrebox.Text + "' WHERE `p_ID` = '"
                + per_idbox.Text + "'", Bagla);



            komut.ExecuteNonQuery();

            Bagla.Close();

            MessageBox.Show("Personel Id " + per_idbox.Text + " Başarlı bir şekilde güncellendi...");

            dataguncelle();
            textguncelle();

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


            per_idbox.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            per_adbox.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            per_soyadbox.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            per_epostabox.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            per_gsmbox.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            per_adresbox.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            per_maasbox.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
            per_unvanbox.Text = dataGridView1.Rows[satir].Cells[7].Value.ToString();
            per_sifrebox.Text = dataGridView1.Rows[satir].Cells[8].Value.ToString(); 

        }

        private void button_persil_Click(object sender, EventArgs e)
        {
         try        {                 


                DialogResult cevap;
                cevap = MessageBox.Show("Silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    Bagla.Open();
                    komut = new MySqlCommand("delete from personel where p_ID='" + per_idbox.Text + "' ", Bagla);
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
    }
}
