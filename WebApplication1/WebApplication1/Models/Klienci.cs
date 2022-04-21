using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Klienci
    { 
   [Key, Column("Id_Klienta")]
    public int IdKlineta { set; get; }
    [Required]
    public string Imie { set; get; }
    [Required]
    public string Nazwisko { set; get; }
    [Required, Column("Nr_dowodu")]
    public string NrDowodu { get; set; }
    [Required, Column("Nr_telefonu"), MinLength(9), MaxLength(9)]
    public long NrTelefonu { get; set; }
    [ForeignKey(nameof(IdAdres)), Column("Data_waż_prawa_jazdy")]
    public int IdAdres { get; set; }
    public DateTime DataWażnościUprawnień { get; set; }
    [Column("Czy_wynajmuje")]
    public bool CzyWynajmuje { get; set; }

    public List<Adres> Adress { set; get; }
    public List<Zlecenie> Zlecenia { set; get; }
}
}
