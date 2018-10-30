﻿using DataLayer;
using PodcastUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

            static public void load()
        {
            XmlContainer visaFeed = new XmlContainer();

            var visa = visaFeed.ReadEpisodesFromRssLink("https://cdn.radioplay.se/data/rss/507.xml");




            Console.WriteLine(visa);

        }


    }
}
