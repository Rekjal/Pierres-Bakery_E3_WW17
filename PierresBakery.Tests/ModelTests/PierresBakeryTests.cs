using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FindReplace.Models;
using System;

namespace FindReplace.Tests
{
    [TestClass]
    public class FindReplaceTests : IDisposable
    {

        public void Dispose()
        {
            // Item.ClearAll();
        }

        [TestMethod]
        public void FindRConstructor_CreateInstanceOfFindR_FindR()
        {
            FindR newObject = new FindR();
            Assert.AreEqual(typeof(FindR), newObject.GetType());
        }

        [TestMethod]
        public void ConvertSentence_FindAndReplace_String()
        {
            string source = "she sells sea shells on the seashore";
            string expected = "she sells OCEAN shells on the OCEANshore";  //she sells sea shells on the seashore
            FindR newObject = new FindR();
            string replacement = newObject.ConvertSentence(source, "sea", "OCEAN");
            Assert.AreEqual(expected, replacement);
        }

        // [TestMethod]
        // public void GetScore_AddsValuesForEachLetter_Int()
        // {

        //     Assert.AreEqual(typeof(PrimeNum), newItem.GetType());
        // }

        // // [TestMethod]
        // // public void GenNumerals_GeneratedADictionaryWithKVPair_Dictionary()
        // // {
        // //     //Arrange
        // //     // GenNumber(userenterednumber)
        // //     int userEnteredNum = 100;
        // //     PrimeNum primeObject = new PrimeNum();

        // //     //Act
        // //     Dictionary<int, string> allNumbers = new Dictionary<int, string>() { };
        // //     for (int i = 2; i <= userEnteredNum; i++)
        // //     {
        // //         allNumbers[i] = "unProcessed";
        // //     }
        // //     Dictionary<int, string> result = primeObject.GenNumber(userEnteredNum);

        // //     //Assert
        // //     CollectionAssert.AreEqual(allNumbers, result);
        // // }

        // // [TestMethod]
        // // public void SetDescription_SetDescription_String()
        // // {
        // //     //Arrange
        // //     string description = "Walk the dog2.";
        // //     Item newItem = new Item(description);

        // //     //Act
        // //     string updatedDescription = "Do the dishes";
        // //     newItem.Description = updatedDescription;
        // //     string result = newItem.Description;

        // //     //Assert
        // //     Assert.AreEqual(updatedDescription, result);
        // // }

        // // [TestMethod]
        // // public void GetAll_ReturnsEmptyList_ItemList()
        // // {
        // //     // Arrange
        // //     List<Item> newList = new List<Item> { };

        // //     // Act
        // //     List<Item> result = Item.GetAll();

        // //     foreach (Item thisItem in result)
        // //     {
        // //         Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
        // //     }
        // //     // Assert
        // //     CollectionAssert.AreEqual(newList, result);
        // // }

        // // [TestMethod]
        // // public void GetAll_ReturnsItems_ItemList()
        // // {
        // //     //Arrange
        // //     string description01 = "Walk the dog3";
        // //     string description02 = "Wash the dishes";
        // //     Item newItem1 = new Item(description01);
        // //     Item newItem2 = new Item(description02);
        // //     List<Item> newList = new List<Item> { newItem1, newItem2 };

        // //     //Act
        // //     List<Item> result = Item.GetAll();

        // //     foreach (Item thisItem in result)
        // //     {
        // //         Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
        // //     }

        // //     //Assert
        // //     CollectionAssert.AreEqual(newList, result);
        // // }
    }
}