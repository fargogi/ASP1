using MyWebStore.Data;
using MyWebStore.DomainEntities.Entities;
using MyWebStore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebStore.Infrastructure.Implementations
{
    class InMemoryProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        public IEnumerable<Section> GetSections() => TestData.Sections;
    }
}
