using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionAndCastle.Core.Repository.Interfaces;

namespace DependencyInjectionAndCastle.Core.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<string> List()
        {
            return new List<string>() { "Beverages", "Condiments", "Daily Products", "Confections" };
        }
    }
}
