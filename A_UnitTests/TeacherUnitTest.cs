using Project_part_A.Classes;
using Project_part_A.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A_UnitTests
{
    [TestClass]
    public class TeacherTests
    {
        [TestMethod]
        public void Teacher_AddTaughtSubject_AddsSubjectToTaughtSubjects()
        {
            // Arrange
            var teacher = new Teacher("Mr.", "Johnson");
            var subject = new Subject("History", teacher);

            // Act
            teacher.AddTaughtSubject(subject);

            // Assert
            Assert.IsTrue(teacher.TaughtSubjects.Contains(subject));
        }

        [TestMethod]
        public void Teacher_GetTaughtSubjects_ReturnsTaughtSubjects()
        {
            // Arrange
            var teacher = new Teacher("Mrs.", "Williams");
            var mathSubject = new Subject("Math", teacher);
            var physicsSubject = new Subject("Physics", teacher);
            teacher.AddTaughtSubject(mathSubject);
            teacher.AddTaughtSubject(physicsSubject);

            // Act
            var taughtSubjects = teacher.GetTaughtSubjects();

            // Assert
            Assert.AreEqual(2, taughtSubjects.Count);
            CollectionAssert.Contains(taughtSubjects, mathSubject);
            CollectionAssert.Contains(taughtSubjects, physicsSubject);
        }
    }
}