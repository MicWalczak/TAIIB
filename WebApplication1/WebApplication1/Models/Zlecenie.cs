using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Zlecenie
    {
        [Key, Required, Column("Id_zlecenia")]
        public int IdZlecenia { get; set; }
        [ForeignKey(nameof(IdKlienata)), Required, Column("Id_kilenta")]
        public int IdKlienata { get; set; }
        public Klienci kliencil { get; set; }

        [ForeignKey(nameof(IdPracownika)), Required, Column("Id_pracownika")]
        public int IdPracownika { get; set; }
        public Pracownicy pracownicy;
        [ForeignKey(nameof(Id_pojazdu)), Required, Column("Id_pojazdu")]
        public int Id_pojazdu { get; set; }
        [Required, Column("Data_od")]
        public DateTime Data_od { get; set; }
        [Required, Column("Data_do")]
        public DateTime Data_do { get; set; }
        [Required, Column("Ubezpieczenie")]
        public bool Ubezpieczenie { get; set; }




    }
}
