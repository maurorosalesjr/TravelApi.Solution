using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
    public class Travel
    {
        public int TravelId { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [Required]
        [StringLength(1000)]
        public string Blerb { get; set; }
        [Required]
        [Range(0, 10, ErrorMessage = "We use a one to ten scale in these parts")]
        public int Rating { get; set; }
    }
}