using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace TestJSON2
{
    public class ShowBooks
    {
        static ShowBooks()
        {
            using (var webClient = new WebClient())

            {
                // get a string representation of our JSON.
                String rawJSON = webClient.DownloadString("http://snap.stanford.edu/data/amazon/productGraph/categoryFiles/reviews_Books_5.json.gz");
                // convert the JSOn string to a series of object.
                booktitlecollection booktitlecollection = JsonConvert.DeserializeObject<booktitlecollection>(rawJSON);
                // do some computation.
                Console.WriteLine(booktitlecollection.Booktitles.Count);

                // take the objects parsed from JSON, and give them to my static collection.
                AllBooktitles = booktitlecollection.Booktitles;
            }
        }

        private static List<booktitle> allBooktitles;

        public static List<booktitle> AllBooktitles { get => allBooktitles; set => allBooktitles = value; }

        public static List<booktitle> GetBooktitles()
        {
            return AllBooktitles;
        }

    }
}