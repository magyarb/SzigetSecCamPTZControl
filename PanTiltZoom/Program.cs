/************************************************************************************************************ 
 * OZEKI CAMERA SDK
 * http://www.camera-sdk.com/
 * 
 * Example project
 * Title: PTZ camera motion control
 * Description: This example demonstrates how you can move and zoom with the camera.
 * The moving can happen manually, preset positions or automatic scanning.
 *  
 * Documentation:
 * http://www.camera-sdk.com/p_19-onvif.html
 * 
 * License:
 * This example can be freely used, distributed and modified according to the
 * license agreement at the following webpage: http://camera-sdk.com/p_241-license.html 
 * *********************************************************************************************************/
using System;
using System.Windows.Forms;

namespace _02_PTZ_Camera_Motion_Control
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
