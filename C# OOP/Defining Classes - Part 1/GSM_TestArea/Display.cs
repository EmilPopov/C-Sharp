using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_TestArea
{
    public class Display
    {
        private double size;
        private double numberOfColors;
        public Display(double displaySize,double displayNumberOfColors)
        {
            this.Size = displaySize;
            this.NumberOfColors = displayNumberOfColors;
        }

        public double NumberOfColors
        {
            get { return numberOfColors; }
            set { this.numberOfColors= value; }
        }
        
        public double Size
        {
            get { return size; }
            set { this.size = value; }
        }
        
    }
}
