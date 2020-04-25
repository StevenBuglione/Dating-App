using System;
using System.ComponentModel.DataAnnotations;

namespace Dating_App_Backend.Dtos
{
    public class UserForRegister
    {
        //Api validation
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage ="You must specify password between 4 and 8 characters")]
        public string Password { get; set; }

    }
}
