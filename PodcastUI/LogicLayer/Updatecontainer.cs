using DataLayer;
using PodcastUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LogicLayer {
    public class Updatecontainer {

        private static System.Timers.Timer updateTimer;
        public XmlContainer _xmlcontainer;
        public PodcastMani _podcastMani;


        private Feed _feed;
        private string feedName;
        private string categoryName;
        private string url;

        public Updatecontainer() {
            updateTimer = new Timer();
            _xmlcontainer = new XmlContainer();
            _podcastMani = new PodcastMani();
            updateTimer.Elapsed += new ElapsedEventHandler(Update_Elapsed);

        }

        public void Update_Elapsed(object sender, ElapsedEventArgs e) {

            updateTimer.Stop();

            _xmlcontainer.AddFeedInfo(url, _feed.Updateintervall, _feed.aPath, _feed.Title, _feed.Category);


        }

        public void newUpdate(string title, string titleOfCategory, Feed podcastFile, string aPath) {

            _feed = podcastFile;
            feedName = title;
            categoryName = titleOfCategory;
            url = aPath;

            updateTimer.Interval = podcastFile.Updateintervall;
            updateTimer.Enabled = true;
            updateTimer.Start();
        }
    }
}
