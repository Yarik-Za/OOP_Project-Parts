using Project_part_A.Classes;

namespace Project_part_A
{
    public class SchoolSystem
    {
        private List<SchoolClass> Classes { get; }
        private List<Teacher> Teachers { get; }
        private List<Student> Students { get; }

        public SchoolSystem(List<SchoolClass> classes, List<Teacher> teachers, List<Student> students)
        {
            Classes = classes;
            Teachers = teachers;
            Students = students;
        }

        public void AddClass(SchoolClass schoolClass)
        {
            Classes.Add(schoolClass);
        }

        public List<SchoolClass> GetClasses()
        {
            return Classes;
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return Teachers;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}