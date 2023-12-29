namespace Project_part_A.Classes
{
    public class Teacher : Person, ICloneable
    {
        private int age;
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override int Age
        {
            get => age; set
            {
                if (value < 23)
                {
                    throw new Exception("Надто молодий для вчителя");
                }
                age = value;
            }
        }
        public List<Subject> TaughtSubjects { get; set; } = new List<Subject>();

        public Teacher(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void AddTaughtSubject(Subject subject)
        {
            TaughtSubjects.Add(subject);
        }

        public List<Subject> GetTaughtSubjects()
        {
            return TaughtSubjects;
        }

        public object Clone()
        {
            return new Teacher(FirstName, LastName, Age);
        }
    }
}
