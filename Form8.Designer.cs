namespace luttop_co
{
    partial class Form8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_urunsil = new System.Windows.Forms.Button();
            this.button_urunduzenle = new System.Windows.Forms.Button();
            this.button_urunkaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.urun_satisfiyatbox = new System.Windows.Forms.TextBox();
            this.urun_alimfiyatbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.urun_stokbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urun_modelbox = new System.Windows.Forms.TextBox();
            this.urun_idbox = new System.Windows.Forms.TextBox();
            this.urun_markabox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(707, 387);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(4, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1075, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Panele Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button_urunsil);
            this.groupBox1.Controls.Add(this.button_urunduzenle);
            this.groupBox1.Controls.Add(this.button_urunkaydet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.urun_satisfiyatbox);
            this.groupBox1.Controls.Add(this.urun_alimfiyatbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.urun_stokbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.urun_modelbox);
            this.groupBox1.Controls.Add(this.urun_idbox);
            this.groupBox1.Controls.Add(this.urun_markabox);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(725, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 398);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Seçke İşlemleri";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(171, 152);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 23);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 23);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_urunsil
            // 
            this.button_urunsil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_urunsil.Location = new System.Drawing.Point(16, 330);
            this.button_urunsil.Name = "button_urunsil";
            this.button_urunsil.Size = new System.Drawing.Size(316, 56);
            this.button_urunsil.TabIndex = 23;
            this.button_urunsil.Text = "Ürün Sil";
            this.button_urunsil.UseVisualStyleBackColor = true;
            this.button_urunsil.Click += new System.EventHandler(this.button_urunsil_Click);
            // 
            // button_urunduzenle
            // 
            this.button_urunduzenle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_urunduzenle.Location = new System.Drawing.Point(16, 333);
            this.button_urunduzenle.Name = "button_urunduzenle";
            this.button_urunduzenle.Size = new System.Drawing.Size(316, 56);
            this.button_urunduzenle.TabIndex = 22;
            this.button_urunduzenle.Text = "Ürün Düzenle";
            this.button_urunduzenle.UseVisualStyleBackColor = true;
            this.button_urunduzenle.Click += new System.EventHandler(this.button_urunduzenle_Click);
            // 
            // button_urunkaydet
            // 
            this.button_urunkaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_urunkaydet.Location = new System.Drawing.Point(16, 333);
            this.button_urunkaydet.Name = "button_urunkaydet";
            this.button_urunkaydet.Size = new System.Drawing.Size(316, 56);
            this.button_urunkaydet.TabIndex = 21;
            this.button_urunkaydet.Text = "Kaydet";
            this.button_urunkaydet.UseVisualStyleBackColor = true;
            this.button_urunkaydet.Click += new System.EventHandler(this.button_urunkaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(28, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ürün Satış Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(33, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ürün Alım Fiyatı:";
            // 
            // urun_satisfiyatbox
            // 
            this.urun_satisfiyatbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_satisfiyatbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urun_satisfiyatbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_satisfiyatbox.Location = new System.Drawing.Point(165, 265);
            this.urun_satisfiyatbox.Name = "urun_satisfiyatbox";
            this.urun_satisfiyatbox.Size = new System.Drawing.Size(132, 23);
            this.urun_satisfiyatbox.TabIndex = 16;
            this.urun_satisfiyatbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urun_satisfiyatbox_KeyPress);
            // 
            // urun_alimfiyatbox
            // 
            this.urun_alimfiyatbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_alimfiyatbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urun_alimfiyatbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_alimfiyatbox.Location = new System.Drawing.Point(165, 232);
            this.urun_alimfiyatbox.Name = "urun_alimfiyatbox";
            this.urun_alimfiyatbox.Size = new System.Drawing.Size(132, 23);
            this.urun_alimfiyatbox.TabIndex = 15;
            this.urun_alimfiyatbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urun_alimfiyatbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(40, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ürün Stok Adeti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(32, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Bitiş Tarihi:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // urun_stokbox
            // 
            this.urun_stokbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_stokbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urun_stokbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_stokbox.Location = new System.Drawing.Point(165, 195);
            this.urun_stokbox.Name = "urun_stokbox";
            this.urun_stokbox.Size = new System.Drawing.Size(132, 23);
            this.urun_stokbox.TabIndex = 12;
            this.urun_stokbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urun_stokbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Geliş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(77, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(77, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün ID:";
            // 
            // urun_modelbox
            // 
            this.urun_modelbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_modelbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urun_modelbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_modelbox.Location = new System.Drawing.Point(165, 76);
            this.urun_modelbox.Name = "urun_modelbox";
            this.urun_modelbox.Size = new System.Drawing.Size(132, 23);
            this.urun_modelbox.TabIndex = 5;
            // 
            // urun_idbox
            // 
            this.urun_idbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_idbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urun_idbox.Enabled = false;
            this.urun_idbox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_idbox.Location = new System.Drawing.Point(165, 20);
            this.urun_idbox.Name = "urun_idbox";
            this.urun_idbox.Size = new System.Drawing.Size(132, 23);
            this.urun_idbox.TabIndex = 3;
            // 
            // urun_markabox
            // 
            this.urun_markabox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_markabox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urun_markabox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_markabox.Location = new System.Drawing.Point(165, 47);
            this.urun_markabox.Name = "urun_markabox";
            this.urun_markabox.Size = new System.Drawing.Size(132, 23);
            this.urun_markabox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(84, 37);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.raporlaToolStripMenuItem});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(76, 33);
            this.ürünToolStripMenuItem.Text = "Ürün";
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
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(174, 34);
            this.raporlaToolStripMenuItem.Text = "Raporla";
            this.raporlaToolStripMenuItem.Click += new System.EventHandler(this.raporlaToolStripMenuItem_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::luttop_co.Properties.Resources.logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form8";
            this.Text = "Ürün Ekle Düzenle";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_urunsil;
        private System.Windows.Forms.Button button_urunduzenle;
        private System.Windows.Forms.Button button_urunkaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox urun_satisfiyatbox;
        private System.Windows.Forms.TextBox urun_alimfiyatbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox urun_stokbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urun_modelbox;
        private System.Windows.Forms.TextBox urun_idbox;
        private System.Windows.Forms.TextBox urun_markabox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem;
    }
}