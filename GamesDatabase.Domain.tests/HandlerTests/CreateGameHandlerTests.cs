using GamesDatabase.Domain.Commands;
using GamesDatabase.Domain.Handlers;
using GamesDatabase.Domain.tests.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.tests.HandlerTests
{
    [TestClass]
    public class CreateGameHandlerTests
    {
        //Refatorar Testes de unidade
        [TestMethod]
        public void Dado_Um_Comando_Invalido_Deve_Adicionar_Uma_Notificação()
        {
            List<string> list = new List<string>();
            var command = new CreateGameCommand("BO", "IO", "", "", 0, 0, 0, list);
            var handler = new GameHandler(new FakeGamesRepository());
            var result = (GenericCommandResult)handler.Handle(command);

            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        public void Dado_Um_Comando_Valido_Deve_Executar_A_Tarefa()
        {
            List<string> list = new List<string>();
            list.Add(new string("http/csimg.com"));
            var command = new CreateGameCommand("TipoValido", "NomeValido", "GeneroValido", "DescriscaoValida", 0, 0, 0, list);
            var handler = new GameHandler(new FakeGamesRepository());
            var result = (GenericCommandResult)handler.Handle(command);

            Assert.AreEqual(result.Success, true);
        }
    }
}
