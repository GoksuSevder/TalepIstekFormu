using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.DataAccess.Abstract;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
      private readonly IDepartmentDal _dal;

        public DepartmentManager(IDepartmentDal dal)
        {
            _dal = dal;
        }
        public Department Create(Department entity)
        {
            return _dal.Create(entity);
        }

        public void Delete(Department entity)
        {
            _dal.Delete(entity);
        }

        public List<Department> GetAll(Expression<Func<Department, bool>> filter = null)
        {
            return _dal.GetAll(filter).ToList();
        }

        public Department GetById(int id)
        {
            return _dal.GetById(id);
        }

        public Department GetOne(Expression<Func<Department, bool>> filter)
        {
            return _dal.GetOne(filter);
        }

        public Department Update(Department entity)
        {
            return _dal.Update(entity);
        }
    }
}
