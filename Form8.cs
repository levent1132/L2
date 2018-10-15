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
    public partial class Form8 : Form
    {
        public Form1 frm1;
        MySqlConnection connect = new MySqlConnection("server=localhost; database=lutop; user=root; password=; pooling = false;convert zero datetime=True");
        MySqlDataAdapter adapter;
        DataSet tablo;
        MySqlCommand komut;
        BindingSource acces;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            connect.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM `urun` ", connect);
            tablo = new DataSet();
            acces = new BindingSource();
            adapter.Fill(tablo, "veri2");
            acces.DataSource = tablo.Tables["veri2"];
            dataGridView1.DataSource = acces;

            guncelle();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Marka";
            dataGridView1.Columns[2].HeaderText = "Model";
            dataGridView1.Columns[3].HeaderText = "Geliş Tarih";
            dataGridView1.Columns[4].HeaderText = "Bitiş Tarih";
            dataGridView1.Columns[5].HeaderText = "Stok Adet";
            dataGridView1.Columns[6].HeaderText = "Alım Fiyat";
            dataGridView1.Columns[7].HeaderText = "Satış Fiyat";
            
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 85;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 75;
            dataGridView1.Columns[7].Width = 85;
           


            button_urunkaydet.Visible = false;
            button_urunduzenle.Visible = false;
            button_urunsil.Visible = false;
            
            connect.Close();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void guncelle()
        {

            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker2.CustomFormat = "yyyy.MM.dd";

            urun_idbox.Text = tablo.Tables[0].Rows[0]["u_ID"].ToString();
            urun_markabox.Text = tablo.Tables[0].Rows[0]["u_marka"].ToString();
            urun_modelbox.Text = tablo.Tables[0].Rows[0]["u_model"].ToString();
            dateTimePicker1.Text = tablo.Tables[0].Rows[0]["u_gelis_tarih"].ToString();
            dateTimePicker2.Text = tablo.Tables[0].Rows[0]["u_bitis_tarih"].ToString();
            urun_stokbox.Text = tablo.Tables[0].Rows[0]["u_stok"].ToString();
            urun_alimfiyatbox.Text = tablo.Tables[0].Rows[0]["u_alim_fiyat"].ToString();
            urun_satisfiyatbox.Text = tablo.Tables[0].Rows[0]["u_satis_fiyat"].ToString();

        }
        public void baglan()
        {

            
            connect.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM `urun` ", connect);
            tablo = new DataSet();
            acces = new BindingSource();
            adapter.Fill(tablo, "veri2");
            acces.DataSource = tablo.Tables["veri2"];
            dataGridView1.DataSource = acces;
            connect.Close();






        
        }
        public void textemizle()
        {
            urun_idbox.Clear();
            urun_markabox.Clear();
            urun_modelbox.Clear();
            urun_stokbox.Clear();
            urun_alimfiyatbox.Clear();
            urun_satisfiyatbox.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_urunsil.Visible = false;
            button_urunduzenle.Visible = false;
            button_urunkaydet.Visible = true;
            textemizle();
            baglan();

        }

        private void button_urunkaydet_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Kaydetmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    connect.Open();
                    MySqlCommand komut = new MySqlCommand();
                    komut.Connection = connect;
                    komut.CommandText = ("INSERT INTO urun (u_marka,u_model,u_gelis_tarih,u_bitis_tarih,u_stok,u_alim_fiyat,u_satis_fiyat) VALUES " + "( ' " + urun_markabox.Text + " ',' " + urun_modelbox.Text + " ',' " + dateTimePicker1.Text + " ','" + dateTimePicker2.Text + "','" + urun_stokbox.Text + "','" + urun_alimfiyatbox.Text + "','" + urun_satisfiyatbox.Text + "')");
                    komut.ExecuteNonQuery();
                    connect.Close();
                    baglan();


                    MessageBox.Show("Kayıt işlemi tamamlandı !");
                    textemizle();
                }
                else
                {
                    MessageBox.Show("Listeden seçim yapınız !");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz.. !");
                textemizle();
            }
        }
        

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_urunkaydet.Visible = false;
            button_urunsil.Visible = false;
            button_urunduzenle.Visible = true;
            

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_urunkaydet.Visible = false;
            button_urunduzenle.Visible = false;
            button_urunsil.Visible = true;

        }

        private void urun_stokbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urun_alimfiyatbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urun_satisfiyatbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_urunduzenle_Click(object sender, EventArgs e)
        {
            connect.Open();
                  

     
            komut = new MySqlCommand(" UPDATE `urun` SET `u_marka` = '" + urun_markabox.Text + "', `u_model` = '"
                + urun_modelbox.Text + "', `u_gelis_tarih` = '" + dateTimePicker1.Text + "', `u_bitis_tarih` = '" 
                + dateTimePicker2.Text + "', `u_stok` = '" + urun_stokbox.Text + "', `u_alim_fiyat` = '"
                + urun_alimfiyatbox.Text + "', `u_satis_fiyat` = '" + urun_satisfiyatbox.Text + "' WHERE `urun`.`u_ID` = '" 
                +  urun_idbox.Text + "'", connect);

            

            komut.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Member Id " + urun_idbox.Text + " Başarlı bir şekilde güncellendi...");

            baglan();
            guncelle();

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


            urun_idbox.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            urun_markabox.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            urun_modelbox.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            urun_stokbox.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
             urun_alimfiyatbox.Text= dataGridView1.Rows[satir].Cells[6].Value.ToString();
            urun_satisfiyatbox.Text = dataGridView1.Rows[satir].Cells[7].Value.ToString(); 



        }

        private void button_urunsil_Click(object sender, EventArgs e)
        {
            

           
            try
            {


                DialogResult cevap;
                cevap = MessageBox.Show("Silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    connect.Open();
                    komut = new MySqlCommand("delete from urun where u_ID='" + urun_idbox.Text + "' ", connect);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Silme işlemi tamamlandı !");
                    connect.Close();
                    baglan();
                    guncelle(); 
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       

       
    }
}
