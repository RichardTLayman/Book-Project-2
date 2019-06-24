using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Book_Project.Models
{
    public class PageDBContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }

    public class Page
    {
        public int ID { get; set; }
        public string ImageLinks { get; set; }
        public string Texts { get; set; }

        public string SoundLinks { get; set; }

        public int OptionOne { get; set; }
        public int OptionTwo { get; set; }
    }
}