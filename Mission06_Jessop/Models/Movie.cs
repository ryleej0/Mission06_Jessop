using System.ComponentModel.DataAnnotations;

namespace Mission06_Jessop.Models
{
    /// <summary>
    /// Represents a movie in Joel Hilton's collection.
    /// Required fields per Mission 7: Title, Year, Edited, CopiedToPlex.
    /// Year must be 1888 or later (year of first movie).
    /// </summary>
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        public string? Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 (first movie) and 2100")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        /// <summary>Whether the movie has been edited for content.</summary>
        public bool Edited { get; set; }

        /// <summary>Whether the movie has been copied to Plex. Required per Mission 7.</summary>
        public bool CopiedToPlex { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}