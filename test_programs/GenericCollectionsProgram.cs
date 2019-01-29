using System;
using System.Collections.Generic;
namespace test_programs
{
    public class GenericCollectionsProgram
    {
        private List<string> names = new List<string>();
        public GenericCollectionsProgram(params string[] names)
        {
            foreach(string name in names)
            {
                this.names.Add(name);
            }
        }
        public void EmployeeNames()
        {
            Console.WriteLine("+++ List Of Employees +++");
            foreach(string name in this.names)
            {
                Console.WriteLine("> Name : {0}",name);
            }
        }
    }
}