namespace kolokwiumPoprawkowe.DTOs
{
    public class GalleryInfoDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime EstablishedDate { get; set; }


        public List<ExhibitionInfoDTO> ExhibitionsDTO { get; set; } = null!;

        public ArtWorkDTO ArtWorkDTOs { get; set; } = null!;

    }
    public class ExhibitionInfoDTO
    {
        public string Title { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NumberOfArtworks { get; set; }

       

    }

    public class ArtWorkDTO()
    {
        public String Title { get; set; } = null!;
        public int YearCreated { get; set; }


    }
}
