using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionAndCastle.Core.Repository.Interfaces;

namespace DependencyInjectionAndCastle.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bootstrapper.Initialize();
            
            var categoryRepository = Bootstrapper.WindsorContainer.Resolve<ICategoryRepository>();

            var categories = categoryRepository.List();

            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }

            Console.ReadKey();
        }
    }
}
