using Project_part_A.Interfaces;
namespace Project_part_A.Classes
{
    public class Student : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Subject> ChosenSubjects { get; set; } = new List<Subject>();

        public Student(string firstName, string lastName, int age)
        {
            throw new NotImplementedException();
        }

        public void ChooseSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public List<Subject> GetEnrolledSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
