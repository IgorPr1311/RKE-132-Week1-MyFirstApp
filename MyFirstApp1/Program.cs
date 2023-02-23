// See https://aka.ms/new-console-template for more information
//rakendus palub kasutajat sisestada tema nimi
//rakendus tervitab nimepidi



Console.WriteLine("Enter your name");
//string - sõne
string username = Console.ReadLine();
Console.WriteLine("Hello" + ", " + username + "!");

 //string interpolation
Console.WriteLine($"Hello, {username}!");