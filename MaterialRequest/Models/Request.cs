using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaterialRequest.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Part Number")]
        [MaxLength(20)]
        public string PartNumber { get; set; }

        [MaxLength(15)]
        public string Location { get; set; }

        [Required]
        [DisplayName("Time Needed")]
        public DateTime TimeNeeded { get; set; }
        
        [Required]
        [DisplayName("Requested By")]
        [MaxLength(25)]
        public string RequestedBy { get; set; }

        [DisplayName("Requested At")]
        public DateTime RequestedAt { get; set; }

        public bool Completed { get; set; }
        [DisplayName("Completed At")]
        public DateTime CompletedAt { get; set; }

        [NotMapped]
        public TimeSpan TimeDifference 
        {
            get 
            {
                return CompletedAt.Subtract(RequestedAt);
            } 
        }

    }
}
