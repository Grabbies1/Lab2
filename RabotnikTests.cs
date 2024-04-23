using L.R_N4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LR4_Tests
{
    [TestClass]
    public class RabotnikTests
    {
        [TestMethod]
        public void Stazh2016_6returned()
        {
            int x = 2016;
            int expected = 6;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2017_5returned()
        {
            int x = 2017;
            int expected = 5;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2012_10returned()
        {
            int x = 2012;
            int expected = 10;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2000_22returned()
        {
            int x = 2000;
            int expected = 22;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2022_0returned()
        {
            int x = 2022;
            int expected = 0;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2021_1returned()
        {
            int x = 2021;
            int expected = 1;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2006_16returned()
        {
            int x = 2006;
            int expected = 16;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh1998_24returned()
        {
            int x = 1998;
            int expected = 24;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2002_20returned()
        {
            int x = 2002;
            int expected = 20;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Stazh2018_4returned()
        {
            int x = 2018;
            int expected = 4;

            Rabotnik c = new Rabotnik();
            c.setGod(x);
            int actual = 0;
            actual = c.stazh(actual);

            Assert.AreEqual(expected, actual);
        }
    }
}
