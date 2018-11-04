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
            this.lvFeeds = new System.Windows.Forms.ListView();
            this.cAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tx_rssUrl = new System.Windows.Forms.TextBox();
            this.cb_updateinterval = new System.Windows.Forms.ComboBox();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.lvAvsnitt = new System.Windows.Forms.ListView();
            this.skrivKategori = new System.Windows.Forms.TextBox();
            this.btnNyFeed = new System.Windows.Forms.Button();
            this.btnSparaFeed = new System.Windows.Forms.Button();
            this.btnTaBortFeed = new System.Windows.Forms.Button();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvKategorier = new System.Windows.Forms.ListBox();
            this.tx_podcastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvFeeds
            // 
            this.lvFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cAvsnitt,
            this.cNamn,
            this.cFrekvens,
            this.cKategori});
            this.lvFeeds.Location = new System.Drawing.Point(26, 12);
            this.lvFeeds.Name = "lvFeeds";
            this.lvFeeds.Size = new System.Drawing.Size(549, 200);
            this.lvFeeds.TabIndex = 0;
            this.lvFeeds.UseCompatibleStateImageBehavior = false;
            this.lvFeeds.View = System.Windows.Forms.View.Details;
            this.lvFeeds.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // lvAvsnitt
            // 
            this.lvAvsnitt.Location = new System.Drawing.Point(26, 360);
            this.lvAvsnitt.Name = "lvAvsnitt";
            this.lvAvsnitt.Size = new System.Drawing.Size(497, 97);
            this.lvAvsnitt.TabIndex = 4;
            this.lvAvsnitt.UseCompatibleStateImageBehavior = false;
            // 
            // skrivKategori
            // 
            this.skrivKategori.Location = new System.Drawing.Point(624, 196);
            this.skrivKategori.Name = "skrivKategori";
            this.skrivKategori.Size = new System.Drawing.Size(339, 26);
            this.skrivKategori.TabIndex = 6;
            // 
            // btnNyFeed
            // 
            this.btnNyFeed.Location = new System.Drawing.Point(262, 292);
            this.btnNyFeed.Name = "btnNyFeed";
            this.btnNyFeed.Size = new System.Drawing.Size(75, 35);
            this.btnNyFeed.TabIndex = 7;
            this.btnNyFeed.Text = "Ny...";
            this.btnNyFeed.UseVisualStyleBackColor = true;
            this.btnNyFeed.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSparaFeed
            // 
            this.btnSparaFeed.Location = new System.Drawing.Point(361, 292);
            this.btnSparaFeed.Name = "btnSparaFeed";
            this.btnSparaFeed.Size = new System.Drawing.Size(75, 35);
            this.btnSparaFeed.TabIndex = 8;
            this.btnSparaFeed.Text = "Spara";
            this.btnSparaFeed.UseVisualStyleBackColor = true;
            this.btnSparaFeed.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTaBortFeed
            // 
            this.btnTaBortFeed.Location = new System.Drawing.Point(472, 292);
            this.btnTaBortFeed.Name = "btnTaBortFeed";
            this.btnTaBortFeed.Size = new System.Drawing.Size(93, 35);
            this.btnTaBortFeed.TabIndex = 9;
            this.btnTaBortFeed.Text = "Ta bort";
            this.btnTaBortFeed.UseVisualStyleBackColor = true;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(633, 237);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(75, 35);
            this.btnNyKategori.TabIndex = 10;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.nykategori_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(758, 236);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(75, 35);
            this.btnSparaKategori.TabIndex = 11;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(888, 236);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(75, 36);
            this.btnTaBortKategori.TabIndex = 12;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.button6_Click);
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
            // lvKategorier
            // 
            this.lvKategorier.FormattingEnabled = true;
            this.lvKategorier.ItemHeight = 20;
            this.lvKategorier.Location = new System.Drawing.Point(633, 35);
            this.lvKategorier.Name = "lvKategorier";
            this.lvKategorier.Size = new System.Drawing.Size(362, 144);
            this.lvKategorier.TabIndex = 19;
            this.lvKategorier.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
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
            this.Controls.Add(this.lvKategorier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.btnTaBortFeed);
            this.Controls.Add(this.btnSparaFeed);
            this.Controls.Add(this.btnNyFeed);
            this.Controls.Add(this.skrivKategori);
            this.Controls.Add(this.lvAvsnitt);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.cb_updateinterval);
            this.Controls.Add(this.tx_rssUrl);
            this.Controls.Add(this.lvFeeds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFeeds;
        private System.Windows.Forms.ColumnHeader cAvsnitt;
        private System.Windows.Forms.ColumnHeader cNamn;
        private System.Windows.Forms.ColumnHeader cFrekvens;
        private System.Windows.Forms.ColumnHeader cKategori;
        private System.Windows.Forms.TextBox tx_rssUrl;
        private System.Windows.Forms.ComboBox cb_updateinterval;
        private System.Windows.Forms.ComboBox categoryCb;
        private System.Windows.Forms.ListView lvAvsnitt;
        private System.Windows.Forms.TextBox skrivKategori;
        private System.Windows.Forms.Button btnNyFeed;
        private System.Windows.Forms.Button btnSparaFeed;
        private System.Windows.Forms.Button btnTaBortFeed;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lvKategorier;
        private System.Windows.Forms.TextBox tx_podcastName;
    }
}

