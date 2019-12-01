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
        public Machine machine;
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Initialized");
            Engine1.Maximum = 255;
            Engine2.Maximum = 255;
            Engine3.Maximum = 255;
            Engine4.Maximum = 255;

        }
        public void setMachine(Machine machine)
        {
            this.machine = machine;
        }

        public void SetEnginePower(byte E1,byte E2,byte E3,byte E4)        {
            
            Engine1.Value = E1;
            Engine2.Value = E2;
            Engine3.Value = E3;
            Engine4.Value = E4;

            Engine1State.Text = (E1 / 255).ToString();
            Engine2State.Text = (E2 / 255).ToString();
            Engine3State.Text = (E3 / 255).ToString();
            Engine4State.Text = (E4 / 255).ToString();

            Refresh();
        }

        private void PanicButton_Click(object sender, EventArgs e)
        {
            machine.STOP();
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
