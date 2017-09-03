using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkinsHive.Models
{
    public class NumberOfStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
            return (movie.Stock > 0) ? ValidationResult.Success : new ValidationResult("Stock must be greater then 0.");
            if (movie.Stock == 0)
            {
                return new ValidationResult("Stock must be greater then 0.");
            }
            else
            {
                return ValidationResult.Success;
            }            
        }
    }
}