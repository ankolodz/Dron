using System;
using System.Drawing;
using System.Windows.Forms;
using SlimDX.DirectInput;

namespace DronApp
{
    public partial class Form1 : Form
    {
        private Mediator proxy;
        GyroscopeDrawUtil gyroscopeDrawUtil;


        public Form1()
        {     
            InitializeComponent();
            this.gyroscopeDrawUtil = new GyroscopeDrawUtil(gyroscop, gyroFrame);
        }  

        public void setProxy(Mediator proxy)
        {
            this.proxy = proxy;
        }

        //update
        private void refresh(object sender, EventArgs e)
        {
            gyroscopeDrawUtil.drawGyroscope(proxy.getMachine().gyroscope);
            updateThrotle(proxy.getMachine().flyController.getThrotle());
            updateEngine(proxy.getMachine().engine.getEngineState());
            updaterRudder(proxy.getMachine().flyController.getHorizontalDirection(), proxy.getMachine().flyController.getVerticalDirection());
            connection(proxy.getState());
            proxy.getMachine().sendToReal();
            update.Interval = proxy.getSleepTime();
            Refresh();

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
            ProgressCircleUtils.setEngineValue(arr[0], Engine1);
            ProgressCircleUtils.setEngineValue(arr[1], Engine2);
            ProgressCircleUtils.setEngineValue(arr[2], Engine3);
            ProgressCircleUtils.setEngineValue(arr[3], Engine4);
        }

        public void updateThrotle(byte t)
        {
            Throtle.Value = t;
            Throtle.SubscriptText = (t * 100 / 255).ToString();
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
        }

        public void updaterRudder(byte x,byte y)
        {
            RudderDrawUtil.refreshRudder(vertical, horizontal, x, y);
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
