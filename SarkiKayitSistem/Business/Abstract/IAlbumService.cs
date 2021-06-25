using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAlbumService
    {
        List<Album> GetAll();
        Album Get(int albumId);
        void AddAlbum(Album album);
        void DeleteAlbum(Album album);
        void UpdateAlbum(Album album);
    }
}
