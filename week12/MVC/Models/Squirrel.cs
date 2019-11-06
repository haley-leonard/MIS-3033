using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Squirrel
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int TeethSize { get; set; }

        public Squirrel()
        {
            Name = string.Empty;
            ImageURL = string.Empty;
            TeethSize = 0;
        }
    }
}