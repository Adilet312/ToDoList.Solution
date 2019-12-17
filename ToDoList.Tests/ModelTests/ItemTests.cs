using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest:IDisposable
  {
    [TestMethod]
public void Dispose()
{
  Item.ClearAll();
}


   
    [TestMethod]
    public void GetAll_ReturnsEmptyList()
    {
        //Arrange
        List<Item> newList = new List<Item>{ };
        //Act
        List<Item> result = Item.GetAllItems();

        CollectionAssert.AreEqual(result,newList);

    }

     [TestMethod]
    public void ItemConstructor_CreateInstanceOfItem()
    {
        Item  items = new Item("A");
        Assert.AreEqual(typeof(Item),items.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
        string description = "Walk the dog.";
        Item items = new Item(description);
        string getResult = items.getDescription();
        Assert.AreEqual(description,getResult);
    }
    [TestMethod]
    public void SetDEscription_SetDEscription_String()
    {
        //Arrange
        string description = "Walk the dog.";
        Item items = new Item(description);
        //Act
        string updatedDescription = "Do the dishes.";
        items.setDescription(updatedDescription);
        //Assert 
        Assert.AreNotEqual("Do",items.getDescription());

    }

    [TestMethod]

    public void Get_All_ReturnsItems()
    {
      string desc1 = "Walk the dog.";
      string desc2 = "Wash the dishes.";
      Item item1 = new Item(desc1);
      Item item2 = new Item(desc2);
      List<Item> list2 = new List<Item>{item1,item2};
      List<Item> original = Item.GetAllItems();
      CollectionAssert.AreEqual(original,list2);


    }

  }
}