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
            int oneNumber = 22;
            int nextNumber = 2;

            CustomList customList = new CustomList();
            int total = customList.Add(oneNumber, nextNumber);

            Assert.AreEqual(24, total);
        }

        [TestMethod]

        public void AddSuits()
        {
            string modelOfSuit = "MK 1";
            string classOfSuit = "Armor";

            CustomList customList = new CustomList();
            string writeout = customList.Add(modelOfSuit, classOfSuit);

            Assert.AreEqual("MK 1 Armor", writeout);
        }
        

        [TestMethod]

        public void AddValue()
        {
            int originalValue = 100;
            int decreasingValue = -25;

            CustomList customList = new Sandbox.CustomList();
            int currentValue = customList.Add(originalValue, decreasingValue);

            Assert.AreEqual(75, currentValue);
        }
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
            // what happens to the last-added item?
            // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
