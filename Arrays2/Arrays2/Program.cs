namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //int[] array = {1, 85, 243, 367, 34, 8, 35};

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            ////1


            ////2
            //int[] array = { 1, 85, -243, 367, -34, 8, -35 };
            //int counter = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //    {
            //        counter++;
            //        Console.WriteLine(array[i]);
            //    }
            //}
            //Console.WriteLine(counter);
            ////2


            ////3
            //int[] array = { 1, 85, -243, 367, -34, 8, -35 };
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += i;
            //}
            //int avarage = sum / (array.Length);
            //Console.WriteLine(sum);
            //Console.WriteLine(avarage);
            ////3

            ////4
            //int[] array = { 1, 85, -243, 367, -34, 8, -35 };
            //int minArray = array[0];
            //int maxArray = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (minArray > array[i])
            //    {
            //        minArray = array[i];
            //    }
            //    if (maxArray < array[i])
            //    {
            //        maxArray = array[i];
            //    }
            //}
            //Console.WriteLine(minArray);
            //Console.WriteLine(maxArray);
            //Console.WriteLine(minArray + maxArray);
            ////4


            ////5
            //int[] array = { 1, 85, 36, 43, 34, 8, 35 };
            //int maxDigit = array[0];
            //int secondMaxDigit = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > maxDigit)
            //    {
            //        maxDigit = array[i];
            //    }
            //    if (array[i] > secondMaxDigit && array[i] < maxDigit)
            //    {
            //        secondMaxDigit = array[i];
            //    }
            //}
            ////5
            //Console.WriteLine(maxDigit);
            //Console.WriteLine(secondMaxDigit);

            //6
            Console.WriteLine("10-20 arasi eded daxil edin: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            do
            {

                    Console.WriteLine("davam etmek isteyirsen? yes(Y/y/Yes) ");
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "Y" || userInput2 == "y" || userInput2 == "Yes")
                    {
                        Console.WriteLine("10-20 arasi eded daxil edin: ");
                        int userInput3 = Convert.ToInt32(Console.ReadLine());
                        if (userInput3 % 2 == 0)
                        {
                            Console.WriteLine("cut ededdir");
                        }
                        else
                        {
                            Console.WriteLine("tek ededdir");
                        }
                    }

                
                else
                {
                    Console.WriteLine("sehvdir");
                }
            }
            while (userInput > 10 && userInput < 20);

            //6
        }
    }
}
 