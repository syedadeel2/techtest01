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
     * Sample Singleton Implementation not used in the project
     */

    /*    public class SingletonDataContext : DbContext
        {
            public DbSet<Product> Products { get; set; }

            private static SingletonDataContext _instance;

            private SingletonDataContext() : base("name=TechTest01Db")
            {
                // This protects class from instantiation
            }

            public static SingletonDataContext DefaultInstance
            {
                get
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonDataContext();
                    }

                    return _instance;
                }
            }

        }
     */
}
