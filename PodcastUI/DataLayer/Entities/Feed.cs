using DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PodcastUI.Models
{
    public class Feed 
    {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till podcasten, detta är en node. Behövs bara om vi vill namnge podcasten
        public string Category { get; set; }
        public string RssLink { get; set; }
        public string Path { get; set; } // Här har vi skapat Path och den kommer visa vart filen ligger på datorn, detta är en node.
        public int Updateintervall { get; set; } // Här har vi skapat en node som innehåller updateintervall.
        public List<Episode> Episodes { get; set; } // Här har vi skapat en lista med Episode obejct. Den kommer bestå av avsnitt. Detta är en node.



        public override string ToString() {
            return Title;
        }

    }
}