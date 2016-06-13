namespace DefiningClassesPartOne.Models
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class GSM
    {
        private static string iPhone4S = "Some specail info about the iPhone 4s";

        private decimal? price;
        private string model;
        private string manufacturer;
        private string owner;
        private Battery batterySpec;
        private Display display;
        private List<Call> callHistory;

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                this.CheckLenght(2, value);
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            private set
            {
                this.CheckLenght(2, value);
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid Price!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            private set
            {
                if (value != null)
                {
                    this.CheckLenght(2, value);
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.batterySpec;
            }

            set
            {
                this.batterySpec = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public string IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal GetCallsPrice(decimal pricePerMinute)
        {
            decimal result = 0;
            if (pricePerMinute < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            foreach (var call in this.callHistory)
            {
                result += call.Duration * pricePerMinute / 60;
            }
            return result;
        }

        public GSM(string model, string manufacturer, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo prop in typeof(GSM).GetProperties())
            {
                if (prop.GetValue(this) != null && prop.Name != "IPhone4S" && prop.Name != "CallHistory")
                {
                    sb.Append(prop.Name + ": " + prop.GetValue(this));
                    sb.Append(Environment.NewLine);
                }

                if (prop.GetValue(this) != null && prop.Name == "IPhone4S" && this.model == "iPhone 4s")
                {
                    sb.Append(prop.GetValue(this));
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        private void CheckLenght(int lenght, string value)
        {
            if (value.Length < lenght)
            {
                throw new Exception(string.Format("The lenght must be at least {0} symbols!", lenght));
            }
        }
    }
}
