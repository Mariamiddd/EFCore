using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore.Models.Entities
{
    internal class Actor
    {
      public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string firstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string lastName { get; set; }

        public ICollection<Movie> Movies { get; set; }

    }
}
