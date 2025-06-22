using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwiumPoprawkowe.Models
{
    [Table("Gallery")]
    public class Gallery
    {
        [Key]
        public int GalleryId { get; set; }

        [MaxLength(50)]
        public String Name { get; set; } = null!;

        public DateTime EstablishedDate { get; set; }

        public ICollection<Exhibition> Exhibition { get; set; } = null!;

    }
}
