namespace School.Models
{
    using System.Collections.Generic;
    using Interfaces;
    using Common;

    public class School : IComment
    {
        private IList<Student> students;
        private IList<Teacher> teachers;

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
            Validator.ValidateNull(student, Messages.STUDENT_CANNOT_BE_NULL);
            this.students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Validator.ValidateNull(teacher, Messages.TEACHER_CANNOT_BE_NULL);
            this.teachers.Add(teacher);
        }

        public void RemoveStudent(Student student)
        {
            Validator.ValidateNull(student, Messages.STUDENT_CANNOT_BE_NULL);
            this.students.Remove(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            Validator.ValidateNull(teacher, Messages.TEACHER_CANNOT_BE_NULL);
            this.teachers.Remove(teacher);
        }

        public string Comment { get; set; }
    }
}
