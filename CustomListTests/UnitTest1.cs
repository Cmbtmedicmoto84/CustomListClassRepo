using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange // // 
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddNumbers()
        {
            CustomList<int> suitsListQuantity = new CustomList<int>();
            int oneNumber = 1;
            int expected= 1;
            int actual;

            suitsListQuantity.Add(oneNumber);

            actual = suitsListQuantity.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddStrings_SecondThingAdded_IsAtFirstIndex()
        {
            CustomList<string> suitListNames = new CustomList<string>();
            string modelOfSuit = "MK 1";
            string classOfSuit = "Armor";
            string expected = "Armor";

            //act
            suitListNames.Add(modelOfSuit);
            suitListNames.Add(classOfSuit);
            string actual = suitListNames[1];
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        

        [TestMethod] //needs work to double array index
        public void AddValues_PastCapacity_CapacityWillDouble()
        {
            //arrange
            CustomList<int> suitListValues = new CustomList<int>();
            int originalValue = 4;
            int doubleCapacity = 8;
            int expected = 5;
            

            //act
            suitListValues.Add(originalValue);
            suitListValues.Add(doubleCapacity);
            suitListValues.Add(originalValue);
            suitListValues.Add(doubleCapacity);
            suitListValues.Add(5);
            suitListValues.Add(doubleCapacity);

            int actual = suitListValues[4]; //changed from .count to [4]
           
            //(100, -25, 100, -25, 100)
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddValues_PastCapacity_NewItemInRightPlace()
        {
            //arrange
            CustomList<int> suitListValues = new CustomList<int>();
            int originalValue = 100;
            int decreasingValue = 25;
            int expected = 500;

            //act
            suitListValues.Add(originalValue);
            suitListValues.Add(decreasingValue);
            suitListValues.Add(originalValue);
            suitListValues.Add(decreasingValue);
            suitListValues.Add(500);


            int actual = suitListValues[4];

            //(100, -25, 100, -25, 100)
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddValues_PastCapacity_OldItemInRightPlace()
        {
            //arrange
            CustomList<int> suitListValues = new CustomList<int>();
            int originalValue = 100;
            int someValue = 200;
            int expected = 200;

            //act
            suitListValues.Add(someValue);
            suitListValues.Add(originalValue);
            suitListValues.Add(originalValue);
            suitListValues.Add(originalValue);
            suitListValues.Add(originalValue);

            int actual = suitListValues[0];

            //(100, -25, 100, -25, 100)
            //assert
            Assert.AreEqual(expected, actual);
        }
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
            int valuePrimary = 2;
            int valueSecondary = 4;
            int valueThird = 6;
            int valueFourth = 8;
            int expected = 6;


            //Act
            testList.Add(valuePrimary);
            testList.Add(valueSecondary);
            testList.Add(valueThird);
            testList.Add(valueFourth);
            testList.Add(6);
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
            testList.Add(8);

            testList.Remove(8);

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
            int expected = 8;


            //Act
            testList.Add(itemToRemove);
            testList.Add(itemToRemove);
            testList.Add(8);
            testList.Add(itemToRemove);

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
            int valueOne = 1;
            int valueTwo = 2;
            int expected = 2;


            //Act
            testList.Add(valueOne);
            testList.Add(valueTwo);
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
            int valueFirst = 5;
            int valueSecond = 7;
            int expected = 7;

            //Act
            testList.Add(valueFirst);
            testList.Add(valueSecond);
            testList.Remove(valueFirst);


            int actual = testList[1]; //not sure on this?????

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
