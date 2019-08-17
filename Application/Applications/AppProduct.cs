using Application.Interface;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Applications
{
    public class AppProduct : IApplicationProduct
    {
        private readonly IProduct _product;
        public AppProduct(IProduct product)
        {
            _product = product;
        }

        public void Add(Product entity)
        {
            _product.Add(entity);
        }

        public IList<Product> GetEntities()
        {
            return _product.GetEntities();
        }

        public Product GetEntityById(int id)
        {
            return _product.GetEntityById(id);
        }

        public void Remove(Product entity)
        {
            _product.Remove(entity);
        }

        public void Update(Product entity)
        {
            _product.Update(entity);
        }
    }
}
