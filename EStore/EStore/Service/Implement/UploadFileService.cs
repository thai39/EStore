using EStore.Model;
using EStore.Repository;

namespace EStore.Service.Implement
{
    public class UploadFileService : IUploadFileService
    {
        private readonly IGalleryRepo _galleryRepo;

        public UploadFileService(IGalleryRepo galleryRepo)
        {
            _galleryRepo = galleryRepo;
        }

        public void AddImages(gallery gal)
        {
            _galleryRepo.AddImage(gal);
        }

        public void Upload(IFormFile[] images)
        {
            _galleryRepo.UploadImages(images);
        }
    }
}
