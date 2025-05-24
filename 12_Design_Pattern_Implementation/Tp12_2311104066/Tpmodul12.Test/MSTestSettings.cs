using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tpmodul12; 

namespace Tpmodul12.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestPangkat_Normal()
        {
            var form = new Form1();
            Assert.AreEqual(8, form.CariNilaiPangkat(2, 3)); 
        }

        [TestMethod]
        public void TestPangkat_NolPangkatNol()
        {
            var form = new Form1();
            Assert.AreEqual(1, form.CariNilaiPangkat(0, 0)); 
        }

        [TestMethod]
        public void TestPangkat_Bernilai0()
        {
            var form = new Form1();
            Assert.AreEqual(1, form.CariNilaiPangkat(5, 0)); 
        }

        [TestMethod]
        public void TestPangkat_BNegatif()
        {
            var form = new Form1();
            Assert.AreEqual(-1, form.CariNilaiPangkat(2, -2)); 
        }

        [TestMethod]
        public void TestPangkat_BTerlaluBesar()
        {
            var form = new Form1();
            Assert.AreEqual(-2, form.CariNilaiPangkat(5, 11)); 
        }

        [TestMethod]
        public void TestPangkat_ATerlaluBesar()
        {
            var form = new Form1();
            Assert.AreEqual(-2, form.CariNilaiPangkat(101, 3)); 
        }

        [TestMethod]
        public void TestPangkat_Overflow()
        {
            var form = new Form1();
            Assert.AreEqual(-3, form.CariNilaiPangkat(9, 30)); 
        }
    }
}
