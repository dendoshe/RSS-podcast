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
            this.cNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tx_rssUrl = new System.Windows.Forms.TextBox();
            this.cb_updateinterval = new System.Windows.Forms.ComboBox();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.listAvsnitt = new System.Windows.Forms.ListView();
            this.skrivKategori = new System.Windows.Forms.TextBox();
            this.btn_changeFeeds = new System.Windows.Forms.Button();
            this.btn_saveXML = new System.Windows.Forms.Button();
            this.btn_DeletePodcast = new System.Windows.Forms.Button();
            this.btn_newCatergory = new System.Windows.Forms.Button();
            this.btn_changeCategory = new System.Windows.Forms.Button();
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
            this.listView1.Location = new System.Drawing.Point(17, 8);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 131);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cNamn
            // 
            this.cNamn.Text = "Namn";
            this.cNamn.Width = 149;
            // 
            // cAvsnitt
            // 
            this.cAvsnitt.Text = "Antal-Avsnitt";
            this.cAvsnitt.Width = 118;
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
            this.tx_rssUrl.Location = new System.Drawing.Point(17, 155);
            this.tx_rssUrl.Margin = new System.Windows.Forms.Padding(2);
            this.tx_rssUrl.Name = "tx_rssUrl";
            this.tx_rssUrl.Size = new System.Drawing.Size(131, 20);
            this.tx_rssUrl.TabIndex = 1;
            this.tx_rssUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_updateinterval
            // 
            this.cb_updateinterval.FormattingEnabled = true;
            this.cb_updateinterval.Location = new System.Drawing.Point(169, 167);
            this.cb_updateinterval.Margin = new System.Windows.Forms.Padding(2);
            this.cb_updateinterval.Name = "cb_updateinterval";
            this.cb_updateinterval.Size = new System.Drawing.Size(114, 21);
            this.cb_updateinterval.TabIndex = 2;
            // 
            // categoryCb
            // 
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Location = new System.Drawing.Point(303, 167);
            this.categoryCb.Margin = new System.Windows.Forms.Padding(2);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(82, 21);
            this.categoryCb.TabIndex = 3;
            // 
            // listAvsnitt
            // 
            this.listAvsnitt.Location = new System.Drawing.Point(17, 234);
            this.listAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.listAvsnitt.Name = "listAvsnitt";
            this.listAvsnitt.Size = new System.Drawing.Size(367, 101);
            this.listAvsnitt.TabIndex = 4;
            this.listAvsnitt.UseCompatibleStateImageBehavior = false;
            this.listAvsnitt.SelectedIndexChanged += new System.EventHandler(this.listAvsnitt_SelectedIndexChanged);
            // 
            // skrivKategori
            // 
            this.skrivKategori.Location = new System.Drawing.Point(422, 121);
            this.skrivKategori.Margin = new System.Windows.Forms.Padding(2);
            this.skrivKategori.Name = "skrivKategori";
            this.skrivKategori.Size = new System.Drawing.Size(227, 20);
            this.skrivKategori.TabIndex = 6;
            // 
            // btn_changeFeeds
            // 
            this.btn_changeFeeds.Location = new System.Drawing.Point(241, 189);
            this.btn_changeFeeds.Margin = new System.Windows.Forms.Padding(2);
            this.btn_changeFeeds.Name = "btn_changeFeeds";
            this.btn_changeFeeds.Size = new System.Drawing.Size(50, 23);
            this.btn_changeFeeds.TabIndex = 7;
            this.btn_changeFeeds.Text = "Ändra";
            this.btn_changeFeeds.UseVisualStyleBackColor = true;
            // 
            // btn_saveXML
            // 
            this.btn_saveXML.Location = new System.Drawing.Point(169, 190);
            this.btn_saveXML.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveXML.Name = "btn_saveXML";
            this.btn_saveXML.Size = new System.Drawing.Size(50, 23);
            this.btn_saveXML.TabIndex = 8;
            this.btn_saveXML.Text = "Spara";
            this.btn_saveXML.UseVisualStyleBackColor = true;
            this.btn_saveXML.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_DeletePodcast
            // 
            this.btn_DeletePodcast.Location = new System.Drawing.Point(315, 190);
            this.btn_DeletePodcast.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeletePodcast.Name = "btn_DeletePodcast";
            this.btn_DeletePodcast.Size = new System.Drawing.Size(62, 23);
            this.btn_DeletePodcast.TabIndex = 9;
            this.btn_DeletePodcast.Text = "Ta bort";
            this.btn_DeletePodcast.UseVisualStyleBackColor = true;
            this.btn_DeletePodcast.Click += new System.EventHandler(this.btn_DeletePodcast_Click);
            // 
            // btn_newCatergory
            // 
            this.btn_newCatergory.Location = new System.Drawing.Point(422, 154);
            this.btn_newCatergory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newCatergory.Name = "btn_newCatergory";
            this.btn_newCatergory.Size = new System.Drawing.Size(62, 23);
            this.btn_newCatergory.TabIndex = 10;
            this.btn_newCatergory.Text = "Lägg till";
            this.btn_newCatergory.UseVisualStyleBackColor = true;
            this.btn_newCatergory.Click += new System.EventHandler(this.nykategori_Click);
            // 
            // btn_changeCategory
            // 
            this.btn_changeCategory.Location = new System.Drawing.Point(505, 153);
            this.btn_changeCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_changeCategory.Name = "btn_changeCategory";
            this.btn_changeCategory.Size = new System.Drawing.Size(50, 23);
            this.btn_changeCategory.TabIndex = 11;
            this.btn_changeCategory.Text = "Ändra";
            this.btn_changeCategory.UseVisualStyleBackColor = true;
            this.btn_changeCategory.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.Location = new System.Drawing.Point(592, 153);
            this.btn_deleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(50, 23);
            this.btn_deleteCategory.TabIndex = 12;
            this.btn_deleteCategory.Text = "Ta bort";
            this.btn_deleteCategory.UseVisualStyleBackColor = true;
            this.btn_deleteCategory.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "URL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kategorier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "xxxxx:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Avsnitt";
            // 
            // ListCategories
            // 
            this.ListCategories.FormattingEnabled = true;
            this.ListCategories.Location = new System.Drawing.Point(422, 23);
            this.ListCategories.Margin = new System.Windows.Forms.Padding(2);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(243, 95);
            this.ListCategories.TabIndex = 19;
            this.ListCategories.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
            // 
            // tx_podcastName
            // 
            this.tx_podcastName.Location = new System.Drawing.Point(17, 190);
            this.tx_podcastName.Margin = new System.Windows.Forms.Padding(2);
            this.tx_podcastName.Name = "tx_podcastName";
            this.tx_podcastName.Size = new System.Drawing.Size(131, 20);
            this.tx_podcastName.TabIndex = 20;
            // 
            // title_name
            // 
            this.title_name.AutoSize = true;
            this.title_name.Location = new System.Drawing.Point(19, 173);
            this.title_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_name.Name = "title_name";
            this.title_name.Size = new System.Drawing.Size(57, 13);
            this.title_name.TabIndex = 21;
            this.title_name.Text = "File-Namn:";
            // 
            // listdescrip
            // 
            this.listdescrip.FormattingEnabled = true;
            this.listdescrip.Location = new System.Drawing.Point(435, 213);
            this.listdescrip.Margin = new System.Windows.Forms.Padding(2);
            this.listdescrip.Name = "listdescrip";
            this.listdescrip.Size = new System.Drawing.Size(304, 95);
            this.listdescrip.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 342);
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
            this.Controls.Add(this.btn_changeCategory);
            this.Controls.Add(this.btn_newCatergory);
            this.Controls.Add(this.btn_DeletePodcast);
            this.Controls.Add(this.btn_saveXML);
            this.Controls.Add(this.btn_changeFeeds);
            this.Controls.Add(this.skrivKategori);
            this.Controls.Add(this.listAvsnitt);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.cb_updateinterval);
            this.Controls.Add(this.tx_rssUrl);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btn_changeFeeds;
        private System.Windows.Forms.Button btn_saveXML;
        private System.Windows.Forms.Button btn_DeletePodcast;
        private System.Windows.Forms.Button btn_newCatergory;
        private System.Windows.Forms.Button btn_changeCategory;
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

