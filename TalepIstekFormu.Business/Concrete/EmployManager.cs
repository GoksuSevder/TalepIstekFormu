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
    public class EmployManager : IEmployService
    {
        private readonly IEmployDal _dal;
        private readonly ICompanyDal _companydal;
        private readonly IDepartmentDal _departmentdal;

        public EmployManager(
             IEmployDal dal,
             ICompanyDal companydal,
             IDepartmentDal departmentdal
           )
        {
            _dal = dal;
            _companydal = companydal;
            _departmentdal = departmentdal;
        }
        public Employ Create(Employ entity)
        {
            return _dal.Create(entity);
        }

        public void Delete(Employ entity)
        {
            _dal.Delete(entity);
        }

        public List<Employ> GetAll(Expression<Func<Employ, bool>> filter = null)
        {
            return _dal.GetAll(filter).ToList();
        }

        public List<EmployList> GetAllEmployList()
        {
            var query = (from employ in _dal.GetAll().ToList()
                         join department in _departmentdal.GetAll().ToList()
                         on employ.DepartmentId equals department.DepartmentId
                         join company in _companydal.GetAll().ToList()
                         on employ.CompanyId equals company.CompanyId
                         where employ.IsDeleted == false
                         select new
                         {
                             EmployName = employ.EmployName,
                             EmployId = employ.EmployId,
                             EmploySurname = employ.EmploySurname,
                             CompanyName = company.CompanyName,
                             DepartmentName = department.DepartmentName
                         }).ToList();
            List<EmployList> employList = new List<EmployList>();
            foreach (var item in query)
            {
                EmployList employs = new EmployList();
                employs.EmployId = item.EmployId;
                employs.EmployName = item.EmployName;
                employs.EmploySurname = item.EmploySurname;
                employs.CompanyName = item.CompanyName;
                employs.DepartmentName = item.DepartmentName;
                employList.Add(employs);
            }
            return employList;
        }

        public Employ GetById(int id)
        {
            return _dal.GetById(id);
        }

        public Employ GetOne(Expression<Func<Employ, bool>> filter)
        {
            return _dal.GetOne(filter);
        }

        public Employ Update(Employ entity)
        {
            return _dal.Update(entity);
        }
    }
}
