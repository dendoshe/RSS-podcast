using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PodcastUI.Models
{
    public class Episode
    {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till avsnitten, detta är en node.
        public string Url { get; set; } //Här har vi skapat url-noden till avsnitten som håller ljudfilen.

    }

}

