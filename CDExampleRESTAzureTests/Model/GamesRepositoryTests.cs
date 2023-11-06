using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDExampleRESTAzure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDExampleRESTAzure.Model.Tests
{
    [TestClass()]
    public class GamesRepositoryTests
    {


        [TestMethod()]
        public void GetAllTest()
        {
            GamesRepository gamesRepository = new GamesRepository();
            IEnumerable<Game> games = gamesRepository.GetAll();
            Assert.AreEqual(2, games.Count());
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            GamesRepository gamesRepository = new GamesRepository();
            Game game = gamesRepository.GetById(1);
            Assert.AreEqual("Chess", game.Name);
        }
    }
}