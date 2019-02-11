using MyWebStore.DomainEntities.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebStore.DomainEntities.Entities.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
