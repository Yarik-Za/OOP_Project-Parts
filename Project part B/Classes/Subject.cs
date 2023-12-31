﻿using Project_part_A.Interfaces;

namespace Project_part_A.Classes
{
    public class Subject
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        public Subject(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;
        }

        public string GetName()
        {
            return Name;
        }

        public Teacher GetTeacher()
        {
            return Teacher;
        }

        public override string ToString()
        {
            string res= $"Subject: {Name}";
            if (Teacher != null)
            {
                res+=$", teacher: {Teacher.FirstName} {Teacher.LastName}";
            }
            return res;
        }
    }
}
