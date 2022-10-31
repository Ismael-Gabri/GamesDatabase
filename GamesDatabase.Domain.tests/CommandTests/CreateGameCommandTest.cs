using GamesDatabase.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.tests.CommandTests
{
    [TestClass]
    public class CreateGameCommandTest
    {
        private static readonly List<string> _invalidList = new List<string>();
        private static readonly List<string> _validList = new List<string>();
        private readonly CreateGameCommand _invalid_command = new CreateGameCommand("BO", "IO", "", "", 0, 0, 0, _invalidList);
        private readonly CreateGameCommand _valid_command = new CreateGameCommand("TipoValido", "NomeValido", "GeneroValido", "DescriscaoValida", 0, 0, 0, _validList);

        [TestMethod]
        public void Deve_Retornar_5_Quando_Passado_Comando_Invalido()
        {
            _invalid_command.Validate();
            Assert.AreEqual(5, _invalid_command.Notification.Count);
        }

        [TestMethod]
        public void Deve_Retornar_0_Quando_Passado_Comando_Valido()
        {
            _validList.Add(new string("http/csimg.com"));
            _valid_command.Validate();
            Assert.AreEqual(0, _valid_command.Notification.Count);
        }
    }
}
