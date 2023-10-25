namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 1;
            //int num2 = 6;

            //Console.WriteLine("Main: ");
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //SwapNumbers(ref num1, ref num2);
            //Console.WriteLine("Main: ");
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            int[] array = new int[0];
            for (int i = array.Length; ; i++)
            {
                Console.WriteLine("Element daxil etmek isteyirsiz? (Yes, yes, Y, y) (No, no, N, n)");
                string userAnswer = Console.ReadLine();


                if (userAnswer == "Yes" || userAnswer == "yes" || userAnswer == "Y" || userAnswer == "y")
                {
                    Console.WriteLine("Element daxil edin: ");
                    int userNums = Convert.ToInt32(Console.ReadLine());
                    Array.Resize(ref array, array.Length + 1);
                    array[i] = userNums;                    
                }
                else if (userAnswer == "No" || userAnswer == "no" || userAnswer == "N" || userAnswer == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Duzgun cavab daxil edin!");
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ,");
            }
        }

        //static void SwapNumbers(ref int num1,ref int num2)
        //{
        //    num1 = num1 + num2;
        //    num2 = num1 - num2;
        //    num1 = num1 - num2;
        //    Console.WriteLine("SwapNumbers: ");
        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);
        //}
    }
}