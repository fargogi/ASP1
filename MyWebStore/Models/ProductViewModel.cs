﻿using MyWebStore.DomainEntities.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebStore.Models
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public string Name { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
