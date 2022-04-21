using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Repositories.Interface
{
    public interface IAdresRepo
    {
        void addAdres(Adres adres);
        IEnumerable<Adres> GetAdres(string kraj);
        bool DeleteAdres(int id);
        IEnumerable<Adres> GetKlientAdres(int idKlient);
        bool AddAdresToKlient(int idKlient, int idAdres);
        void addAdres(IEnumerable<Adres> adres);
        IEnumerable<Adres> GetAdres();
    }
}
