using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Music.Models;

namespace Music.DAL
{
    public class MusicInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var artists = new List<Artist>
            {
                new Artist { Name="Muse", YearFormed=1994, Country="United Kingdom"},
                new Artist { Name="Nirvana", YearFormed=1987, Country="USA"},
                new Artist { Name="The National", YearFormed=1999, Country="USA"},
                new Artist { Name="AC/DC", YearFormed=1973, Country="Australia"},
                new Artist { Name="U2", YearFormed=1976, Country="Ireland"},
            };

            artists.ForEach(s => context.Artists.Add(s));
            context.SaveChanges();
            var albums = new List<Album>
            {
                new Album{Title="The Unforgettable Fire", ArtistID=5, Year=1984 },
                new Album{Title="The Joshua Tree", ArtistID=5, Year=1987},
                new Album{Title="All That You Can't Leave Behind", ArtistID=5, Year=2000},
                new Album{Title="Showbiz",ArtistID=1, Year=1999  },
                new Album{Title="Absolution", ArtistID=1, Year=2003  },
                new Album{Title="Alligator", ArtistID=3, Year=2005},
                new Album{Title="Boxer", ArtistID=3, Year=2007},
                new Album{Title="High Violet", ArtistID=3,Year=2010},
                new Album{Title="Nevermind", ArtistID=2, Year=1991},
            };
            albums.ForEach(s => context.Albums.Add(s));
            context.SaveChanges();
            var songs = new List<Song>
            {
                new Song {Title="Muscle Museum", AlbumID=4},
                new Song {AlbumID=4, Title="Filip"},
                new Song {AlbumID=9, Title="Smells Like Teen Spirit"},
                new Song {AlbumID=7, Title="Fake Empire"},
                new Song {AlbumID=7, Title="Apartment Story"},
                new Song {AlbumID=3, Title="Walk On"},
                new Song {AlbumID=3, Title="Beautiful Day"},
            };
            songs.ForEach(s => context.Songs.Add(s));
            context.SaveChanges();
        }
    }
}