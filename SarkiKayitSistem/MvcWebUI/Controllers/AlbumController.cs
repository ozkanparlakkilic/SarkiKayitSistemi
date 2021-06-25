using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new AlbumViewModel()
            {
                Albums = _albumService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int albumId)
        {
            Album album = _albumService.Get(albumId);
            _albumService.DeleteAlbum(album);
            if (album != null)
            {
                TempData["message"] = $"{album.SongName} was deleted";
            }
            return RedirectToAction("Index");
        }

        public ViewResult Update(int albumId)
        {
            var model = new AlbumViewModel()
            {
                Album = _albumService.Get(albumId)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Album album)
        {
            _albumService.UpdateAlbum(album);
            if (album != null)
            {
                TempData["message"] = $"{album.SongName} was updated";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Album album)
        {
            _albumService.AddAlbum(album);
            if (album != null)
            {
                TempData["message"] = $"{album.SongName} was added";
            }
            return RedirectToAction("Index");
        }

    }
}
