using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    class RemoveTests
    {
        [TestMethod]
        public void RemoveItem_CountGoesDown()
        {

            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;

            //Act

            testList.Add(5);
            testList.Add(10);
            testList.Remove(5);

            int actual = testList.Count;
            //Assert
            Assert.AreEqual(expected, actual);


        }




    }
}
