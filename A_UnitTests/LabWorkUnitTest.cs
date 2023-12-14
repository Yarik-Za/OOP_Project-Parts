using Project_part_A.Classes;
using Project_part_A.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A_UnitTests
{
    [TestClass]
    public class LabWorkTests
    {
        [TestMethod]
        public void LabWork_AddClass_AddsClassToClassesList()
        {
            // Arrange
            var labWork = new LabWork();
            var schoolClass = new SchoolClass(12, new Teacher("Mr.", "Davis"));

            // Act
            labWork.AddClass(schoolClass);

            // Assert
            Assert.IsTrue(labWork.GetClasses().Contains(schoolClass));
        }

        [TestMethod]
        public void LabWork_AddTeacher_AddsTeacherToTeachersList()
        {
            // Arrange
            var labWork = new LabWork();
            var teacher = new Teacher("Mrs.", "Smith");

            // Act
            labWork.AddTeacher(teacher);

            // Assert
            Assert.IsTrue(labWork.GetTeachers().Contains(teacher));
        }

        [TestMethod]
        public void LabWork_AddStudent_AddsStudentToStudentsList()
        {
            // Arrange
            var labWork = new LabWork();
            var student = new Student("Jane", "Doe", 16);

            // Act
            labWork.AddStudent(student);

            // Assert
            Assert.IsTrue(labWork.GetStudents().Contains(student));
        }
    }
}