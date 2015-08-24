using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using DependencyInjectionAndCastle.Core.Container.Installers;

namespace DependencyInjectionAndCastle.Core
{
    public static class Bootstrapper
    {
        public static IWindsorContainer WindsorContainer { get; private set; }

        public static IWindsorContainer Initialize()
        {
            WindsorContainer =new WindsorContainer();

            WindsorContainer.Install(new RepositoryInstaller());
            
            return WindsorContainer;
        }
    }
}
