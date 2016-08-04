using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using _02_PTZ_Camera_Motion_Control.LOG;
using System.Collections.Generic;
using SlimDX.DirectInput;
using SlimDX;

namespace _02_PTZ_Camera_Motion_Control
{
    public partial class MainForm : Form
    {
        //private IpCameraHandler _model;
        Joystick pad;
        JoystickState state;
        IpCameraHandler[] kamerak = new IpCameraHandler[10];
        bool stopped = false;
        public int selectedcamera = 0;

        private CameraURLBuilderWF _myCameraUrlBuilder;

        public MainForm()
        {
            InitializeComponent();
            Log.OnLogMessageReceived += Log_OnLogMessageReceived;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DeviceInstance joystick = null;
                DirectInput dinput = new DirectInput();
                foreach (DeviceInstance di in dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
                {
                    if (di.InstanceName.Equals("T.Flight Hotas X"))
                    {
                        joystick = di;
                    }
                }
                pad = new Joystick(dinput, joystick.InstanceGuid);
                foreach (DeviceObjectInstance doi in pad.GetObjects(ObjectDeviceType.Axis))
                {
                    pad.GetObjectPropertiesById((int)doi.ObjectType).SetRange(-5000, 5000);
                }

                pad.Properties.AxisMode = DeviceAxisMode.Absolute;
                //pad.SetCooperativeLevel(parent, (CooperativeLevel.Nonexclusive | CooperativeLevel.Background));
                pad.Acquire();
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lehet, hogy be kéne dugni a dildót.","Má megin gyökér vagy!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Close();
            }


            _myCameraUrlBuilder = new CameraURLBuilderWF();

            InitializeViewer();

        }
        private void poll()
        {
            state = new JoystickState();
            Result r = pad.Poll();
            pad.GetCurrentState(ref state);
            /*result.X = state.X / 5000.0f;
            result.Y = state.Y / 5000.0f;
            int ispressed = 0;
            bool[] buttons = state.GetButtons();*/
        }
        private void InitializeViewer()
        {
            ControlToCenter();
        }

        private void ModelCameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                IpCameraHandler curr = (IpCameraHandler)sender;
                Log.Write(curr.Camera.CameraAddress.ToString() + " : " + e.State);
            });
        }

        private void GetCameraStreams(IpCameraHandler _model)
        {
        }

        private void ModelCameraErrorOccured(object sender, CameraErrorEventArgs e)
        {
            InvokeGuiThread(() => Log.Write("Camera error: " + (e.Details ?? e.Error.ToString())));
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = new LinkLabel.Link { LinkData = "http://www.camera-sdk.com/" };

            if (link.LinkData != null) Process.Start(link.LinkData as string);
        }

        #region Connect - Disconnect

        private void button_Connect_Click(object sender, EventArgs e)
        {
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {

        }

        private void ConnectIpCam()
        {

        }

        #endregion

        #region LOG

        void Log_OnLogMessageReceived(object sender, LogEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                logListBox.Items.Add(e.LogMessage);
                LogScroll();
            });
        }

        void LogScroll()
        {
            logListBox.SelectedIndex = logListBox.Items.Count - 1;
            logListBox.SelectedIndex = -1;
        }

        #endregion



        private void ClearFields()
        {

        }

        #region Stream select

        private void StreamCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo == null || combo.SelectedIndex == -1) return;

            /*var CurrentStream = _model.Camera.AvailableStreams[StreamCombo.SelectedIndex];
            if (CurrentStream == null) throw new ArgumentNullException("Stream");
            Log.Write("Camera changed stream to " + CurrentStream.Name);

            _model.Camera.Start(CurrentStream);

            InvokeGuiThread(() =>
            {
                DetailsText.Text = _model.GetDeviceInfo();
                AudioInfoText.Text = _model.StreamInfoAudio();
                VideoInfoText.Text = _model.StreamInfoVideo();
            });*/
        }
        #endregion

        #region Image Size
        private void applyButton_Click(object sender, EventArgs e)
        {
        }

        void ControlToCenter()
        {

        }

        #endregion


        #region Image Settings

        private void TrackbarPropertiesScroll(object sender, EventArgs e)
        {

        }

        private void RefreshTrackBars()
        {

        }

        private void RefreshFrameRate()
        {

        }

        private void InitializeTrackBars()
        {

        }

        #endregion

        private void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }

        private void Flip(object sender, EventArgs e)
        {
        }

        private void move()
        {
            //if (button != null) _model.Move(button.Text);
        }

        private void MouseDownMove(object sender, MouseEventArgs e)
        {

        }

        private void MouseUpMove(object sender, MouseEventArgs e)
        {

        }

        private void button_Home_Click(object sender, EventArgs e)
        {

        }

        private void button_SetHome_Click(object sender, EventArgs e)
        {

        }

        private void button_AddPreset_Click(object sender, EventArgs e)
        {

        }

        private void button_PresetMove_Click(object sender, EventArgs e)
        {

        }

        private void button_PresetDelete_Click(object sender, EventArgs e)
        {

        }

        private void button_ScanStart_Click(object sender, EventArgs e)
        {

        }

        private void button_ScanStop_Click(object sender, EventArgs e)
        {

        }

        private void btn_compose_Click(object sender, EventArgs e)
        {

        }

        private void button_Right_Click(object sender, EventArgs e)
        {
        }

        private void button_Left_Click(object sender, EventArgs e)
        {

        }

        private void button_Down_Click(object sender, EventArgs e)
        {

        }

        private void button_ZoomIn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            poll();
            bool[] buttons = state.GetButtons();
            for (int i = 0; i <= 8; i++)
            {
                if (buttons[i])
                    selectedcamera = i+1;
            }
            label8.Text = selectedcamera.ToString();
            if (selectedcamera != 0)
            {
                
                int xsp = (state.X) / 625;
                int ysp = (state.Y) / 625;
                int zsp = (state.Z) / 625;

                if (xsp > 0)
                {
                    stopped = false;

                    SetSpeed(kamerak[selectedcamera], xsp);
                    kamerak[selectedcamera].Camera.CameraMovement.ContinuousMove(MoveDirection.Right);
                }
                else if (xsp < 0)
                {
                    stopped = false;

                    SetSpeed(kamerak[selectedcamera], xsp * -1);

                    kamerak[selectedcamera].Camera.CameraMovement.ContinuousMove(MoveDirection.Left);
                }
                else if (ysp > 0)
                {
                    stopped = false;

                    SetSpeed(kamerak[selectedcamera], ysp);

                    kamerak[selectedcamera].Camera.CameraMovement.ContinuousMove(MoveDirection.Up);
                }
                else if (ysp < 0)
                {
                    stopped = false;

                    SetSpeed(kamerak[selectedcamera], ysp * -1);
                    kamerak[selectedcamera].Camera.CameraMovement.ContinuousMove(MoveDirection.Down);
                }
                else if (zsp < 0)
                {
                    stopped = false;

                    kamerak[selectedcamera].Camera.CameraMovement.ZoomSpeed = ((float)zsp / -8);
                    kamerak[selectedcamera].Camera.CameraMovement.Zoom(MoveDirection.In);
                }
                else if (zsp > 0)
                {
                    stopped = false;

                    kamerak[selectedcamera].Camera.CameraMovement.ZoomSpeed = ((float)zsp / 8);
                    kamerak[selectedcamera].Camera.CameraMovement.Zoom(MoveDirection.Out);
                }
                else
                {
                    if (!stopped)
                    {
                        kamerak[selectedcamera].Camera.CameraMovement.StopMovement();
                        stopped = true;
                    }
                }
                label2.Text = xsp.ToString() + "\n" + ysp.ToString() + "\n" + zsp.ToString();
                label2.Text += stopped ? "\nstopped" : "\nmoving";
            }




            //timer1.Enabled = false;
        }

        private void SetSpeed(IpCameraHandler cam, int sp)
        {
            cam.Camera.CameraMovement.TiltSpeed = (float)sp / 8;
            cam.Camera.CameraMovement.PanSpeed = (float)sp / 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);

            IpCameraHandler cam = new IpCameraHandler();
            cam.CameraStateChanged += ModelCameraStateChanged;
            cam.CameraErrorOccured += ModelCameraErrorOccured;
            cam.ConnectOnvifCamera("192.168.226.10" + i + ":80;Username=admin;Password=123456;Transport=UDP;");
            kamerak[i] = cam;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string prev = label3.Text;
            string next = "";
            for (int i = 1; i <= 9; i++)
            {
                next += "\n" + i + " : ";
                try
                {
                    next += kamerak[i].Camera.State;
                }
                catch (Exception exex)
                {
                    next += "Not connected.";
                }

            }
            if (!prev.Equals(next))
            { label3.Text = next; }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
