using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int YearFormed { get; set; }
        public string Country { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}