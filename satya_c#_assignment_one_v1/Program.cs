using System;

namespace satya_c__assignment_one_v1
{
    public delegate void HelloFunctionDelegate(string strMessage);
    class Program
    {
        private int[] elements = new int[10];
        private delegate int Result(int no);
        private int option; 
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(CustomDeligates.Hello);
            del("Hello My First Delegate"); 
            /* Console.WriteLine("Hello World!");
            Program obj = new Program();
            obj.GetNumbers();
            Result obj_one = new Result(Program.ResultHandler); */
        }
        private void GetNumbers()
        {
            int[] arr = new int[10];
            int index = 0;
            while(index<arr.Length)
            {
                Console.Write("Enter The {0} Number \t: ",(index+1));
                string userInput = Console.ReadLine();
                int element;
                if(Int32.TryParse(userInput,out element))
                {
                    this.elements[index++] = element;
                }
                else
                {
                    Console.WriteLine("Warning : Please Enter Numeric Value !");
                }
            }
            Console.WriteLine(arr.Length);
        }
        private static int ResultHandler(int option)
        {
            if(option==1)
                return 1;
            if(option==2)
                return 2;
            if(option==3)
                return 3;
            else
                return 4;
        }
        private bool CheckEven(int i)
        {
            if(i%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool GreaterThanTen(int i)
        {
            if(i>10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool DivisibleByFive(int i)
        {
            if(i%5==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    class CustomDeligates
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
