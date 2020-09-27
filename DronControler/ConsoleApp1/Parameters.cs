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
        public static Color engineHighColor = Color.Red;
        public static int engineThreshold = 200;

        //rudder
        public static Brush rudderPosition = Brushes.Blue;
        public static Brush rudderNeutralPosition = Brushes.Red;

        //gyroscop
        public static int zeroGyroMaping = 127;
        public static Color dangerState1 = Color.Red;
        public static Color dangerState2 = Color.OrangeRed;
        public static Color okState = Color.Gray;

    }
}
