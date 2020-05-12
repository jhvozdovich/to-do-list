using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
  
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      // Act
      string result = newItem.Description;
      // Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      // Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      // Act
      string updatedDescription = "Do the dishes.";
      newItem.Description = updatedDescription;
      string result = newItem.Description;
      // Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };
      // Act
      List<Item> result = Item.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      // Arrange
      string description1 = "Walk the dog";
      string description2 = "Wash the dishes";
      Item dog = new Item(description1);
      Item dishes = new Item (description2);
      List<Item> newList = new List<Item> { dog, dishes };
      // Act
      List<Item> result = Item.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}