using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChrissyTest
{
    public class Car
    {
        int id;
        string make_id;
        string make_display;
        int make_is_common;
        string make_country;

        public int Id { get => id; set => id = value; }
        public string Make_id { get => make_id; set => make_id = value; }
        public string Make_display { get => make_display; set => make_display = value; }
        public int Make_is_common { get => make_is_common; set => make_is_common = value; }
        public string Make_country { get => make_country; set => make_country = value; }
    }
}