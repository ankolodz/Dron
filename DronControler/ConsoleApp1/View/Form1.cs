using System;
using System.Drawing;
using System.Windows.Forms;
using SlimDX.DirectInput;

namespace DronApp
{
    public partial class Form1 : Form
    {
        private Mediator mediator;
        GyroscopeDrawUtil gyroscopeDrawUtil;


        public Form1()
        {     
            InitializeComponent();
            this.gyroscopeDrawUtil = new GyroscopeDrawUtil(gyroscop, gyroFrame);
        }  

        public void setProxy(Mediator mediator)
        {
            this.mediator = mediator;
        }

        //update
        private void refresh(object sender, EventArgs e)
        {
            gyroscopeDrawUtil.drawGyroscope(mediator.getMachine().gyroscope);
            updateThrotle(mediator.getMachine().flyController.getThrotle());
            updateEngine(mediator.getMachine().engine.getEngineState());
            updaterRudder(mediator.getMachine().flyController.getHorizontalDirection(), mediator.getMachine().flyController.getVerticalDirection());
            updateAirSensor(mediator.getMachine().airSensors);
            connection(mediator.getState());
            mediator.getMachine().sendToReal();
            update.Interval = mediator.getSleepTime();
            Refresh();

        }

        private void updateAirSensor(AirSensorsManager airSensors)
        {
            this.PM10.Text = airSensors.getPM10().ToString();
            this.PM25.Text = airSensors.getPM25().ToString();
            this.temp.Text = airSensors.getTemp().ToString();
        }

        private void ThrotleHendler(object sender, System.Windows.Forms.KeyEventArgs e) {
            switch (e.KeyCode)
            {
                case Keys.A:
                    mediator.getMachine().flyController.upThrotle();
                    break;
                case Keys.Z:
                    mediator.getMachine().flyController.downThrotle();
                    break;
                case Keys.D1:
                    mediator.getMachine().start(false);
                    break;
                case Keys.Q:
                    mediator.getMachine().start(true);
                    break;
                default:
                    mediator.getMachine().STOP();
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
           mediator.getMachine().STOP();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.mediator.getMachine().refreshAirSensor();
        }

        private void autoAirBtnClick(object sender, EventArgs e)
        {
            this.airTimer.Enabled = !this.airTimer.Enabled;
            State state = this.airTimer.Enabled
                ? State.auto
                : State.active;
            IcoUtils.setState(sensorIco, state);
        }

        private void singleRefreshAirSensorBtn(object sender, EventArgs e)
        {
            this.mediator.getMachine().refreshAirSensor();
        }
    };
}
