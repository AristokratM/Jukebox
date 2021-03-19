using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Domain;
using Jukebox.Domain.Abstract;
namespace Jukebox.Abstract
{
    public interface IDataReader
    {
         IFiltrator<Album> GetContainerFilter();

         IFiltrator<Song> GetContainerItemFilter();
    }
}
