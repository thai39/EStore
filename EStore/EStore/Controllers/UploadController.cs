using EStore.Model;
using EStore.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EStore.Controllers
{
    [Authorize]
    [Route("api/upload")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IUploadFileService _uploadFileService;

        public UploadController(IUploadFileService uploadFileService)
        {
            _uploadFileService = uploadFileService;
        }
        [HttpPost]
        public void Upload(IFormFile[] files)
        {
            _uploadFileService.Upload(files);
        }
        [HttpPost("add")]
        public void AddImages([FromForm] gallery gal)
        {
            _uploadFileService.AddImages(gal);
        }



    }
}
