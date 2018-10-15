namespace luttop_co
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seçkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gösterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDurumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gösterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cariHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kârZararTabosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişPANELİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.BackgroundImage = global::luttop_co.Properties.Resources.logo1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçkeToolStripMenuItem,
            this.müşteriToolStripMenuItem1,
            this.ürünlerToolStripMenuItem,
            this.siparişToolStripMenuItem,
            this.cariHesapToolStripMenuItem,
            this.girişPANELİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // seçkeToolStripMenuItem
            // 
            this.seçkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem});
            this.seçkeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seçkeToolStripMenuItem.Name = "seçkeToolStripMenuItem";
            this.seçkeToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.seçkeToolStripMenuItem.Text = "Personeller";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.personelToolStripMenuItem.Text = "Ekle";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem1
            // 
            this.müşteriToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.müşteriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem2});
            this.müşteriToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.müşteriToolStripMenuItem1.Name = "müşteriToolStripMenuItem1";
            this.müşteriToolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.müşteriToolStripMenuItem1.Text = "Müşteriler";
            // 
            // ekleToolStripMenuItem2
            // 
            this.ekleToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
            this.ekleToolStripMenuItem2.Name = "ekleToolStripMenuItem2";
            this.ekleToolStripMenuItem2.Size = new System.Drawing.Size(110, 24);
            this.ekleToolStripMenuItem2.Text = "Ekle";
            this.ekleToolStripMenuItem2.Click += new System.EventHandler(this.ekleToolStripMenuItem2_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.ürünlerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.siparişDurumToolStripMenuItem});
            this.siparişToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            this.siparişToolStripMenuItem.Click += new System.EventHandler(this.siparişToolStripMenuItem_Click);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem2,
            this.gizleToolStripMenuItem});
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.gösterToolStripMenuItem.Text = "Siparişler";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gösterToolStripMenuItem2
            // 
            this.gösterToolStripMenuItem2.Name = "gösterToolStripMenuItem2";
            this.gösterToolStripMenuItem2.Size = new System.Drawing.Size(129, 24);
            this.gösterToolStripMenuItem2.Text = "Göster";
            this.gösterToolStripMenuItem2.Click += new System.EventHandler(this.gösterToolStripMenuItem2_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // siparişDurumToolStripMenuItem
            // 
            this.siparişDurumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem1,
            this.gizleToolStripMenuItem1});
            this.siparişDurumToolStripMenuItem.Name = "siparişDurumToolStripMenuItem";
            this.siparişDurumToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.siparişDurumToolStripMenuItem.Text = "Sipariş Durum";
            // 
            // gösterToolStripMenuItem1
            // 
            this.gösterToolStripMenuItem1.Name = "gösterToolStripMenuItem1";
            this.gösterToolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.gösterToolStripMenuItem1.Text = "Göster";
            this.gösterToolStripMenuItem1.Click += new System.EventHandler(this.gösterToolStripMenuItem1_Click);
            // 
            // gizleToolStripMenuItem1
            // 
            this.gizleToolStripMenuItem1.Name = "gizleToolStripMenuItem1";
            this.gizleToolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.gizleToolStripMenuItem1.Text = "Gizle";
            this.gizleToolStripMenuItem1.Click += new System.EventHandler(this.gizleToolStripMenuItem1_Click);
            // 
            // cariHesapToolStripMenuItem
            // 
            this.cariHesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kârZararTabosuToolStripMenuItem});
            this.cariHesapToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cariHesapToolStripMenuItem.Name = "cariHesapToolStripMenuItem";
            this.cariHesapToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.cariHesapToolStripMenuItem.Text = "Cari Hesap";
            // 
            // kârZararTabosuToolStripMenuItem
            // 
            this.kârZararTabosuToolStripMenuItem.Name = "kârZararTabosuToolStripMenuItem";
            this.kârZararTabosuToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.kârZararTabosuToolStripMenuItem.Text = "Kâr Zarar Tabosu";
            this.kârZararTabosuToolStripMenuItem.Click += new System.EventHandler(this.kârZararTabosuToolStripMenuItem_Click);
            // 
            // girişPANELİToolStripMenuItem
            // 
            this.girişPANELİToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.girişPANELİToolStripMenuItem.Name = "girişPANELİToolStripMenuItem";
            this.girişPANELİToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.girişPANELİToolStripMenuItem.Text = "Giriş Paneli";
            this.girişPANELİToolStripMenuItem.Click += new System.EventHandler(this.girişPANELİToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 397);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(512, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(483, 397);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Siparişler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sipariş Durumları";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Yetkili Paneli";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişDurumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem girişPANELİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariHesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kârZararTabosuToolStripMenuItem;

    }
}