namespace Group
{
    using System.Collections.Generic;
    
    public class Group
    {
        public int GroupNumber
        {
            get;
            private set;
        }

        public string DepartmentName
        {
            get;
            private set;
        }

        public Group(int groupNumber, string departmentName)
        {

            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }

    public class TestList
    {
        public static List<Group> MyGroupsList = new List<Group>
            {
                new Group (1, "Programing"),
                new Group (2, "Physics"),
                new Group (3, "Mathematics")
            };
    }
}