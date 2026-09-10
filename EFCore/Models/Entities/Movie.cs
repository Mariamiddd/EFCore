using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore.Models.Entities
{
    internal class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int StudioId { get; set; }
        public Studio Studio { get; set; }

        public ICollection<Actor> Actors { get; set; }
    }
}
