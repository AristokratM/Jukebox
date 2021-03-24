using Jukebox.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data
{
    public class JukeboxContext : DbContext
    {
        static JukeboxContext()
        {
            Database.SetInitializer<JukeboxContext>(new MyContextInitializer());
        }
        public JukeboxContext() : base("DbConnection")
        {
 
        }
        
        public DbSet<AlbumEntity> ALbums { get; set; }
        public DbSet<SongEntity> Songs { get; set; }
    }


}
