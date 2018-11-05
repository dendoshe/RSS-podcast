using DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastUI.Models {

    public class Category : IPodcast {
        //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
        public string Title { get; set; } //Här har vi skapat Title till kategory, detta är en node. 
        public string aPath { get; set; } // Här har vi skapat Path och den kommer visa vart mappen ligger på datorn, detta är en node.
        public List<Feed> PodcastList { get; set; } // Här har vi skapat en lista med podcast obejct. Den kommer bestå av avsnitt. Detta är en node.


        public void Delete(string folder, string smh)
        { 

            var folderLocation = Directory.GetCurrentDirectory();
            string path = Path.Combine(folderLocation, folder);

            if (Directory.GetFiles(path).Length == 0)
            {
                Directory.Delete(path, true);

            }

            else
            {

                DialogResult dialogResult = MessageBox.Show("kategorin som du har valt innehåller podcasts. Vill du ta bort den ändå?", "Varning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Directory.Delete(path, true);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        public void Add(string folder, string smh)
        {
            smh = "";
            var dirName = folder;

            try
            {
                if (Directory.Exists(dirName))
                {

                    MessageBox.Show("Dir: " + dirName + " finns redan");
                }

                else
                {
                    Directory.CreateDirectory(dirName);
                    MessageBox.Show("Skapat dir: " + dirName);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void Edit (string newLocation, string oldLocation)
        {

                if (Directory.Exists(oldLocation))
                {

                    Directory.Move(oldLocation, newLocation);
                    MessageBox.Show("Din kategori har ändrats till " + newLocation);
                }


        }

    }
}
