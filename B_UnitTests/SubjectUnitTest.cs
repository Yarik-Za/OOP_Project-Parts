using Project_part_A.Classes;
using Project_part_A.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A_UnitTests
{
    [TestClass]
    public class SubjectTests
    {
        [TestMethod]
        public void Subject_GetName_ReturnsSubjectName()
        {
            // Arrange
            var teacher = new Teacher("Mr.", "Johnson", 37);
            var subject = new Subject("Math", teacher);

            // Act
            var subjectName = subject.GetName();

            // Assert
            Assert.AreEqual("Math", subjectName);
        }

        [TestMethod]
        public void Subject_GetTeacher_ReturnsAssignedTeacher()
        {
            // Arrange
            var teacher = new Teacher("Ms.", "Brown", 37);
            var subject = new Subject("English", teacher);

            // Act
            var assignedTeacher = subject.GetTeacher();

            // Assert
            Assert.AreEqual(teacher, assignedTeacher);
        }
    }
}