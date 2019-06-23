using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Project.Models
{
    public class Page
    {
        // picture
        // sound
        // text
        public int ID { get; set; }
        public string ImageLinks { get; set; }
        public string Texts { get; set; }

        public string SoundLinks { get; set; }
    }
}