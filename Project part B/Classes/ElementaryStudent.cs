namespace Project_part_A.Classes
{
    public class ElementaryStudent : Student
    {
        public override int Age
        {
            get => base.Age; set
            {
                if (value > 10)
                {
                    throw new Exception("Надто дорослий для початкової школи");
                }
                base.Age = value;
            }
        }
        public ElementaryStudent(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public override void ChooseSubject(Subject subject)
        {
            if (ChosenSubjects.Count > 4)
            {
                throw new Exception("Надто багато вибіркових дисциплін для початкової школи");
            }
            ChosenSubjects.Add(subject);
        }

    }
}
