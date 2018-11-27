using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectTest
{
    public class Titles
    {
        private int id;
        int asin;
        string reviewerName;
        int helpful;
        string reviewText;
        int overall;
        string summary;
        int unixReviewTime;
        private DateTime reviewTime;

        public int Id { get => id; set => id = value; }
        public int Asin { get => asin; set => asin = value; }
        public string ReviewerName { get => reviewerName; set => reviewerName = value; }
        public int Helpful { get => helpful; set => helpful = value; }
        public string ReviewText { get => reviewText; set => reviewText = value; }
        public int Overall { get => overall; set => overall = value; }
        public string Summary { get => summary; set => summary = value; }
        public int UnixReviewTime { get => unixReviewTime; set => unixReviewTime = value; }
        public DateTime ReviewTime { get => reviewTime; set => reviewTime = value; }
    }
}