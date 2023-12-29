
using Project_part_A.Interfaces;

namespace Project_part_A.Classes
{
    public abstract class Person
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, вік: {Age}";
        }

    }
}