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
    public class ZleceniaRepo : IZlecenieRepo
    {
        private readonly WypozyczalniaDb wypozyczalniaDb;
        public ZleceniaRepo(WypozyczalniaDb wypozyczalniaDb)
        {
            this.wypozyczalniaDb = wypozyczalniaDb;
        }
        public void addZlecenie(Zlecenie zlecenie)
        {
            wypozyczalniaDb.Zlecenie.Add(zlecenie);
        }

        public bool DeleteZlecenie(int id)
        {
            bool wynik = false;
            Zlecenie toDelete = GetZlecenie(id);
            if (toDelete != null)
            {
                wynik = true;
                wypozyczalniaDb.Zlecenie.Remove(toDelete);
            }
            return wynik;
        }

        public IEnumerable<Zlecenie> GetZlecenie()
        {
            return wypozyczalniaDb.Zlecenie;
        }

        public Zlecenie GetZlecenie(int id)
        {
            return wypozyczalniaDb.Zlecenie.Where(z => z.IdZlecenia == id).FirstOrDefault();
        }
    }
}
