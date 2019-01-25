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
            do
            {
                Console.WriteLine("Hello World To My First C# Programs !");
                Application obj = new Application();
                obj.elements = customInput.GetUserNumbers();
                do
                {
                    option = customInput.GetUserChoiceToFilter();
                    CheckValidity objectOfDelegate = null;
                    if(option==1)
                    {
                        objectOfDelegate = new CheckValidity(validation.CheckEven);
                    }
                    else if(option==2)
                    {
                        objectOfDelegate = new CheckValidity(validation.CheckLessThanTen);
                    }
                    else if(option==3)
                    {
                        objectOfDelegate = new CheckValidity(validation.CheckDivisibleByFive);
                    }
                    if(objectOfDelegate!=null)
                        Console.WriteLine("Result : "+obj.GetResult(obj.elements,objectOfDelegate));
                    option = customInput.GetUserChoiceToContinue();
                }while(option!=0 && option!=1);
            }while(option!=0);
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
    }
}
