using Project_part_A.Classes;

namespace A_UnitTests
{
    [TestClass]
    public class SchoolClassTests
    {
        [TestMethod]
        public void SchoolClass_AddStudent_AddsStudentToStudentsList()
        {
            // Arrange
            var schoolClass = new SchoolClass(10, new Teacher("Mrs.", "Johnson"));
            var student = new Student("John", "Doe", 15);

            // Act
            schoolClass.AddStudent(student);

            // Assert
            Assert.IsTrue(schoolClass.GetStudents().Contains(student));
        }

        [TestMethod]
        public void SchoolClass_GetClassTeacher_ReturnsClassTeacher()
        {
            // Arrange
            var teacher = new Teacher("Mr.", "Smith");
            var schoolClass = new SchoolClass(11, teacher);

            // Act
            var classTeacher = schoolClass.GetClassTeacher();

            // Assert
            Assert.AreEqual(teacher, classTeacher);
        }
    }
}