using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastUI.models {

    public class Podcasts {
        public string Url { get; set; }
        public string Content { get; set; }
        public int ContentLength {
            get { return Content != null ? Content.Length : 0; }
        }
    }

    public class PodcastList : List<Podcasts> {

    }



}
