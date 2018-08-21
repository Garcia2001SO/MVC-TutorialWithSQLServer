using Microsoft.EntityFrameworkCore;

namespace myFirstMvc.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }

        public DbSet<myFirstMvc.Models.Movie> Movie { get; set; }
    }
}