namespace School.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class School : IComment
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public School(string identifier)
        {
            this.Identifier = identifier;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public School(string identifier, string comment)
            : this(identifier)
        {
            this.Comment = comment;
        }

        public string Identifier { get; set; }

        public List<Student> GetStudents()
        {
            return new List<Student>(this.students);
        }

        public List<Teacher> GetTeachers()
        {
            return new List<Teacher>(this.teachers);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public string Comment { get; set; }
    }
}
