namespace DefiningClassesPartOne.Models
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Display
    {
        decimal? size;
        ulong? numberOfColors;

        public Display(decimal? size, ulong? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public decimal? Size
        {
            get
            {
                return this.size;
            }
            
            private set
            {
                if (value < 0)
                {
                    value *= -1;
                }
                else if (value == 0)
                {
                    this.size = null;
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public ulong? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            
            private set
            {
                if (value < 0)
                {
                    value *= Convert.ToUInt64(-1);
                }
                else if (value == 0)
                {
                    this.numberOfColors = null;
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        public override string ToString()
        {
             StringBuilder sb = new StringBuilder(Environment.NewLine);
            foreach (PropertyInfo prop in typeof(Display).GetProperties())
            {
                if (prop.GetValue(this) != null)
                {
                    sb.Append("\t" + prop.Name + ": " + prop.GetValue(this));
                    sb.Append(Environment.NewLine);
                }
            }
            
            return sb.ToString();
        }
    }
}
