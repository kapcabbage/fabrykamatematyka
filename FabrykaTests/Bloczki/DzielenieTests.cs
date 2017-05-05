using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fabryka.Bloczki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka.Bloczki.Tests
{
    [TestClass()]
    public class DzielenieTests
    {
        private Dzielenie _dzielenie;
        private Dzialanie _dzialanie;

        [TestInitialize]
        public void init()
        {
            _dzialanie = new Dzialanie();
            _dzialanie.oper = '"';
            _dzielenie = new Dzielenie();
        }

        [TestMethod()]
        public void wykonajUjemnaTest()
        {
            _dzialanie.zm1 = 1;
            _dzialanie.zm2 = -2;
            _dzielenie.wykonaj(_dzialanie);
            Assert.AreEqual(_dzialanie.wynik, -0.5);

        }
        [TestMethod()]
        public void wykonajZwykłyTest()
        {
            _dzialanie.zm1 = 1;
            _dzialanie.zm2 = 3;
            _dzielenie.wykonaj(_dzialanie);
            Assert.AreEqual(_dzialanie.wynik, 1/3);
        }
    }
}