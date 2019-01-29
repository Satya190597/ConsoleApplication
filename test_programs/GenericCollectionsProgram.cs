using System;
using System.Collections.Generic;
namespace test_programs
{
    public class GenericCollectionsProgram
    {
        private List<string> names = new List<string>();
        private Dictionary<int,string> employees = new Dictionary<int, string>();
        private int employeeId = 100;
        public GenericCollectionsProgram(params string[] names)
        {
            // Populate in the list
            foreach(string name in names)
            {
                this.names.Add(name);
            }
            // Populate in the dictionary
            foreach(string name in names)
            {
                this.employees.Add(this.employeeId++,name);
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
        public void EmployeeNamesWithId()
        {
            Console.WriteLine("+++ List Of Employee With Id +++");
            foreach(KeyValuePair<int,string> element in this.employees)
            {
                Console.WriteLine("Employee ID {0} And Employee Name {1}",element.Key,element.Value);
            }
        }
    }
}