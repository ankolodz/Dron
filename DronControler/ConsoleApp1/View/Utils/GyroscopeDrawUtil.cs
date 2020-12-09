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
        private Image background;
        private Image image;
        private Image indicator;
        private PictureBox gyroscop;
        private PictureBox gyroFrame;

        public GyroscopeDrawUtil(PictureBox gyroscop, PictureBox gyroFrame)
        {
            this.background = Image.FromFile("horyzontBackground.png");
            this.image = Image.FromFile("horyzont.png");
            this.indicator = Image.FromFile("indicator.png");
            this.gyroscop = gyroscop;
            this.gyroFrame = gyroFrame;
        }

        public void drawGyroscope(Gyroscope gyroscopeParts)
        {
            int x = (int)gyroscopeParts.getX();
            int y = (int)gyroscopeParts.getY();

            y = Math.Min(y, 20);
            y = Math.Max(y, -20);

            if (Math.Abs(x) > 30 || Math.Abs(y) > 15)
                setBackgroundAlert();
            else
                setBackgroundNeutral();          

            Bitmap flag = new Bitmap(250, 250);
            Graphics g = Graphics.FromImage(flag);

            g.DrawImage(background, new Rectangle(0, 0, 250, 250));

            g.TranslateTransform(125, 125);
            g.RotateTransform(-x);
            g.TranslateTransform(-125, -125);

            g.DrawImage(image, new Rectangle(-75, -75 + pixelFromDag(y), 400, 400));

            g.TranslateTransform(125, 125);
            g.RotateTransform(x);
            g.TranslateTransform(-125, -125);

            g.DrawImage(indicator, new Rectangle(0, 0, 250, 250));


            gyroscop.Image = flag;
        }

        private void setBackgroundNeutral()
        {
            if (gyroFrame.BackColor != Parameters.okState)
                gyroFrame.BackColor = Parameters.okState;
        }

        private void setBackgroundAlert()
        {
            if (gyroFrame.BackColor == Parameters.dangerState1)
                gyroFrame.BackColor = Parameters.dangerState2;
            else
                gyroFrame.BackColor = Parameters.dangerState1;
        }

        private int pixelFromDag (int y)
        {
            return -y * 10; //1 dag = 10 px
        }
    }
}
