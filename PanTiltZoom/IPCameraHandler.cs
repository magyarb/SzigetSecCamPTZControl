/* 
 * 02_PTZ_Camera_Motion_Control
 * You can set an IP camera and change the camera properties with this application 
 * 
 * IPCameraHandler class controlling the IPCamera object
 * 
 * If you want more information http://www.camera-sdk.com/ check our link. 
 */
using System;
using System.Text;
using Ozeki.Camera;
using Ozeki.Media;

namespace _02_PTZ_Camera_Motion_Control
{
    class IpCameraHandler
    {
        private MediaConnector Connector;

        public OzekiCamera Camera { get; private set; }
        public DrawingImageProvider ImageProvider { get; private set; }

        public event EventHandler<CameraStateEventArgs> CameraStateChanged;
        public event EventHandler<CameraErrorEventArgs> CameraErrorOccured;
       
        public IpCameraHandler()
        {
            ImageProvider = new DrawingImageProvider();
            Connector = new MediaConnector();
        }

        public void ConnectOnvifCamera(string cameraUrl)
        {
            if (Camera != null)
                CloseCamera();

            // Gets the camera, which can be reached by the address, and requires authentication.
            Camera = new OzekiCamera(cameraUrl);

            if (Camera == null) return;
            //Connector.Connect(Camera.VideoChannel, ImageProvider);

            Camera.CameraStateChanged += Camera_CameraStateChanged;
            Camera.CameraErrorOccurred += Camera_CameraErrorOccurred;

            Camera.Start();
            //Camera.Connect();
        }

        private void Camera_CameraErrorOccurred(object sender, CameraErrorEventArgs e)
        {
            // signal to GUI
            var handler = CameraErrorOccured;
            if (handler != null)
                handler(this, e);
        }

        private void Camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            // signal to GUI
            var handler = CameraStateChanged;
            if (handler != null)
                handler(this, e);
        }

        public void Disconnect()
        {
            CloseCamera();
        }

        private void CloseCamera()
        {
            if (Camera == null)
                return;

            Connector.Disconnect(Camera.VideoChannel, ImageProvider);
            Camera.Disconnect();
            Camera.Dispose();
        }

        public void Stop()
        {
            if (Camera != null)
            {
                Connector.Dispose();
                CloseCamera();
                ImageProvider.Dispose();
            }
        }

        public string GetDeviceInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"Firmware - " + Camera.CameraInfo.DeviceInfo.Firmware + "\n");
            sb.AppendLine(@"Hardware ID - " + Camera.CameraInfo.DeviceInfo.HardwareId + "\n");
            sb.AppendLine(@"Manufacture - " + Camera.CameraInfo.DeviceInfo.Manufacturer + "\n");
            sb.AppendLine(@"Model - " + Camera.CameraInfo.DeviceInfo.Model + "\n");
            sb.AppendLine(@"Serial number - " + Camera.CameraInfo.DeviceInfo.SerialNumber + "\n");

            return sb.ToString();
        }

        public string StreamInfoAudio()
        {
            if (Camera.CurrentStream.AudioEncoding == null) return "";
            var sb = new StringBuilder();

            sb.AppendLine(" - Audio Encoding \n");
            sb.AppendLine("\t Bitrate - " + Camera.CurrentStream.AudioEncoding.Bitrate + "\n");
            sb.AppendLine("\t Encoding - " + Camera.CurrentStream.AudioEncoding.Encoding + "\n");
            sb.AppendLine("\t Samplerate - " + Camera.CurrentStream.AudioEncoding.SampleRate + "\n");
            sb.AppendLine("\t Session time out - " + Camera.CurrentStream.AudioEncoding.SessionTimeOut + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.AudioEncoding.UseCount + "\n");

            sb.AppendLine(" - Audio Source \n");
            sb.AppendLine("\t Channels - " + Camera.CurrentStream.AudioSource.Channels + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.AudioSource.UseCount + "\n");

            return sb.ToString();
        }

        public string StreamInfoVideo()
        {
            var sb = new StringBuilder();

            sb.AppendLine(" - Video Encoding \n");
            sb.AppendLine("\t Bitrate - " + Camera.CurrentStream.VideoEncoding.BitRate + "\n");
            sb.AppendLine("\t Encoding - " + Camera.CurrentStream.VideoEncoding.Encoding + "\n");
            sb.AppendLine("\t Encoding interval - " + Camera.CurrentStream.VideoEncoding.EncodingInterval + "\n");
            sb.AppendLine("\t Framerate - " + Camera.CurrentStream.VideoEncoding.FrameRate + "\n");
            sb.AppendLine("\t Quality - " + Camera.CurrentStream.VideoEncoding.Quality + "\n");
            sb.AppendLine("\t Resolution - " + Camera.CurrentStream.VideoEncoding.Resolution + "\n");
            sb.AppendLine("\t Session time out - " + Camera.CurrentStream.VideoEncoding.SessionTimeout + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.VideoEncoding.UseCount + "\n");

            sb.AppendLine(" - Video Source \n");
            sb.AppendLine("\t Bounds - " + Camera.CurrentStream.VideoSource.Bounds + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.VideoSource.UseCount + "\n");

            return sb.ToString();
        }

        public void Move(string direction)
        {
            if (Camera == null) return;
            switch (direction)
            {
                case "Up Left":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.LeftUp);
                    break;
                case "Up":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Up);
                    break;
                case "Up Right":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.RightUp);
                    break;
                case "Left":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Left);
                    break;
                case "Right":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Right);
                    break;
                case "Down Left":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.LeftDown);
                    break;
                case "Down":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.Down);
                    break;
                case "Down Right":
                    Camera.CameraMovement.ContinuousMove(MoveDirection.RightDown);
                    break;
                case "Set home":
                    Camera.CameraMovement.SetHome();
                    break;
                case "In":
                    Camera.CameraMovement.Zoom(MoveDirection.In);
                    break;
                case "Out":
                    Camera.CameraMovement.Zoom(MoveDirection.Out);
                    break;

            }
        }
    }
}
