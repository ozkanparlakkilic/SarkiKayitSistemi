using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAlbumDal : IEntityRepository<Album>
    {
        // Listeleme 
        // Ekleme 
        // Silme
        // Güncelleme
    }
}
