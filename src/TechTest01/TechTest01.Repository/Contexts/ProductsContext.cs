using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository.Contexts
{
    /* 
     * Using Singleton is not a good practice for data context we may run into numerous issues, 
     * including memory, concurrency and transaction problems.
       
     * See SingletonDataContext.cs file for a sample Singleton Implementation
    */

    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
