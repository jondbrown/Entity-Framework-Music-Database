using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class Song
    {
        public int SongID { get; set;  }
        public string Title { get; set; }
        public int AlbumID { get; set; }
        

        public Album Album { get; set; }

    }


}