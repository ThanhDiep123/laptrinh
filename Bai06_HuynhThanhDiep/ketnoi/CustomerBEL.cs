using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketnoi
{
    class CustomerBEL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AreaName Area { get; set; }

        internal static List<CustomerBEL> Tolist()
        {
            throw new NotImplementedException();
        }

        public string AreaName { get; set; }

        
    }
}
