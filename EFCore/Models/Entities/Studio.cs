using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore.Models.Entities
{
    internal class Studio
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        //foreign key 
        public int CountryId { get; set; }
        // navigation property countrystan one to many relationship
        public Country Country { get; set; }
        //navigation property studio details one to one relationship
        public StudioDetails StudioDetails { get; set; }
        // one to many collection of movies
        public ICollection<Movie> Movies { get; set; }

    }
}
