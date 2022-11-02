//using GamesDatabase.Domain.Entities;
//using GamesDatabase.Domain.Queries;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GamesDatabase.Domain.tests.QueryTests
//{
//    [TestClass]
//    public class GameQueries
//    {
//        private List<Game> _games;
//        public GameQueries()
//        {
//            _games = new List<Game>();
//            _games.Add(new Game("Jogo", "Counter Strike", "FPS", 10.0, 0, 10.0, "foto"));
//            _games.Add(new Game("Jogo", "Outlast 2", "Terror", 20.0, 50, 5.0, "foto"));
//            _games.Add(new Game("Jogo", "Outlast 1", "Terror", 13.0, 0, 13.0, "foto"));
//            _games.Add(new Game("Jogo", "Rockt League", "Corrida", 39.0, 0, 39.0, "foto"));
//        }
//        [TestMethod]
//        public void Dada_A_Consulta_Deve_Retornar_Jogos()
//        {
//            var result = _games.AsQueryable().Where(Queries.GameQueries.GetAll("Jogo"));
//            Assert.AreEqual(4, result.Count());
//        }
//    }
//}
