using DataLayer;
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
            _categories = _xmlcontainer.GetAllCatergories();
            _feeds = _xmlcontainer.GetAllPoscastInCategory();
            FillCatergory();
            FillUpdateInterval();
            FillPodcastInfoList();

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


            var listOfcategories = _xmlcontainer.GetAllCatergories();
            _categories = listOfcategories;

            foreach (var category in _categories) {

                ListCategories.Items.Add(category.Title);
                categoryCb.Items.Add(category.Title);

            }
        }

        private void FillPodcastInfoList() {
            listView1.Items.Clear();
            var listOfcategories = _xmlcontainer.GetAllCatergories();
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
            string changeDir = skrivKategori.Text;
            string path = ListCategories.SelectedItem.ToString();
            logicLayer.ChangeCategory(changeDir, path);
            FillCatergory();
            FillPodcastInfoList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void nykategori_Click(object sender, EventArgs e) {

            string newDir = skrivKategori.Text;
            logicLayer.CreatenewDir(newDir);

            FillCatergory();
        }

        private void button6_Click(object sender, EventArgs e) {


            if (ListCategories.SelectedIndex != -1) {

                string genreFolder = ListCategories.SelectedItem.ToString();
                logicLayer.DeleteCategori(genreFolder);
                ListCategories.Items.RemoveAt(ListCategories.SelectedIndex); //denna metod tar oavsett vad alltid bort det som är valt i kategori boxen
                FillCatergory();


            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e) {


        }

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            var updateInterval = cb_updateinterval.Text;
            int newUpdateInterval = Convert.ToInt32(updateInterval);

            var path = Directory.GetCurrentDirectory() + @"\" + categoryCb.Text + @"\" + tx_podcastName.Text + ".xml";
            _xmlcontainer.AddFeedInfo(tx_rssUrl.Text,tx_rssUrl.Text, newUpdateInterval, path, tx_podcastName.Text, categoryCb.Text);
            FillPodcastInfoList();





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

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btn_DeletePodcast_Click(object sender, EventArgs e) {

            var selectedFeed = listView1.SelectedItems[0];
            logicLayer.DeleteFeed(selectedFeed.SubItems[0].Text, selectedFeed.SubItems[3].Text);
            FillPodcastInfoList();

        }
    }
}
