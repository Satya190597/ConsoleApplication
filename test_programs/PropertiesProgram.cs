using System;
namespace test_programs
{
    class PropertiesProgram
    {
        private string employeeName;
        private int employeeId;
        private string employeeEmail;
        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
        public string Email
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public string Name
        {
            get
            {
                return employeeEmail;
            }
            set
            {
                employeeEmail = value;
            }
        }
        public static void SetEmployeeDetails(PropertiesProgram obj,string name,int id,string email)
        {
            obj.ID = id;
            obj.Name = name;
            obj.Email = email;
        }
        public static void DisplayEmployeeDetails(PropertiesProgram obj)
        {
            Console.WriteLine("Employee Details > Name : {1} ID : {0} Email : {2}",obj.ID,obj.Name,obj.Email);
        }
    }
}