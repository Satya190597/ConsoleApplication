using System;

namespace MindfireAssignmentOne
{
    public delegate bool CheckValidity(int number);
    class Application
    {
        private int[] elements = new int[10];
        private delegate int Result(int no);
        static void Main(string[] args)
        {
            ICustomInput customInput = new CustomInputImplementer();
            IValidation validation = new ValidationImplementer();
            int  option; 
            Console.WriteLine("Hello World To My First C# Programs !");
            Application obj = new Application();
            obj.elements = customInput.GetUserNumbers();
            Console.WriteLine("+ --- Enter Your Choice --- +");
            Console.WriteLine("1 For Even Numbers Filters");
            Console.WriteLine("2 For Numbers Greater Than 10 Filters");
            Console.WriteLine("3 For Divisible By 5 Filters");
            option = Int32.Parse(Console.ReadLine());
            CheckValidity objectOfDelegate = null;
            if(option==1)
            {
                objectOfDelegate = new CheckValidity(obj.CheckEven);
            }
            else if(option==2)
            {
                objectOfDelegate = new CheckValidity(obj.GreaterThanTen);
            }
            else if(option==3)
            {
                objectOfDelegate = new CheckValidity(obj.DivisibleByFive);
            }
            else
            {
                Console.WriteLine("Invalid Input !");
            }
            Console.WriteLine("Result : "+obj.GetResult(obj.elements,objectOfDelegate));
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
        private String GetResult(int[] userNumbers,CheckValidity checkValidity)
        {
            String result = "";
            foreach(int number in userNumbers)
            {
                if(checkValidity(number))
                {
                    result += " " + number + "";
                }
            }
            return result;
        }
        public bool CheckEven(int number)
        {
            if(number%2==0)
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
}
