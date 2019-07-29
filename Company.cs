using System;
using System.Collections.Generic;

namespace employeeCompany

{
    class Company
    {
        public DateTime dateFounded { get; set; }
        public string _companyName { get; set; }
        public List<Employee> employees { get; set; } // property that is a List of employees. Each item in Employee List will have properties that are on the Employee class

        public void ListEmployees() {

            employees.ForEach(emp => Console.WriteLine(emp));
        }

        public Company(string companyName) // This is a constructor. When you create a new instance of Company must pass in a string and this sets the companyName field.
        {
            companyName = _companyName; // companyName is the private field and it is set equal to the argument that was passed in the constructor.
        }
    }
}