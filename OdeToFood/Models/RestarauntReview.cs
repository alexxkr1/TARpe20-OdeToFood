using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class RestarauntReview
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string City { get; set; }
        [Required, StringLength(255)]
        public string Country { get; set; }
        [Required, StringLength(255)]
        public int Rating { get; set; }
    }
}