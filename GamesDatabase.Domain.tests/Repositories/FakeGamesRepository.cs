using GamesDatabase.Domain.Entities;
using GamesDatabase.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.tests.Repositories
{
    public class FakeGamesRepository : IGameRepository
    {
        public void Create(Game game)
        {
            
        }

        public void Delete(Game game)
        {
            
        }

        public IEnumerable<Game> GetAll(string type)
        {
            throw new NotImplementedException();
        }
    }
}
