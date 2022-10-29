using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Entities
{
    public class Category : Entity
    {
        public Category(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }
}
