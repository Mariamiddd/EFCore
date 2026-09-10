using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore.Models.Entities
{
    internal class StudioDetails
    {
        public int Id { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        public int StudioId { get; set; }

        public Studio Studio { get; set; }
    }
}
