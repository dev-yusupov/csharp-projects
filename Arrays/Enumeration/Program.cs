/*
namespace Enumeration
{
    public enum DaysOfWeek
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }

    public enum TaskStatus
    {
        Pending,
        Completed,
    }

    public class Task
    {
        public string Description { get; set; }
        public TaskStatus Status { get; set; }

        public Task(string description)
        {
            Description = description;
            Status = TaskStatus.Pending;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Monday;

            Console.Write(today);
        }
    }
}
*/


namespace Enumeration
{
    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine()!;

            TrafficLight currentLight;

            if (!Enum.TryParse(userInput, true, out currentLight))
            {
                throw new ArgumentException("Invalid traffic light color!");
            }

            switch (currentLight)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Stop");
                    break;

                case TrafficLight.Yellow:
                    Console.WriteLine("Caution, prepare to stop!");
                    break;

                case TrafficLight.Green:
                    Console.WriteLine("Go!!!");
                    break;
            }
        }
    }
}