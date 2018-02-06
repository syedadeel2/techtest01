using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;
using TechTest01.Shared.Exceptions;

namespace TechTest01.Services.Catalog
{
    public class ProductService : IProductService
    {

        private IRepository<Product> _productRepository = null;

        #region Ctor

        /// <summary>
        /// Required Product Service
        /// </summary>
        /// <param name="productService"></param>
        public ProductService(IRepository<Product> productRepository)
        {
            this._productRepository = productRepository;
        }
        #endregion

        #region Methods
        public Product GetById(int id)
        {

            Product product = this._productRepository.GetEntityById(id);

            if (product == null) throw new RecordNotFoundException("The product you are looking for was not found in the database.");

            return product;

        }

        public Product GetBySlug(string slug)
        {
            Product product = this._productRepository.GetEntityByProperty("Slug", slug);

            if (product == null) throw new RecordNotFoundException("The product you are looking for was not found in the database.");

            return product;
        }

        public ICollection<Product> GetProducts()
        {
            var products = this._productRepository.GetEntities();

            return products;
        }

        #endregion
    }
}
