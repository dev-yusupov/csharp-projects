/*
 Array data structure built-in methods and properties
 */

using System.Collections;

string[] teachers = new string[4];
string[] students = { "Testov", "Testovich", "Testjonov", "Testova" };

// Length property which returns the length of the array
Console.WriteLine($"Length of the array is: {students.Length}");

// IsFixedSize property which checks whether array is fixed size or not

// Both properties return true as their limit of elements are stated once and won't be changed
Console.WriteLine( students.IsFixedSize ); // True
Console.WriteLine( teachers.IsFixedSize ); // True

ArrayList students2 = new ArrayList();

Console.WriteLine( students2.IsFixedSize );