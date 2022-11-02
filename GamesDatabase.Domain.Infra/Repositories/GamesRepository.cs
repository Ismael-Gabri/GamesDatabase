using GamesDatabase.Domain.Entities;
using GamesDatabase.Domain.Infra.Contexts;
using GamesDatabase.Domain.Queries;
using GamesDatabase.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Infra.Repositories
{
    public class GamesRepository : IGameRepository
    {
        private readonly GamesContext _context;

        public GamesRepository(GamesContext context)
        {
            _context = context;
        }

        public void Create(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var game = _context.Games.FirstOrDefault(x => x.Id == id);
            _context.Games.Remove(game);
            _context.SaveChanges();
        }

        public IEnumerable<Game> GetAll(string type)
        {
            return _context.Games.AsNoTracking().Where(GameQueries.GetAll("Jogo"));
        }
    }
}
