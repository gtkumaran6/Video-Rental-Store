using Microsoft.AspNetCore.Mvc;
using VideoRentalStore.Data;

namespace VideoRentalStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoController : Controller
    {
        private readonly    VideoContext dbContext;  
        public VideoController(VideoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetVideos()
        {
            return Ok(dbContext.Videos.ToList());
        }
    }
}
