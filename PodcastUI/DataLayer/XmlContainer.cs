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

        public void addFeedInfo(string url, int frequency, string category, string feedholder) { //steg 1 och även här det avslutas . Steg 1 sätter in värder som jag lägger till xml.filen
            var feed = new Feed
            {

                //Title = "", ifall vi vill namnge när vi lägger till en feed
                Updateintervall = frequency,
                Path = feedholder,
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
                episode.Title = item.Title.Text; //Lägger till Title på avsnitte från SyndicationFeed
                episodeList.Add(episode); //Lägger till den enskilda objekten i episodeList

            }

            return episodeList;
        }



        public void save(Feed feedObject) //steg 3 Det här är en metod för att spara Xml-filen. 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Feed));
            using (StreamWriter writer = new StreamWriter(feedObject.Path)) {

                serializer.Serialize(writer, feedObject);

            }

        }






       

    //public List<Feed> Getpostcastfiles (string feedpath) // Det här har inget med XML-filen. Utan är en metod som jag anropar för att fulla min lista med podcast
    //    {
    //        string[] files = Directory.GetFiles(feedpath); 

    //        List<Feed> feedList = new List<Feed>();

    //        foreach (var item in files) 
    //        {
    //            FileInfo fileinfo = new FileInfo(item);

    //        }

    //        return feedList;

    //    }

    
      
        
        
    }
}
