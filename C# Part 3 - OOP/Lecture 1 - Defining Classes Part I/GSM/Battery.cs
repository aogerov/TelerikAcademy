using System;
using System.Text;

namespace GSM
{
    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType batteryType;

        public Battery(string model = null, double? hoursIdle = null, double? hoursTalk = null, BatteryType batteryType = BatteryType.NONE)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.batteryType = batteryType;
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
                    throw new ArgumentException("Invalid battery model!");
                }
            }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }

            set
            {
                this.hoursIdle = value;

                if (this.hoursIdle < 1)
                {
                    this.hoursIdle = null;

                    throw new ArgumentException("Invalid idle hours count!");
                }
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }

            set
            {
                this.hoursTalk = value;

                if (this.hoursTalk < 1)
                {
                    this.hoursTalk = null;

                    throw new ArgumentException("Invalid talk hours count!");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (model != null)
            {
                sb.Append(String.Format("\r\nBattery: \r\n\tmodel - {0}", model));
            }

            if (hoursIdle != null)
            {
                sb.Append(String.Format("\r\n\thours idle - {0}", hoursIdle));
            }

            if (hoursTalk != null)
            {
                sb.Append(String.Format("\r\n\thours talk - {0}", hoursTalk));
            }

            if (batteryType != BatteryType.NONE)
            {
                sb.Append(String.Format("\r\n\tbattery type - {0}", batteryType));
            }

            return sb.ToString();
        }
    }
}