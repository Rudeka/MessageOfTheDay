using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MessageOfTheDay.Domain.Abstract;
using MessageOfTheDay.Domain.Concrete;
using Ninject;

namespace MessageOfTheDay.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IMessageRepository>().To<EFMessageRepository>();
            kernel.Bind<ILanguageRepository>().To<EFLanguageRepository>();
            kernel.Bind<IDayRepository>().To<EFDayRepository>();
        }
    }
}