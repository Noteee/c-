using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; set;}
        public string Profession { get; set;}
        public Room Room;

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.Salary = salary;
            this.Profession = profession;
            Room = null;
        }

        public override string ToString()
        {
            return base.ToString() + $", salary: {Salary},  profession: {Profession}, room: {Room.Number}";
        }

        public object Clone()
        {
            var newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}
