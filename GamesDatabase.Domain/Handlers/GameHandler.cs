using GamesDatabase.Domain.Commands;
using GamesDatabase.Domain.Commands.Contracts;
using GamesDatabase.Domain.Entities;
using GamesDatabase.Domain.Handlers.Contracts;
using GamesDatabase.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Handlers
{
    public class GameHandler : IHandler<CreateGameCommand>
    {
        private readonly IGameRepository _repository;

        public GameHandler(IGameRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateGameCommand command)
        {
            if (!command.Validate())
                return new GenericCommandResult(false, "Ops, algo deu errado", command.Notification);
            
            //Criar jogo
            var game = new Game(command.Type, command.Name, command.Genre, command.InitialPrice, command.Discount_Percentage, command.FinalPrice, command.ScreenshotPath);

            //Salvar no banco
            _repository.Create(game);

            return new GenericCommandResult(true, "Jogo Salvo", game);
        }

        public ICommandResult HandleDelete(Guid id)
        {
            _repository.Delete(id);

            return new GenericCommandResult(true, "Jogo Deletado", id);
        }
    }
}
