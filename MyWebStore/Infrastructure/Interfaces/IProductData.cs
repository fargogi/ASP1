using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebStore.DomainEntities.Entities;

namespace MyWebStore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        /// <summary>Бренды</summary>
        /// <returns>Возвращает бренды</returns>
        IEnumerable<Brand> GetBrands();

        /// <summary>Секции</summary>
        /// <returns>Возвращает секции</returns>
        IEnumerable<Section> GetSections();

        /// <summary>Товары</summary>
        /// <param name="filter">Фильтрация товаров</param>
        /// <returns>Возвращает список товаров</returns>
        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}
