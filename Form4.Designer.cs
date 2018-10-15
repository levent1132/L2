namespace luttop_co
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparisidbox = new System.Windows.Forms.TextBox();
            this.musteriidbox = new System.Windows.Forms.TextBox();
            this.urunidbox = new System.Windows.Forms.TextBox();
            this.siparisadetbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gösterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gösterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gösterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.girişPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_siparisduzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(723, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // siparisidbox
            // 
            this.siparisidbox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siparisidbox.Location = new System.Drawing.Point(121, 25);
            this.siparisidbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.siparisidbox.Name = "siparisidbox";
            this.siparisidbox.Size = new System.Drawing.Size(71, 25);
            this.siparisidbox.TabIndex = 2;
            // 
            // musteriidbox
            // 
            this.musteriidbox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriidbox.Location = new System.Drawing.Point(121, 54);
            this.musteriidbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.musteriidbox.Name = "musteriidbox";
            this.musteriidbox.Size = new System.Drawing.Size(89, 25);
            this.musteriidbox.TabIndex = 3;
            // 
            // urunidbox
            // 
            this.urunidbox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunidbox.Location = new System.Drawing.Point(121, 83);
            this.urunidbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.urunidbox.Name = "urunidbox";
            this.urunidbox.Size = new System.Drawing.Size(103, 25);
            this.urunidbox.TabIndex = 4;
            // 
            // siparisadetbox
            // 
            this.siparisadetbox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siparisadetbox.Location = new System.Drawing.Point(121, 112);
            this.siparisadetbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.siparisadetbox.Name = "siparisadetbox";
            this.siparisadetbox.Size = new System.Drawing.Size(116, 25);
            this.siparisadetbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.Location = new System.Drawing.Point(42, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sipariş ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label3.Location = new System.Drawing.Point(37, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label4.Location = new System.Drawing.Point(47, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.Location = new System.Drawing.Point(29, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sipariş Adet :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::luttop_co.Properties.Resources.logo1;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişToolStripMenuItem,
            this.siparişDurumuToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.girişPaneliToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(850, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gzleToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gzleToolStripMenuItem
            // 
            this.gzleToolStripMenuItem.Name = "gzleToolStripMenuItem";
            this.gzleToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.gzleToolStripMenuItem.Text = "Gizle";
            this.gzleToolStripMenuItem.Click += new System.EventHandler(this.gzleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // siparişDurumuToolStripMenuItem
            // 
            this.siparişDurumuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem1});
            this.siparişDurumuToolStripMenuItem.Font = new System.Drawing.Font("Californian FB", 12.25F, System.Drawing.FontStyle.Bold);
            this.siparişDurumuToolStripMenuItem.Name = "siparişDurumuToolStripMenuItem";
            this.siparişDurumuToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.siparişDurumuToolStripMenuItem.Text = "Sipariş Durumu";
            // 
            // gösterToolStripMenuItem1
            // 
            this.gösterToolStripMenuItem1.Name = "gösterToolStripMenuItem1";
            this.gösterToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.gösterToolStripMenuItem1.Text = "Göster";
            this.gösterToolStripMenuItem1.Click += new System.EventHandler(this.gösterToolStripMenuItem1_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem2});
            this.personelToolStripMenuItem.Font = new System.Drawing.Font("Californian FB", 12.25F, System.Drawing.FontStyle.Bold);
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // gösterToolStripMenuItem2
            // 
            this.gösterToolStripMenuItem2.Name = "gösterToolStripMenuItem2";
            this.gösterToolStripMenuItem2.Size = new System.Drawing.Size(127, 24);
            this.gösterToolStripMenuItem2.Text = "Göster";
            this.gösterToolStripMenuItem2.Click += new System.EventHandler(this.gösterToolStripMenuItem2_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem3});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // gösterToolStripMenuItem3
            // 
            this.gösterToolStripMenuItem3.Name = "gösterToolStripMenuItem3";
            this.gösterToolStripMenuItem3.Size = new System.Drawing.Size(132, 26);
            this.gösterToolStripMenuItem3.Text = "Göster";
            this.gösterToolStripMenuItem3.Click += new System.EventHandler(this.gösterToolStripMenuItem3_Click);
            // 
            // girişPaneliToolStripMenuItem
            // 
            this.girişPaneliToolStripMenuItem.Font = new System.Drawing.Font("Californian FB", 12.25F, System.Drawing.FontStyle.Bold);
            this.girişPaneliToolStripMenuItem.Name = "girişPaneliToolStripMenuItem";
            this.girişPaneliToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.girişPaneliToolStripMenuItem.Text = "Giriş Paneli";
            this.girişPaneliToolStripMenuItem.Click += new System.EventHandler(this.girişPaneliToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Californian FB", 12.25F, System.Drawing.FontStyle.Bold);
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış ";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button_siparisduzenle);
            this.groupBox1.Controls.Add(this.urunidbox);
            this.groupBox1.Controls.Add(this.siparisidbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.musteriidbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.siparisadetbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 315);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Seçke İşlemleri";
            // 
            // button_siparisduzenle
            // 
            this.button_siparisduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_siparisduzenle.Location = new System.Drawing.Point(33, 232);
            this.button_siparisduzenle.Name = "button_siparisduzenle";
            this.button_siparisduzenle.Size = new System.Drawing.Size(221, 42);
            this.button_siparisduzenle.TabIndex = 10;
            this.button_siparisduzenle.Text = "Sipariş Düzenle";
            this.button_siparisduzenle.UseVisualStyleBackColor = true;
            this.button_siparisduzenle.Click += new System.EventHandler(this.button_siparisduzenle_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Personel Paneli";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox siparisidbox;
        private System.Windows.Forms.TextBox musteriidbox;
        private System.Windows.Forms.TextBox urunidbox;
        private System.Windows.Forms.TextBox siparisadetbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_siparisduzenle;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişPaneliToolStripMenuItem;
    }
}