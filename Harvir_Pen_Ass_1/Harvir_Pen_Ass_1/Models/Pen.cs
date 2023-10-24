using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Harvir_Pen_Ass_1.Models
{
    public class Pen
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Color")]
        public string Color { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Brand")]
        public string Brand { get; set; }

    
        [Display(Name = "Length")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Length { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Ink Color")]
        public string InkColor { get; set; }

        [Display(Name = "Is Ballpoint")]
        public bool IsBallpoint { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]

        public decimal Price { get; set; }
       
       
      
        [Required]
        public CustomRatingScale Rating { get; set; }
    }


    public enum CustomRatingScale
    {
        [Display(Name = "Sad")]
        One = 1,

        [Display(Name = "Netural")]
        Two = 2,

        [Display(Name = "Joy")]
        Three = 3,

        [Display(Name = "Happy")]
        Four = 4,

        [Display(Name = "Very Happy")]
        Five = 5
    }
}