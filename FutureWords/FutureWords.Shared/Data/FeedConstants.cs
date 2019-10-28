namespace FutureWords.Shared.Data
{
    public class FeedConstants
    {
        public static string FeedUrl = "https://www.idiwork.com/feed/";

        public static string ItemsRoute = "rss/channel/item";

        public static string TitleNode = "title";
        public static string DescriptionNode = "description";
        public static string LinkNode = "link";
        public static string CategoryNode = "category";
        public static string PublicationDateNode = "pubDate";

        public static string NoTitleMessage = "No title";
        public static string NoDescriptionMessage = "No description";
        public static string NoLinkMessage = "No link available";
        public static string NoCategoryMessage = "No category";
        public static string NoPubDateMessage = "No publication date";
    }
}
