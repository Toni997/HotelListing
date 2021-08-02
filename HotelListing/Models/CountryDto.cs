using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateCountryDto
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }
        [Required]
        [MaxLength(2, ErrorMessage = "Short country name is too long")]
        public string ShortName { get; set; }
    }

    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }
        public IList<HotelDto> Hotels { get; set; }

    }
}
