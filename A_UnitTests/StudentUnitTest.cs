using Project_part_A.Classes;

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
            var subject = new Subject("Math", new Teacher("Mr.", "Smith"));

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
            var mathSubject = new Subject("Math", new Teacher("Ms.", "Jones"));
            var englishSubject = new Subject("English", new Teacher("Mrs.", "Brown"));
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