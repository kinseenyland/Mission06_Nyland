using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Nyland.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter a title")]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2024, ErrorMessage = "Year must be between 1888 and 2024")]
        public int Year { get; set; } = 0;

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter if the movie is edited or not")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter if the movie is copied to Plex or not")]
        public bool CopiedToPlex { get; set; }

        public string? Notes { get; set; }
    }
}
