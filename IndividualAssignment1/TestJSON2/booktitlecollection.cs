using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestJSON2
{
    public class booktitlecollection
    {
        private List<booktitle> booktitle;

        public List<booktitle> Booktitles { get => booktitle; set => booktitle = value; }
    }
}