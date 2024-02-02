// See https://aka.ms/new-console-template for more information
using ConsoleApp9;
using ConsoleApp9.DataBase;
Console.WriteLine("Hello, World!");
using (var dbManager = new DbManager())
{
    dbManager.PopulateTasks();
}