using GamesDatabase.Domain.Commands;
using GamesDatabase.Domain.Entities;
using GamesDatabase.Domain.Handlers;
using GamesDatabase.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GamesDatabase.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/games")]
    public class GameController : ControllerBase
    {
        [HttpGet("")]
        public IEnumerable<Game> GetAllGames([FromServices] IGameRepository repository)
        {
            return repository.GetAll("Jogo");
        }

        [HttpPost("")]
        public GenericCommandResult Create([FromBody] CreateGameCommand command, [FromServices] GameHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
