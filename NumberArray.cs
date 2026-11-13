using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{

    internal class NumberArray : IEvenOddOutput, IValueCounter
    {

        private int[] _data;

        public NumberArray(int[] data)
        {
            _data = data;
        }

        public void Show()
        {
            Console.Write("Array: ");

            for (int i = 0; i < _data.Length; i++)
            {
                Console.Write($"{_data[i]} ");
            }

            Console.WriteLine();
        }


        // ---------- IEvenOddOutput ----------
        public void ShowEven()
        {
            Console.Write("Even values: ");

            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] % 2 == 0)
                {
                    Console.Write($"{_data[i]} ");
                }
            }

            Console.WriteLine();
        }


        public void ShowOdd()
        {
            Console.Write("Odd values: ");

            for (int i = 0; i < _data.Length; i++)
            {
                // "!= 0", რომ უარყოფითი კენტი რიცხვებიც ჩაითვალოს (-7 % 2 == -1)
                if (_data[i] % 2 != 0)
                {
                    Console.Write($"{_data[i]} ");
                }
            }

            Console.WriteLine();
        }


        // ---------- IValueCounter ----------
        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < _data.Length; i++)
            {
                bool alreadySeen = false;

                // ვამოწმებთ, შეგვხვედრია თუ არა ეს მნიშვნელობა უფრო ადრე
                for (int j = 0; j < i; j++)
                {
                    if (_data[j] == _data[i])
                    {
                        alreadySeen = true;
                        break;
                    }
                }

                if (!alreadySeen)
                {
                    count++;
                }
            }

            return count;
        }


        public int EqualToValue(int valueToCompare)
        {
            int count = 0;

            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] == valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
