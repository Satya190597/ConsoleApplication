using System;

namespace satya_c__assignment_one_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] ar = Program.GetNumbers();
            Console.WriteLine("This Is Great {0}",ar);
        }
        private static int[] GetNumbers()
        {
            int[] arr = new int[10];
            int index = 0;
            while(index<arr.Length)
            {
                Console.Write("Enter The {0} Number \t: ",(index+1));
                string userInput = Console.ReadLine();
                int elements;
                if(Int32.TryParse(userInput,out elements))
                {
                    arr[index++] = elements;
                }
                else
                {
                    Console.WriteLine("Warning : Please Enter Numeric Value !");
                }
            }
            Console.WriteLine(arr.Length);
            return arr;
        }
    }
}
