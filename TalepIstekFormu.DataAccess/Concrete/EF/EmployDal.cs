using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.DataAccess.Abstract;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.DataAccess.Concrete.EF
{
    public class EmployDal : GenericRepository<Employ, AppContext>, IEmployDal
    {
    }
}
