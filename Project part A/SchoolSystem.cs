using Project_part_A.Classes;

namespace Project_part_A
{
    // SchoolSystem.cs
    using System;
    using System.Collections.Generic;

    namespace Project_part_A
    {
        public class SchoolSystem
        {
            private List<SchoolClass> Classes { get; }
            private List<Teacher> Teachers { get; }
            private List<Student> Students { get; }

            public SchoolSystem(List<SchoolClass> classes, List<Teacher> teachers, List<Student> students)
            {
                throw new NotImplementedException();
            }

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

            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}