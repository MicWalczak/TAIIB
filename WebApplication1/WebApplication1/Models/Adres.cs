using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Adres
    {
        [Key, Column("Id_Adres")]
        public int IdAdres { set; get; }
        [Required]
        public string Kraj { set; get; }
        [Required]
        public string Miasto { set; get; }
        [Required, Column("Kod_pocztowy"), MinLength(6), MaxLength(6)]
        public string KodPocztowy { set; get; }
        [Required]
        public string Ulica { set; get; }
        [Required, Column("Nr_budynku")]
        public string NrBudynku { set; get; }
        [Column("Nr_mieszkania")]
        public string NrMieszkania { set; get; }
        public Klienci kliencil { get; set; }
        public Pracownicy pracownicy { get; set; }
    }
}
}
