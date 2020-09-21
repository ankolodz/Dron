using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DronApp
{
    public class Parameters
    {
        //engine 
        public static Color engineLowColor = Color.LimeGreen;
        public static Color engineHighColor = Color.OrangeRed;
        public static int engineThreshold = 200;

        //rudder
        public static Brush rudderPosition = Brushes.Blue;
        public static Brush rudderNeutralPosition = Brushes.Red;


    }
}
