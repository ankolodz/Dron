using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DronApp
{
    public class GyroscopeDrawUtil
    {
        public static void drawGyroscope(PictureBox gyroscop, byte x, byte y)
        {
            Image image = new Bitmap("horyzont.png");
            //image.RotateFlip(x);

            Bitmap flag = new Bitmap(250, 250);
            Graphics flagGraphics = Graphics.FromImage(flag);
      

            flagGraphics.DrawImage(image, new Rectangle(-75, -75 + y, 400, 400));
            drawHorisontLine(flagGraphics);

            gyroscop.Image = flag;
        }
        private static void drawHorisontLine(Graphics flagGraphics)
        {
            Pen horisontPen = new Pen(Parameters.rudderNeutralPosition);
            horisontPen.Width = 4.0F;
            flagGraphics.DrawLine(horisontPen, new Point(0, 123), new Point(255, 123));

        }
    }
}
