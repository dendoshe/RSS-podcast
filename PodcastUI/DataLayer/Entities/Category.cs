using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastUI.Models {
    public class Category {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till kategory, detta är en node. 
        public string Path { get; set; } // Här har vi skapat Path och den kommer visa vart mappen ligger på datorn, detta är en node.
        public List<Feed> FeedList { get; set; } // Här har vi skapat en lista med podcast obejct. Den kommer bestå av avsnitt. Detta är en node.
    }
}
