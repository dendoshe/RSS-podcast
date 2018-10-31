using DataLayer; //refererar till datalager projektet för att projektet ska känna av de metoder som finns i datalayer
using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace LogicLayer {
    public class PodcastMani {
        private XmlContainer xmlcontainer = new XmlContainer(); //Här har vi skapat ett av XmlConatiner som ligger i DataLayer. Den körs en gång vid uppstart.


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

        //public string[] folders = {

        //    @"Workspace\",
        //    @"Workspace\Archive\"
        //};

        //public enum FolderNames {
        //    Workspace, 
        //    Archive
        //}


        //public void CreateDirectory() { //skapa flera folders 

        //    var total = folders.Length;

        //    for (var i = 0; i < total; i++) {

        //        var dirName = GetFoldersByName((FolderNames)i);

        //        if (Directory.Exists(dirName)) {

        //            Console.WriteLine("Dir '" + dirName + "' exists");
        //        } else {

        //            Directory.CreateDirectory(dirName);
        //            Console.WriteLine("Create dir '" + dirName + " '");
        //        }
        //     }

        //  }

        //public void DeleteFolder(string name) { 

        //    var deleteDir = GetFoldersByName(FolderNames.;

        //    if(Directory.Exists(deleteDir)) {

        //        Directory.Delete(deleteDir, true); 
        //    }





        //public string GetFoldersByName(FolderNames name) { //vi kan alltid anropa denna folder när vi behöver tillgång till en specifik folder

        //    return folders[(int)name];
        //}




    }

}
