using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VideoRentalStore.Data;    

namespace VideoRentalStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<VideoContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
