using Project_part_A.Interfaces;

namespace Project_part_A.Classes
{
    public class LabWork : IPrintable
    {
        public List<SchoolClass> Classes { get; set; } = new List<SchoolClass>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddClass(SchoolClass schoolClass)
        {
            throw new NotImplementedException();
        }

        public List<SchoolClass> GetClasses()
        {
            throw new NotImplementedException();
        }

        public void AddTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetTeachers()
        {
            throw new NotImplementedException();
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
