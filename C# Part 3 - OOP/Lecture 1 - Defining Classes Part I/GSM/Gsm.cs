using System;
using System.Collections.Generic;
using System.Text;

namespace GSM
{
    public class Gsm
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public static Gsm IPhone4S = new Gsm("4S", "iPhone", 1023.4M, "Mila", 
            new Battery("AZ-4M", 128.5, 32.4, BatteryType.LiIon), new Display("1024 x 768", 256000));

        public Gsm(string model, string manufacturer, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get { return this.model; }

            set
            {
                if (value.Length > 1)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Invalid GSM model!");
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }

            set
            {
                if (value.Length > 1)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Invalid manufacturer!");
                }
            }
        }

        public decimal? Price
        {
            get { return this.price; }

            set
            {
                this.price = value;

                if (this.price < 0)
                {
                    this.price = null;

                    throw new ArgumentException("Price can't be negative!");
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }

            set
            {
                if (value.Length > 1)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("Invalid owner length!");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("Model - {0}", model));
            sb.Append(String.Format("\r\nManufacturer - {0}", manufacturer));

            if (price != null)
            {
                sb.Append(String.Format("\r\nPrice - {0:C}", price));
            }

            if (owner != null)
            {
                sb.Append(String.Format("\r\nOwner - {0}", owner));
            }

            if (battery != null)
            {
                sb.Append(battery.ToString());
            }

            if (display != null)
            {
                sb.Append(display.ToString());
            }

            sb.Append("\r\n---------------------------------");

            return sb.ToString();
        }

        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }

        public void RemoveCall(int index = 0)
        {
            if (index < callHistory.Count)
            {
                callHistory.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Incorrect index, call won't be deleted!");
            }
        }

        public void DeleteCallHistory()
        {
            callHistory.Clear();
        }

        public List<Call> GetCallList()
        {
            return callHistory;
        }

        public decimal CalculateCallsPrice(decimal pricePerMinute)
        {
            decimal duration = 0;

            foreach (var call in callHistory)
            {
                duration += call.Duration;
            }

            duration /= 60;

            return duration * pricePerMinute;
        }

        public int LongestCallIndex()
        {
            int i = 0;
            int index = 0;
            int maxDuration = 0;

            foreach (var call in callHistory)
            {
                if (maxDuration < call.Duration)
                {
                    maxDuration = call.Duration;
                    index = i;
                }

                i++;
            }

            return index;
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        static void Main()
        {
        }
    }
}