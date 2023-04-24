using EStore.Model;

namespace EStore.Repository
{
    public interface IGalleryRepo
    {
        public void UploadImages(IFormFile[] files);
        public void AddImage(gallery gal);
    }
}
