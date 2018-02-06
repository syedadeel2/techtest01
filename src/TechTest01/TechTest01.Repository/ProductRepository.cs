using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository.Contexts;

namespace TechTest01.Repository
{
    public class ProductRepository : IRepository<Product>
    {

        private ProductsContext productsContext;

        #region Ctro
        public ProductRepository()
        {
            this.productsContext = new ProductsContext();
        }

        #endregion

        #region methods

        public ICollection<Product> GetEntities()
        {
            var products = this.productsContext.Products.ToList();
            return products;
        }

        public Product GetEntityById(int id)
        {
            var product = this.productsContext.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public Product GetEntityByProperty(string propertyName, string propertyValue)
        {

            // lets do reflection way

            // build the lambda expression 
            ParameterExpression parameter = Expression.Parameter(typeof(Product), "x");
            Expression property = Expression.Property(parameter, propertyName);
            Expression target = Expression.Constant(propertyValue);
            MethodInfo equalsMethod = typeof(string).GetMethod("Equals", new[] { typeof(string) });
            Expression equalsMethodCall = Expression.Call(property, equalsMethod, target);
            Expression<Func<Product, bool>> lambda = Expression.Lambda<Func<Product, bool>>(equalsMethodCall, parameter);

            var product = this.productsContext.Products.FirstOrDefault(lambda);
            return product;
        }

        public Product GetEntityBySlug(string slug)
        {
            var product = this.productsContext.Products.FirstOrDefault(x => x.Slug.Equals(slug));
            return product;
        }

        #endregion
    }
}
