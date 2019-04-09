using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20,MinimumLength =3)]
        public string Titre { get; set; }
        [Display(Name ="Date de production")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Prix { get; set; }
    }
}