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
        private Machine machine;
/*        private DirectInput joystick = new DirectInput();
        SlimDX.DirectInput.Joystick stick;
        Jou
  */  
        
        public Form1()
        {
            
            InitializeComponent();
            Engine1.Maximum = 255;
            Engine2.Maximum = 255;
            Engine3.Maximum = 255;
            Engine4.Maximum = 255;
            Throtle.Maximum = 255;
            //gyroscop = new PictureBox();

            SetGyroscope(125, 125);

        }
        public void setMachine(Machine machine)
        {
            this.machine = machine;
        }

        public void SetEnginePower(byte[] arr)
        {

            Engine1.Value = arr[0];
            Engine2.Value = arr[1];
            Engine3.Value = arr[2];
            Engine4.Value = arr[3];

            Engine1State.Text = (arr[0] * 100 / 255).ToString() + "%";
            Engine2State.Text = (arr[1] * 100 / 255).ToString() + "%";
            Engine3State.Text = (arr[2] * 100 / 255).ToString() + "%";
            Engine4State.Text = (arr[3] * 100 / 255).ToString() + "%";

            Refresh();
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
        public void SetThrotle(byte t)
        {
            Throtle.Value = t;
            ThrotleState.Text = (t * 100 / 255).ToString() + "%";
            Refresh();
        }
        public void SetRudder(byte y,byte x)
        {
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
            machine.STOP();
            machine.flyController.STOP();

        }


        private void Override_Click(object sender, EventArgs e)
        {
            if (machine.engine.getManualState())
            {
                machine.engine.manualOFF();
                OverideControl.Value = 0;
            }
            else
            {
                machine.engine.manualON();
                OverideControl.Value = 100;
            }

        }
        private void ThrotleHendler(object sender, KeyEventArgs e)
        {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        machine.flyController.upThrotle();
                        break;
                    case Keys.X:
                        machine.flyController.downThrotle();
                        break;
                    case Keys.W:
                        machine.flyController.upRudder();
                        break;
                    case Keys.S:
                        machine.flyController.downRudder();
                        break;
                    case Keys.A:
                        machine.flyController.leftRudder();
                        break;
                    case Keys.D:
                        machine.flyController.rightRudder();
                        break;
                    default:
                        machine.STOP();
                        break;

                }

            SetThrotle(machine.flyController.getThrotle());
            SetEnginePower(machine.engine.getEngineState());
            SetRudder(machine.flyController.getVerticalDirection(), machine.flyController.getHorizontalDirection());
            System.Threading.Thread.Sleep(100);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetEnginePower(machine.engine.getEngineState());
            
            if (!machine.engine.getManualState())
            {
                machine.flyController.sendFlyController();
            }
                
      
                
            
        }

    };
}
