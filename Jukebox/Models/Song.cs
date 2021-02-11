using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Interfaces;
namespace Jukebox.Models
{
    public class Song:BaseClass<Song>, IContainerItem
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
        private String _performer;
        public String Performer
        {
            get { return _performer; }
            set { _performer = value; }
        }
        private Single _duration;
        public Single Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        private Guid _containerId;

        public Guid ContainerId 
        { 
                get { return _containerId; }
                set { _containerId = value; }
        }

        public Song(IContainer container, String name, String genre, String author, String perfomer, Single duration) : base(name)
        {
            this.Genre = genre;
            this.Author = author;
            this.Performer = perfomer;
            this.Duration = duration;
            this.ContainerId = container.Id;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}",Name, Genre, Author, Performer, Duration);
        }
    }
}
