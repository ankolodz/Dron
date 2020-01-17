using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {

        
        //private UART myUart = new UART();
        //myUart.initCOM;
        private Machine machine;//= new Machine(myUart);
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

            //Console.WriteLine(arr[0] + " " + arr[1]);

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
        public void SetThrotle (byte t)
        {
            Throtle.Value = t;
            ThrotleState.Text = (t * 100 / 255).ToString() + "%";
            Refresh();
        }

        private void PanicButton_Click(object sender, EventArgs e)
        {
            machine.STOP();
            machine.throtle.STOP();

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
            if (machine.engine.getManualState())
                switch (e.KeyCode)
                {
                    case Keys.A:
                        machine.throtle.upThrotle();
                        break;
                    case Keys.Z:
                        machine.throtle.downThrotle();
                        break;
                    case Keys.D1:
                        machine.engine.upEnginePower(5);
                        break;
                    case Keys.D2:
                        machine.engine.upEnginePower(1);
                        break;
                    case Keys.D3:
                        machine.engine.upEnginePower(2);
                        break;
                    case Keys.D4:
                        machine.engine.upEnginePower(3);
                        break;
                    case Keys.D5:
                        machine.engine.upEnginePower(4);
                        break;

                    case Keys.Q:
                        machine.engine.downEnginePower(5);
                        break;
                    case Keys.W:
                        machine.engine.downEnginePower(1);
                        break;
                    case Keys.E:
                        machine.engine.downEnginePower(2);
                        break;
                    case Keys.R:
                        machine.engine.downEnginePower(3);
                        break;
                    case Keys.T:
                        machine.engine.downEnginePower(4);
                        break;
                    default:
                        machine.engine.STOP();
                        break;
                }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        machine.throtle.upThrotle();
                        break;
                    case Keys.Z:
                        machine.throtle.downThrotle();
                        break;

                }
            }

            SetThrotle(machine.throtle.getThrotle());
            SetEnginePower(machine.engine.getEngineState());
            System.Threading.Thread.Sleep(100);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            SetThrotle(machine.throtle.getThrotle());
            SetEnginePower(machine.engine.getEngineState());
            SetGyroscope(machine.gyroscope.getX(), machine.gyroscope.getY());

            if (!machine.engine.getManualState())
                machine.throtle.sendThrotleStatr();
      
                
            
        }
    };
}
