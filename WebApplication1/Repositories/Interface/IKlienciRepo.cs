using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Repositories.Interface
{
    public interface IKlienciRepo
    {
        void addKlient(Klienci klienci);
        IEnumerable<Klienci> GetKlient();
        bool DeleteKlient(int id);
        Klienci GetKlient(int id);
    }
}
