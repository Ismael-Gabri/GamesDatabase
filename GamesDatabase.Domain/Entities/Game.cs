using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Entities
{
    public class Game : Entity
    {
        public Game(string type,
            string name,
            string genre,
            decimal initialPrice,
            decimal discount_Percentage,
            decimal finalPrice, 
            string screenshotPath)
        {
            Type = type;
            Name = name;
            Genre = genre;
            InitialPrice = initialPrice;
            Discount_Percentage = discount_Percentage;
            FinalPrice = finalPrice;
            ScreenshotPath = screenshotPath;
        }

        public string Type { get; private set; }
        public string Name { get; private set; }
        public string Genre { get; private set; }
        public decimal InitialPrice { get; private set; }
        public decimal Discount_Percentage { get; private set; }
        public decimal FinalPrice { get; private set; }
        public string ScreenshotPath { get; set; }
    }
}
