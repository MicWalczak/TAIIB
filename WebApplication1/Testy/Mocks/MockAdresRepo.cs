using Moq;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Testy.Mocks
{
    public class MockAdresRepo: Mock<IAdresRepo>
    {
        public MockAdresRepo mockGetAdres(IEnumerable<Adres> adres)
        {
            Setup(x => x.GetAdres(It.IsAny<>()));
        }

    }
}
