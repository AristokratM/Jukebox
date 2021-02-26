using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Domain.Filters
{
    public class ContainerItemFilter : IFiltrator<IContainerItem>
    {
        private String Author { get; set; }
        private String Genre { get; set; }
        private String Performer { get; set; }
        public ContainerItemFilter(String author, String genre, String performer)
        {
            Author = author;
            Genre = genre;
            Performer = performer;
        }
        public Boolean Filter(IContainerItem model)
        {
            return AuthorFilter(model) && GenreFilter(model) && PerformerFilter(model);
        }

        private Boolean AuthorFilter(IContainerItem model)
        {
            return Author.Equals("") || Author.Equals(model.Author);
        }

        private Boolean GenreFilter(IContainerItem model)
        {
            return Genre.Equals("") || Genre.Equals(model.Genre);
        }

        private Boolean PerformerFilter(IContainerItem model)
        {
            return Performer.Equals("") || Performer.Equals(model.Performer);
        }
    }
}
