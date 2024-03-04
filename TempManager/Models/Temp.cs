using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
//Author: Firaol baneta
//Date: 3/3/2024
namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a date.")]
        [Remote("CheckDate", "Validation", ErrorMessage = "Date already exists in the database.")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Please enter a low temperature.")]
        [Range(-200, 200, ErrorMessage = "Low temperature must be between -200 and 200.")]
        public double? Low { get; set; }

        [Required(ErrorMessage = "Please enter a high temperature.")]
        [Range(-200, 200, ErrorMessage = "High temperature must be between -200 and 200.")]
        public double? High { get; set; }
    }
}
