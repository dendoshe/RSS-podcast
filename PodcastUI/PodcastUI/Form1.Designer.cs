namespace PodcastUI
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tx_rssUrl = new System.Windows.Forms.TextBox();
            this.cb_updateinterval = new System.Windows.Forms.ComboBox();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.skrivKategori = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nykategori = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListCategories = new System.Windows.Forms.ListBox();
            this.tx_podcastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cAvsnitt,
            this.cNamn,
            this.cFrekvens,
            this.cKategori});
            this.listView1.Location = new System.Drawing.Point(26, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 200);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cAvsnitt
            // 
            this.cAvsnitt.Text = "Avsnitt";
            this.cAvsnitt.Width = 92;
            // 
            // cNamn
            // 
            this.cNamn.Text = "Namn";
            this.cNamn.Width = 149;
            // 
            // cFrekvens
            // 
            this.cFrekvens.Text = "Frekvens";
            this.cFrekvens.Width = 125;
            // 
            // cKategori
            // 
            this.cKategori.Text = "Kategori";
            this.cKategori.Width = 123;
            // 
            // tx_rssUrl
            // 
            this.tx_rssUrl.Location = new System.Drawing.Point(26, 260);
            this.tx_rssUrl.Name = "tx_rssUrl";
            this.tx_rssUrl.Size = new System.Drawing.Size(194, 26);
            this.tx_rssUrl.TabIndex = 1;
            this.tx_rssUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_updateinterval
            // 
            this.cb_updateinterval.FormattingEnabled = true;
            this.cb_updateinterval.Location = new System.Drawing.Point(253, 257);
            this.cb_updateinterval.Name = "cb_updateinterval";
            this.cb_updateinterval.Size = new System.Drawing.Size(169, 28);
            this.cb_updateinterval.TabIndex = 2;
            // 
            // categoryCb
            // 
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Location = new System.Drawing.Point(454, 257);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(121, 28);
            this.categoryCb.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(26, 360);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(497, 97);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // skrivKategori
            // 
            this.skrivKategori.Location = new System.Drawing.Point(624, 196);
            this.skrivKategori.Name = "skrivKategori";
            this.skrivKategori.Size = new System.Drawing.Size(339, 26);
            this.skrivKategori.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ny...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Spara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Ta bort";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // nykategori
            // 
            this.nykategori.Location = new System.Drawing.Point(633, 237);
            this.nykategori.Name = "nykategori";
            this.nykategori.Size = new System.Drawing.Size(75, 35);
            this.nykategori.TabIndex = 10;
            this.nykategori.Text = "Ny...";
            this.nykategori.UseVisualStyleBackColor = true;
            this.nykategori.Click += new System.EventHandler(this.nykategori_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(758, 236);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 35);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Spara";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(888, 236);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 36);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Ta bort";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "URL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kategorier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "xxxxx:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Avsnitt";
            // 
            // ListCategories
            // 
            this.ListCategories.FormattingEnabled = true;
            this.ListCategories.ItemHeight = 20;
            this.ListCategories.Location = new System.Drawing.Point(633, 35);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(362, 144);
            this.ListCategories.TabIndex = 19;
            this.ListCategories.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
            // 
            // tx_podcastName
            // 
            this.tx_podcastName.Location = new System.Drawing.Point(26, 292);
            this.tx_podcastName.Name = "tx_podcastName";
            this.tx_podcastName.Size = new System.Drawing.Size(194, 26);
            this.tx_podcastName.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 498);
            this.Controls.Add(this.tx_podcastName);
            this.Controls.Add(this.ListCategories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nykategori);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skrivKategori);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.cb_updateinterval);
            this.Controls.Add(this.tx_rssUrl);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cAvsnitt;
        private System.Windows.Forms.ColumnHeader cNamn;
        private System.Windows.Forms.ColumnHeader cFrekvens;
        private System.Windows.Forms.ColumnHeader cKategori;
        private System.Windows.Forms.TextBox tx_rssUrl;
        private System.Windows.Forms.ComboBox cb_updateinterval;
        private System.Windows.Forms.ComboBox categoryCb;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox skrivKategori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button nykategori;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListCategories;
        private System.Windows.Forms.TextBox tx_podcastName;
    }
}

