using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimDX.DirectInput;

namespace DronApp
{
    public partial class Form1 : Form
    {
        private Proxy proxy;


        public Form1()
        {

            InitializeComponent();

            //gyroscop = new PictureBox();
            SetGyroscope(125, 125);

        }


        public void setProxy(Proxy proxy)
        {
            this.proxy = proxy;
        }

        //update
        private void Timer1_Tick(object sender, EventArgs e)
        {
            updateThrotle(proxy.getMachine().flyController.getThrotle());
            updateEngine(proxy.getMachine().engine.getEngineState());
            updaterRudder(proxy.getMachine().flyController.getHorizontalDirection(), proxy.getMachine().flyController.getVerticalDirection());
            connection(proxy.getUDP().getState());
            proxy.getMachine().sendToReal();
            update.Interval = proxy.getSleepTime();

        }

        private void ThrotleHendler(object sender, System.Windows.Forms.KeyEventArgs e) {
            switch (e.KeyCode)
            {
                case Keys.A:
                    proxy.getMachine().flyController.upThrotle();
                    break;
                case Keys.Z:
                    proxy.getMachine().flyController.downThrotle();
                    break;
                case Keys.D1:
                    proxy.getMachine().start(false);
                    break;
                case Keys.Q:
                    proxy.getMachine().start(true);
                    break;
                default:
                    proxy.getMachine().STOP();
                    break;

            }
        }    

public void updateEngine(byte[] arr)
        {

            Engine1.Value = arr[0];
            Engine2.Value = arr[1];
            Engine3.Value = arr[2];
            Engine4.Value = arr[3];

            if (arr[0] >= 200)
                Engine1.ProgressColor = Color.OrangeRed;
            else
                Engine1.ProgressColor = Color.LimeGreen;

            if (arr[1] >= 200)
                Engine2.ProgressColor = Color.OrangeRed;
            else
                Engine2.ProgressColor = Color.LimeGreen;

            if (arr[2] >= 200)
                Engine3.ProgressColor = Color.OrangeRed;
            else
                Engine3.ProgressColor = Color.LimeGreen;

            if (arr[3] >= 200)
                Engine4.ProgressColor = Color.OrangeRed;
            else
                Engine4.ProgressColor = Color.LimeGreen;

            Engine1.SubscriptText = (arr[0] * 100 / 255).ToString();
            Engine2.SubscriptText = (arr[1] * 100 / 255).ToString();
            Engine3.SubscriptText = (arr[2] * 100 / 255).ToString();
            Engine4.SubscriptText = (arr[3] * 100 / 255).ToString();

            Refresh();
        }
        public void updateThrotle(byte t)
        {
            Throtle.Value = t;
            Throtle.SubscriptText = (t * 100 / 255).ToString();
            Refresh();
        }

        public void connection(State state)
        {          
            IcoUtils.setState(connectionIco, state);
        }


        public void SetGyroscope(int x, int y)
        {
            x = 255 - x;
            
            //this.Controls.Add(gyroscop);
            Bitmap flag = new Bitmap(255, 255);
            Graphics flagGraphics = Graphics.FromImage(flag);

            //horyzont
            flagGraphics.FillRectangle(Brushes.LightSkyBlue, 0, 0, 255, 255);
            flagGraphics.FillRectangle(Brushes.Brown, 0, x, 255, 255);

            //wskaźniki osY
           // flagGraphics.FillRectangle(Brushes.Black, 63, x-, 255, 255);
           // flagGraphics.FillRectangle(Brushes.Black, 0, x, 255, 255);

            // flagGraphics.FillRectangle(Brushes.Black, x, 0, 5, 250);
            //flagGraphics.FillRectangle(Brushes.Black, 0, y, 250, 5);
            flagGraphics.FillRectangle(Brushes.Red, 123, 123, 9, 9);

            gyroscop.Image = flag;
            Refresh();
        }

        public void updaterRudder(byte x,byte y)
        {
            x -= 80;
            y -= 80;
            Pen bluePen = new Pen(Brushes.Blue);
            bluePen.Width = 2.0F;
            Pen redPen = new Pen(Brushes.Red);
            redPen.Width = 2.0F;

            Bitmap flagY = new Bitmap(25, 160);
            Graphics yGraphic = Graphics.FromImage(flagY);
            Bitmap flagX = new Bitmap(160, 25);
            Graphics xGraphic = Graphics.FromImage(flagX);

            yGraphic.DrawLine(bluePen,new Point(0,80),new Point(25,80));
            yGraphic.DrawLine(redPen, new Point(0, y*2), new Point(25, y*2));

            xGraphic.DrawLine(bluePen, new Point(80, 0), new Point(80, 25));
            xGraphic.DrawLine(redPen, new Point(x*2, 0), new Point(x*2, 25));

            vertical.Image = flagY;
            horizontal.Image = flagX;
        }

        private void PanicButton_Click(object sender, EventArgs e)
        {
            proxy.getMachine().STOP();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    };
}
