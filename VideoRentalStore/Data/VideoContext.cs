using Microsoft.EntityFrameworkCore;
using VideoRentalStore.Models;

namespace VideoRentalStore.Data
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> options) : base(options) { } 
        public VideoContext() { }
        public DbSet<Video> Videos { get; set; }

    }
}
