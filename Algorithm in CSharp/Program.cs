// See https://aka.ms/new-console-template for more information
using Algorithm_in_CSharp.Algorithms.String_Algorithms;

Console.WriteLine("Hi form the program!");

String_Algorithms stringAlgo = new String_Algorithms();

var lower = stringAlgo.IsLowerCase("hello");
var upper = stringAlgo.IsUpperCase("HELLO");
Console.WriteLine(lower);
Console.WriteLine(upper);
