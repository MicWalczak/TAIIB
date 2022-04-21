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
    public class PojazdRepo : IPojazdRepo
    {
        private readonly WypozyczalniaDb wypozyczalniaDb;
        public PojazdRepo(WypozyczalniaDb wypozyczalniaDb)
        {
            this.wypozyczalniaDb = wypozyczalniaDb;
        }

        public void addPojazd(Pojazd pojazd)
        {
            wypozyczalniaDb.Pojazd.Add(pojazd);
        }

        public bool DeletePojazd(int id)
        {
            bool wynik = false;
            Pojazd toDelete = GetPojazd(id);
            if (toDelete != null)
            {
                wynik = true;
                wypozyczalniaDb.Pojazd.Remove(toDelete);
            }
            return wynik;
        }

        public IEnumerable<Pojazd> GetPojazd()
        {
            return wypozyczalniaDb.Pojazd;
        }

        public Pojazd GetPojazd(int id)
        {
            return wypozyczalniaDb.Pojazd.Where(z => z.IdPojazdu == id).FirstOrDefault();
        }

    }
}
