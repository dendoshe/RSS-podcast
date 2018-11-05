using DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PodcastUI.Models
{
    public class Feed : IPodcast
    {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till podcasten, detta är en node. Behövs bara om vi vill namnge podcasten
        public string Category { get; set; }
        public string aPath { get; set; } // Här har vi skapat Path och den kommer visa vart filen ligger på datorn, detta är en node.
        public int Updateintervall { get; set; } // Här har vi skapat en node som innehåller updateintervall.
        public List<Episode> Episodes { get; set; } // Här har vi skapat en lista med Episode obejct. Den kommer bestå av avsnitt. Detta är en node.

        public void Delete(string theCategory, string selectedFeed)
        {
                string path = Path.Combine(Directory.GetCurrentDirectory(), selectedFeed, theCategory + @".xml");

                DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort podcasten " + selectedFeed + " permanent?", "Varning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(path);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
        }

        public void Add(string theCategory, string selectedFeed)
        {

            var path = Directory.GetCurrentDirectory() + @"\" + theCategory + @"\" + selectedFeed + ".xml";

        }

        public void AddToXmlContainer(string url, int updateinterval, string path, string name, string category)
        {
            XmlContainer _xmlcontainer = new XmlContainer();
            var result = _xmlcontainer.AddFeedInfo(url, updateinterval, path, name, category);
        }

        public void Edit(string newLocation, string oldLocation)
        {

        }
    }
}