using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.Business.Abstract
{
    public interface IDepartmentService
    {
        Department GetById(int id);
        Department GetOne(Expression<Func<Department, bool>> filter);
        List<Department> GetAll(Expression<Func<Department, bool>> filter = null);

        Department Create(Department entity);
        Department Update(Department entity);
        void Delete(Department entity);
    }
}
