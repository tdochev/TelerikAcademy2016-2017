namespace School.Models
{
    using System.Collections.Generic;

    using Common;

    public class Teacher : People
    {
        private IList<Discipline> disciplines;

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
            Validator.ValidateNull(discipline, Messages.DISCIPLINE_CANNOT_BE_NULL);
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            Validator.ValidateNull(discipline, Messages.DISCIPLINE_CANNOT_BE_NULL);
            this.disciplines.Remove(discipline);
        }

        public List<Discipline> GetDisciplines()
        {
            return new List<Discipline>(this.disciplines);
        }
    }
}
