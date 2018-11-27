﻿using DataLayer;
using LogicLayer;
using PodcastUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PodcastUI {


    public partial class Form1 : Form {
        private PodcastMani logicLayer = new PodcastMani(); //Här har vi skapat ett object av PostcastMani som ligger i LogicLayer. Den körs en gång vid uppstart.
        private XmlContainer _xmlcontainer = new XmlContainer();
        private List<Category> _categories;
        private List<Feed> _feeds;
        private Updatecontainer _updatecontainer;
        private string podname;



        public Form1() {
            InitializeComponent();
            logicLayer = new PodcastMani();
            _updatecontainer = new Updatecontainer();
            _xmlcontainer = new XmlContainer();
            _categories = _xmlcontainer.GetAllCategories();
            _categories = new List<Category>();
            _feeds = _xmlcontainer.GetAllPodcastInCategories();
            FillCatergory();
            FillUpdateInterval();
            //FillPodcastInfoList();

        }
        private void FillUpdateInterval() {
            cb_updateinterval.Items.Add(500);
            cb_updateinterval.Items.Add(550);
            cb_updateinterval.Items.Add(1000);
            cb_updateinterval.Items.Add(1500);
            cb_updateinterval.Items.Add(2000);
        }

        private void FillCatergory() {
            ListCategories.Items.Clear();
            categoryCb.Items.Clear();


            var listOfcategories = _xmlcontainer.GetAllCategories();
            _categories = listOfcategories;

            foreach (var category in _categories) {

                ListCategories.Items.Add(category.Title);
                categoryCb.Items.Add(category.Title);

            }
        }

        private void FillPodcastInfoList() {
            listView1.Items.Clear();
            var listOfcategories = _xmlcontainer.GetAllCategories();
            _categories = listOfcategories;
            foreach (var podcast in _categories) {

                var titleOfCategory = podcast.Title;
                foreach (var podcastFile in podcast.PodcastList) {

                    _updatecontainer.newUpdate(podcastFile.Title, titleOfCategory, podcastFile, podcastFile.RssLink);
                    var totalEpisodes = podcastFile.Episodes.Count().ToString();
                    string[] row = { podcastFile.Title, totalEpisodes, podcastFile.Updateintervall.ToString(), titleOfCategory };

                    ListViewItem lvt = new ListViewItem(row);
                    listView1.Items.Add(lvt);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

            var podcastItem = listView1.SelectedItems;
            listAvsnitt.Clear();

            if (listView1.SelectedItems.Count == 1) {

                var firstSelectedItem = listView1.SelectedItems[0].Text;
                podname = firstSelectedItem;

                foreach (var item in _feeds) {

                    if (item.Title.Equals(firstSelectedItem)) {

                        foreach (var episodeList in item.Episodes) {

                            listAvsnitt.Items.Add(episodeList.Title);
                        }

                    }

                }
            }


        }

        private void button5_Click(object sender, EventArgs e) {


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void nykategori_Click(object sender, EventArgs e) {
            Validator checkIfEmpty = new Validator(skrivKategori, "Kategori", " är tomt. Försök igen");
            //Category aCategory = new Category();

            try {
                while (checkIfEmpty.isFieldEmpty() == false) {
                    string newDir = skrivKategori.Text;
                    logicLayer.Add(newDir, "");

                    FillCatergory();
                    skrivKategori.Clear();
                    break;

                }
            } catch (Exception) {

                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e) {


            try
            {
                if (ListCategories.SelectedIndex != -1)
                {

                    string genreFolder = ListCategories.SelectedItem.ToString();
                    logicLayer.DeleteCategory(genreFolder, "");
                    ListCategories.Items.RemoveAt(ListCategories.SelectedIndex); //denna metod tar oavsett vad alltid bort det som är valt i kategori boxen
                    FillCatergory();
                    FillPodcastInfoList();
                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e) {


        }

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e) {
            listView1.Items.Clear();
            listAvsnitt.Items.Clear();
            listdescrip.Items.Clear();

            var categoryName = ListCategories.SelectedItem;

            foreach (var podcast in _categories) {

                if (podcast.Title.Contains(categoryName.ToString())) 
                {

                    var titleOfCategory = podcast.Title;
                    foreach (var podcastFile in podcast.PodcastList) {

                        _updatecontainer.newUpdate(podcastFile.Title, titleOfCategory, podcastFile, podcastFile.RssLink);
                        var totalEpisodes = podcastFile.Episodes.Count().ToString();
                        string[] row = { podcastFile.Title, totalEpisodes, podcastFile.Updateintervall.ToString(), titleOfCategory };

                        ListViewItem lvt = new ListViewItem(row);
                        listView1.Items.Add(lvt);
                    }

                }

            }
          

        }

        private void button2_Click(object sender, EventArgs e) {
            Validator checkIfBoxEmpty = new Validator(cb_updateinterval, "Du måste ange hur ofta du vill att din nya podcast ska uppdateras");
            Validator checkIfURLEmpty = new Validator(tx_rssUrl, "URL", "Du måste ange ett giltigt URL");
            Validator checkIfNameEmpty = new Validator(tx_podcastName, "Namn", "Podcasten som du vill lägga till måste ha ett namn");
            Validator checkIfCategoryEmtpty = new Validator(categoryCb, "Välj en kategori till din nya podcast");
            //Feed newFeed = new Feed();

            if (!checkIfBoxEmpty.isBoxEmpty() && !checkIfURLEmpty.isFieldEmpty() && !checkIfNameEmpty.isFieldEmpty() && !checkIfCategoryEmtpty.isBoxEmpty() && tx_rssUrl.Text.Contains("rss")) {
                var updateInterval = cb_updateinterval.Text;
                int newUpdateInterval = Convert.ToInt32(updateInterval);
                var path = Directory.GetCurrentDirectory() + @"\" + categoryCb.Text + @"\" + tx_podcastName.Text + ".xml";

                var directoryPath = Directory.GetCurrentDirectory() + @"\" + categoryCb.Text + @"\" + tx_podcastName.Text + ".xml";
                _xmlcontainer.AddFeedInfo(directoryPath, tx_rssUrl.Text, newUpdateInterval, path, tx_podcastName.Text, categoryCb.Text);
                FillPodcastInfoList();

            } else {
                MessageBox.Show("Någonting gick fel. Kanske är den URL du angav inte giltig?");
            }


        }

        private void listAvsnitt_SelectedIndexChanged(object sender, EventArgs e) {

            listdescrip.Items.Clear();
            if (listAvsnitt.SelectedItems.Count == 1) {
                var selectedEpisode = listAvsnitt.SelectedItems[0].Text;

                foreach (var items in _feeds) {
                    foreach (var singleEpisode in items.Episodes) {
                        if (singleEpisode.Title.Equals(selectedEpisode) && items.Title.Equals(podname)) {

                            listdescrip.Items.Add(singleEpisode.Description);
                        }
                    }
                }
            }
        }

        //private void Form1_Load(object sender, EventArgs e) {

        //}

        private void btn_DeletePodcast_Click(object sender, EventArgs e) {

            try
            {
                if (listView1.SelectedItems.Count == 1)
                {

                    var selectedFeed = listView1.SelectedItems[0];
                    logicLayer.Delete(selectedFeed.SubItems[0].Text, selectedFeed.SubItems[3].Text);
                    FillPodcastInfoList();
                }
                else MessageBox.Show("Markera en podcast.");

            }
            catch (Exception)
            {

                MessageBox.Show("Någonting gick fel.");
            }






        }

        private void btnAndra_Click(object sender, EventArgs e) {
            Validator Validation = new Validator(skrivKategori, "", "Markera kategorin som du vill ändra och skriv det nya namnet i fältet");

            try {
                while (Validation.isFieldEmpty() == false) {
                    string changeDir = skrivKategori.Text;
                    string path = ListCategories.SelectedItem.ToString();
                    logicLayer.Edit(changeDir, path);
                    FillCatergory();
                    FillPodcastInfoList();

                }
            } catch (Exception ex) {

                Console.WriteLine("An error occurred: '{0}'", ex);


            }



        }

        private void bn_changeCat_Click(object sender, EventArgs e) {


            try
            {
                var thirdSelectedItem = listView1.SelectedItems[0];
                var selectedPodCategory = thirdSelectedItem.SubItems[3];

                logicLayer.changePodcastLocation(selectedPodCategory.Text, categoryCb.Text, thirdSelectedItem.Text, categoryCb);

                listView1.Items.Clear();
                listAvsnitt.Items.Clear();
                listdescrip.Items.Clear();
                _categories = _xmlcontainer.GetAllCategories();
                FillCatergory();
            }
            catch (Exception)
            {
                MessageBox.Show("Se till att ha markerat podcasten som du vill flytta samt valt ny kategori.");
            }


        }

        private void bn_changeFrek_Click(object sender, EventArgs e) {
           //var podcast = listView1.SelectedItems[0];
           // Feed myFeed = new Feed();
           // _xmlcontainer.AddFeedInfo()
           // myFeed.Title = podcast.Text;
           // var castPodcast = "hej";
            
        }

        private void bn_changeName_Click(object sender, EventArgs e) {

        }
    }
}
