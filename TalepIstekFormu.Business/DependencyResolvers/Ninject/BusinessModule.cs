using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.Business.Concrete;
using TalepIstekFormu.DataAccess.Abstract;
using TalepIstekFormu.DataAccess.Concrete.EF;
using AppContext = TalepIstekFormu.DataAccess.Concrete.EF.AppContext;

namespace TalepIstekFormu.Business.DependencyResolvers.Ninject
{
    public class BusinessModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IFormService>().To<FormManager>().InSingletonScope();
            Bind<IFormDal>().To<FormDal>().InSingletonScope();
          
            Bind<IDepartmentService>().To<DepartmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<DepartmentDal>().InSingletonScope();
          
            Bind<ICompanyService>().To<CompanyManager>().InSingletonScope();
            Bind<ICompanyDal>().To<CompanyDal>().InSingletonScope();
            
            Bind<IEmployService>().To<EmployManager>().InSingletonScope();
            Bind<IEmployDal>().To<EmployDal>().InSingletonScope();

            Bind<DbContext>().To<AppContext>();
        }
    }
}
