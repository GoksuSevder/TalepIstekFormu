using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.Business.Abstract
{
    public interface IFormService
    {
        Form GetById(int id);
        Form GetOne(Expression<Func<Form, bool>> filter);
        List<Form> GetAll(Expression<Func<Form, bool>> filter = null);
        Form Create(Form entity);
        Form Update(Form entity);
        void Delete(Form entity);

        List<FormList> GetAllFormListIncludingEmploy();
        FormList GetByIdFormListIncludingEmploy(int id);
    }
}
