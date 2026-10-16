using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCarApp.Infrastructure.Data.Domain
{
    public class Order
    {
        public int Id { get; set; }
      
        public int ClientId { get; set; }

        public virtual Client Client { get; set; } = null!;

        public int CarId { get; set; }

        public virtual Car Car { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        



    }
}
