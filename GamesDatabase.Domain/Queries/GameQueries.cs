using GamesDatabase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Queries
{
    public static class GameQueries
    {
        public static Expression<Func<Game, bool>> GetAll(string type)
        {
            return x => x.Type == type;
        }
    }
}
