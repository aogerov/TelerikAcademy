using System;
using System.Text;

namespace GSM
{
    public class Display
    {
        private string size;
        private int? numberOfColors;

        public Display(string size = null, int? numberOfColors = null)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public string Size
        {
            get { return this.size; }

            set
            {
                if (value.Length > 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException("Too small size!");
                }

            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                this.numberOfColors = value;

                if (this.numberOfColors < 16)
                {
                    this.numberOfColors = null;

                    throw new ArgumentException("Invalid number of colors!");
                }

            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (size != null)
            {
                sb.Append(String.Format("\r\nDisplay: \r\n\tsize - {0}", size));
            }

            if (numberOfColors != null)
            {
                sb.Append(String.Format("\r\n\tnumber of colors - {0}", numberOfColors));
            }

            return sb.ToString();
        }
    }
}