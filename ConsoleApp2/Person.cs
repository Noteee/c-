using System;

namespace ConsoleApp2
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }


        public Person()
        {

        }

        public Person (string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public enum Genders : int { Male, Female };

        public Genders Gender;

        public override string ToString()
        {
            return $"name: {Name}, birth date: {BirthDate}";
        }
    }
}
