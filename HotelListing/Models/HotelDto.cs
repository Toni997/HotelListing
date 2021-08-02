using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HotelListing.Data;

namespace HotelListing.Models
{
    public class CreateHotelDto
    {
        [Required]
        [MaxLength(150, ErrorMessage = "Hotel name is too long")]
        public string Name { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Hotel address is too long")]
        public string Address { get; set; }
        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }


        [ForeignKey(nameof(Country))]
        public Country Country { get; set; }
    }

    public class HotelDto : CreateHotelDto
    {
        public int Id { get; set; }
        public CountryDto Country { get; set; }
    }
}
