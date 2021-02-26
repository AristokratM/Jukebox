using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain;
using Jukebox.Entities;
using Jukebox.Models;
namespace Jukebox.Mappers
{
    public static class AlbumMapper
    {
        public static AlbumEntity ToEntity(this Album album)
        {
            return new AlbumEntity { Name = album.Name, ReleaseDate = album.ReleaseDate, ItemPlayPrice = album.ItemPlayPrice, Id = album.Id, CreatedDate = DateTime.Now };
        }
        public static Album ToDomain(this AlbumModel albumModel)
        {
            return new Album { ItemPlayPrice = albumModel.ItemPlayPrice, Name = albumModel.Name, ReleaseDate = albumModel.ReleaseDate, Id = albumModel.Id };
        }
        public static AlbumModel ToModel(this Album album)
        {
            return new AlbumModel { ReleaseDate = album.ReleaseDate, ItemPlayPrice = album.ItemPlayPrice, Name = album.Name, Id = album.Id };
        }
        public static Album ToDomain(this AlbumEntity albumEntity)
        {
            return new Album { Name = albumEntity.Name, ReleaseDate = albumEntity.ReleaseDate, ItemPlayPrice = albumEntity.ItemPlayPrice, Id = albumEntity.Id };
        }
    }
}
