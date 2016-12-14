using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Music.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Music.DAL
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("MusicContext")
        {
            Database.SetInitializer<MusicContext>(new MusicInitializer());
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}