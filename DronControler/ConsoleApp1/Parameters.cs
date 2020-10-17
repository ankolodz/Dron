﻿using System;
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
        public const int engineThreshold = 200;

        //rudder
        public static Brush rudderPosition = Brushes.Blue;
        public static Brush rudderNeutralPosition = Brushes.Red;

        //gyroscop
        public const int zeroGyroMaping = 127;
        public static Color dangerState1 = Color.Red;
        public static Color dangerState2 = Color.OrangeRed;
        public static Color okState = Color.Gray;

        //message
        public const int portRefreshTimout = 100;
        public const int messageSize = 8;
        public const int lostMessageTimeout = 200;
        public const int sleepMessageTime = 1000;
    }

    public class ErrorDebugMessage
    {
        public const string portNotReplyError = "Error connection, port not reply";
        public const string lostConnection = "Error lost connection";
    }
}
