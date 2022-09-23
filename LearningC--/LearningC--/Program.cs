// See https://aka.ms/new-console-template for more information

//string message = "Hello World!!";
//int bigNumber = 1000000000;
//bool veryCool = true;
//decimal pi = 3.14m;
//char letter = 'a';

//Console.WriteLine(message);
//Console.WriteLine(bigNumber);
//Console.WriteLine(veryCool);
//Console.WriteLine(pi);
//Console.WriteLine(letter);

//message = "changed message";
//bigNumber = 944059;
//veryCool = false;
//pi = 3.145m;
//letter = 'b';


//Console.WriteLine(message);
//Console.WriteLine(bigNumber);
//Console.WriteLine(veryCool);
//Console.WriteLine(pi);
//Console.WriteLine(letter);

//const string message2 = "this is a message";
//const int bigNumber2 = 1000;
//const bool veryCool2 = true;
//const decimal eeee = 2.57m;
//const char letter2 = 'c';
//Console.WriteLine(message2);
//Console.WriteLine(bigNumber2);
//Console.WriteLine(veryCool2);
//Console.WriteLine(eeee);
//Console.WriteLine(letter2);

//message2 = "not coool ";
//bigNumber2 = 2012930921;
//veryCool2 = false;

using System.Text;

StringBuilder example = new StringBuilder("Hello World");
string example2 = "Hello World";

for (int i = 0; i < example.Length; i++)
{
    Console.WriteLine(example[i]);
}

for (int i = 0; i < example2.Length; i++)
{
    Console.WriteLine(example2[i]);
}