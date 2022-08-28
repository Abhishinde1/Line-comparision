namespace Line_Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparison Program");
            Console.WriteLine("console option \n 1. Enter the Points ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UC1LineComparison.GetDistance();
                    break;
            }
        }
    }
}