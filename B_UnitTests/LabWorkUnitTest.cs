using Project_part_A.Classes;
using Project_part_A.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A_UnitTests
{
    [TestClass]
    public class LabWorkTests
    {

        [TestMethod]
        public void LabWork_AddTeacher_AddsTeacherToTeachersList()
        {
            // Arrange
            var schoolClass = new SchoolClass(12, new Teacher("Mr.", "Davis", 37));
            var labWork = new LabWork(schoolClass);
            var teacher = new Teacher("Mrs.", "Smith", 37);

            // Act
            labWork.AddTeacher(teacher);

            // Assert
            Assert.IsTrue(labWork.GetTeachers().Contains(teacher));
        }

        [TestMethod]
        public void LabWork_AddStudent_AddsStudentToStudentsList()
        {
            // Arrange
            var schoolClass = new SchoolClass(12, new Teacher("Mr.", "Davis", 37));
            var labWork = new LabWork(schoolClass);
            var student = new Student("Jane", "Doe", 16);

            // Act
            labWork.AddStudent(student);

            // Assert
            Assert.IsTrue(labWork.GetStudents().Contains(student));
        }
    }
}