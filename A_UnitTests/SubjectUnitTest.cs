using Project_part_A.Classes;

namespace A_UnitTests
{
    [TestClass]
    public class SubjectTests
    {
        [TestMethod]
        public void Subject_GetName_ReturnsSubjectName()
        {
            // Arrange
            var teacher = new Teacher("Mr.", "Johnson");
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
            var teacher = new Teacher("Ms.", "Brown");
            var subject = new Subject("English", teacher);

            // Act
            var assignedTeacher = subject.GetTeacher();

            // Assert
            Assert.AreEqual(teacher, assignedTeacher);
        }
    }
}