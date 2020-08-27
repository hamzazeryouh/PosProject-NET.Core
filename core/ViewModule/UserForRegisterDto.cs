using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace core.ViewModule
{
    public class UserForRegisterDto
    {

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(22, MinimumLength = 6, ErrorMessage = "You must specify passord betwen 6 and 22 characters")]
        public string Password { get; set; }
    }
}
