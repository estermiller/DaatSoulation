using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Xml;

namespace DaatSoulation.DAL
{
    public class RssFeedDAL
    {
    //this method retrieves an RSS feed either from the cache or by making a request to the specified URL
            public static SyndicationFeed GetRssFeed()
            {
                var cacheKey = "RssFeed";
                var cache = HttpContext.Current.Cache;
                var cachedFeed = cache[cacheKey] as SyndicationFeed;
                //first checks if the RSS feed is already stored in the cache
                if (cachedFeed == null)
                {
                    //fetch the RSS feed from a specified URL
                    var url = "http://news.google.com/news?pz=1&cf=all&ned=en_il&hl=en&output=rss";
                    var reader = XmlReader.Create(url);
                    cachedFeed = SyndicationFeed.Load(reader);
                    //set to expire after 10 minutes (you can change minutes)
                    cache.Insert(cacheKey, cachedFeed, null, DateTime.Now.AddMinutes(10), TimeSpan.Zero);
                }
                return cachedFeed;
            }
    }
}