using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product : EntityBase
    {
        public decimal Price { get; set; }
    }
}
