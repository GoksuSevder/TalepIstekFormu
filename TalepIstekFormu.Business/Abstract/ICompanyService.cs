using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.Business.Abstract
{
    public interface ICompanyService
    {
        Company GetById(int id);
        Company GetOne(Expression<Func<Company, bool>> filter);
        List<Company> GetAll(Expression<Func<Company, bool>> filter = null);

        Company Create(Company entity);
        Company Update(Company entity);
        void Delete(Company entity);
    }
}
