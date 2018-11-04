using DataLayer;
using System.Collections.Generic;


namespace PodcastUI.Models
{
    public class Feed
    {
        public Category Category { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public int UpdateIntervall { get; set; } // Här har vi skapat en node som innehåller updateintervall.
        public List<Episode> Episodes { get; set; }

        public Feed NewFeed (string url, int updateIntervall, List <Episode> episodes) //metod för att skapa ny feed som läggs till i sin kategori
        {
            var newFeed = new Feed { Url = url, UpdateIntervall = updateIntervall};
            return newFeed;

        }

        public void addNewFeedToCategory(Category categoryName, List <Feed> newFeedList)
        {
            Category.AddFeedToCategory(categoryName, newFeedList);
        }

        }




        //public void GenerateEpisodesToFeed(Feed chosenFeed)
        //{
        //    Episode episode = new Episode();
        //    episode.GetListOfEpisodesInFeed(chosenFeed); //här ska metoden i episodes anropas och fylla sin feed med avsnittlänkar

        //}

        //public Feed SelectFeed(string url)
        //{
        //    XmlContainer xml = new XmlContainer();



        //    var aFeed = from feed in
        //                where feed.url == url
        //                select feed;
        //    return aFeed;
        //}

    }

    //public List<Feed> Generate FeedList


    //public class PodcastList : List<Podcast> {
    //    public List<Podcast> GetOrdered() {
    //        return this.OrderBy((w))

    //    }


