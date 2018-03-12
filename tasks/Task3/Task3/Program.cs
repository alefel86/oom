using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{

    public interface IOrga
    {
        string Name { get; set; }
        string Profession { get; set; }
        
    }

    class Employee : IOrga
    {
        public Employee(string name, string department, int salary)
        {
            this.Name = name;
            this.Profession = department;
            this.Salary = salary;
        }

        public string Name
        {
            get;
            set;

        }

        public string Profession
        {
            get;
            set;
        }

        public int Salary
        {
            get;
            set;
        }
    }
    class Member : IOrga
    {
        public Member(string name, string association)
        {
            this.Name = name;
            this.Profession = association;
        }    

            public string Name
            {
                get;
                set;

            }

            public string Profession
            {
                get;
                set;
            }
                  
        }
    

    class Program
    {
        static void Main(string[] args)
        {
            var Guests = new IOrga[]
            {
                new Employee(name:"Max Mustermann", department:"Anwalt", salary: 34000),
                new Employee(name:"Moritz Mustermann", department:"Controller", salary: 53000),
                new Employee(name:"Peter Zwegat", department:"Einkäufer", salary: 69000),
                new Member(name:"Herbert Lidl", association:"Vorstand"),
                new Member(name:"Elisabeth Stangl", association:"Autorin"),
                new Member(name:"Karin Maier", association:"Journalistin"),
                new Member(name:"Felix Baumgartner", association:"Sportler"),
            };

           foreach (var x in Guests)
            {
                Console.WriteLine($"{ x.Name, -40} { x.Profession}");
                
            }



            


        }
    }
}
