// See https://aka.ms/new-console-template for more information
using DataStructures;

Console.WriteLine("Hello, World!");
CustomArray array = new CustomArray(2);
array.Print();
array.Insert(1);
array.Insert(2);
array.Print();
array.Insert(3);
array.Insert(4);
array.Insert(5);
array.Print();
array.RemoveAt(4);
array.Print();
Console.WriteLine(array.indexOf(100));
Console.ReadLine();
