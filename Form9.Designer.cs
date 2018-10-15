namespace luttop_co
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_mussil = new System.Windows.Forms.Button();
            this.button_musduzenle = new System.Windows.Forms.Button();
            this.button_musekle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mus_sifrebox = new System.Windows.Forms.TextBox();
            this.mus_sirketbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mus_adresbox = new System.Windows.Forms.TextBox();
            this.mus_gsmbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mus_soyadbox = new System.Windows.Forms.TextBox();
            this.mus_epostabox = new System.Windows.Forms.TextBox();
            this.mus_idbox = new System.Windows.Forms.TextBox();
            this.mus_adbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(668, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1042, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Panele Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(112, 37);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(104, 33);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(174, 34);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(174, 34);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(174, 34);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button_mussil);
            this.groupBox1.Controls.Add(this.button_musduzenle);
            this.groupBox1.Controls.Add(this.button_musekle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mus_sifrebox);
            this.groupBox1.Controls.Add(this.mus_sirketbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mus_adresbox);
            this.groupBox1.Controls.Add(this.mus_gsmbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mus_soyadbox);
            this.groupBox1.Controls.Add(this.mus_epostabox);
            this.groupBox1.Controls.Add(this.mus_idbox);
            this.groupBox1.Controls.Add(this.mus_adbox);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(682, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 398);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Seçke İşlemleri";
            // 
            // button_mussil
            // 
            this.button_mussil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_mussil.Location = new System.Drawing.Point(16, 333);
            this.button_mussil.Name = "button_mussil";
            this.button_mussil.Size = new System.Drawing.Size(316, 56);
            this.button_mussil.TabIndex = 23;
            this.button_mussil.Text = "Müşteri Sil";
            this.button_mussil.UseVisualStyleBackColor = true;
            this.button_mussil.Click += new System.EventHandler(this.button_mussil_Click);
            // 
            // button_musduzenle
            // 
            this.button_musduzenle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_musduzenle.Location = new System.Drawing.Point(16, 333);
            this.button_musduzenle.Name = "button_musduzenle";
            this.button_musduzenle.Size = new System.Drawing.Size(316, 56);
            this.button_musduzenle.TabIndex = 22;
            this.button_musduzenle.Text = "Müşteri Düzenle";
            this.button_musduzenle.UseVisualStyleBackColor = true;
            this.button_musduzenle.Click += new System.EventHandler(this.button_musduzenle_Click);
            // 
            // button_musekle
            // 
            this.button_musekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_musekle.Location = new System.Drawing.Point(16, 333);
            this.button_musekle.Name = "button_musekle";
            this.button_musekle.Size = new System.Drawing.Size(316, 56);
            this.button_musekle.TabIndex = 21;
            this.button_musekle.Text = "Yeni Müşteri ";
            this.button_musekle.UseVisualStyleBackColor = true;
            this.button_musekle.Click += new System.EventHandler(this.button_musekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(43, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Müşteri  Şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(47, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Müşteri Şirket:";
            // 
            // mus_sifrebox
            // 
            this.mus_sifrebox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_sifrebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_sifrebox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_sifrebox.Location = new System.Drawing.Point(165, 276);
            this.mus_sifrebox.Name = "mus_sifrebox";
            this.mus_sifrebox.Size = new System.Drawing.Size(132, 23);
            this.mus_sifrebox.TabIndex = 16;
            // 
            // mus_sirketbox
            // 
            this.mus_sirketbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_sirketbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_sirketbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_sirketbox.Location = new System.Drawing.Point(165, 244);
            this.mus_sirketbox.Name = "mus_sirketbox";
            this.mus_sirketbox.Size = new System.Drawing.Size(132, 23);
            this.mus_sirketbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(43, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Müşteri Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(57, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Müşteri  GSM:";
            // 
            // mus_adresbox
            // 
            this.mus_adresbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_adresbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_adresbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_adresbox.Location = new System.Drawing.Point(165, 163);
            this.mus_adresbox.Multiline = true;
            this.mus_adresbox.Name = "mus_adresbox";
            this.mus_adresbox.Size = new System.Drawing.Size(132, 67);
            this.mus_adresbox.TabIndex = 12;
            // 
            // mus_gsmbox
            // 
            this.mus_gsmbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_gsmbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_gsmbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_gsmbox.Location = new System.Drawing.Point(165, 134);
            this.mus_gsmbox.Name = "mus_gsmbox";
            this.mus_gsmbox.Size = new System.Drawing.Size(132, 23);
            this.mus_gsmbox.TabIndex = 11;
            this.mus_gsmbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mus_gsmbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri E-POSTA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(64, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müşteri ID:";
            // 
            // mus_soyadbox
            // 
            this.mus_soyadbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_soyadbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_soyadbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_soyadbox.Location = new System.Drawing.Point(165, 76);
            this.mus_soyadbox.Name = "mus_soyadbox";
            this.mus_soyadbox.Size = new System.Drawing.Size(132, 23);
            this.mus_soyadbox.TabIndex = 5;
            // 
            // mus_epostabox
            // 
            this.mus_epostabox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_epostabox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_epostabox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_epostabox.Location = new System.Drawing.Point(165, 105);
            this.mus_epostabox.Name = "mus_epostabox";
            this.mus_epostabox.Size = new System.Drawing.Size(132, 23);
            this.mus_epostabox.TabIndex = 6;
            // 
            // mus_idbox
            // 
            this.mus_idbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_idbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_idbox.Enabled = false;
            this.mus_idbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_idbox.Location = new System.Drawing.Point(165, 20);
            this.mus_idbox.Name = "mus_idbox";
            this.mus_idbox.Size = new System.Drawing.Size(132, 23);
            this.mus_idbox.TabIndex = 3;
            // 
            // mus_adbox
            // 
            this.mus_adbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mus_adbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mus_adbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mus_adbox.Location = new System.Drawing.Point(165, 47);
            this.mus_adbox.Name = "mus_adbox";
            this.mus_adbox.Size = new System.Drawing.Size(132, 23);
            this.mus_adbox.TabIndex = 4;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::luttop_co.Properties.Resources.logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form9";
            this.Text = "Müşteri Ekle Düzenle";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_mussil;
        private System.Windows.Forms.Button button_musduzenle;
        private System.Windows.Forms.Button button_musekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mus_sifrebox;
        private System.Windows.Forms.TextBox mus_sirketbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mus_adresbox;
        private System.Windows.Forms.TextBox mus_gsmbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mus_soyadbox;
        private System.Windows.Forms.TextBox mus_epostabox;
        private System.Windows.Forms.TextBox mus_idbox;
        private System.Windows.Forms.TextBox mus_adbox;

    }
}