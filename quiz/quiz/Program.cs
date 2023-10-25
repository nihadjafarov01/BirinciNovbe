namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //int number = 1234;
            //int reversedNum = 0;
            //bool isPol = false;
            //do
            //{
            //    reversedNum = 10*( number % 10);
            //}
            //while ();
            ////1

            ////1
            //int number = 1221;
            //int temp = number;
            //int reversed = 0;

            //do
            //{
            //    temp = number % 10;
            //    number = number - number % 10;
            //    reversed = (reversed + temp) * 10;
            //}
            //while (temp != 0);
            //Console.WriteLine(reversed);
            ////1


            #region Task2
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int minDigit = 0;
            int maxDigit = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[minDigit])
                {
                    minDigit = i;
                }
                if (array[i] > array[minDigit])
                {
                    maxDigit = i;
                }
                //minDigit = maxDigit;
                //maxDigit = temp;

            }
            array[maxDigit] = array[maxDigit] + array[minDigit];
            array[minDigit] = array[maxDigit] - array[minDigit];
            array[maxDigit] = array[maxDigit] - array[minDigit];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            #endregion

            #region Task3
            //3
            int number = 8443;
            int temp = number%10;
            int lastNum = temp;
            int mertebe = 1000;

            for (int i = 1000; ;i/=10)
            {
                lastNum = temp;
                if (i == 0)
                {
                    break;
                }
                temp = number / i; // 8
                Console.WriteLine(temp);   //8
                if (temp != number / i)
                {
                    lastNum += temp * i;
                    
                }
                number = number - (i * (number / i)); //443

            }
            Console.WriteLine(lastNum);
            #endregion
            
        }
    }
}