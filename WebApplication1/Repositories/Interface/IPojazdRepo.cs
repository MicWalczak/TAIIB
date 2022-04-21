using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Repositories.Interface
{
    public interface IPojazdRepo
    {
        void addPojazd(Pojazd pojazd);
        IEnumerable<Pojazd> GetPojazd();
        bool DeletePojazd(int id);
        Pojazd GetPojazd(int id);

    }
}
