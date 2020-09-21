using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DronApp
{
    public class RudderDrawUtil
    {
        public static void refreshRudder(PictureBox vertical, PictureBox horizontal, byte x, byte y)
        {
            x -= 80;
            y -= 80;
            Pen actualPenPosition = new Pen(Parameters.rudderPosition);
            actualPenPosition.Width = 2.0F;
            Pen neutralPenPosition = new Pen(Parameters.rudderNeutralPosition);
            neutralPenPosition.Width = 2.0F;

            Bitmap flagY = new Bitmap(25, 160);
            Graphics yGraphic = Graphics.FromImage(flagY);
            Bitmap flagX = new Bitmap(160, 25);
            Graphics xGraphic = Graphics.FromImage(flagX);

            yGraphic.DrawLine(actualPenPosition, new Point(0, 80), new Point(25, 80));
            yGraphic.DrawLine(neutralPenPosition, new Point(0, y * 2), new Point(25, y * 2));

            xGraphic.DrawLine(actualPenPosition, new Point(80, 0), new Point(80, 25));
            xGraphic.DrawLine(neutralPenPosition, new Point(x * 2, 0), new Point(x * 2, 25));

            vertical.Image = flagY;
            horizontal.Image = flagX;
        }
    }
}
