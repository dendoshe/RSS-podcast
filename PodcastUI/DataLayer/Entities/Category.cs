using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastUI.Models
{
    public class Category
    {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till kategory, detta är en node. 
        public List<Feed> FeedList { get; set; } // Här har vi skapat en lista med feed objekt (som består av varsin url, updateintervall och tillhör en kategori).
        public List<Feed> EpisodeList { get; set; } // Här har vi skapat en lista med Episode objekt (som härleds ur feed objekten). Den kommer bestå av avsnitt.

        public void NewCategory ()

    }
}


