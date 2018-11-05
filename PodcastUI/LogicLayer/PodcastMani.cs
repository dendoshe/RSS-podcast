using DataLayer; //refererar till datalager projektet för att projektet ska känna av de metoder som finns i datalayer
using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using PodcastUI;

namespace LogicLayer
{
    public class PodcastMani
    {
        private XmlContainer xmlcontainer = new XmlContainer(); //Här har vi skapat ett av XmlConatiner som ligger i DataLayer. Den körs en gång vid uppstart.





        public void editFeed(string URL, string folderName, int updateInterval, string category)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), folderName, URL + @".xml");
            

        }
    }
}
