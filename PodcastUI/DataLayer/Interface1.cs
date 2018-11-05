using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    interface IPodcast
    {
        void Delete(string folder, string smh);
        void Add(string folder, string smh);
        void Edit(string newLocation, string oldLocation);
    }
}
