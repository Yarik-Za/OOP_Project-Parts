using Project_part_A.Interfaces;

namespace Project_part_A.Classes
{
    public class LabWork : IPrintable
    {
        public SchoolClass Class { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Student> Students { get; set; } = new List<Student>();

        public LabWork(SchoolClass schoolclass)
        {
            Class = schoolclass;
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

        public void PrintToDisplay()
        {
            Console.WriteLine("Лабораторна робота класу " + Class.ClassNumber);
            string result = "";
            foreach (var teacher in Teachers)
            {
                result += teacher.FirstName + " " + teacher.LastName + ", ";
            }
            Console.WriteLine("Відповідальні за виконання роботи вчителі: " + result);
            result = "";
            foreach (var student in Students)
            {
                result += student.FirstName + " " + student.LastName + ", ";
            }
            Console.WriteLine("Допущені до виконання роботи учні: " + result);
        }
    }
}
