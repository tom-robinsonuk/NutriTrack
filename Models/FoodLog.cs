using System;
using System.ComponentModel.DataAnnotations;

namespace NutriTrack.Models
{
    public class FoodLog
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public string Liquids { get; set; }
        public int ExerciseCount { get; set; }
        public string Location { get; set; } // Home / Hotel etc.
    }
}