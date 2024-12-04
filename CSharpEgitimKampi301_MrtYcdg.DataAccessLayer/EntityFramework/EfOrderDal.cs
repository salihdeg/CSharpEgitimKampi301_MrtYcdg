using CSharpEgitimKampi301_MrtYcdg.DataAccessLayer.Abstract;
using CSharpEgitimKampi301_MrtYcdg.DataAccessLayer.Repositories;
using CSharpEgitimKampi301_MrtYcdg.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_MrtYcdg.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
    }
}
