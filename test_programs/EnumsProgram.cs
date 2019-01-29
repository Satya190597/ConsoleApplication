using System;
namespace test_programs
{
    public enum Cars
    {
        Nissan = 101,
        BMW = 201,
        Honda = 301,
        Jaguar = 401
    }
    class EnumsProgram
    {
        public static void DisplayMyEnums()
        {
            foreach(string car in Enum.GetNames(typeof(Cars)))
            {
                Console.WriteLine(car);
            }
        }
        public static void GetUserEnums()
        {
            Console.Write("Please Enter The Brand ID : ");
            int number = Int32.Parse(Console.ReadLine());
            Cars car = (Cars)number;
            switch(car)
            {
                case Cars.BMW:
                    Console.WriteLine("Thankyou To Select BMW");
                break;
                case Cars.Honda:
                    Console.WriteLine("Thankyou Select Honda");
                break;
                case Cars.Jaguar:
                    Console.WriteLine("Thankyou To Select Jaguar");
                break;
                case Cars.Nissan:
                    Console.WriteLine("Thankyou To Select Nissan");
                break;
                default:
                    Console.WriteLine("Please Enter A Valid Brand ID");
                break;
            }
        }
        public static void GetIdAndName()
        {
            Console.WriteLine("+++ Enums Names And Values +++");
            foreach(string car in Enum.GetNames(typeof(Cars)))
            {
                Console.WriteLine("> Names : {0} And Values : {1}",car,Enum.Parse(typeof(Cars),car));
            }
            Console.WriteLine("+++ Enums Values And Name +++");
            foreach(int id in Enum.GetValues(typeof(Cars)))
            {
                Console.WriteLine("> Values : {0} And Names : {1}",id,Enum.GetName(typeof(Cars),id));
            }
        }
    }
}