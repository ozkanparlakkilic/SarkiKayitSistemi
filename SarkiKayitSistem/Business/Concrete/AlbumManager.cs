using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AlbumManager : IAlbumService
    {
        private IAlbumDal _albumDal;

        public AlbumManager(IAlbumDal AlbumDal)
        {
            _albumDal = AlbumDal;
        }

        public List<Album> GetAll()
        {
            return _albumDal.GetList();
        }

        public Album Get(int albumId)
        {
            return _albumDal.Get(a => a.Id == albumId);
        }

        public void AddAlbum(Album album)
        {
            _albumDal.Add(album);
        }
        public void DeleteAlbum(Album album)
        {
            _albumDal.Delete(album);
        }

        public void UpdateAlbum(Album album)
        {
            _albumDal.Update(album);
        }
    }
}
