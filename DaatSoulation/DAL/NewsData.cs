using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace DaatSoulation.DAL
{
    
    public class NewsData
    {
            public NewsData(string title,Uri link, string summary)
            {
                Title = title;
                Link = link;
                Summary = summary;
            }
            //Properties of News
            public string Title { get; set; }
            public Uri Link { get; set; }
            public string Summary { get; set; }

            public static NewsData GetNewsById(int id)
            {
                  var feedItem = RssFeedDAL.GetRssFeed().Items.ToArray()[id];
                  Uri linkUri = feedItem.Links[0].Uri;
                  string summary = feedItem.Summary.Text;
                  string title = feedItem.Title.Text;
                  NewsData news = new NewsData(title, linkUri, summary);
                  return news;
            }
    }
}