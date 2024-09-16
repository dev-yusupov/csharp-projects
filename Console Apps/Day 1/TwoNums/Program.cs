/*
    Read two integer numbers from the user input and print the smaller one. If they are equal, print a message about that to the console.
*/

Console.WriteLine("Enter the first int");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second int");
double y = double.Parse(Console.ReadLine());

if (x == y)
{
    Console.WriteLine("Numbers are equal!");
}
else
{
    if (x > y)
    {
        Console.WriteLine(x);
    }
    else
    {
        Console.WriteLine(y);
    }
}
 