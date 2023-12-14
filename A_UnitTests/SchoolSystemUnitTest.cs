using Project_part_A.Classes;
using Project_part_A.Interfaces;
using Project_part_A;

namespace A_UnitTests
{
    [TestClass]
    public class SchoolSystemTests
    {
        [TestMethod]
        public void SchoolSystem_AddClass_ShouldAddClassToList()
        {
            // Arrange
            var schoolSystem = new SchoolSystem(new List<SchoolClass>(), new List<Teacher>(), new List<Student>());
            var schoolClass = new SchoolClass(10, new Teacher("Mr.", "Johnson"));

            // Act
            schoolSystem.AddClass(schoolClass);

            // Assert
            CollectionAssert.Contains(schoolSystem.GetClasses(), schoolClass);
        }

        [TestMethod]
        public void SchoolSystem_AddTeacher_ShouldAddTeacherToList()
        {
            // Arrange
            var schoolSystem = new SchoolSystem(new List<SchoolClass>(), new List<Teacher>(), new List<Student>());
            var teacher = new Teacher("Mrs.", "Smith");

            // Act
            schoolSystem.AddTeacher(teacher);

            // Assert
            CollectionAssert.Contains(schoolSystem.GetTeachers(), teacher);
        }

        [TestMethod]
        public void SchoolSystem_AddStudent_ShouldAddStudentToList()
        {
            // Arrange
            var schoolSystem = new SchoolSystem(new List<SchoolClass>(), new List<Teacher>(), new List<Student>());
            var student = new Student("John", "Doe", 15);

            // Act
            schoolSystem.AddStudent(student);

            // Assert
            CollectionAssert.Contains(schoolSystem.GetStudents(), student);
        }
    }
}