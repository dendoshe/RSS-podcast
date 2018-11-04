using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using PodcastUI.Models;
using System.IO;
using System.Xml.Serialization;

namespace DataLayer {
    public class XmlContainer {

        private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(Feed));

        

        public void AddFeedInfo(string url, int frequency, string localPath) { //steg 1 och även här det avslutas . Steg 1 sätter in värder som jag lägger till xml.filen

            var feed = new Feed
            {

                //Title = feedholder //, ifall vi vill namnge när vi lägger till en feed
                UpdateIntervall = frequency,
                Url = localPath,
                Episodes = ReadEpisodesFromRssLink(url)
            };

            save(feed);


        }

    
        public List<Episode> ReadEpisodesFromRssLink(string rssLink) // steg 2, detta hämtar namn på enskilda feeds
        {

            var reader = XmlReader.Create(rssLink);
            var syndicationFeed = SyndicationFeed.Load(reader);

            List<Episode> episodeList = new List<Episode>();

            foreach (var item in syndicationFeed.Items) {
                var episode = new Episode(); //skapat ett object av en episode som lever en gång i foreach-loopen
                episode.Title = item.Title.Text; //Lägger till Title på avsnittet från SyndicationFeed
                episodeList.Add(episode); //Lägger till den enskilda objecten i episodeList

            }

            return episodeList;
        }



        public void save(Feed feedObject) //steg 3 Det här är en metod för att spara Xml-filen. 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Feed));
            using (StreamWriter writer = new StreamWriter(feedObject.Path)) {

                serializer.Serialize(writer, feedObject);
                writer.Close();
            }

        }

        public List<Feed> GetAllFeedsInCategory(string categoryPath) {
            var files = Directory.GetFiles(categoryPath);
            List<Feed> feeds = new List<Feed>();

            foreach (var file in files) {

                var info = new FileInfo(file);

                using (var reader = new StreamReader(file)) {
                    feeds.Add((Feed)_xmlSerializer.Deserialize(reader));
                    reader.Close();
                }

            }
            return feeds;
        }

        public List<Category> GetAllCatergories() {
            var path = Directory.GetCurrentDirectory();
            var folders = Directory.GetDirectories(path);
            List<Category> categories = new List<Category>();
            foreach (var folder in folders) {

                var info = new DirectoryInfo(folder);
                categories.Add(new Category() { Title = info.Name, Path = folder, FeedList = GetAllFeedsInCategory(folder) });

            }
            return categories;

        }


     }
}
