namespace LogicLayer {
    public interface IPodcastInterface {
        void Add(string folder, string smh);
        void Delete(string theCategory, string selectedFeed);
        void DeleteCategory(string folder, string smh);
        void Edit(string newLocation, string oldLocation);
        void editFeed(string URL, string folderName, int updateInterval, string category);
    }
}