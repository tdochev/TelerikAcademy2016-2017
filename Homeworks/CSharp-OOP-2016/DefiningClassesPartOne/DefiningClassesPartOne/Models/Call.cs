namespace DefiningClassesPartOne.Models
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime callDateAndTime;
        private string dialledNumber;

        public Call(uint duration, string dialledNumber)
        {
            this.callDateAndTime = DateTime.Now.Subtract(new TimeSpan(0, 0, (int)duration));
            this.Duration = duration;
            this.DialledNumber = dialledNumber;
        }

        public string Date
        {
            get
            {
                return this.callDateAndTime.ToShortDateString();
            }
        }

        public string Time
        {
            get
            {
                return this.callDateAndTime.ToShortTimeString();
            }
        }

        public uint Duration
        {
            get;
            set;
        }

        public string DurationInMinutes
        {
            get
            {
                return string.Format("{0} minutes and {1} seconds", this.Duration / 60, this.Duration % 60);
            }
        }

        public string DialledNumber
        {
            get
            {
                return this.dialledNumber;
            }

            private set
            {
                this.dialledNumber = value;
            }
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Call duration (in seconds): " + this.Duration);
            sb.Append(Environment.NewLine);
            sb.Append("Dialed number: " + this.DialledNumber);
            sb.Append(Environment.NewLine);
            sb.Append("Date: " + this.Date);
            sb.Append(Environment.NewLine);
            sb.Append("Time: " + this.Time);
            return sb.ToString();
        }
    }
}
