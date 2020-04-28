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

            testList.Add(1);
            testList.Add(2);
            testList.Remove(2);

            int actual = testList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveItem_SecondaryCountGoesDown()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;


            //Act
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);
            testList.Remove(6);

            int actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveItem_PostSecondary()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1337;
            int valueTwo = 1;
            int valueThree = 22;
            int expected = 8;


            //Act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);

            testList.Remove(valueThree);

            int actual = testList.Count;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_SecondaryCount_ArrayShift()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 6;
            int expected = 3;


            //Act
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);

            testList.Remove(itemToRemove); //mark garbage collect?
            int actual = testList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CountDoesNotChangeAfterRemove()
        {

            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 1;
            int otherItemToRemove = 2;
            int expected = 2;

            
            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Remove(200); //show the count does not go down?
            
            int actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemDoesNotShiftAfterRemove()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Remove(200);

            int actual = testList[]; //not sure on this?????

            //Assert
            Assert.AreEqual(expected, actual);
        }




    }
}
