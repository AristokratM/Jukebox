using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data
{
    public class Song:BaseClass<Song>
    {
        private String _genre;

        public String Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        private String _author;
        public String Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private String _perfomer;
        public String Perfomer
        {
            get { return _perfomer; }
            set { _perfomer = value; }
        }
        private Single _duration;
        public Single Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
    //    private Guid _albumId;

    //    public Album 
        public Song(String genre, String author, String perfomer, Single duration) : base() 
        {
            this.Genre = genre;
            this.Author = author;
            this.Perfomer = perfomer;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Genre, Author, Perfomer, Duration);
        }
    }
}
