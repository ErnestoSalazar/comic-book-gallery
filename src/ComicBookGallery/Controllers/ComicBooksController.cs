using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    // Controller classes need to be public otherwise MVC won't be able to find them and use them
    public class ComicBooksController: Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            ComicBook[] comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id) // ? means that we can pass a null for the id parameter
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value); // when ussing Nullable we need to ask for parameter Value or cast
            // ViewBag is an object in MVC that allow us to pass data from a controller to a view
            

            return View(comicBook); // we can pass data yo our View method to make it strongly typed
        }
    }
}