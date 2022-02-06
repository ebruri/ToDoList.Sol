using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? [Add/View]");
      string answer = Console.ReadLine();
      if (answer == "Add" || answer == "add")
      {
        Console.WriteLine("Add your item");
        string item = Console.ReadLine();
        Item newItem = new Item(item);
        Main();
      }
      else if (answer == "View" || answer == "view")
      {
        foreach (Item task in Item.GetAll())
        {
        Console.WriteLine(task.Description);
        }
        Main();
      }
      else
      {
        Console.WriteLine("PLEASE READ: Would you like to add an item to your list or view your list? [Add/View]");
      }
    }
  }
}