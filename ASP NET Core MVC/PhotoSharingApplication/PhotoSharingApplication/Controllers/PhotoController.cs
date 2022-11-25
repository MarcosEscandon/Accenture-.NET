using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using PhotoSharingApplication.Models;
using PhotoSharingApplication.Data;

namespace PhotoSharingApplication.Controllers
{
    public class PhotoController : Controller
    {
        private PhotoDBContext context = new PhotoDBContext();

        // GET: Photo
        public ActionResult Index()
        {
            return View("Index",context.Photos.ToList());
        }

        public ActionResult Display(int id)
        {
            Photo photo = context.Photos.Find(id);

            if (photo == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Display", photo);
            }   
        }

        // GET: Photo/Create
        public ActionResult Create()
        {
            Photo newPhoto = new Photo();
            newPhoto.CreatedDate = DateTime.Today;

            return View("Create", newPhoto);
        }

        // POST: Photo/Create
        [HttpPost]
        public ActionResult Create(Photo photo, HttpPostedFileBase image)
        {
            photo.CreatedDate = DateTime.Today;
            if (!ModelState.IsValid)
            {
                return View("Create", photo);
            }
            else
            {
                if (image != null)
                {
                    photo.ImageMimeType =
                    image.ContentType;
                    photo.PhotoFile = new
                    byte[image.ContentLength];
                    image.InputStream.Read(
                    photo.PhotoFile, 0,
                    image.ContentLength);
                }
            }
            context.Photos.Add(photo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE: Photo/Delete
        public ActionResult Delete(int id)
        {
            Photo photo = context.Photos.Find(id);

            if (photo == null)
            {
                return HttpNotFound();
            }
            return View("Delete", photo);
        }

        // DELETE: Photo/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Photo photo = context.Photos.Find(id);
            context.Photos.Remove(photo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Photo/GetImage
        public FileContentResult GetImage(int id)
        {
            Photo photo = context.Photos.Find(id);

            if (photo != null)
            {
                return File(photo.PhotoFile, photo.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
    }
}