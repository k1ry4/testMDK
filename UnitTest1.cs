using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace testec
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void pravilno()
        {
            //Arrange
            string x = "odin123+";
            string y = "odin123+";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void net_cifr()
        {
            //Arrange
            string x = "odin++a";
            string y = "odin++a";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void korotko()
        {
            //Arrange
            string x = "oo";
            string y = "oo";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void tri_v_ryad()
        {
            //Arrange
            string x = "777777";
            string y = "777777";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void ne_vvel_parol()
        {
            //Arrange
            string x = "";
            string y = "";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void net_symbol()
        {
            //Arrange
            string x = "odin123";
            string y = "odin123";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void dlinno()
        {
            //Arrange
            string x = "odin++aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa228";
            string y = "odin++aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa228";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void ne_sovpadenie()
        {
            //Arrange
            string x = "odin++a";
            string y = "odin++aa";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void pravilno2()
        {
            //Arrange
            string x = "avaa228+";
            string y = "avaa228+";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void pravilno3()
        {
            //Arrange
            string x = "aye500*";
            string y = "aye500*";
            string result1 = "Вы победили";
            //Act
            Form1 c = new Form1();
            string result2 = c.Sum_two(x, y);
            //Assert
            Assert.AreEqual(result1, result2);
        }
    }
}
