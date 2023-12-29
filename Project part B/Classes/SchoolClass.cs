namespace Project_part_A.Classes
{
    public class SchoolClass
    {
        public int ClassNumber { get; set; }
        public Teacher ClassTeacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public SchoolClass(int classNumber, Teacher classTeacher)
        {
            ClassNumber = classNumber;
            ClassTeacher = classTeacher;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public Teacher GetClassTeacher()
        {
            return ClassTeacher;
        }

        public override string ToString() { 
            string res = $"номер класу: {ClassNumber}, класний керівник :{ClassTeacher.ToString()} ";
            return res; 
        }
    }
}
