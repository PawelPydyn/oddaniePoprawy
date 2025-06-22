using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwiumPoprawkowe.Models
{
    [Table("ExhibitionArtWork")]
    [PrimaryKey(nameof(ExhibitionId),nameof(ArtworkId))]
    public class Exhibition_Artwork
    {

        [ForeignKey(nameof(Exhibition))]
        public int ExhibitionId { get; set; }

        [ForeignKey(nameof(Artwork))]
        public int ArtworkId { get; set; }


        [Column(TypeName ="decimal")]
        [Precision(10,2)]
        public double InsuranceValue { get; set; }


        public Exhibition Exhibition { get; set; } = null!;
        public Artwork Artwork { get; set; } = null!;

    }
}
