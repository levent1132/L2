using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

using System.Drawing.Imaging;


namespace luttop_co
{
    public partial class Form3 : Form
    {
        public MySqlConnection Bagla = new MySqlConnection("server=localhost; database=lutop; user=root; password=");
        MySqlDataAdapter Adaptor;
        DataSet Ds;
        public Form1 frm1;
        
        Bitmap bmp;
        Graphics grp;
        string chars = "abcdefghıijklmnoöprsştuüvyz0123456789";
        Random rdm = new Random();
        string captcha;

        public Form3()
        {
            InitializeComponent();
        }

        private void bttn_giris_Click(object sender, EventArgs e)
        {
            try
            {
               // string k_sifre = adminsifrebox.Text;
               // string k_mail = adminepostabox.Text;
                Adaptor = new MySqlDataAdapter("select * from admin where a_mail='" + adminepostabox.Text + "' and a_sifre = " + adminsifrebox.Text + "", Bagla);
                Bagla.Open();
                Ds = new DataSet();
                Ds.Clear();
                Adaptor.Fill(Ds, "veri");

                if (Ds.Tables[0].Rows.Count == 1 && captcha == captchabox.Text)
                {
                    string adı = Ds.Tables[0].Rows[0]["a_ad"].ToString();
                    string password = Ds.Tables[0].Rows[0]["a_sifre"].ToString();
                    string soyad = Ds.Tables[0].Rows[0]["a_soyad"].ToString();
                    string email = Ds.Tables[0].Rows[0]["a_mail"].ToString();

                    MessageBox.Show("Giriş Yapıldı..  Hoş Geldiniz  :" + adı + " " + soyad, "Hoş geldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminepostabox.Clear();
                    adminepostabox.DataBindings.Clear();
                    adminsifrebox.Clear();
                    adminsifrebox.DataBindings.Clear();
                    Form5 frm5 = new Form5();
                    this.Hide();
                    frm5.Show();

                }
                Bagla.Close();
            }
                 
            catch (Exception)
            {

                MessageBox.Show("E-mail adresi :" + " " + adminepostabox.Text + " - şifre : " + adminsifrebox.Text + "  Gözden Geçiriniz", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminsifrebox.Clear();
                
                
            }
            if (captcha != captchabox.Text)
            {

                DialogResult br;
                br = MessageBox.Show("Güvenlik Kodu Hatalı", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (br == DialogResult.Retry)
                {
                    
                    guvenlik();
                    captchabox.Clear();
                    


                }
            }

        }
         
        
        public void guvenlik()
        {
            bmp = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = System.Drawing.Graphics.FromImage(bmp);
            captcha = String.Empty;
            for (int i = 0; i < 5; i++)
            {
                int x = rdm.Next(0, chars.Length);
                char c = chars[x];
                captcha += c;
            }
            HatchBrush brush = new HatchBrush(HatchStyle.Cross, System.Drawing.Color.Green, System.Drawing.Color.Black);
            System.Drawing.Rectangle rec = new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height);
            grp.FillRectangle(brush, rec);
            Font f = new System.Drawing.Font("Tahoma", 13, System.Drawing.FontStyle.Bold);
            grp.DrawString(captcha, f, System.Drawing.Brushes.White, new System.Drawing.PointF(5, 5));
            pictureBox1.Image = bmp;
            grp.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            guvenlik();
        }

        private void captchabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr;
            dr = MessageBox.Show("Çıkış yapmak istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
      
    }
}
