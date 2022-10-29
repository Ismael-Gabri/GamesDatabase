using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Entities
{
    public class Game : Entity
    {
        public Game(string type, string name, Genre genre, IList<Category> categories, PriceOverview price_Overview, Screenshots screenshots)
        {
            Type = type;
            Name = name;
            Genre = genre;
            Categories = categories;
            Price_Overview = price_Overview;
            Screenshots = screenshots;
        }

        public string Type { get; private set; }
        public string Name { get; private set; }
        public Genre Genre { get; private set; }
        public IList<Category> Categories { get; private set; }
        public PriceOverview Price_Overview { get; private set; }
        public Screenshots Screenshots { get; private set; }
    }
}
