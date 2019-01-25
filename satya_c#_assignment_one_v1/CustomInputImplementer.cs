using System;
class CustomInputImplementer : ICustomInput
{
    public int[] GetUserNumbers()
    {
        int[] userNumbers = new int[10];
        int index = 0,element = 0;
        while(index < userNumbers.Length)
        {
            Console.Write("Enter The {0} Number \t: ",(index+1));
            string userInput = Console.ReadLine();
            if(Int32.TryParse(userInput,out element))
            {
                userNumbers[index++] = element;
            }
            else
            {
                Console.WriteLine("Warning : Please Enter Numeric Value !");
            }
        }
        return userNumbers;
    }
    public int GetUserChoice()
    {
        do
        {
            string userInput;
            int option;
            Console.WriteLine("+ --- Enter Your Choice --- +");
            Console.WriteLine("1 For Even Numbers Filters");
            Console.WriteLine("2 For Numbers Greater Than 10 Filters");
            Console.WriteLine("3 For Divisible By 5 Filters");
            Console.WriteLine("0 To Exit");
            Console.WriteLine("------------------------------");
            Console.Write("Enter (1,2,3 or 0) :\t");
            userInput = Console.ReadLine();
            if(Int32.TryParse(userInput,out option))
            {
                return option;
            }
            else
            {
                Console.WriteLine("Please Enter A Valid Option : ");
            }
        }while(true);
    }
}