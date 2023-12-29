using Project_part_A.Classes;

namespace Project_part_A
{
    public class SchoolSystem
    {
        private List<SchoolClass> Classes { get; }
        private List<Teacher> Teachers { get; }
        private List<Student> Students { get; }
        private List<Subject> Subjects { get; }

        public SchoolSystem()
        {
            Classes = new List<SchoolClass>();
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Subjects = new List<Subject>();
            MainMenu();
        }
        public void MainMenu()
        {
            try
            {
                Console.WriteLine("Виберіть опцію:\n1 - Додати учня\n2 - Додати вчителя\n3 - Додати предмет\n4 - Додати клас\n" +
                    "5 - Вибирання студентом предмета\n6 - Додавання студенту до класу\n7 - Вчитель обирає предмет\n8 - Лабораторна робота");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        AddTeacher();
                        break;
                    case "3":
                        AddSubject();
                        break;
                    case "4":
                        AddClass();
                        break;
                    case "5":
                        StudenChoosesSubject(); break;
                    case "6":
                        AddStudentToClass(); break;
                    case "7":
                        TeacherChoosesSubject(); break;
                    case "8":
                        AssignLabWork(); break;
                    default:
                        throw new Exception("Немає такого вибору");
                }
            }
            catch (Exception ex)
            {
                GoToMenu(ex);
            }
        }
        public void GoToMenu()
        {
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
        public void GoToMenu(Exception exception)
        {
            Console.WriteLine(exception.Message);
            GoToMenu();
        }
        public void AssignLabWork()
        {
            Console.WriteLine("Оберіть клас, що буде виконувати лабораторну роботу");
            for (int i = 0; i < Classes.Count; i++)
            {
                Console.WriteLine(i + " - " + Classes[i]);
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            SchoolClass schoolClass = Classes[int.Parse(Console.ReadLine())];
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            List<Student> studentstoassign = schoolClass.Students;
            List<Teacher> teachersassign = new List<Teacher>();
            while (true)
            {
                Console.WriteLine("Оберіть вчителів для допомоги з виконанням лабораторної роботи");
                for (int i = 0; i < Teachers.Count; i++)
                {
                    Console.WriteLine(i + " - " + Teachers[i]);
                }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                int pos = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                if (!teachersassign.Contains(Teachers[pos]))
                    teachersassign.Add(Teachers[pos]);
                else
                    Console.WriteLine("Такий вчитель уже залучений");
                Console.WriteLine("Продовжити? 1 - так, 2 - ні");
                if (Console.ReadLine() == "2")
                    break;
            }
            if (teachersassign.Count == 0 || studentstoassign.Count == 0)
                throw new Exception("Недостатньо учасників для виконання лабораторної роботи");
            LabWork labWork = new(schoolClass);
            foreach (var student in studentstoassign)
            {
                labWork.AddStudent(student);
            }
            foreach (Teacher teacher in teachersassign)
            {
                labWork.AddTeacher(teacher);
            }
            labWork.PrintToDisplay();
            GoToMenu();
        }
        public void AddClass()
        {
            if (Teachers.Count == 0)
            {
                throw new Exception("Немає можливих вчителів");
            }
            Console.WriteLine("Введіть номер класу");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            int number = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            if (GetClasses().Any(u => u.ClassNumber == number))
                throw new Exception("Такий клас уже існує");
            Console.WriteLine("Оберіть вчителя");
            for (int i = 0; i < Teachers.Count; i++)
            {
                Console.Write(i + " - " + Teachers[i].ToString());
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Teacher tempteacher = Teachers[int.Parse(Console.ReadLine())];
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Classes.Add(new SchoolClass(number, tempteacher));
            GoToMenu();
        }

        public List<SchoolClass> GetClasses()
        {
            return Classes;
        }

        public void AddTeacher()
        {
            Console.WriteLine("Клонувати вчителя чи найняти нового? 1 - клонувати, 2 - найняти");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string result = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.

            if (result == "1")
            {
                Console.WriteLine("Оберіть вчителя");
                for (int i = 0; i < Teachers.Count; i++)
                {
                    Console.WriteLine(i + " - " + Teachers[i]);
                }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                Teacher tempteacher = Teachers[int.Parse(Console.ReadLine())];
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                Teachers.Add(tempteacher);
            }
            else if (result == "2")
            {
                Console.WriteLine("Введіть ім'я вчителя");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                string firstname = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                Console.WriteLine("Введіть прізвище вчителя");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                string lastname = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                Console.WriteLine("Введіть вік вчителя");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                int age = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                Teachers.Add(new Teacher(firstname, lastname, age));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            }
            else throw new Exception("Немає такої опції");
            GoToMenu();
        }

        public List<Teacher> GetTeachers()
        {
            return Teachers;
        }

        public void AddStudent()
        {
            Console.WriteLine("Введіть ім'я учня");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string firstname = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            Console.WriteLine("Введіть прізвище учня");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string lastname = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            Console.WriteLine("Введіть вік учня");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            int age = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            if (age > 10)
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                Students.Add(new Student(firstname, lastname, age));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            else
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                Students.Add(new ElementaryStudent(firstname, lastname, age));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            GoToMenu();
        }
        public void AddStudentToClass()
        {
            Console.WriteLine("Виберіть учня");
            for (int i = 0; i < Students.Count; i++)
            {
                Console.Write(i + " - " + Students[i].ToString());
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            var tempstudent = Students[int.Parse(Console.ReadLine())];
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Console.WriteLine("Виберіть клас");
            for (int i = 0; i < Classes.Count; i++)
            {
                Console.WriteLine(i + " - " + Classes[i].ToString());
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Classes[int.Parse(Console.ReadLine())].AddStudent(tempstudent);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            GoToMenu();
        }
        public void StudenChoosesSubject()
        {
            Console.WriteLine("Виберіть учня");
            for (int i = 0; i < Students.Count; i++)
            {
                Console.Write(i + " - ");
                Students[i].ToString();
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            int student = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Console.WriteLine("Виберіть предмет");
            for (int i = 0; i < Subjects.Count; i++)
            {
                Console.Write(i + " - " + Subjects[i].ToString());
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Students[student].ChooseSubject(Subjects[int.Parse(Console.ReadLine())]);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            GoToMenu();
        }
        public void TeacherChoosesSubject()
        {
            Console.WriteLine("Виберіть учня");
            for (int i = 0; i < Teachers.Count; i++)
            {
                Console.Write(i + " - " + Teachers[i].ToString());
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            int teacher = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Console.WriteLine("Виберіть предмет");
            for (int i = 0; i < Subjects.Count; i++)
            {
                Console.WriteLine(i + " - " + Subjects[i]);
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Teachers[teacher].AddTaughtSubject(Subjects[int.Parse(Console.ReadLine())]);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            GoToMenu();
        }
        public List<Student> GetStudents()
        {
            return Students;
        }
        public void AddSubject()
        {
            Console.WriteLine("Введіть назву предмета");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string subjectname = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            if (GetSubjects().Any(u => u.Name == subjectname))
                throw new Exception("Такий предмет уже існує");
            Console.WriteLine("Оберіть вчителя");
            for (int i = 0; i < Teachers.Count; i++)
            {
                Console.Write(i + " - " + Teachers[i].ToString());
            }
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Teacher tempteacher = Teachers[int.Parse(Console.ReadLine())];
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Subjects.Add(new Subject(subjectname, tempteacher));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            GoToMenu();
        }
        public List<Subject> GetSubjects()
        {
            return Subjects;
        }
    }
}