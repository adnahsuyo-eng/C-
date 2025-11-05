namespace ConsoleApp1;
public class JaggedArrayLesson
{
    static void Main(string[] args)
    {
        int[][] jagged =
        {
            new int[]{4,5},
            new int[]{6,7,8},
            new int[]{9,10,11,12},
            new int[]{13,14,15,16,17},
        };
        System.Console.WriteLine(jagged[3][2]);
    }
}