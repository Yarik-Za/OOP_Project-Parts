namespace Project_part_A.Classes
{
    public class SchoolClass
    {
        public int ClassNumber { get; set; }
        public Teacher ClassTeacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public SchoolClass(int classNumber, Teacher classTeacher)
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

        public Teacher GetClassTeacher()
        {
            throw new NotImplementedException();
        }
    }
}
