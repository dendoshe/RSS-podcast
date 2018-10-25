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

        public void addPodcastInfo(string url, int frequency, string category, string podcastholder) { //steg 1 och även här det avslutas . Steg 1 sätter in värder som jag lägger till xml.filen
            var podcast = new Podcast {

                //Title = "", ifall vi vill namnge när vi lägger till en podcast
                Updateintervall = frequency,
                Path = podcastholder,
                Episodes = ReadEpisodesFromRssLink(url)
            };

            save(podcast);


        }

        public List<Episode> ReadEpisodesFromRssLink(string rssLink) // steg 2, detta hämtar namn på enskilda podcastavsnitt
          {

            var reader = XmlReader.Create(rssLink);
            var syndicationFeed = SyndicationFeed.Load(reader);

            List<Episode> episodeList = new List<Episode>();

            foreach (var item in syndicationFeed.Items) {
                var episode = new Episode(); //skapat ett object av en episode som lever en gång i foreach-loopen
                episode.Title = item.Title.Text; //Lägger till Title på avsnitte från SyndicationFeed
                episodeList.Add(episode); //Lägger till den enskilda objecten i episodeList

            }

            return episodeList;
        }



        public void save(Podcast podcastObject) //steg 3 Det här är en metod för att spara Xml-filen. 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Podcast));
            using (StreamWriter writer = new StreamWriter(podcastObject.Path)) {

                serializer.Serialize(writer, podcastObject);

            }

        }






       

    //public List<Podcast> Getpostcastfiles (string podcastpath) // Det här har inget med XML-filen. Utan är en metod som jag anropar för att fulla min lista med podcast
    //    {
    //        string[] files = Directory.GetFiles(podcastpath); 

    //        List<Podcast> podcastList = new List<Podcast>();

    //        foreach (var item in files) 
    //        {
    //            FileInfo fileinfo = new FileInfo(item);

    //        }

    //        return podcastList;

    //    }

    
      
        
        
    }
}
