using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAndCastle.Core.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        List<string> List();
    }
}
