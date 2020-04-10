using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Praktyczne_kursy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę kategorii")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkon { get; set; }


        public virtual ICollection<Kurs> Kursy { get; set; }

    }
}