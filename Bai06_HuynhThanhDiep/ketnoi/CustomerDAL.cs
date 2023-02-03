using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketnoi
{
    class CustomerDAL : DBConnection
    {
        public List<CustomerBEL> ReadCustomer()
        {
            return CustomerBEL.Tolist();
        }
        public void DeleteCustomer(CustomerBEL cus)
        {
            this.Customers.Remove(cus);
            this.SaveChanges();
        }
        public void NewCustomer(CustomerBEL cus)
        {
            this.Customers.Add(cus);
            this.SaveChanges();
        }
        public void EditCustomer(CustomerBEL cus)
        {
            this.Entry(cus).State = System.Data.Entity.EntityState.Modified;
            this.SaveChanges();
        }
    }
}
