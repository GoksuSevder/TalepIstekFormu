using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.Business.Abstract
{
    public interface IEmployService
    {
        Employ GetById(int id);
        Employ GetOne(Expression<Func<Employ, bool>> filter);
        List<Employ> GetAll(Expression<Func<Employ, bool>> filter = null);

        Employ Create(Employ entity);
        Employ Update(Employ entity);
        void Delete(Employ entity);
        List<EmployList> GetAllEmployList();
    }
}
