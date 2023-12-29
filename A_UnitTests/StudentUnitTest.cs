using Project_part_A.Classes;
using Project_part_A.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A_UnitTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Student_ChooseSubject_AddsSubjectToChosenSubjects()
        {
            // Arrange
            var student = new Student("John", "Doe", 18);
            var subject = new Subject("Math", new Teacher("Mr.", "Smith", 37));

            // Act
            student.ChooseSubject(subject);

            // Assert
            Assert.IsTrue(student.ChosenSubjects.Contains(subject));
        }

        [TestMethod]
        public void Student_GetEnrolledSubjects_ReturnsChosenSubjects()
        {
            // Arrange
            var student = new Student("Jane", "Doe", 17);
            var mathSubject = new Subject("Math", new Teacher("Ms.", "Jones", 37));
            var englishSubject = new Subject("English", new Teacher("Mrs.", "Brown", 37));
            student.ChooseSubject(mathSubject);
            student.ChooseSubject(englishSubject);

            // Act
            var enrolledSubjects = student.GetEnrolledSubjects();

            // Assert
            Assert.AreEqual(2, enrolledSubjects.Count);
            CollectionAssert.Contains(enrolledSubjects, mathSubject);
            CollectionAssert.Contains(enrolledSubjects, englishSubject);
        }
    }

}