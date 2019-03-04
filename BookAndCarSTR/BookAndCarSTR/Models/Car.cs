using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace BookAndCarSTR.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="bisey yaz lan")]
        [StringLength(50)]
        [MinLength(3)]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "bisey yaz lan")]
        [StringLength(50)]
        [MinLength(3)]
        public string ModelName { get; set; }


        [Required(ErrorMessage = "bisey yaz lan")]
        [StringLength(200)]
        [MinLength(3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "bisey yaz lan")]
        public int MileAge { get; set; }

        [Required(ErrorMessage = "bisey yaz lan")]
        [StringLength(50)]
        [MinLength(3)]
        public string MotorType { get; set; }

        [Required(ErrorMessage = "bisey yaz lan")]
        public decimal Price { get; set; }

        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }  // upload qalsin dediz :/

        [StringLength(500)]
        public string Image { get; set; }

        [Required]
        public DateTime Create { get; set; }


        public DateTime? Update { get; set; }
    }
}
