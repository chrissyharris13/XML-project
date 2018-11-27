using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace TestJSON2
{
    public partial class readtitleJSON : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())

            {
                // get a string representation of our JSON.
                String rawJSON = webClient.DownloadString("http://snap.stanford.edu/data/amazon/productGraph/categoryFiles/reviews_Books_5.json.gz");
                // convert the JSOn string to a series of object.
                booktitlecollection booktitlecollection = JsonConvert.DeserializeObject<booktitlecollection>(rawJSON);
                // do some computation.
                Console.WriteLine(booktitlecollection.Booktitles.Count);
            }
        }

        protected void BltdListDescr_Click(object sender, BulletedListEventArgs e)


    }

}