using System.Collections.Generic;
using System;
namespace ToDoList.Models
{
  public class Item
  {
    private string description;
    private static List<Item> instance = new List<Item>{};

    public Item(string description)
    {
      this.description = description;
      instance.Add(this);
    }

    public static void ClearAll()
    {
      instance.Clear();
    }

    public static  List<Item> GetAllItems()
    {
      return instance;
    }
    public string getDescription()
    {
      return this.description;
    }
    public void setDescription(string new_des)
    {
      this.description = new_des;
    }

    public string PrintDescription()
    {
      string output = "";
      output = "Description: "+this.description;
      return output;
    }

  }
}