namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] firstArray = { 1, 7, 16, 5, 9 };
            //int[] newArray = new int[firstArray.Length];

            //for (int i = firstArray.Length - 1; i >= 0; i--)
            //{
            //    newArray[firstArray.Length - 1 - i] = firstArray[i];
            //}

            //for (int i = 0; i< newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i]);
            //}

            //string word = "Hello";
            //char letter = 'e';
            //bool isExist = false;

            //for (int i =0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        isExist = true;
            //    }
            //}
            //Console.WriteLine(isExist);



            //string sentence = "world Hello";
            //string word =     "Hello";
            //string emptyWord = "";

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    //    10  -  6  =   4
            //    //     4  -  0  =   4
            //    if (sentence[i] == word[i])
            //    { // 4 = 
            //        emptyWord = emptyWord + sentence[i];
            //    }
            //    else
            //    {
            //        emptyWord = "";
            //    }
            //}
            //Console.WriteLine(emptyWord == word);

            //string word = " Nica t ";
            //string newWord = "";

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] != ' ')
            //    {
            //        newWord += word[i];
            //    }
            //}
            //Console.WriteLine(newWord);

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if ((i == 0 || i == word.Length-1) &&  word[i] == ' ')
            //    {
            //    }
            //    else
            //    {
            //        newWord += word[i];
            //    }
            //}
            //Console.WriteLine(newWord);


            ////2
            //Console.Write("N : ");
            //int N = Convert.ToInt32(Console.ReadLine());

            //Console.Write("M : ");
            //int M = Convert.ToInt32(Console.ReadLine());

            //for (int i = N + 1; i < M; i++)
            //{
            //    if(i < 0)
            //    {
            //        Console.WriteLine("Menfi " + i + " Musbet " + i*-1);
            //    }
            //    else if (i > 0)
            //    {
            //        Console.WriteLine("Menfi " + i*-1 + " Musbet " + i);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            ////2


            ////3
            //string word = "apple";
            //string reversedWord = "";
            //for (int i = (word.Length-1); i >= 0; i--)
            //{
            //    reversedWord += word[i];
            //}
            //Console.WriteLine(reversedWord);
            ////3


            //4
            int[] array = { 1,2,2, 4, 5, 5, 5,5, 6, 8 };
            int dublicate = array[0];
            int eded = array[0];
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == dublicate)
                {
                    counter++;
                    Console.WriteLine(dublicate + " ededinden " + counter + " eded var");
                    

                }
                eded = array[i];
                dublicate = array[i];
            }
            Console.WriteLine(counter);
            //4
        }
    }
}
