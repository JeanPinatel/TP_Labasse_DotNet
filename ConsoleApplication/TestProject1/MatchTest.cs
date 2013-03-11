using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
    {


        /// <summary>
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = 0;
            int awayGoal = 0;
            Match match = new Match(home,away,homeGoal,awayGoal);
            Assert.IsNotNull(match);

        }

        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = 3;
            int awayGoal = 3;
            Match match = new Match(home, away, homeGoal, awayGoal);
            Assert.IsNotNull(away);
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = 3;
            int awayGoal = 3;
            Match match = new Match(home, away, homeGoal, awayGoal);
            Assert.IsNotNull(awayGoal);
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = 3;
            int awayGoal = 3;
            Match match = new Match(home, away, homeGoal, awayGoal);
            Assert.IsNotNull(home);
        }

        /// <summary>
        ///Test pour HomeGoal
        ///</summary>
        [TestMethod()]
        public void HomeGoalTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = 3;
            int awayGoal = 3;
            Match match = new Match(home, away, homeGoal, awayGoal);
            Assert.IsNotNull(homeGoal);
        }
        
        /// <summary>
        ///Test pour IsAwayForfait
        ///</summary>
        [TestMethod()]
        public void IsAwayForfaitTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = 3;
            int awayGoal = -1;
            Match match = new Match(home, away, homeGoal, awayGoal);
            Assert.IsTrue(match.IsAwayForfait);
        }
        
        /// <summary>
        ///Test pour IsDraw
        ///</summary>
        [TestMethod()]
        public void IsDrawTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = 3;
            int awayGoal = 3;
            Match match = new Match(home, away, homeGoal, awayGoal);
            Assert.IsTrue(match.IsDraw);
        }

        /// <summary>
        ///Test pour IsHomeForfait
        ///</summary>
        [TestMethod()]
        public void IsHomeForfaitTest()
        {
            Club home = new Club("France");
            Club away = new Club("Allemagne");
            int homeGoal = -1;
            int awayGoal = 3;
            Match match = new Match(home, away, homeGoal, awayGoal);
            Assert.IsTrue(match.IsHomeForfait);
        }
    }
}
