namespace Project_part_A.Classes
{
    public class Student : Person
    {
        private int age;
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override int Age { get => age; set => age = value; }
        public List<Subject> ChosenSubjects { get; set; } = new List<Subject>();

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void ChooseSubject(Subject subject)
        {
            ChosenSubjects.Add(subject);
        }

        public List<Subject> GetEnrolledSubjects()
        {
            return ChosenSubjects;
        }
    }
}
