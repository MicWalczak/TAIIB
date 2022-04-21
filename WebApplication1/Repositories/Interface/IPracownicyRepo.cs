using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Repositories.Interface
{
    public interface IPracownicyRepo
    {
        void addPracownicy(Pracownicy pracownicy);
        IEnumerable<Pracownicy> GetPracownicy();
        bool DeletePracownicy(int id);
        Pracownicy GetPracownicy(int id);
    }
}
