namespace Matrix
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]
    public class Version : Attribute
    {
        public Version(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; set; }

        public int Minor { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.Major, this.Minor);
        }
    }
}