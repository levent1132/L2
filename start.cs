using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace luttop_co
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }
        int i;
        private void button1_Click(object sender, EventArgs e)
        {

            Form1.ActiveForm.Text = "Sistem Hazırlanıyor";
            progressBar1.Maximum = 3000;

            progressBar1.Minimum = 10;

            for (int j = 100; j < 3000; j++)
            {

                progressBar1.Value = j;
            }
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void start_Load(object sender, EventArgs e)
        {

           
            i = 0;

            timer1.Enabled = true;
            button1.Visible = false;
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (i < 100)
            {
                if (i>0)
                {
                     Form1.ActiveForm.Text = "Bekleyiniz";
                     if (i == 30)
                     {
                         label1.ForeColor = Color.RoyalBlue;
                         
                     }
                     if (i == 75)
                     {
                         label1.ForeColor = Color.Red;
                     }
                }                
                if (i == 99)
                {
                    button1.Visible = true;

                    label1.Visible = false;
                }

                i++;

                progressBar1.Value = i;

                label1.Text = "Okunuyor  % " + i + " hazır" ;

            }
        }
    }
}
