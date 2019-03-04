using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAndCarSTR.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "bisey yaz lan")]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "bisey yaz lan")]
        [StringLength(200)]
        [MinLength(3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "bisey yaz lan")]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }

        [StringLength(50)]
        [MinLength(3)]
        [Required(ErrorMessage = "bisey yaz lan")]
        public string Author { get; set; }

        [Required(ErrorMessage = "bisey yaz lan")]
        public int Year { get; set; }

        [Required]
        public DateTime Create { get; set; }

        public DateTime? Update { get; set; }
    }
}
