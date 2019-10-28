using FutureWords.Shared.Data;
using FutureWords.Shared.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace FutureWords.Shared.Services
{
    public class FeedReader
    {
        private string FeedUrl { get; }

        public List<Post> Posts { get; set; }

        public FeedReader()
        {
            FeedUrl = FeedConstants.FeedUrl;
            Posts = new List<Post>();
        }

        public List<Post> GetPostsFromFeed()
        {
            XmlDocument rss = new XmlDocument();
            rss.Load(FeedUrl);

            XmlNodeList nodes = rss.SelectNodes(FeedConstants.ItemsRoute);

            foreach (XmlNode node in nodes)
            {
                Posts.Add(GetPostFromNode(node));
            }

            return Posts;
        }

        private Post GetPostFromNode(XmlNode node)
        {
            Post post = new Post();

            var titleNode = node.SelectSingleNode(FeedConstants.TitleNode);
            post.Title = titleNode?.InnerText ?? FeedConstants.NoTitleMessage;

            var descriptionNode = node.SelectSingleNode(FeedConstants.DescriptionNode);
            var description = descriptionNode?.InnerText;
            post.Content = string.IsNullOrEmpty(description) ? FeedConstants.NoDescriptionMessage : CleanNodeContent(description.Substring(0, 250));

            var pubDateNode = node.SelectSingleNode(FeedConstants.PublicationDateNode);
            try
            {
                post.PublicationDate = DateTime.Parse(pubDateNode.InnerText);
            }
            catch
            {
                post.PublicationDate = null;
            }

            var linkNode = node.SelectSingleNode(FeedConstants.LinkNode);
            post.Link = linkNode?.InnerText ?? FeedConstants.NoLinkMessage;

            var categoryNode = node.SelectSingleNode(FeedConstants.CategoryNode);
            post.Category = categoryNode?.InnerText ?? FeedConstants.NoCategoryMessage;

            return post;
        }

        private string CleanNodeContent(string data)
        {
           return data.Replace("![CDATA[", "").Replace("<p>", "");
        }
    }
}
