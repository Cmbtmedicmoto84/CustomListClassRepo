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
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 5;
            int expected = 4;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

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
            int itemToAdd = 1;
            int expected = 2;
            int actual;

            suitsListQuantity.Add(1);
            suitsListQuantity.Add(2);

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
            int valueToAdd = 100;
            int decreasingValue = -25;
            int expected = 8;

            //act
            suitListValues.Add(valueToAdd);
            suitListValues.Add(decreasingValue);
            suitListValues.Add(valueToAdd);
            suitListValues.Add(decreasingValue);
            suitListValues.Add(8);

            int actual = suitListValues.Capacity;
           
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
            int decreasingValue = -25;
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
            int decreasingValue = -25;
            int expected = 100;

            //act
            suitListValues.Add(originalValue);
            suitListValues.Add(decreasingValue);
            suitListValues.Add(originalValue);
            suitListValues.Add(decreasingValue);
            suitListValues.Add(originalValue);

            int actual = suitListValues[5];

            //(100, -25, 100, -25, 100)
            //assert
            Assert.AreEqual(expected, actual);
        }
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
