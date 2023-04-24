using EStore.Model;

namespace EStore.Service
{
    public interface IUploadFileService
    {
        public void Upload(IFormFile[] images);
        public void AddImages(gallery gal);
    }
}
