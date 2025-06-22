using kolokwiumPoprawkowe.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwiumPoprawkowe.Data
{
    public class DatabaseContext : DbContext
    {
       
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Exhibition_Artwork> Exhibition_Artworks { get; set; }

        public DbSet<Gallery> Galleries { get; set; }



        protected DatabaseContext() { }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(new List<Artist>()
        {
         new Artist() { ArtistId = 1, FristName = " Pawel" , LastName = "Nazwisko", BirthDate = DateTime.Parse("2025-06-22")}
      
         });

            modelBuilder.Entity<Artwork>().HasData(new List<Artwork>()
        {
         new Artwork() { ArtworkId = 1, ArtistId = 1, Titile = "Tytul", YearCreated = 5}

         });

            modelBuilder.Entity<Gallery>().HasData(new List<Gallery>()
        {
         new Gallery() { GalleryId = 1, Name = "Nazwa", EstablishedDate = DateTime.Parse("2024-01-01")}

         });

            modelBuilder.Entity<Exhibition>().HasData(new List<Exhibition>()
        {
         new Exhibition() { ExhibitionId = 1, GalleryId = 1, Title = "Tytul", StartDate = DateTime.Parse("2025-06-10"), EndDate = DateTime.Parse("2025-06-22"), NumberOfArtworks = 50}

         });


            modelBuilder.Entity<Exhibition_Artwork>().HasData(new List<Exhibition_Artwork>()
        {
         new Exhibition_Artwork() { ExhibitionId = 1, ArtworkId = 1, InsuranceValue = 20 }
         });




        }



    }
}
