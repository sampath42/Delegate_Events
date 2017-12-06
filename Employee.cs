using System;
using System.Collections.Generic;

namespace Demo
{
    public class Employee
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public double Salary{get;set;}
        public int Experience{get;set;}
        public void PromoteEmployee(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                if(employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
        
    }
}