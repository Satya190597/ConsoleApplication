using System;

namespace test_programs
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // ***** Only call Other Classes *****
            /*
                Enums Program Methods Calls
                1. EnumsProgram.DisplayMyEnums();
                2. EnumsProgram.GetUserEnums();
                3. EnumsProgram.GetIdAndName();
             */
            /*
                Properties Program Nethods Calls
                PropertiesProgram obj = new PropertiesProgram();
                PropertiesProgram.SetEmployeeDetails(obj,"Satya Prakash Nandy",35,"nandy@yahoo.in");
                PropertiesProgram.DisplayEmployeeDetails(obj);
            */
            GenericCollectionsProgram obj = new GenericCollectionsProgram("Satya","Rahul","Ravi","Aslam","Charles");
            obj.EmployeeNames();
        }
    }
}
