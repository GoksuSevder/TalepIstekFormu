using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.Business.Concrete;
using TalepIstekFormu.DataAccess.Abstract;
using TalepIstekFormu.DataAccess.Concrete.EF;

namespace TalepIstekFormu.WebUI.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
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

        }
    }
}