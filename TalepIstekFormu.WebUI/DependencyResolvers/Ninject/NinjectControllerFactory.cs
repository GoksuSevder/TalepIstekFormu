using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TalepIstekFormu.WebUI.DependencyResolvers.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel(new BusinessModule());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}