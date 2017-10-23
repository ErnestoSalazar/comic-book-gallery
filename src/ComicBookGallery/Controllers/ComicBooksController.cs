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

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The amazing Spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist(){ Name="Dan Slott", Role = "Script"},
                    new Artist(){ Name="Humberto Ramos", Role = "Pencils"},
                    new Artist(){ Name="Victor Olazaba", Role = "Inks"},
                    new Artist(){ Name="Edgar Delgado", Role = "Colors"},
                    new Artist(){ Name="Chris Eliopoulos", Role = "Letters"}
                }
            };
            // ViewBag is an object in MVC that allow us to pass data from a controller to a view
            

            return View(comicBook); // we can pass data yo our View method to make it strongly typed
        }
    }
}