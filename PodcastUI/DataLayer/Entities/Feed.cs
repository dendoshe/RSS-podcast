using DataLayer;
using System.Collections.Generic;


namespace PodcastUI.Models
{
    public class Feed
    {
        public Category Category { get; set; }
        public string Url { get; set; }
        public int UpdateIntervall { get; set; } // Här har vi skapat en node som innehåller updateintervall.
        public List<Feed> FeedList { get; set; } // Här har vi skapat en lista med feed objekt (som består av varsin url, updateintervall och tillhör en kategori).
        public Dictionary<Feed, List<Episode>> EpisodeListInFeed { get; set; } // Här har vi skapat en lista med Episode objekt (som härleds ur sin key, feed objekten). Den kommer bestå av avsnitt.



        //public void NewFeed(string url, int updateIntervall, Category category) //metod för att skapa ny feed som läggs till i sin kategori
        //{
        //    var newFeed = new Feed { Url = url, UpdateIntervall = updateIntervall, Category = category };
        //    Category.AddFeedToCategory(category, newFeed);
        //}

        //public void GenerateEpisodesToFeed(Feed chosenFeed)
        //{
        //    Episode episode = new Episode();
        //    episode.GetListOfEpisodesInFeed(chosenFeed); //här ska metoden i episodes anropas och fylla sin feed med avsnittlänkar

        //}

        public Feed SelectFeed(string url)
        {
            XmlContainer xml = new XmlContainer();



            var aFeed = from feed in
                        where feed.url == url
                        select feed;
            return aFeed;
        }

    }

    //public List<Feed> Generate FeedList


    //public class PodcastList : List<Podcast> {
    //    public List<Podcast> GetOrdered() {
    //        return this.OrderBy((w))

    //    }
}

