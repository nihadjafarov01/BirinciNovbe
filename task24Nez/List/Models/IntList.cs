using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Models
{
    internal class IntList
    {
        int[] _array;

        public void Add(int number)
        {
            _array[0] = number;
        }
        public void Add(params int[] numbers)
        {

        }

        public int Get(int index) 
        {
            return _array[index]; 
        }

        public void GetAll()
        {

        }

        public void Print()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
    }
}
