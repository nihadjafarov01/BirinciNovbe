namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //int[] numbers = { 1, 32, 3, 94, 75, 6, 79 };

            //for (int i = 0; i < numbers.Length; i++)
            //{   
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            ////1

            ////2
            //int[] numbers = { 1, 32, 3, 94, 75, 6, 79 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            ////2

            ////3
            //int[] numbers = { 1, 32, 3, 94, 75, 6, 79 };
            //int counter = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 5 == 0)
            //    {
            //        counter++;
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine(counter);
            ////3

            ////4
            //int[] numbers = { 1, 32, 3, 94, 75, 6, 79 };
            //int maxNumber = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            ////4


            //5
            int[] numbers = { 1, 32, 3, 94, 75, 6, 79 };
            int maxNumber = numbers[0];
            int indexOfMax = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                    indexOfMax = i;
                }
            }
            Console.WriteLine(indexOfMax);
            //5
        }
    }
}
