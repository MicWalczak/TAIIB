using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;
using WebApplication1.Models;

namespace Repositories.Repos
{
    public class PracownicyRepo : IPracownicyRepo
    {
        private readonly WypozyczalniaDb wypozyczalniaDb;
        public PracownicyRepo(WypozyczalniaDb wypozyczalniaDb)
        {
            this.wypozyczalniaDb = wypozyczalniaDb;
        }
        public void addPracownicy(Pracownicy pracownicy)
        {
            wypozyczalniaDb.Pracownicy.Add(pracownicy);
        }

        public bool DeletePracownicy(int id)
        {
            bool wynik = false;
            Pracownicy toDelete = GetPracownicy(id);
            if (toDelete != null)
            {
                wynik = true;
                wypozyczalniaDb.Pracownicy.Remove(toDelete);
            }
            return wynik;
        }

        public IEnumerable<Pracownicy> GetPracownicy()
        {
            return wypozyczalniaDb.Pracownicy;
        }

        public Pracownicy GetPracownicy(int id)
        {
            return wypozyczalniaDb.Pracownicy.Where(z => z.IdPracownika == id).FirstOrDefault();
        }

    }
}
