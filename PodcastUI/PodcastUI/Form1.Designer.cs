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
            this.listAvsnitt = new System.Windows.Forms.ListView();
            this.skrivKategori = new System.Windows.Forms.TextBox();
            this.btn_newPoscast = new System.Windows.Forms.Button();
            this.btn_saveXML = new System.Windows.Forms.Button();
            this.btn_DeletePodcast = new System.Windows.Forms.Button();
            this.btn_newCatergory = new System.Windows.Forms.Button();
            this.btn_saveCategory = new System.Windows.Forms.Button();
            this.btn_deleteCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListCategories = new System.Windows.Forms.ListBox();
            this.tx_podcastName = new System.Windows.Forms.TextBox();
            this.title_name = new System.Windows.Forms.Label();
            this.listdescrip = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNamn,
            this.cAvsnitt,
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
            this.cAvsnitt.Text = "Antal-Avsnitt";
            this.cAvsnitt.Width = 118;
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
            this.tx_rssUrl.Location = new System.Drawing.Point(26, 238);
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
            // listAvsnitt
            // 
            this.listAvsnitt.Location = new System.Drawing.Point(26, 360);
            this.listAvsnitt.Name = "listAvsnitt";
            this.listAvsnitt.Size = new System.Drawing.Size(549, 154);
            this.listAvsnitt.TabIndex = 4;
            this.listAvsnitt.UseCompatibleStateImageBehavior = false;
            this.listAvsnitt.SelectedIndexChanged += new System.EventHandler(this.listAvsnitt_SelectedIndexChanged);
            // 
            // skrivKategori
            // 
            this.skrivKategori.Location = new System.Drawing.Point(633, 186);
            this.skrivKategori.Name = "skrivKategori";
            this.skrivKategori.Size = new System.Drawing.Size(339, 26);
            this.skrivKategori.TabIndex = 6;
            // 
            // btn_newPoscast
            // 
            this.btn_newPoscast.Location = new System.Drawing.Point(262, 292);
            this.btn_newPoscast.Name = "btn_newPoscast";
            this.btn_newPoscast.Size = new System.Drawing.Size(75, 35);
            this.btn_newPoscast.TabIndex = 7;
            this.btn_newPoscast.Text = "Ny...";
            this.btn_newPoscast.UseVisualStyleBackColor = true;
            // 
            // btn_saveXML
            // 
            this.btn_saveXML.Location = new System.Drawing.Point(361, 292);
            this.btn_saveXML.Name = "btn_saveXML";
            this.btn_saveXML.Size = new System.Drawing.Size(75, 35);
            this.btn_saveXML.TabIndex = 8;
            this.btn_saveXML.Text = "Spara";
            this.btn_saveXML.UseVisualStyleBackColor = true;
            this.btn_saveXML.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_DeletePodcast
            // 
            this.btn_DeletePodcast.Location = new System.Drawing.Point(472, 292);
            this.btn_DeletePodcast.Name = "btn_DeletePodcast";
            this.btn_DeletePodcast.Size = new System.Drawing.Size(93, 35);
            this.btn_DeletePodcast.TabIndex = 9;
            this.btn_DeletePodcast.Text = "Ta bort";
            this.btn_DeletePodcast.UseVisualStyleBackColor = true;
            // 
            // btn_newCatergory
            // 
            this.btn_newCatergory.Location = new System.Drawing.Point(633, 237);
            this.btn_newCatergory.Name = "btn_newCatergory";
            this.btn_newCatergory.Size = new System.Drawing.Size(75, 35);
            this.btn_newCatergory.TabIndex = 10;
            this.btn_newCatergory.Text = "Ny...";
            this.btn_newCatergory.UseVisualStyleBackColor = true;
            this.btn_newCatergory.Click += new System.EventHandler(this.nykategori_Click);
            // 
            // btn_saveCategory
            // 
            this.btn_saveCategory.Location = new System.Drawing.Point(758, 236);
            this.btn_saveCategory.Name = "btn_saveCategory";
            this.btn_saveCategory.Size = new System.Drawing.Size(75, 35);
            this.btn_saveCategory.TabIndex = 11;
            this.btn_saveCategory.Text = "Spara";
            this.btn_saveCategory.UseVisualStyleBackColor = true;
            this.btn_saveCategory.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.Location = new System.Drawing.Point(888, 236);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(75, 36);
            this.btn_deleteCategory.TabIndex = 12;
            this.btn_deleteCategory.Text = "Ta bort";
            this.btn_deleteCategory.UseVisualStyleBackColor = true;
            this.btn_deleteCategory.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 215);
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
            // title_name
            // 
            this.title_name.AutoSize = true;
            this.title_name.Location = new System.Drawing.Point(28, 266);
            this.title_name.Name = "title_name";
            this.title_name.Size = new System.Drawing.Size(85, 20);
            this.title_name.TabIndex = 21;
            this.title_name.Text = "File-Namn:";
            // 
            // listdescrip
            // 
            this.listdescrip.FormattingEnabled = true;
            this.listdescrip.ItemHeight = 20;
            this.listdescrip.Location = new System.Drawing.Point(653, 328);
            this.listdescrip.Name = "listdescrip";
            this.listdescrip.Size = new System.Drawing.Size(342, 144);
            this.listdescrip.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 526);
            this.Controls.Add(this.listdescrip);
            this.Controls.Add(this.title_name);
            this.Controls.Add(this.tx_podcastName);
            this.Controls.Add(this.ListCategories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deleteCategory);
            this.Controls.Add(this.btn_saveCategory);
            this.Controls.Add(this.btn_newCatergory);
            this.Controls.Add(this.btn_DeletePodcast);
            this.Controls.Add(this.btn_saveXML);
            this.Controls.Add(this.btn_newPoscast);
            this.Controls.Add(this.skrivKategori);
            this.Controls.Add(this.listAvsnitt);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.cb_updateinterval);
            this.Controls.Add(this.tx_rssUrl);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ListView listAvsnitt;
        private System.Windows.Forms.TextBox skrivKategori;
        private System.Windows.Forms.Button btn_newPoscast;
        private System.Windows.Forms.Button btn_saveXML;
        private System.Windows.Forms.Button btn_DeletePodcast;
        private System.Windows.Forms.Button btn_newCatergory;
        private System.Windows.Forms.Button btn_saveCategory;
        private System.Windows.Forms.Button btn_deleteCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListCategories;
        private System.Windows.Forms.TextBox tx_podcastName;
        private System.Windows.Forms.Label title_name;
        private System.Windows.Forms.ListBox listdescrip;
    }
}

