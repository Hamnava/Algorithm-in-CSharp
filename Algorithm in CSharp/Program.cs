﻿// See https://aka.ms/new-console-template for more information
using Algorithm_in_CSharp.Algorithms.String_Algorithms;

Console.WriteLine("Hi form the program!");

#region String Algorithm

String_Algorithms stringAlgo = new String_Algorithms();

var lower = stringAlgo.IsLowerCase("hello");
var upper = stringAlgo.IsUpperCase("HELLO");
Console.WriteLine(lower);
Console.WriteLine(upper);

// for Password complexity validation

var password1 = stringAlgo.IsPasswordComplex("1Aa!");
var password2 = stringAlgo.IsPasswordComplex("Admin");

Console.WriteLine(password1);
Console.WriteLine(password2);

Console.WriteLine(stringAlgo.NormalizeString(" Hey there, BUDDY  "));

// Reverse a string chars
Console.WriteLine(stringAlgo.Reversed("Hamnava"));
Console.WriteLine(stringAlgo.Reversed("olleh"));
Console.WriteLine(stringAlgo.Reversed("tamen"));

Console.WriteLine(stringAlgo.Reverse("Hamnava"));
Console.WriteLine(stringAlgo.Reverse("olleh"));
Console.WriteLine(stringAlgo.Reverse("tamen"));
#endregion

