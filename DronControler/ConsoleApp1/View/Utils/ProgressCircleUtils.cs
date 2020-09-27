using System;
using System.Drawing;

namespace DronApp
{
    public class ProgressCircleUtils
    {
        public static void setEngineValue(int val, CircularProgressBar.CircularProgressBar engine)
        {
            if (val >= Parameters.engineThreshold)
                engine.ProgressColor = Parameters.engineHighColor;
            else
                engine.ProgressColor = Parameters.engineLowColor;

            engine.Value = val;
            engine.SubscriptText = (val * 100 / 255).ToString();
        }
    }
}
