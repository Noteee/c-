using System;

namespace ConsoleApp2
{
    class Person
    {
        public String Name { get; set; }
        public int BirthDate { get; set; }


        public Person()
        {

        }

        public Person (String Name, int BirthDate)
        {
            this.Name = Name;
            this.BirthDate = BirthDate;
        }

        public enum Genders : int { Male, Female };

        public Genders gender;

        public override string ToString()
        {
            return $"name: {Name}, birth date: {BirthDate}";
        }
    }
}
