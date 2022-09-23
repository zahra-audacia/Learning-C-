// See https://aka.ms/new-console-template for more information
using Models;

User  me = new ("Zahra", "Khan", new DateTime(2000, 12, 18, 1, 1, second: 1), "brown", "zahra@gmail.com", 173);

//Console.WriteLine("First Name: " + me.FirstName);
Console.WriteLine(me.ReturnString(me));