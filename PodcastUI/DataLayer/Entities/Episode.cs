﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastUI.Models
{
    public class Episode
    {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till avsnitten, detta är en node.
        public string Url { get; set; } //Här har vi skapat url-noden till avsnitten som håller ljudfilen.


        //public List<Episode> GetListOfEpisodesInFeed(Feed feed)
        //{
        //    foreach (var episode in feed)
        //    {

        //    }
        //    return episodesInFeed;
        //}
    }



}
