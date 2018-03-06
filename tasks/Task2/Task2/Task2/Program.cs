using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{

    public class Employee
    {
        public static int NumberOfEmployees; //public field
        public static int counter; //public field
        private string name; //private field
        public int salary; //public field
                
        public string Name //property of Name
        {
            get { return name; }
            set
            {
                name = value;
                counter = ++counter;
            }
        }

        public double Personellcosts(int salary) //method
        {
            return 1.5 * salary; 
        }
        
        public Employee(int weeklySalary, int numberOfWeeks) //constructor
        {
            salary = weeklySalary * numberOfWeeks;
        }
     
        public static int Counter //static property counter
        {
            get { return NumberOfEmployees + counter; }
        }
               
    }
           
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee.NumberOfEmployees = 0;

            Employee E1 = new Employee(500, 52);
            E1.Name = "Max Mustermann";
            
            Console.WriteLine("Employee name: {0}, Employee Salary: {1}", E1.Name, E1.salary);

            Console.WriteLine("Total Personell Costs are {0}", E1.Personellcosts(E1.salary));
            Console.WriteLine("Number of Total Employees is {0}", Employee.Counter);

            Employee E2 = new Employee(650, 52)
            {
                Name = "Moritz Mustermann"
            };

            Console.WriteLine("Employee name: {0}, Employee Salary: {1}", E2.Name, E2.salary);
                  
            Console.WriteLine("Total Personell Costs are {0}", E1.Personellcosts(E1.salary + E2.salary));
            Console.WriteLine("Number of Total Employees is {0}", Employee.Counter);

            Employee E3 = new Employee(470, 52)
            {
                Name = "Peter Zwegat"
            };

            Console.WriteLine("Employee name: {0}, Employee Salary: {1}", E3.Name, E3.salary);

            Console.WriteLine("Total Personell Costs are {0}", E1.Personellcosts(E1.salary + E2.salary + E3.salary));
            Console.WriteLine("Number of Total Employees is {0}", Employee.Counter);

        }
    }
}
