using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3_ab.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Podaj imie") ]
        public string Name { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko") ]
        public string Surename { get; set; }

        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required (ErrorMessage = "Podaj poprawny email" )]
        public string Email { get; set; }


        [MinLength(length: 5, ErrorMessage = "Temat musi mieć co najmniej 3 znaki")]
        [Required(ErrorMessage = "Podaj temat")]
        public string Subject { get; set; }


        [MinLength(length: 5, ErrorMessage = "Twoja wiadomość musi mieć co najmniej 5 znaków")]
        [Required (ErrorMessage = "Podaj wiadomosc" )]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } // do sparsowania pewnie?

        //priority?

        }
}

