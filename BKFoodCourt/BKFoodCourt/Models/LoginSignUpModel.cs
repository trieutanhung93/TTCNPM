using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BKFoodCourt.Models
{
    public class LoginSignUpModel
    {
        [Required]

        public string Email { set; get; }

        public string PassWord { set; get; }

        public string Name { set; get; }

        public static bool State { set; get; }

        public static int typeAccount { set; get; }
    }
}