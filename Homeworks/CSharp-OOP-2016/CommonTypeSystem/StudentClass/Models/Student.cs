namespace StudentClass.Models
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName, int socialSecurityNumber)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = socialSecurityNumber;
        }

        public Student(
            string firstName, 
            string middleName, 
            string lastName, 
            int socialSecurityNumber, 
            string permanentAdress, 
            string mobilePhone, 
            string email)
            : this(firstName, middleName, lastName, socialSecurityNumber)
        {
            this.PermanentAddress = permanentAdress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
        }

        public Student(
                string firstName, 
                string middleName, 
                string lastName, 
                int socialSecurityNumber,
                string permanentAdress, 
                string mobilePhone, 
                string email, 
                string course, 
                Specialty specialty,
                Faculty faculty, 
                University university)
            : this(firstName, middleName, lastName, socialSecurityNumber, permanentAdress, mobilePhone, email)
        {
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public int SSN { get; private set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public Specialty? Specialty { get; set; }

        public Faculty? Faculty { get; set; }

        public University? University { get; set; }

        public override bool Equals(object obj)
        {
            var objAsStdunet = obj as Student;
            if (objAsStdunet != null)
            {
                if (this.FirstName != objAsStdunet.FirstName)
                {
                    return false;
                }

                if (this.MiddleName != objAsStdunet.MiddleName)
                {
                    return false;
                }

                if (this.LastName != objAsStdunet.LastName)
                {
                    return false;
                }

                if (this.SSN != objAsStdunet.SSN)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append($"Name: {this.FirstName} {this.MiddleName} {this.LastName}{Environment.NewLine}");
            result.Append($"SSN: {this.SSN}{Environment.NewLine}");
            result.Append($"Permanent address: {this.PermanentAddress}{Environment.NewLine}");
            result.AppendFormat($"Mobile phone: {this.MobilePhone}{Environment.NewLine}");
            result.AppendFormat($"E-mail: {this.Email}{Environment.NewLine}");
            result.AppendFormat($"Course: {this.Course}{Environment.NewLine}");
            result.AppendFormat($"Specialty: {this.Specialty}{Environment.NewLine}");
            result.AppendFormat($"University: {this.University}{Environment.NewLine}");
            result.AppendFormat($"Faculty: {this.Faculty}{Environment.NewLine}");
            return result.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Equals(firstStudent, secondStudent);
        }

        public object Clone()
        {
            var cloned = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN);
            cloned.PermanentAddress = this.PermanentAddress;
            cloned.MobilePhone = this.MobilePhone;
            cloned.Email = this.Email;
            cloned.Course = this.Course;
            cloned.Specialty = this.Specialty;
            cloned.University = this.University;
            cloned.Faculty = this.Faculty;
            return cloned;
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }

            if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }

            if (this.LastName.CompareTo(otherStudent.LastName) != 0)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }

            if (this.SSN.CompareTo(otherStudent.SSN) != 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return 0;
        }
    }
}
