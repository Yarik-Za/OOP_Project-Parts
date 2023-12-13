using Project_part_A.Interfaces;

namespace Project_part_A.Classes
{
    public class Teacher : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Subject> TaughtSubjects { get; set; } = new List<Subject>();

        public Teacher(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public void AddTaughtSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public List<Subject> GetTaughtSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
