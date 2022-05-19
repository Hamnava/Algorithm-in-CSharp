// See https://aka.ms/new-console-template for more information
using Algorithm_in_CSharp.Algorithms.Array_Algorithms;
using Algorithm_in_CSharp.Algorithms.Linkedlist;
using Algorithm_in_CSharp.Algorithms.String_Algorithms;
using static Algorithm_in_CSharp.Algorithms.Linkedlist.CustomLinkedList;

Console.WriteLine("Hi form the program!");

#region String Algorithm

//String_Algorithms stringAlgo = new String_Algorithms();

//var lower = stringAlgo.IsLowerCase("hello");
//var upper = stringAlgo.IsUpperCase("HELLO");
//Console.WriteLine(lower);
//Console.WriteLine(upper);

//// for Password complexity validation

//var password1 = stringAlgo.IsPasswordComplex("1Aa!");
//var password2 = stringAlgo.IsPasswordComplex("Admin");

//Console.WriteLine(password1);
//Console.WriteLine(password2);

//Console.WriteLine(stringAlgo.NormalizeString(" Hey there, BUDDY  "));

//// Reverse a string chars
//Console.WriteLine(stringAlgo.Reversed("Hamnava"));
//Console.WriteLine(stringAlgo.Reversed("olleh"));
//Console.WriteLine(stringAlgo.Reversed("tamen"));

//Console.WriteLine(stringAlgo.Reverse("Hamnava"));
//Console.WriteLine(stringAlgo.Reverse("olleh"));
//Console.WriteLine(stringAlgo.Reverse("tamen"));

//Console.WriteLine(stringAlgo.ReverseEachWord("Helly my babby, I love you"));
//Console.WriteLine(stringAlgo.ReverseEachWord("Hey Scott, Nice to meet You"));
//Console.WriteLine(stringAlgo.ReverseEachWord("I'm Coming..."));
#endregion


#region Array Algorithms
ArrayAlgorithms arrayAlgorithms = new ArrayAlgorithms();
int[] arr = { 1, -2, 3, -4, 5, -6, 7, 8, 9 };
int[] arr2 = { 1,2, 3, 4,5, 6, 7,8, 9 };

//Console.WriteLine(arrayAlgorithms.LinearSearch(arr, 3));
//Console.WriteLine(arrayAlgorithms.LinearSearch(arr, 0));

//int item = Array.Find(arr, element=> element == 3);
//Console.WriteLine(item);

//int[] items = Array.FindAll(arr, element=> element >=5);
//Array.ForEach(items, item => Console.WriteLine(item));

//Console.WriteLine(arrayAlgorithms.BinarySearch(arr,7));

//Console.WriteLine(Array.BinarySearch(arr, 5));

//int[] evenNummber = arrayAlgorithms.FindEvenNumbers(arr, arr2);
//Array.ForEach(evenNummber, Console.WriteLine);

//Reverse 
//var result = arrayAlgorithms.Reverse(arr);
//Array.ForEach(result, Console.WriteLine);
//arrayAlgorithms.RotateArray(arr2);
//Array.ForEach(arr2,Console.WriteLine);

#endregion


#region LinkedList
LinkedIistPart linked = new LinkedIistPart();
linked.strLinkedList();

CustomLinkedList customLinkedList = new CustomLinkedList();
Node firstNode = new Node(3);
Node secondNode = new Node(4);
Node thirdNode = new Node(5);
Node fourthNode = new Node(6);

customLinkedList.head = firstNode;
firstNode.next = secondNode;
secondNode.next = thirdNode;
thirdNode.next = fourthNode;

customLinkedList.DisplayNods();
//customLinkedList.DeleteBackHalf();
customLinkedList.DeleteKthNodeFromEnd(2);
Console.WriteLine();
customLinkedList.DisplayNods();

#endregion
