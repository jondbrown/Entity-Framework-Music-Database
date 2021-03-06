﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Music.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public int ArtistID { get; set; }

        public Artist Artist { get; set; }
        public ICollection<Song> Song { get; set; }
    }
}