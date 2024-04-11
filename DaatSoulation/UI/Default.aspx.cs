using DaatSoulation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace DaatSoulation.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // returned feed items
                var feed = RssFeedDAL.GetRssFeed();
                rptTopics.DataSource = feed.Items;
                rptTopics.DataBind();

            }
        }
        [WebMethod]
        public static NewsData GetNewsById(int id)
        {
           return NewsData.GetNewsById(id);
        }

    }
}