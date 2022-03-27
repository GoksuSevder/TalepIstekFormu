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
    public class CompanyManager : ICompanyService
    {
      private readonly ICompanyDal _dal;

        public CompanyManager(ICompanyDal dal)
        {
            _dal = dal;
        }
        public Company Create(Company entity)
        {
            return _dal.Create(entity);
        }

        public void Delete(Company entity)
        {
            _dal.Delete(entity);
        }

        public List<Company> GetAll(Expression<Func<Company, bool>> filter = null)
        {
            return _dal.GetAll(filter).ToList();
        }

        public Company GetById(int id)
        {
            return _dal.GetById(id);
        }

        public Company GetOne(Expression<Func<Company, bool>> filter)
        {
            return _dal.GetOne(filter);
        }

        public Company Update(Company entity)
        {
            return _dal.Update(entity);
        }
    }
}
