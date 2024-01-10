﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kutse_App.Models
{
    public class Guest
    {
        [Required(ErrorMessage ="Sisesta nimi siia")]

        public string Name { get; set; }
        [Required(ErrorMessage ="Sisesta posti adress siia")]
        [RegularExpression(@".+\@.+\..+",ErrorMessage ="Vale postkast")]
        public string Email { get; set; }

        [RegularExpression(@"\+37[0-9]{8}", ErrorMessage = "Vale number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Tee oma Valik")]
        public bool? WillAttend { get; set; }

        public string Adress { get; set; } 






    }
}