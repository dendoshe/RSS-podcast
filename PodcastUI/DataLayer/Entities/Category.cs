using DataLayer;
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
        public string Path { get; set; }
        public List <Feed> FeedList { get; set; }
        static public Dictionary<Category, List<Feed>> CategoryContainer = new Dictionary<Category, List<Feed>>(); //Lista för att hålla alla kategorier med sina respektive feeds 



        public Category NewCategory(string name)
        {
            return new Category { Title = name };

        }

        public void AddFeedToCategory(Category categoryName, List<Feed> newFeedList)
        {
            if (CategoryContainer.ContainsKey(categoryName))
            {
                CategoryContainer.Add(categoryName, newFeedList);
            }

        }




    }
}
