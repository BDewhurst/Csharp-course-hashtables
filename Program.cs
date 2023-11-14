using System;
using System.Collections;
// See https://aka.ms/new-console-template for more information

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Frank", 48);
            Student stud3 = new Student(3, "Connor", 28);
            Student stud4 = new Student(4, "Sara", 94);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            foreach (DictionaryEntry student in studentsTable) {
                Student temp = (Student)student.Value;
                Console.WriteLine("Student ID: {0}", temp.Id);
                Console.WriteLine("Student ID: {0}", temp.Name);
                Console.WriteLine("Student ID: {0}", temp.GPA);

            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
