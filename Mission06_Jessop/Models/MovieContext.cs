using Microsoft.EntityFrameworkCore;

namespace Mission06_Jessop.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    CopiedToPlex = true,
                    LentTo = null,
                    Notes = null
                },
                new Movie
                {
                    MovieId = 2,
                    Category = "Comedy",
                    Title = "Napoleon Dynamite",
                    Year = 2004,
                    Director = "Jared Hess",
                    Rating = "PG",
                    Edited = false,
                    CopiedToPlex = false,
                    LentTo = null,
                    Notes = "Vote for Pedro!"
                },
                new Movie
                {
                    MovieId = 3,
                    Category = "Drama",
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Director = "Frank Darabont",
                    Rating = "R",
                    Edited = false,
                    CopiedToPlex = true,
                    LentTo = null,
                    Notes = null
                }
            );
        }
    }
}
