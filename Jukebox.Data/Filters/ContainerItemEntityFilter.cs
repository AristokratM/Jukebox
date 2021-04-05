using Jukebox.Data.Filters.Abstract;
using Jukebox.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data.Filters
{
     public class ContainerItemEntityFilter : IEntityFiltrator<SongEntity>
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Performer { get; set; }
        public ContainerItemEntityFilter(string author, string genre, string performer)
        {
            Author = author;
            Genre = genre;
            Performer = performer;
        }
        public bool Filter(SongEntity model)
        {
            return AuthorFilter(model) && GenreFilter(model) && PerformerFilter(model);
        }

        private bool AuthorFilter(SongEntity model)
        {
            return Author.Equals("") || Author.Equals(model.Author);
        }

        private bool GenreFilter(SongEntity model)
        {
            return Genre.Equals("") || Genre.Equals(model.Genre);
        }

        private bool PerformerFilter(SongEntity model)
        {
            return Performer.Equals("") || Performer.Equals(model.Performer);
        }
    }
}
