using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ChrissyTest
{
    public partial class emojisJSON : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                
                // get a String representation of our JSON
                String rawJSON =
                    webClient.DownloadString("http://www.carqueryapi.com/api/0.3/?callback=?&cmd=getMakes&utm_medium=referral&utm_campaign=ZEEF&utm_source=https%3A%2F%2Fjson-datasets.zeef.com%2Fjdorfmann");
                // convert the JSON to a series of objects.
                List<CarCollection> carCollection = JsonConvert.DeserializeObject<List<CarCollection>>(rawJSON);
                // do some computation.
                Console.WriteLine(carCollection.Count);
            }

        }

        protected void BtnReadJSON_Click(object sender, EventArgs e)
        {

        }
        
    }
}