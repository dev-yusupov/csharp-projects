/*
 Array data structure built-in methods and properties
 */

using System.Collections;
using System.Collections.ObjectModel;

string[] teachers = new string[4];
string[] students = { "Testov", "Testovich", "Testjonov", "Testova" };

// Length property which returns the length of the array
Console.WriteLine($"Length of the array is: {students.Length}");

// IsFixedSize property which checks whether array is fixed size or not

// Both properties return true as their limit of elements are stated once and won't be changed
Console.WriteLine( students.IsFixedSize ); // True
Console.WriteLine( teachers.IsFixedSize ); // True

ArrayList students2 = new ArrayList();

/*
 students2 array is not fixed. As it can change its size dynamically
 ArrayList is imported from Collections namespace of System
 */
Console.WriteLine( students2.IsFixedSize ); // False


/*
 IsReadOnly property to check the array can be updated or not. A read-only array cannot be changed
 */

List<int> numbers = new List<int> { 1, 4, 10, 34 };
ReadOnlyCollection<int> readOnlyNumbers = new ReadOnlyCollection<int>( numbers );

bool isReadOnly = ((IList<int>)readOnlyNumbers).IsReadOnly;

Console.WriteLine($"students2 array read-only status is: {students2.IsReadOnly}");
Console.WriteLine($"readOnlyNumbers array read-only status is: {isReadOnly}");

/*
 Methods of array data type in C#
 */

// Adding elements into an array
int[] evenNumbers = new int[5];

for (int i = 0; i < evenNumbers.Length; i++)
{
    int evenNumber = (i + 1) * 2;

    evenNumbers[i] = evenNumber;
}

Console.WriteLine("Even Numbers");

foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}

// Find and FindAll methods

List<int> list = new List<int> { 1, 6, 10, 12, 5 };

int evenNum = list.Find(num => num % 2 == 0);
List<int> evenNums = list.FindAll(num => num % 2 == 0);

Console.WriteLine("Even number from list using find method");
Console.WriteLine(evenNum);

Console.WriteLine("Even numbers");
foreach (int number in evenNums)
{
    Console.WriteLine(number);
}