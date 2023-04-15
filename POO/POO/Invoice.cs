using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetVaueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id}- {Description}" +
                $"\n\tQuantity ..........: {$"{Quantity:N2}",18}" +
                $"\n\tPrice .............: {$"{Price:N2}",18}" +
                $"\n\tValue .............: {$"{GetVaueToPay():C2}",18}";
        }

    }
}
