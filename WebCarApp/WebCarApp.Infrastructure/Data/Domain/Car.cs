using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCarApp.Infrastructure.Data.Domain
{
    public class Car
    {
        public int Id { get; set; }
        [Required]

        public string Model { get; set; }
        [Required]

        public string Picture { get; set; }
        [Required]

        public decimal Price { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; } = null!;


    }
}
