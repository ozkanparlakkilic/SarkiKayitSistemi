using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Album : IEntity
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string AlbumName { get; set; }
        public string ReleaseYear { get; set; }
        public string Singer { get; set; }
        public string Type { get; set; }
    }
}
