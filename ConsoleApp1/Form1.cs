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

            //this.Controls.Add(gyroscop);
            Bitmap flag = new Bitmap(250, 250);
            Graphics flagGraphics = Graphics.FromImage(flag);

            flagGraphics.FillRectangle(Brushes.Black, x, 0, 5, 250);
            flagGraphics.FillRectangle(Brushes.Black, 0, y, 250, 5);

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
        private void ThrotleHendler(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key pressed");
            if (e.KeyCode == Keys.A)  machine.throtle.upThrotle();
            else if (e.KeyCode == Keys.Z) machine.throtle.downThrotle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            machine.refresch();
            
        }
    };
}
