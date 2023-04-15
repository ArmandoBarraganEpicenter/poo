using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ComissionEmployee : Employee
    {
        public float CommisionPercentage { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentage;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\tCommision percentage.: {$"{CommisionPercentage:P2}",18}" +
            $"\n\tVentas...............: {$"{Sales:P2}",18}" +
            $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";

        }
    }

}
