using System.ComponentModel.DataAnnotations;

namespace DEVinCar.Api.DTOs
{
     public class CityDTO
    {     
        [Required(ErrorMessage = "The name is required")]
        [MaxLength(255)]  
        public string Name { get; set; }

        
       
    }
}