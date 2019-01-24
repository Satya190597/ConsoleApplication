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
        return 1;
    }
}