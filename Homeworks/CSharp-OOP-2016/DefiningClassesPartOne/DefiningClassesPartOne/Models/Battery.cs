namespace DefiningClassesPartOne.Models
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery(string model, int? hoursIdle = null, int? hoursTalk = null)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;

        }

        public Battery(string model, BatteryType batteryType, int? hoursIdle = null, int? hoursTalk = null)
        : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid hours idle");
                }
                
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid hours talk");
                }
                
                this.hoursTalk = value;
            }
        }

        public BatteryType? BatteryType
        {
            get;
            private set;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Environment.NewLine);
            foreach (PropertyInfo prop in typeof(Battery).GetProperties())
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

    public enum BatteryType
    {
        NiCd,
        NiMH,
        Li_Ion,
        Li_Ion_Polymer,
    }
}