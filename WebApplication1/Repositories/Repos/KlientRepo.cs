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
    public class KlientRepo : IKlienciRepo
    {
        private readonly WypozyczalniaDb wypozyczalniaDb;
        public KlientRepo(WypozyczalniaDb wypozyczalniaDb)
        {
            this.wypozyczalniaDb = wypozyczalniaDb;
        }

        public void addKlient(Klienci klienci)
        {
            wypozyczalniaDb.Klienci.Add(klienci);
        }


        public bool DeleteKlient(int id)
        {
            bool wynik = false;
            Klienci toDelete = GetKlient(id);
            if (toDelete != null)
            {
                wynik = true;
                wypozyczalniaDb.Klienci.Remove(toDelete);
            }
            return wynik;
        }

        public IEnumerable<Klienci> GetKlient()
        {
            return wypozyczalniaDb.Klienci;
        }

        public Klienci GetKlient(int id)
        {
            return wypozyczalniaDb.Klienci.Where(z => z.IdKlineta == id).FirstOrDefault();
        }

    }
}
