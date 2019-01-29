///<summary>
///     Main Application
///     Peform Filters On Integer Array Like Even Numbers, Numbers Greater Than 10 And Number Divisible By Five
///</summary>
using System;
using CustomValidation;
using CustomInput;
namespace MindfireAssignmentOne
{
    // Delegate : Used To Aplly Filter, Based On User Input
    public delegate bool CheckValidity(int number);
    class Application
    {
        private const int size = 10;
        private  int[] elements = new int[size];
        private  int userOption = 0;
        private  CheckValidity checkValidity = null;
        static void Main(string[] args)
        {
            Application application = new Application();
            ICustomInput customInput = new CustomInputImplementer();
            IValidation validation = new ValidationImplementer();
            do
            {
                Console.Clear();
                Console.WriteLine("***** Hello World To My First C# Assignment ! *****");
                Console.WriteLine("\n>>> Please Enter 10 Number <<<\n");
                application.elements = customInput.GetUserNumbers(Application.size);
                do
                {
                    Console.Clear();
                    application.userOption = customInput.GetUserChoiceToFilter();
                    switch(application.userOption)
                    {
                        case 1:
                            application.checkValidity = new CheckValidity(validation.CheckEven);
                        break;
                        case 2:
                            application.checkValidity = new CheckValidity(validation.CheckLessThanTen);
                        break;
                        case 3:
                            application.checkValidity = new CheckValidity(validation.CheckDivisibleByFive);
                        break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\n++ You Have Not Used Any Filter :( ++\n");
                        break;
                    }
                    if(application.checkValidity!=null)
                    {
                        string result = application.GetResult(application.elements,application.checkValidity);
                        if(result.Length>0)
                        {
                            Console.WriteLine("\n>>> Result : "+result+" <<<\n");
                        }
                        else
                        {
                            Console.WriteLine("\n>>> No Result Found ! :(<<<\n");
                        }
                    }
                    application.userOption = customInput.GetUserChoiceToContinue();
                    application.checkValidity = null;
                }while((application.userOption!=0)&&(application.userOption!=1));
            }while(application.userOption!=0);
        }

        // Apply Filter And Return Result In String Format
        private  string GetResult(int[] userNumbers,CheckValidity checkValidity)
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
