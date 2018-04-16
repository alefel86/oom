using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Task4
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
                Console.WriteLine($"{ x.Name,-40} { x.Profession,-40} {x.Type}");
            }

            var Json = new IOrga[]
            {
                new Employee(name:"Max Mustermann", department:"Anwalt", salary: 34000, type: "Mitarbeiter"),
                new Guest(name:"Karin Maier", profession:"Journalistin", type: "Gast"),
                new Member(name:"Alex Hauser", association: "Sportfreunde", type: "Vereinsmitglied", date: 20010802, status: "Active"),
            };

            string s = JsonConvert.SerializeObject(Json, Formatting.Indented);
            Console.WriteLine(s);

            string xy = @"{
                        'name': 'Hans Nimmersatt',
                        'department': 'Complicance',
                        'salary' : '50000',
                        'type' : 'Mitarbeiter'
                        }";

            Employee Test = JsonConvert.DeserializeObject<Employee>(xy);

            Console.WriteLine(Test.Name);
            Console.WriteLine(Test.Profession);
            Console.WriteLine(Test.Salary);
            Console.WriteLine(Test.Type);

            Console.WriteLine(xy);

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(Json, settings));

            var text = JsonConvert.SerializeObject(Json, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "IOrga.json");
            File.WriteAllText(filename, text);

            var textFromFile = File.ReadAllText(filename);

            var example = new IOrga[]
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

            var producer = new Subject<IOrga>();
            producer.Subscribe(x => Console.WriteLine($"next Member: {x.Name}"));

            var p = producer.GetEnumerator();

            for (var i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                producer.OnNext(new Member(name: "Alex Hauser", association: "Sportfreunde", type: "Vereinsmitglied", date: 20010802, status: "Active"));
            }

            
        }
    }
}