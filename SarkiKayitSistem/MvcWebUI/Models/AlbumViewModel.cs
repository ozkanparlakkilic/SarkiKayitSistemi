using Entities.Concrete;
using System.Collections.Generic;

namespace MvcWebUI.Models
{
    public class AlbumViewModel
    {
        public List<Album> Albums { get; set; }
        public Album Album { get; set; }
    }
}
