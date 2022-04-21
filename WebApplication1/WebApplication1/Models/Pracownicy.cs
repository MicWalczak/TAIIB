using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pracownicy
    {
        [Key, Column("Id_Pracownika")]
        public int IdPracownika { set; get; }
        [Required]
        public string Imie { set; get; }
        [Required]
        public string Nazwisko { set; get; }
        [Required, MinLength(11), MaxLength(11)]
        public long PESEL { get; set; }
        [Column("Nr_telefonu"), MinLength(9), MaxLength(9)]
        public long NrTelefonu { get; set; }
        [ForeignKey(nameof(IdAdres)), Required]
        public int IdAdres { get; set; }
        [Required]
        public string Stanowisko { get; set; }
        public double Pensja { get; set; }
        public List<Adres> Adress { set; get; }
        public List<Zlecenie> Zlecenia { set; get; }
    }
}
