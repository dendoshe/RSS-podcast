using System.Collections.Generic;


namespace PodcastUI.Models {
    public class Feed {
        public Category Category { get; set; }
        public string Url { get; set; }
        public int UpdateIntervall { get; set; } // Här har vi skapat en node som innehåller updateintervall.
        public Dictionary<Feed, List<Episode>> EpisodeListInFeed { get; set; } // Här har vi skapat en lista med Episode objekt (som härleds ur sin key, feed objekten). Den kommer bestå av avsnitt.



        public void NewFeed(string url, int updateIntervall, Category category) //metod för att skapa ny feed som läggs till i sin kategori
        {
            var newFeed = new Feed { Url = url, UpdateIntervall = updateIntervall, Category = category };
            Category.AddFeedToCategory(category, newFeed);
        }

        public void GenerateEpisodesToFeed(Feed chosenFeed)
        {
            GetListOfEpisodesInFeed(chosenFeed); //här ska metoden i episodes anropas och fylla sin feed med avsnittlänkar

        }

    }


    //public class PodcastList : List<Podcast> {
    //    public List<Podcast> GetOrdered() {
    //        return this.OrderBy((w))

    //    }
 }

