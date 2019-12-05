namespace ReclameJa.Models
{
    public class DashBoard
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public DashBoard(string url, string title)
        {
            this.ImageURL = url;
            this.Title = title;

        }
    }
}
