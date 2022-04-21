using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repos
{
    public class AdresRepo : IAdresRepo
    {
        private readonly WypozyczalniaDb wypozyczalniaDb;
        public AdresRepo(WypozyczalniaDb wypozyczalniaDb)
        {
            this.wypozyczalniaDb = wypozyczalniaDb;
        }
        public void addAdres(Adres adres)
        {
            wypozyczalniaDb.Adres.Add(adres);
        }

        public bool DeleteAdres(int id)
        {
            bool wynik = false;
            Adres toDelete = GetAdres(id);
            if (toDelete != null)
            {
                wynik = true;
                wypozyczalniaDb.Adres.Remove(toDelete);
            }
            return wynik;
        }

        public IEnumerable<Adres> GetAdres()
        {
            return wypozyczalniaDb.Adres;
        }

        public Adres GetAdres(int id)
        {
            return wypozyczalniaDb.Adres.Where(z => z.IdAdres == id).FirstOrDefault();
        }
    }
}
