using EStore.Data;
using EStore.Model;

namespace EStore.Repository.Implement
{
    public class GalleryRepo : IGalleryRepo
    {
        private readonly DBConnect _dbConnect;

        public GalleryRepo(DBConnect dbConnect)
        {
            _dbConnect = dbConnect;
        }

        public void AddImage(gallery gal)
        {
            if (gal.files.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imgs", gal.files.FileName);
                using (var stream = System.IO.File.Create(path))
                {
                    gal.files.CopyTo(stream);
                }
                gal.images = "/imgs/" + gal.files.FileName;
            }
            _dbConnect.gallery.Add(gal);
            _dbConnect.SaveChanges();
        }

        public void UploadImages(IFormFile[] files)
        {
            string picture = "";
            if (files.Length > 0)
            {
                foreach (var item in files)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imgs", item.FileName);
                    using (var stream = System.IO.File.Create(path))
                    {
                        item.CopyTo(stream);
                    }
                    picture+= "/imgs/" + item.FileName + ";";
                }
            }
            
        }
    }
}
