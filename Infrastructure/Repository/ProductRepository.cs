using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProduct
    {
    }
}
