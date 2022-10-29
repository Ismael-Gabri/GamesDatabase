using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Entities
{
    public class PriceOverview
    {
        public PriceOverview(decimal initialPrice, double discount_Percentage, decimal finalPrice)
        {
            InitialPrice = initialPrice;
            Discount_Percentage = discount_Percentage;
            FinalPrice = finalPrice;
        }
        public decimal InitialPrice { get; private set; }
        public double Discount_Percentage { get; private set; }
        public decimal FinalPrice { get; private set; }
    }
}
