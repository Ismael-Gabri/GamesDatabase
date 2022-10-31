using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Entities
{
    public class PriceOverview
    {
        public PriceOverview(double initialPrice, double discount_Percentage, double finalPrice)
        {
            InitialPrice = initialPrice;
            Discount_Percentage = discount_Percentage;
            FinalPrice = finalPrice;
        }
        public double InitialPrice { get; private set; }
        public double Discount_Percentage { get; private set; }
        public double FinalPrice { get; private set; }

        public double Price_View 
        { 
            get { return InitialPrice + Discount_Percentage + FinalPrice; }
            set { }
        }
    }
}
