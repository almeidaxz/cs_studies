using MaosNaMassa.NotificationContext;

namespace MaosNaMassa.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) : base(title, url)
        {

        }

        public IList<Notification> Notifications { get; set; }
    }
}