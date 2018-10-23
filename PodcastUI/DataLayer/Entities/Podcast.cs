using System.Collections.Generic;


namespace PodcastUI.Models {
    class Podcast {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till podcasten, detta är en node. 
        public string Path { get; set; } // Här har vi skapat Path och den kommer visa vart filen ligger på datorn, detta är en node.
        public int Updateintervall { get; set; } // Här har vi skapat en node som innehåller updateintervall.
        public List<Episode> Episodes { get; set; } // Här har vi skapat en lista med Episode obejct. Den kommer bestå av avsnitt. Detta är en node.
      
    }

    //public class PodcastList : List<Podcast> {
    //    public List<Podcast> GetOrdered() {
    //        return this.OrderBy((w))

    //    }
 }

