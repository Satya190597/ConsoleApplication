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
                1. PropertiesProgram obj = new PropertiesProgram();
                2. PropertiesProgram.SetEmployeeDetails(obj,"Satya Prakash Nandy",35,"nandy@yahoo.in");
                3. PropertiesProgram.DisplayEmployeeDetails(obj);
            */
            /* 
                Generics Program Methods Calls
                GenericCollectionsProgram obj = new GenericCollectionsProgram("Satya","Rahul","Ravi","Aslam","Charles");
                1. obj.EmployeeNames();
                2. obj.EmployeeNamesWithId();
            */
        }
    }
}
