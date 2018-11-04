using DataLayer; //refererar till datalager projektet för att projektet ska känna av de metoder som finns i datalayer
using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace LogicLayer {
    public class PodcastMani {
        private XmlContainer xmlcontainer = new XmlContainer(); //Här har vi skapat ett av XmlConatiner som ligger i DataLayer. Den körs en gång vid uppstart.


        public void ChangeCategory(string newLocation, string oldLocation) {

        
            if (Directory.Exists(oldLocation)) {

                Directory.Move(oldLocation, newLocation);
                MessageBox.Show("Din kategori har ändrats till " + newLocation);
            }
        }



        public void CreatenewDir(string folder) {
            var dirName = folder;

            if (Directory.Exists(dirName)) {

                MessageBox.Show("Dir: '" + dirName + "' exists");
            } else {

                Directory.CreateDirectory(dirName);
                MessageBox.Show("Created dir: '" + dirName + " '");


            }
        }

        public void DeleteCategori(string folder) 
        {

            var folderLocation = Directory.GetCurrentDirectory();
            string path = Path.Combine(folderLocation, folder);
            if (Directory.GetFiles(path).Length == 0) 
                {
                Directory.Delete(path, true);

            } else {

                DialogResult dialogResult = MessageBox.Show("kategegori innehåller podcasts vill du ta bort den ändå?", "Varning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Directory.Delete(path, true);
                } else if (dialogResult == DialogResult.No) {
                   
                }
            }
            
        }


        public void DeleteFeed(string feedName, string FolderName ) {

            
            string path = Path.Combine(Directory.GetCurrentDirectory(), FolderName, feedName + @".xml");

                                 
                DialogResult dialogResult = MessageBox.Show("Är du säkert du vill ta bort podcasten " + feedName + " permanent?", "Varning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    File.Delete(path);
                } else if (dialogResult == DialogResult.No) {

                }
                                         

        }
              
    }

}
