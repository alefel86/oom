using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{

    public interface IOrga
    {
        string Type { get; set; }
        string Name { get; set; }
        string Profession { get; set; }
    }

    class Employee : IOrga
    {
        public Employee(string name, string department, int salary, string type)
        {
            this.Name = name;
            this.Profession = department;
            this.Salary = salary;
            this.Type = type;
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

        public string Type
        {
            get;
            set;
        }
    }
    class Guest : IOrga
    {
        public Guest(string name, string profession, string type)
        {
            this.Name = name;
            this.Profession = profession;
            this.Type = type;
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

            public string Type
            {
            get;
            set;
            }
        
    }

    class Member : IOrga
    {
        public Member(string name, string association, string type, int date, string status)
        {
            this.Name = name;
            this.Profession = association;
            this.Type = type;
            this.Date = date;
            this.Status = status;
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

        public string Type
        {
            get;
            set;
        }

        public int Date
        {
            get;
            set;
        }

        public string Status
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
                new Employee(name:"Max Mustermann", department:"Anwalt", salary: 34000, type: "Mitarbeiter"),
                new Employee(name:"Moritz Mustermann", department:"Controller", salary: 53000, type: "Mitarbeiter"),
                new Employee(name:"Peter Zwegat", department:"Einkäufer", salary: 69000, type: "Mitarbeiter"),
                new Guest(name:"Herbert Lidl", profession:"Vorstand", type: "Gast"),
                new Guest(name:"Elisabeth Stangl", profession:"Autorin", type: "Gast"),
                new Guest(name:"Karin Maier", profession:"Journalistin", type: "Gast"),
                new Guest(name:"Felix Baumgartner", profession:"Sportler", type: "Gast"),
                new Member(name:"Lisa Schnee", association: "Sportfreunde", type: "Vereinsmitglied", date: 20020912, status: "Active"),
                new Member(name:"Adam Mensch", association: "Sportfreunde", type: "Vereinsmitglied", date: 20070712, status: "Active"),
                new Member(name:"Eva Apfel", association: "Sportfreunde", type: "Vereinsmitglied", date: 20000910, status: "Suspended"),
                new Member(name:"Alex Hauser", association: "Sportfreunde", type: "Vereinsmitglied", date: 20010802, status: "Active"),
            };

           foreach (var x in Guests)
            {
                Console.WriteLine($"{ x.Name, -40} { x.Profession, -40} {x.Type}");
                
            }



            


        }
    }
}
