using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestJSON2
{
    public class booktitlecollection
    {
        private List<booktitle> booktitles;

        public List<booktitle> Booktitles { get => booktitles; set => booktitles = value; }
    }
}