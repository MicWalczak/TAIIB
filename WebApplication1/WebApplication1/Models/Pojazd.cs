using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{ 
        public enum Rodzaj_paliwa
        {
            ON = 0,
            PB95 = 1,
            PB98 = 2,
            PB_LPG = 3,
            electricity = 4
        }
        public class Pojazd
        {
            [Key, Required, Column("Id_pojazdu")]
            public int IdPojazdu { get; set; }
            [Required, MaxLength(100), Column("Marka")]
            public string Marka { get; set; }
            [Required, MaxLength(100), Column("Model")]
            public string Model { get; set; }
            [Required, Column("Rodzaj_paliwa")]
            public Rodzaj_paliwa Paliwo { get; set; }
            [Required, Column("Czy_dostępne")]
            public bool Czy_dostepne { get; set; }
            [Required, Column("Stan_techniczny")]
            public bool Stan_techniczny { get; set; }
            [Required, Column("Cena")]
            public double Cena { get; set; }
            [Required, Column("Pracownik")]
            public int FKPracownik { get; set; }
            public Pracownicy pracownicy;
            [Required, MinLength(5), MaxLength(100), Column("Rejestracja")]
            public string Rejestracja { get; set; }
            [Required, Column("Ważność_ubezpie")]
            public bool Waznosc_ubezpie { get; set; }

        
        }
    }
