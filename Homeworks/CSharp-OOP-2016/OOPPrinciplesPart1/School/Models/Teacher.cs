namespace School.Models
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Discipline>();
        }
        public Teacher(string name, string comment) : base(name,comment)
        {
            this.disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public List<Discipline> GetDiscipline()
        {
            return new List<Discipline>(this.disciplines);
        }
    }
}
