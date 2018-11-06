using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using PodcastUI.Models;
using System.IO;
using System.Xml.Serialization;

namespace DataLayer {
    public class XmlContainer {

        private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(Feed));



        public async Task AddFeedInfo(string url,string rssLink, int frequency, string localPath, string podcastName, string inputCategory) { //steg 1 och även här det avslutas . Steg 1 sätter in värder som jag lägger till xml.filen
            var feed = new Feed {

                Title = podcastName, //, ifall vi vill namnge när vi lägger till en feed
                Category = inputCategory,
                RssLink = rssLink,
                Updateintervall = frequency,
                Path = localPath,
                Episodes = await ReadEpisodesFromRssLink(url)
            };

            save(feed);


        }

        public async Task AddFeedInfo(string url, string rssLink, string frequency, string localPath, string podcastName, string inputCategory) {
            await AddFeedInfo(url, rssLink, int.Parse(frequency), localPath, podcastName, inputCategory);


        }

        public void AddToXmlContainer(string url, string rssLink, int updateinterval, string path, string name, string category) {
            XmlContainer _xmlcontainer = new XmlContainer();
            var result = _xmlcontainer.AddFeedInfo(url,rssLink, updateinterval, path, name, category);
        }


        public async Task<List<Episode>> ReadEpisodesFromRssLink(string rssLink) // steg 2, detta hämtar namn på enskilda feeds
        {

            //await Task.Factory.StartNew(() => 
            //{
            //    using (XmlReader reader = XmlReader.Create(rssLink)) 
            //    {
            //        SyndicationFeed feed = SyndicationFeed.Load(reader);
            //    }


            //});
            XmlReader reader = XmlReader.Create(rssLink);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            List<Episode> episodeList = new List<Episode>();

            foreach (var item in feed.Items) {
                var episode = new Episode(); //skapat ett object av en episode som lever en gång i foreach-loopen
                episode.Title = item.Title.Text; //Lägger till Title på avsnitte från SyndicationFeed
                episode.Description = item.Summary.Text;
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

        public List<Feed> GetAllPodcastsInCategory(string categoryPath) {
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

        public List<Feed> GetAllPoscastInCategory() {
            var getCatergories = GetAllCatergories();

            List<Feed> feeds = new List<Feed>();
            //foreach (var item in getCatergories) {

            var path = Directory.GetCurrentDirectory();
            var foldersTwo = Directory.GetDirectories(path);


            foreach (var anitem in getCatergories) {

                var getfiles = Directory.GetFiles(anitem.Title);
                var info = new FileInfo(anitem.Title);
                foreach (var finalItems in getfiles) {

                    using (var reader = new StreamReader(finalItems)) {
                        feeds.Add((Feed)_xmlSerializer.Deserialize(reader));
                        reader.Close();


                    }



                }
            }
            // }
            return feeds;
        }

        public List<Category> GetAllCatergories() {
            var path = Directory.GetCurrentDirectory();
            var folders = Directory.GetDirectories(path);
            List<Category> categories = new List<Category>();
            foreach (var folder in folders) {

                var info = new DirectoryInfo(folder);
                categories.Add(new Category() { Title = info.Name, Path = folder, PodcastList = GetAllPodcastsInCategory(folder) });

            }
            return categories;

        }


    }
}
