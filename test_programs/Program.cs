using System;

namespace test_programs
{
    class Program
    {
        public string name = "";
        public string NAME
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.DisplayParams("Satya","Rahul","Soubhagya","Aslam");
            String name = "";
            Console.WriteLine("> My Name Is Empty "+name);
            Console.WriteLine("> Please Set My Name");
            obj.SetValue(out name);
            Console.WriteLine("> Thankyou To Set My Name : "+name);
            obj.ModifyMe(ref name);
            Console.WriteLine("> Modified Value "+name);

            //--------- Setting The Properties ---------
            obj.NAME = "MINDFIRE SOLUTIONS";
            Console.WriteLine("> Display The Property Value : "+obj.NAME);
        }
        public void DisplayParams(params String[] elements)
        {
            foreach(String element in elements)
            {
                Console.WriteLine(element);
            }
        }
        public void SetValue(out String name)
        {
            name = "> Satya Prakash Nandy";
        }
        public void ModifyMe(ref String name)
        {
            Console.WriteLine("> Modify This "+name+" To Satya Prakash");
            name = "> Satya Prakash";
        }
    }
}
