using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebStore.DomainEntities.Entities;

namespace MyWebStore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Brand> GetBrands();
        IEnumerable<Section> GetSections();

    }
}
