using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCarApp.Infrastructure.Data.Domain
{
    public class Client
    {
        public int Id { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]

        public string Address { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; } = null!;
    }
}
