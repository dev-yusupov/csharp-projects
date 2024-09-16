/*

*/

namespace Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            int result = length * width;

            Console.WriteLine(result);
        }
    }
}
 