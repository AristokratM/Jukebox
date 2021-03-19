using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Domain.Filters
{
    public class ContainerItemFilter : IFiltrator<Song>
    {
        private string Author { get; set; }
        private string Genre { get; set; }
        private string Performer { get; set; }
        public ContainerItemFilter(string author, string genre, string performer)
        {
            Author = author;
            Genre = genre;
            Performer = performer;
        }
        public bool Filter(Song model)
        {
            return AuthorFilter(model) && GenreFilter(model) && PerformerFilter(model);
        }

        private bool AuthorFilter(Song model)
        {
            return Author.Equals("") || Author.Equals(model.Author);
        }

        private bool GenreFilter(Song model)
        {
            return Genre.Equals("") || Genre.Equals(model.Genre);
        }

        private bool PerformerFilter(Song model)
        {
            return Performer.Equals("") || Performer.Equals(model.Performer);
        }
    }
}
