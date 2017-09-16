using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABCRestaurant.Models
{
    public class SurveyResponse
    {
        [Required(ErrorMessage = "name is required..")]
        public string Name { get; set; }
        [Required(ErrorMessage = "valid email is required..")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "invalid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "phone is required..")]
        [RegularExpression(@"^\(\d{3}\) ?\d{3}( |-)?\d{4}|^\d{3}( |-)?\d{3}( |-)?\d{4}", ErrorMessage = "invalid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "please select a radio button for menu prices")]
        public MenuPrices? MPrices { get; set; }
        [Required(ErrorMessage = "please select a favorite menu item")]
        public string FavoriteMenuItem { get; set; }
        public List<string> MenuItemList { get; set; }


    }
}