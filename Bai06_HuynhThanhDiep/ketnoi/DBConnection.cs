using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketnoi
{
    class DBConnection : DbContext
    {
        public DBConnection() : base("name = saleBD")
        {

        }  
        public System.Data.Entity.DbSet<CustomerBEL> Customers { get; set; }
    }
}
