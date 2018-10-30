using DataLayer;
using LogicLayer;
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
        public Form1() {
            InitializeComponent();

        }

        //private void Form1_Load(object sender, EventArgs e) {
        //    var feeds = new[] {

        //    };
        //    Task.Run(() => GetUrl(feeds));
        //}

        //private async Task GetUrlAsync(string[] feeds) {
        //    foreach (var item in feeds) {
        //        var episode = await logicLayer.GetStringAsync(item);


        //    }
        //}

        private void label1_Click(object sender, EventArgs e) {

        }

        //private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
        //    XmlContainer nyFeed = new XmlContainer();

        //    nyFeed.addFeedInfo("https://www.radioplay.se/podcast/mellan-himmel-och-jord?episode-id=38607", 4, "humor", "https://cdn.radioplay.se/data/rss/507.xml");

        //}

        private void button5_Click(object sender, EventArgs e) {
            var path = Directory.GetCurrentDirectory() + @"\" + "favoriter"+ @"\" + "blomma"+ ".xml";
            _xmlcontainer.addFeedInfo("http://tackforkaffet.libsyn.com/rss",1000,"favoriter",
                path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
