using System.Collections;

namespace ConsoleApp
{
    public class SwitchLesson
    {
        static void Main(string[] args)
        {
            int i = 0;
            switch (i % 2)
            {
                case 0:
                    System.Console.WriteLine($"{i} is an even number", i);
                    break;
                case 1:
                    System.Console.WriteLine($"{i} is an odd number", i);
                    break;
                default:
                    break;
            
            }
        }
    }
}