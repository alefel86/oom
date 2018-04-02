using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    
    public class Tests
    {
        [Test]

        public void EmployeeTest1()
        {
            var x = new Employee(name: "Max Mustermann", department: "Anwalt", salary: 34000, type: "Mitarbeiter");
            Assert.IsTrue(x.Salary != 0);
            Assert.IsTrue(x.Salary > 0);
        }

        [Test] 

        public void EmployeeTest2()
        {
            var x = new Employee(name: "Moritz Mustermann", department: "Controller", salary: 53000, type: "Mitarbeiter");
            Assert.IsTrue(x.Name == "Max Mustermann");
        }

        [Test]

        public void EmployeeTest3()
        {
            var x = new Employee(name: "Moritz Mustermann", department: "Controller", salary: 53000, type: "Mitarbeiter");
            Assert.IsTrue(x.Type == "Mitarbeiter");
        }

        [Test]

        public void EmployeeTest4()
        {
            var x = new Employee(name: "Peter Zwegat", department: "Einkäufer", salary: 69000, type: "Mitarbeiter");
            Assert.IsTrue(x.Profession == "");
        }

        [Test]

        public void GuestTest1()
        {
            var x = new Guest(name: "Karin Maier", profession: "Journalistin", type: "Gast");
            Assert.IsTrue(x.Type == "Gast");
        }

        [Test]

        public void GuestTest2()
        {
            var x = new Guest(name: "Karin Maier", profession: "Journalistin", type: "Gast");
            Assert.IsTrue(x.Type != "Mitarbeiter");
        }

        [Test]

        public void MemberTest1()
        {
            var x = new Member(name: "Eva Apfel", association: "Sportfreunde", type: "Vereinsmitglied", date: 20000910, status: "Suspended");   
            Assert.IsTrue(x.Status != "Suspended");
        }

        [Test]

        public void MemberTest2()
        {
            var x = new Member(name: "Eva Apfel", association: "Sportfreunde", type: "Vereinsmitglied", date: 20000910, status: "Suspended");
            Assert.IsTrue(x.Profession == "Sportfreund");
        }

    }

}
