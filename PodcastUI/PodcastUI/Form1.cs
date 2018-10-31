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

        public Form1() {
            InitializeComponent();
            logicLayer = new PodcastMani();
            _xmlcontainer = new XmlContainer();
            _categories = _xmlcontainer.GetAllCatergories();
            FillCatergory(); 
           }




        private void FillCatergory() {

            _xmlcontainer.GetAllCatergories();
            foreach (var category in _categories) {

                ListCategories.Items.Add(category.Title);
                categoryCb.Items.Add(category.Title);

            }
        }

      


        private void label1_Click(object sender, EventArgs e) {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void nykategori_Click(object sender, EventArgs e) {

                var dirName = skrivKategori.Text;

                if (Directory.Exists(dirName)) {

                    MessageBox.Show("Dir: '" + dirName + "' exists");
                } else {

                    Directory.CreateDirectory(dirName);
                    MessageBox.Show("Created dir: '" + dirName + " '");
             
                    ListCategories.Items.Clear();
                    FillCatergory();  //flytta till logic

            }
            
        }

         private void button6_Click(object sender, EventArgs e) {
           
          
          if (ListCategories.SelectedIndex != -1) {

                string genreFolder = ListCategories.SelectedItem.ToString();
                logicLayer.DeleteCategori(genreFolder);
                ListCategories.Items.RemoveAt(ListCategories.SelectedIndex); //denna metod tar oavsett vad alltid bort det som är valt i kategori boxen
                //FillCatergory();

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
            _xmlcontainer.AddFeedInfo(tx_rssUrl.Text, newUpdateInterval, path);

        }
    }
}
