using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    [TestClass()]
    public class ClubTest
    {

        [TestMethod()]
        public void ClubConstructorTest()
        {
            String name = "OM";
            Club clubname = new Club(name);
            Assert.IsNotNull(clubname);
        }
        /*
        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            string name = string.Empty; // TODO: initialisez à une valeur appropriée
            Club target = new Club(name); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }*/
    }
}
