using System;
using System.Text;

namespace GSM
{
    public class Call
    {
        public DateTime DateTime { get; set; }
        public string DialedNumber { get; set; }
        public int Duration { get; set; }
        
        public Call(DateTime dateTime, string dialedNumber, int duration)
        {
            this.DateTime = dateTime;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("Date: {0}.{1}.{2}", DateTime.Day, DateTime.Month, DateTime.Year));
            sb.Append(String.Format("\r\nTime: {0}:{1}:{2}", DateTime.Hour, DateTime.Minute, DateTime.Second));
            sb.Append(String.Format("\r\nDialed number: {0}", DialedNumber));
            sb.Append(String.Format("\r\nDuration: {0} sec", Duration));
            sb.Append("\r\n---------------------------------");

            return sb.ToString();
        }
    }
}
