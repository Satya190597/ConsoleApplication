///<summary>
///     Implementer For ICustomInput Interface
///     Used to provide appropriate menu and take user inputs
///</summary>
using System;
namespace CustomInput
{
    class CustomInputImplementer : ICustomInput
    {
        public int[] GetUserNumbers(int size)
        {
            int[] userNumbers = new int[size];
            int index = 0,element = 0;

            do
            {
                Console.Write("Enter The {0} Number :\t",(index+1));
                string userInput = Console.ReadLine();
                if(Int32.TryParse(userInput,out element))
                {
                    userNumbers[index++] = element;
                }
                else
                {
                    Console.WriteLine("\n>>> Warning : Please Enter Numeric Value ! <<<\n");
                }
            }while(index<userNumbers.Length);

            return userNumbers;
        }
        public int GetUserChoiceToFilter()
        {
            string userInput = "";

            do
            {
                Console.WriteLine("+++++++++++++ Enter Your Choice +++++++++++++");
                Console.WriteLine("+ 1 For Even Numbers Filters                +");
                Console.WriteLine("+ 2 For Numbers Greater Than 10 Filters     +");
                Console.WriteLine("+ 3 For Divisible By 5 Filters              +");
                Console.WriteLine("+ 0 To Cancel                               +");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Enter (1,2,3 or 0) :\t");
                userInput = Console.ReadLine();
                if(userInput == "1" || userInput== "2" || userInput == "3" || userInput == "0")
                {
                    return Int32.Parse(userInput);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>>> Please Enter A Valid Option <<<\n");
                }
            }while(true);

        }
        public int GetUserChoiceToContinue()
        {
            string userInput = "";
            do
            {
                Console.WriteLine("+ +++++ Enter Your Choice +++++");
                Console.WriteLine("+ 1 To Restart                +");
                Console.WriteLine("+ 2 To Apply Different Filter +");
                Console.WriteLine("+ 0 To Exit                   +");
                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.Write("Enter (1,2 or 0) :\t");
                userInput = Console.ReadLine();
                if(userInput == "1" || userInput == "2" || userInput == "0" )
                {
                    return Int32.Parse(userInput);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>>> Please Enter A Valid Option <<<\n");
                }
            }while(true);
        }
    }
}