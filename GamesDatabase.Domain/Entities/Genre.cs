using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Entities
{
    public class Genre : Entity
    {
        public Genre(string description)
        {
            Description = description;
        }
        public string Description { get; private set; }

        public string DescriptionString
        {
            get { return Description; }
            set { }
        }
    }
}
