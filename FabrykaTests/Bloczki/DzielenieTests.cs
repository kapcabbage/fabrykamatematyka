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
            _dzialanie.oper = '/';
            _dzielenie = new Dzielenie();
        }

        [TestMethod()]
        public void wykonajUjemnaTest()
        {
            _dzialanie.zm1 = 1;
            _dzialanie.zm2 = -2;
            _dzielenie.wykonaj(_dzialanie);
            Assert.IsNotNull(_dzialanie.wynik);
            Assert.AreEqual(_dzialanie.wynik.Value, -0.5, 0.0001);

        }
        [TestMethod()]
        public void wykonajZwykłyTest()
        {
            _dzialanie.zm1 = 1;
            _dzialanie.zm2 = 4;
            _dzielenie.wykonaj(_dzialanie);
            Assert.IsNotNull(_dzialanie.wynik);
            Assert.AreEqual(_dzialanie.wynik.Value, 1/4, 0.000001);
        }
    }
}