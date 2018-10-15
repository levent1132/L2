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
    public partial class Form12 : Form
    {
        public Form1 frm1;
        MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=; pooling = false; convert zero datetime=True");
        MySqlDataAdapter Adaptor;
        DataSet ds;
        BindingSource bs;

        public Form12()
        {
            InitializeComponent();

        }
        string[] u = new string[3];
        string[] urun = new string[3];
        int[] alis = new int[3];
        int[] satis = new int[3];
        int[] fark = new int[3];
        string[] durum = new string[3];
        int j, i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            u[i] = textBox1.Text;
            urun[i] = textBox2.Text;
            alis[i] = int.Parse(textBox3.Text);
            satis[i] = int.Parse(textBox4.Text);
            fark[i] = Math.Abs(satis[i] - alis[i]);
            //Kar Zarar Durumunu Hesaplıyoruz.
            if (alis[i] > satis[i])
            { durum[i] = "Zarar"; }
            else
            { durum[i] = "Kar"; }
            i++; j = i;
            textBox1.Clear(); textBox2.Clear();
            textBox3.Clear(); textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton3.Checked)
            {
                for (i = 0; i < j; i++)
                {
                    listBox1.Items.Add(u[i] + " " + urun[i]
                    + " " + fark[i].ToString() + " TL" +
                     " " + durum[i] + " Etti");
                }
            }
            if (radioButton1.Checked)
            {
                for (i = 0; i < j; i++)
                {
                    if (durum[i] == "Kar")
                    {
                        listBox1.Items.Add(u[i] + " " + urun[i] +
                         " " + fark[i].ToString() + " TL" + " " +
                         durum[i] + " Etti");
                    }
                }
            }
            if (radioButton2.Checked)
            {
                for (i = 0; i < j; i++)
                {
                    if (durum[i] == "Zarar")
                    {
                        listBox1.Items.Add(u[i] + " " + urun[i] +
                         " " + fark[i].ToString() + " TL" + " " +
                         durum[i] + " Etti");
                    }
                }
            }
        }
        public void dataguncelle()
        {

            Bagla.Open();
            Adaptor = new MySqlDataAdapter("SELECT u_ID, u_marka,u_alim_fiyat,u_satis_fiyat FROM `urun` ", Bagla);
            ds = new DataSet();
            bs = new BindingSource();
            Adaptor.Fill(ds, "veri2");
            bs.DataSource = ds.Tables["veri2"];
            dataGridView1.DataSource = bs;
            Bagla.Close();

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            dataguncelle();
            textguncelle();

            dataGridView1.Columns[0].HeaderText = "Ürün No";
            dataGridView1.Columns[1].HeaderText = "Ürün Marka";
            dataGridView1.Columns[2].HeaderText = "Alım Fiyatı";
            dataGridView1.Columns[3].HeaderText = "Satış Fiyatı";
            

            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].Width = 100;
            
            
            
        }
        public void textguncelle()
        {
            textBox1.Text = ds.Tables[0].Rows[0]["u_ID"].ToString();
            textBox2.Text = ds.Tables[0].Rows[0]["u_marka"].ToString();
            textBox3.Text = ds.Tables[0].Rows[0]["u_alim_fiyat"].ToString();
            textBox4.Text = ds.Tables[0].Rows[0]["u_satis_fiyat"].ToString();
            

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int satir;
            for (satir = 0; satir < dataGridView1.Rows.Count; satir++)
            {

                if (dataGridView1.Rows[satir].Cells[0].Selected == true || dataGridView1.Rows[satir].Cells[1].Selected == true || dataGridView1.Rows[satir].Cells[2].Selected == true || dataGridView1.Rows[satir].Cells[3].Selected == true)
                {
                    break;

                }
            }

            textBox1.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {        
            this.Hide();
            
        }
    }
     
}
   