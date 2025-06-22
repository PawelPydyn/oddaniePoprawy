using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwiumPoprawkowe.Models
{
    [Table("Artwork")]
    public class Artwork
    {
        [Key]
        public int ArtworkId { get; set; }

        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }

        [MaxLength(100)]
        public string Titile { get; set; } = null!;

        public int YearCreated { get; set; }

        public Artist Artist { get; set; } = null!;

        public ICollection<Exhibition_Artwork> ExhibitionsArtwork { get; set; } = null!;
    }

}
