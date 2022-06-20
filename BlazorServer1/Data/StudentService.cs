using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer1.Data
{
    public class StudentService
    {
        public List<Student> students = new List<Student>{new Student
            {
                IdStudent = 1,
                FirstName = "John",
                LastName = "Johnowski",
                Birthdate = new DateTime(2000, 1, 1),
                Studies = "Computer Science"
            }, new Student
            {
                IdStudent = 2,
                FirstName = "John",
                LastName = "Johnowski",
                Birthdate = new DateTime(1999, 1, 1),
                Studies = "Computer Science"
            }, new Student
            {
                IdStudent = 3,
                FirstName = "John",
                LastName = "Johnowski",
                Birthdate = new DateTime(1989, 1, 1),
                Studies = "Computer Science"
            }};

        public List<Student> GetStudents()
        {
            return students;
        }
        public Student FindStudent(int idStudent)
        {
            return students.Find(student => student.IdStudent == idStudent);
        }
        public void DeleteStudent(int studentID)
        {
            var student = FindStudent(studentID);
            if (student != null) students.Remove(student);
        }
    }
}
