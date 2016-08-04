using System;
using System.Windows.Forms;

namespace _02_PTZ_Camera_Motion_Control
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.VideoInfoText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AudioInfoText = new System.Windows.Forms.TextBox();
            this.StreamCombo = new System.Windows.Forms.ComboBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.WhiteBalanceCRLabel = new System.Windows.Forms.Label();
            this.TrackBarWhiteBalanceCR = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.FrameRateLabel = new System.Windows.Forms.Label();
            this.WhiteBalanceCBLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TrackBarFrameRate = new System.Windows.Forms.TrackBar();
            this.TrackBarWhiteBalanceCB = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.BackLightLabel = new System.Windows.Forms.Label();
            this.SharpnessLabel = new System.Windows.Forms.Label();
            this.TrackBarBackLight = new System.Windows.Forms.TrackBar();
            this.TrackBarSharpness = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TrackBarSaturation = new System.Windows.Forms.TrackBar();
            this.LabelImage = new System.Windows.Forms.Label();
            this.TrackBarContrast = new System.Windows.Forms.TrackBar();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.VerticalFlipCheck = new System.Windows.Forms.CheckBox();
            this.HorizontalFlipCheck = new System.Windows.Forms.CheckBox();
            this.PTZTab = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button_ScanStop = new System.Windows.Forms.Button();
            this.button_ScanStart = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.comboBox_Direction = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBox_Presets = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button_PresetDelete = new System.Windows.Forms.Button();
            this.button_PresetMove = new System.Windows.Forms.Button();
            this.button_AddPreset = new System.Windows.Forms.Button();
            this.button_SetHome = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_ZoomOut = new System.Windows.Forms.Button();
            this.button_ZoomIn = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button_DownRight = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.button_UpRight = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_DownLeft = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_UpLeft = new System.Windows.Forms.Button();
            this.CameraDetailsBox = new System.Windows.Forms.GroupBox();
            this.DetailsText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.tb_cameraUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_compose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBackLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.PTZTab.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.CameraDetailsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logListBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 497);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event log";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.HorizontalScrollbar = true;
            this.logListBox.Location = new System.Drawing.Point(6, 19);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(438, 108);
            this.logListBox.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.settingsTab);
            this.TabControl.Controls.Add(this.PTZTab);
            this.TabControl.Location = new System.Drawing.Point(468, 108);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(455, 360);
            this.TabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.StreamCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 334);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Streams";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Available";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(6, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(435, 295);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.VideoInfoText);
            this.groupBox7.Location = new System.Drawing.Point(219, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(210, 270);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Video";
            // 
            // VideoInfoText
            // 
            this.VideoInfoText.Location = new System.Drawing.Point(6, 19);
            this.VideoInfoText.Multiline = true;
            this.VideoInfoText.Name = "VideoInfoText";
            this.VideoInfoText.ReadOnly = true;
            this.VideoInfoText.Size = new System.Drawing.Size(198, 244);
            this.VideoInfoText.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AudioInfoText);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // AudioInfoText
            // 
            this.AudioInfoText.Location = new System.Drawing.Point(6, 19);
            this.AudioInfoText.Multiline = true;
            this.AudioInfoText.Name = "AudioInfoText";
            this.AudioInfoText.ReadOnly = true;
            this.AudioInfoText.Size = new System.Drawing.Size(198, 244);
            this.AudioInfoText.TabIndex = 1;
            // 
            // StreamCombo
            // 
            this.StreamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StreamCombo.FormattingEnabled = true;
            this.StreamCombo.Location = new System.Drawing.Point(65, 6);
            this.StreamCombo.Name = "StreamCombo";
            this.StreamCombo.Size = new System.Drawing.Size(370, 21);
            this.StreamCombo.TabIndex = 0;
            this.StreamCombo.SelectedIndexChanged += new System.EventHandler(this.StreamCombo_SelectedIndexChanged);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.groupBox8);
            this.settingsTab.Controls.Add(this.groupBox6);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(447, 334);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.WhiteBalanceCRLabel);
            this.groupBox8.Controls.Add(this.TrackBarWhiteBalanceCR);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.FrameRateLabel);
            this.groupBox8.Controls.Add(this.WhiteBalanceCBLabel);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.TrackBarFrameRate);
            this.groupBox8.Controls.Add(this.TrackBarWhiteBalanceCB);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.BackLightLabel);
            this.groupBox8.Controls.Add(this.SharpnessLabel);
            this.groupBox8.Controls.Add(this.TrackBarBackLight);
            this.groupBox8.Controls.Add(this.TrackBarSharpness);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.SaturationLabel);
            this.groupBox8.Controls.Add(this.ContrastLabel);
            this.groupBox8.Controls.Add(this.brightnessLabel);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.TrackBarSaturation);
            this.groupBox8.Controls.Add(this.LabelImage);
            this.groupBox8.Controls.Add(this.TrackBarContrast);
            this.groupBox8.Controls.Add(this.TrackBarBrightness);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Location = new System.Drawing.Point(4, 54);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(438, 274);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Image adjustment";
            // 
            // WhiteBalanceCRLabel
            // 
            this.WhiteBalanceCRLabel.AutoSize = true;
            this.WhiteBalanceCRLabel.Location = new System.Drawing.Point(400, 205);
            this.WhiteBalanceCRLabel.Name = "WhiteBalanceCRLabel";
            this.WhiteBalanceCRLabel.Size = new System.Drawing.Size(22, 13);
            this.WhiteBalanceCRLabel.TabIndex = 32;
            this.WhiteBalanceCRLabel.Text = "     ";
            // 
            // TrackBarWhiteBalanceCR
            // 
            this.TrackBarWhiteBalanceCR.AutoSize = false;
            this.TrackBarWhiteBalanceCR.Location = new System.Drawing.Point(106, 205);
            this.TrackBarWhiteBalanceCR.Maximum = 1;
            this.TrackBarWhiteBalanceCR.Name = "TrackBarWhiteBalanceCR";
            this.TrackBarWhiteBalanceCR.Size = new System.Drawing.Size(290, 25);
            this.TrackBarWhiteBalanceCR.TabIndex = 31;
            this.TrackBarWhiteBalanceCR.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "White balance CR";
            // 
            // FrameRateLabel
            // 
            this.FrameRateLabel.AutoSize = true;
            this.FrameRateLabel.Location = new System.Drawing.Point(401, 233);
            this.FrameRateLabel.Name = "FrameRateLabel";
            this.FrameRateLabel.Size = new System.Drawing.Size(22, 13);
            this.FrameRateLabel.TabIndex = 29;
            this.FrameRateLabel.Text = "     ";
            // 
            // WhiteBalanceCBLabel
            // 
            this.WhiteBalanceCBLabel.AutoSize = true;
            this.WhiteBalanceCBLabel.Location = new System.Drawing.Point(400, 174);
            this.WhiteBalanceCBLabel.Name = "WhiteBalanceCBLabel";
            this.WhiteBalanceCBLabel.Size = new System.Drawing.Size(22, 13);
            this.WhiteBalanceCBLabel.TabIndex = 28;
            this.WhiteBalanceCBLabel.Text = "     ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Frame rate";
            // 
            // TrackBarFrameRate
            // 
            this.TrackBarFrameRate.AutoSize = false;
            this.TrackBarFrameRate.Location = new System.Drawing.Point(106, 233);
            this.TrackBarFrameRate.Maximum = 100;
            this.TrackBarFrameRate.Name = "TrackBarFrameRate";
            this.TrackBarFrameRate.Size = new System.Drawing.Size(290, 25);
            this.TrackBarFrameRate.TabIndex = 26;
            this.TrackBarFrameRate.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // TrackBarWhiteBalanceCB
            // 
            this.TrackBarWhiteBalanceCB.AutoSize = false;
            this.TrackBarWhiteBalanceCB.Location = new System.Drawing.Point(106, 174);
            this.TrackBarWhiteBalanceCB.Maximum = 1;
            this.TrackBarWhiteBalanceCB.Name = "TrackBarWhiteBalanceCB";
            this.TrackBarWhiteBalanceCB.Size = new System.Drawing.Size(290, 25);
            this.TrackBarWhiteBalanceCB.TabIndex = 25;
            this.TrackBarWhiteBalanceCB.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "White balance CB";
            // 
            // BackLightLabel
            // 
            this.BackLightLabel.AutoSize = true;
            this.BackLightLabel.Location = new System.Drawing.Point(400, 143);
            this.BackLightLabel.Name = "BackLightLabel";
            this.BackLightLabel.Size = new System.Drawing.Size(22, 13);
            this.BackLightLabel.TabIndex = 23;
            this.BackLightLabel.Text = "     ";
            // 
            // SharpnessLabel
            // 
            this.SharpnessLabel.AutoSize = true;
            this.SharpnessLabel.Location = new System.Drawing.Point(400, 112);
            this.SharpnessLabel.Name = "SharpnessLabel";
            this.SharpnessLabel.Size = new System.Drawing.Size(22, 13);
            this.SharpnessLabel.TabIndex = 22;
            this.SharpnessLabel.Text = "     ";
            // 
            // TrackBarBackLight
            // 
            this.TrackBarBackLight.AutoSize = false;
            this.TrackBarBackLight.Location = new System.Drawing.Point(106, 143);
            this.TrackBarBackLight.Maximum = 1;
            this.TrackBarBackLight.Name = "TrackBarBackLight";
            this.TrackBarBackLight.Size = new System.Drawing.Size(290, 25);
            this.TrackBarBackLight.TabIndex = 21;
            this.TrackBarBackLight.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // TrackBarSharpness
            // 
            this.TrackBarSharpness.AutoSize = false;
            this.TrackBarSharpness.Location = new System.Drawing.Point(106, 112);
            this.TrackBarSharpness.Maximum = 1;
            this.TrackBarSharpness.Name = "TrackBarSharpness";
            this.TrackBarSharpness.Size = new System.Drawing.Size(290, 25);
            this.TrackBarSharpness.TabIndex = 20;
            this.TrackBarSharpness.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Sharpness";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Backlight";
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Location = new System.Drawing.Point(400, 86);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(22, 13);
            this.SaturationLabel.TabIndex = 15;
            this.SaturationLabel.Text = "     ";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(401, 57);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(22, 13);
            this.ContrastLabel.TabIndex = 14;
            this.ContrastLabel.Text = "     ";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(400, 26);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(22, 13);
            this.brightnessLabel.TabIndex = 13;
            this.brightnessLabel.Text = "     ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Saturation";
            // 
            // TrackBarSaturation
            // 
            this.TrackBarSaturation.AutoSize = false;
            this.TrackBarSaturation.Location = new System.Drawing.Point(106, 81);
            this.TrackBarSaturation.Maximum = 1;
            this.TrackBarSaturation.Name = "TrackBarSaturation";
            this.TrackBarSaturation.Size = new System.Drawing.Size(290, 25);
            this.TrackBarSaturation.TabIndex = 7;
            this.TrackBarSaturation.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // LabelImage
            // 
            this.LabelImage.Location = new System.Drawing.Point(0, 0);
            this.LabelImage.Name = "LabelImage";
            this.LabelImage.Size = new System.Drawing.Size(100, 23);
            this.LabelImage.TabIndex = 11;
            // 
            // TrackBarContrast
            // 
            this.TrackBarContrast.AutoSize = false;
            this.TrackBarContrast.Location = new System.Drawing.Point(106, 50);
            this.TrackBarContrast.Maximum = 1;
            this.TrackBarContrast.Name = "TrackBarContrast";
            this.TrackBarContrast.Size = new System.Drawing.Size(290, 25);
            this.TrackBarContrast.TabIndex = 3;
            this.TrackBarContrast.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.AutoSize = false;
            this.TrackBarBrightness.Location = new System.Drawing.Point(106, 19);
            this.TrackBarBrightness.Maximum = 1;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(290, 25);
            this.TrackBarBrightness.TabIndex = 2;
            this.TrackBarBrightness.Scroll += new System.EventHandler(this.TrackbarPropertiesScroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Contrast";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Brightness";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.VerticalFlipCheck);
            this.groupBox6.Controls.Add(this.HorizontalFlipCheck);
            this.groupBox6.Location = new System.Drawing.Point(4, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 52);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flip";
            // 
            // VerticalFlipCheck
            // 
            this.VerticalFlipCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.VerticalFlipCheck.AutoSize = true;
            this.VerticalFlipCheck.Location = new System.Drawing.Point(127, 19);
            this.VerticalFlipCheck.Name = "VerticalFlipCheck";
            this.VerticalFlipCheck.Size = new System.Drawing.Size(52, 23);
            this.VerticalFlipCheck.TabIndex = 12;
            this.VerticalFlipCheck.Text = "Vertical";
            this.VerticalFlipCheck.UseVisualStyleBackColor = true;
            this.VerticalFlipCheck.CheckedChanged += new System.EventHandler(this.Flip);
            // 
            // HorizontalFlipCheck
            // 
            this.HorizontalFlipCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.HorizontalFlipCheck.AutoSize = true;
            this.HorizontalFlipCheck.Location = new System.Drawing.Point(19, 19);
            this.HorizontalFlipCheck.Name = "HorizontalFlipCheck";
            this.HorizontalFlipCheck.Size = new System.Drawing.Size(64, 23);
            this.HorizontalFlipCheck.TabIndex = 11;
            this.HorizontalFlipCheck.Text = "Horizontal";
            this.HorizontalFlipCheck.UseVisualStyleBackColor = true;
            this.HorizontalFlipCheck.CheckedChanged += new System.EventHandler(this.Flip);
            // 
            // PTZTab
            // 
            this.PTZTab.Controls.Add(this.groupBox11);
            this.PTZTab.Controls.Add(this.groupBox10);
            this.PTZTab.Controls.Add(this.groupBox4);
            this.PTZTab.Controls.Add(this.groupBox12);
            this.PTZTab.Location = new System.Drawing.Point(4, 22);
            this.PTZTab.Name = "PTZTab";
            this.PTZTab.Padding = new System.Windows.Forms.Padding(3);
            this.PTZTab.Size = new System.Drawing.Size(447, 334);
            this.PTZTab.TabIndex = 3;
            this.PTZTab.Text = "Camera control";
            this.PTZTab.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button_ScanStop);
            this.groupBox11.Controls.Add(this.button_ScanStart);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.textBox_Duration);
            this.groupBox11.Controls.Add(this.comboBox_Direction);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Location = new System.Drawing.Point(12, 218);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(428, 100);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Scanner";
            // 
            // button_ScanStop
            // 
            this.button_ScanStop.Location = new System.Drawing.Point(335, 29);
            this.button_ScanStop.Name = "button_ScanStop";
            this.button_ScanStop.Size = new System.Drawing.Size(75, 23);
            this.button_ScanStop.TabIndex = 6;
            this.button_ScanStop.Text = "Stop";
            this.button_ScanStop.UseVisualStyleBackColor = true;
            this.button_ScanStop.Click += new System.EventHandler(this.button_ScanStop_Click);
            // 
            // button_ScanStart
            // 
            this.button_ScanStart.Location = new System.Drawing.Point(227, 29);
            this.button_ScanStart.Name = "button_ScanStart";
            this.button_ScanStart.Size = new System.Drawing.Size(75, 23);
            this.button_ScanStart.TabIndex = 5;
            this.button_ScanStart.Text = "Scan";
            this.button_ScanStart.UseVisualStyleBackColor = true;
            this.button_ScanStart.Click += new System.EventHandler(this.button_ScanStart_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "seconds";
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(65, 63);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(26, 20);
            this.textBox_Duration.TabIndex = 3;
            // 
            // comboBox_Direction
            // 
            this.comboBox_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Direction.FormattingEnabled = true;
            this.comboBox_Direction.Location = new System.Drawing.Point(65, 26);
            this.comboBox_Direction.Name = "comboBox_Direction";
            this.comboBox_Direction.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Direction.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Duration:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Direction:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBox_Presets);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.button_PresetDelete);
            this.groupBox10.Controls.Add(this.button_PresetMove);
            this.groupBox10.Controls.Add(this.button_AddPreset);
            this.groupBox10.Controls.Add(this.button_SetHome);
            this.groupBox10.Location = new System.Drawing.Point(234, 17);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(206, 177);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Preset";
            // 
            // comboBox_Presets
            // 
            this.comboBox_Presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Presets.FormattingEnabled = true;
            this.comboBox_Presets.Location = new System.Drawing.Point(67, 84);
            this.comboBox_Presets.Name = "comboBox_Presets";
            this.comboBox_Presets.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Presets.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Presets:";
            // 
            // button_PresetDelete
            // 
            this.button_PresetDelete.Location = new System.Drawing.Point(113, 138);
            this.button_PresetDelete.Name = "button_PresetDelete";
            this.button_PresetDelete.Size = new System.Drawing.Size(75, 23);
            this.button_PresetDelete.TabIndex = 3;
            this.button_PresetDelete.Text = "Delete";
            this.button_PresetDelete.UseVisualStyleBackColor = true;
            this.button_PresetDelete.Click += new System.EventHandler(this.button_PresetDelete_Click);
            // 
            // button_PresetMove
            // 
            this.button_PresetMove.Location = new System.Drawing.Point(5, 138);
            this.button_PresetMove.Name = "button_PresetMove";
            this.button_PresetMove.Size = new System.Drawing.Size(75, 23);
            this.button_PresetMove.TabIndex = 2;
            this.button_PresetMove.Text = "Move";
            this.button_PresetMove.UseVisualStyleBackColor = true;
            this.button_PresetMove.Click += new System.EventHandler(this.button_PresetMove_Click);
            // 
            // button_AddPreset
            // 
            this.button_AddPreset.Location = new System.Drawing.Point(113, 20);
            this.button_AddPreset.Name = "button_AddPreset";
            this.button_AddPreset.Size = new System.Drawing.Size(75, 23);
            this.button_AddPreset.TabIndex = 1;
            this.button_AddPreset.Text = "Add preset";
            this.button_AddPreset.UseVisualStyleBackColor = true;
            this.button_AddPreset.Click += new System.EventHandler(this.button_AddPreset_Click);
            // 
            // button_SetHome
            // 
            this.button_SetHome.Location = new System.Drawing.Point(7, 20);
            this.button_SetHome.Name = "button_SetHome";
            this.button_SetHome.Size = new System.Drawing.Size(75, 23);
            this.button_SetHome.TabIndex = 0;
            this.button_SetHome.Text = "Set home";
            this.button_SetHome.UseVisualStyleBackColor = true;
            this.button_SetHome.Click += new System.EventHandler(this.button_SetHome_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_ZoomOut);
            this.groupBox4.Controls.Add(this.button_ZoomIn);
            this.groupBox4.Location = new System.Drawing.Point(175, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(57, 177);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zoom";
            // 
            // button_ZoomOut
            // 
            this.button_ZoomOut.Location = new System.Drawing.Point(7, 122);
            this.button_ZoomOut.Name = "button_ZoomOut";
            this.button_ZoomOut.Size = new System.Drawing.Size(45, 45);
            this.button_ZoomOut.TabIndex = 1;
            this.button_ZoomOut.Text = "Out";
            this.button_ZoomOut.UseVisualStyleBackColor = true;
            this.button_ZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_ZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_ZoomIn
            // 
            this.button_ZoomIn.Location = new System.Drawing.Point(7, 20);
            this.button_ZoomIn.Name = "button_ZoomIn";
            this.button_ZoomIn.Size = new System.Drawing.Size(45, 45);
            this.button_ZoomIn.TabIndex = 0;
            this.button_ZoomIn.Text = "In";
            this.button_ZoomIn.UseVisualStyleBackColor = true;
            this.button_ZoomIn.Click += new System.EventHandler(this.button_ZoomIn_Click);
            this.button_ZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_ZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button_DownRight);
            this.groupBox12.Controls.Add(this.button_Right);
            this.groupBox12.Controls.Add(this.button_UpRight);
            this.groupBox12.Controls.Add(this.button_Down);
            this.groupBox12.Controls.Add(this.button_Home);
            this.groupBox12.Controls.Add(this.button_DownLeft);
            this.groupBox12.Controls.Add(this.button_Left);
            this.groupBox12.Controls.Add(this.button_Up);
            this.groupBox12.Controls.Add(this.button_UpLeft);
            this.groupBox12.Location = new System.Drawing.Point(6, 17);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(162, 177);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Control";
            // 
            // button_DownRight
            // 
            this.button_DownRight.Location = new System.Drawing.Point(109, 122);
            this.button_DownRight.Name = "button_DownRight";
            this.button_DownRight.Size = new System.Drawing.Size(45, 45);
            this.button_DownRight.TabIndex = 8;
            this.button_DownRight.Text = "Down Right";
            this.button_DownRight.UseVisualStyleBackColor = true;
            this.button_DownRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_DownRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Right
            // 
            this.button_Right.Location = new System.Drawing.Point(109, 71);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(45, 45);
            this.button_Right.TabIndex = 7;
            this.button_Right.Text = "Right";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            this.button_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_UpRight
            // 
            this.button_UpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UpRight.Location = new System.Drawing.Point(109, 20);
            this.button_UpRight.Name = "button_UpRight";
            this.button_UpRight.Size = new System.Drawing.Size(45, 45);
            this.button_UpRight.TabIndex = 6;
            this.button_UpRight.Text = "Up Right";
            this.button_UpRight.UseVisualStyleBackColor = true;
            this.button_UpRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_UpRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Down
            // 
            this.button_Down.Location = new System.Drawing.Point(58, 122);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(45, 45);
            this.button_Down.TabIndex = 5;
            this.button_Down.Text = "Down";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Down_Click);
            this.button_Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Home
            // 
            this.button_Home.Location = new System.Drawing.Point(58, 71);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(45, 45);
            this.button_Home.TabIndex = 4;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // button_DownLeft
            // 
            this.button_DownLeft.Location = new System.Drawing.Point(7, 122);
            this.button_DownLeft.Name = "button_DownLeft";
            this.button_DownLeft.Size = new System.Drawing.Size(45, 45);
            this.button_DownLeft.TabIndex = 3;
            this.button_DownLeft.Text = "Down Left";
            this.button_DownLeft.UseVisualStyleBackColor = true;
            this.button_DownLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_DownLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(6, 71);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(45, 45);
            this.button_Left.TabIndex = 2;
            this.button_Left.Text = "Left";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            this.button_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Up
            // 
            this.button_Up.Location = new System.Drawing.Point(58, 20);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(45, 45);
            this.button_Up.TabIndex = 1;
            this.button_Up.Text = "Up";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_UpLeft
            // 
            this.button_UpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UpLeft.Location = new System.Drawing.Point(7, 20);
            this.button_UpLeft.Name = "button_UpLeft";
            this.button_UpLeft.Size = new System.Drawing.Size(45, 45);
            this.button_UpLeft.TabIndex = 0;
            this.button_UpLeft.Text = "Up Left";
            this.button_UpLeft.UseVisualStyleBackColor = true;
            this.button_UpLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_UpLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // CameraDetailsBox
            // 
            this.CameraDetailsBox.Controls.Add(this.DetailsText);
            this.CameraDetailsBox.Location = new System.Drawing.Point(468, 474);
            this.CameraDetailsBox.Name = "CameraDetailsBox";
            this.CameraDetailsBox.Size = new System.Drawing.Size(454, 161);
            this.CameraDetailsBox.TabIndex = 9;
            this.CameraDetailsBox.TabStop = false;
            this.CameraDetailsBox.Text = "Camera details";
            // 
            // DetailsText
            // 
            this.DetailsText.Location = new System.Drawing.Point(7, 20);
            this.DetailsText.Multiline = true;
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.ReadOnly = true;
            this.DetailsText.Size = new System.Drawing.Size(441, 130);
            this.DetailsText.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(57, 471);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(100, 20);
            this.heightText.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Width";
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(211, 471);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(100, 20);
            this.widthText.TabIndex = 13;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(381, 469);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 14;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.button_Disconnect);
            this.groupBox1.Controls.Add(this.tb_cameraUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_compose);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 86);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Connect.ForeColor = System.Drawing.Color.Black;
            this.button_Connect.Location = new System.Drawing.Point(147, 43);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(80, 23);
            this.button_Connect.TabIndex = 18;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(233, 43);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_Disconnect.TabIndex = 22;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // tb_cameraUrl
            // 
            this.tb_cameraUrl.Location = new System.Drawing.Point(83, 17);
            this.tb_cameraUrl.Name = "tb_cameraUrl";
            this.tb_cameraUrl.ReadOnly = true;
            this.tb_cameraUrl.Size = new System.Drawing.Size(280, 20);
            this.tb_cameraUrl.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Camera URL:";
            // 
            // btn_compose
            // 
            this.btn_compose.Location = new System.Drawing.Point(369, 15);
            this.btn_compose.Name = "btn_compose";
            this.btn_compose.Size = new System.Drawing.Size(75, 23);
            this.btn_compose.TabIndex = 19;
            this.btn_compose.Text = "Compose";
            this.btn_compose.UseVisualStyleBackColor = true;
            this.btn_compose.Click += new System.EventHandler(this.btn_compose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Connect next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(660, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 63);
            this.label8.TabIndex = 20;
            this.label8.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 641);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CameraDetailsBox);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTZ camera motion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.groupBox3.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarWhiteBalanceCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBackLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.PTZTab.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.CameraDetailsBox.ResumeLayout(false);
            this.CameraDetailsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TextBox AudioInfoText;
        private System.Windows.Forms.GroupBox CameraDetailsBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox StreamCombo;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.TextBox VideoInfoText;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DetailsText;
        private System.Windows.Forms.TabPage PTZTab;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button_ScanStop;
        private System.Windows.Forms.Button button_ScanStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.ComboBox comboBox_Direction;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboBox_Presets;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button_PresetDelete;
        private System.Windows.Forms.Button button_PresetMove;
        private System.Windows.Forms.Button button_AddPreset;
        private System.Windows.Forms.Button button_SetHome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_ZoomOut;
        private System.Windows.Forms.Button button_ZoomIn;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button_DownRight;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button_UpRight;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_DownLeft;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Button button_UpLeft;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label WhiteBalanceCRLabel;
        private System.Windows.Forms.TrackBar TrackBarWhiteBalanceCR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FrameRateLabel;
        private System.Windows.Forms.Label WhiteBalanceCBLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar TrackBarFrameRate;
        private System.Windows.Forms.TrackBar TrackBarWhiteBalanceCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BackLightLabel;
        private System.Windows.Forms.Label SharpnessLabel;
        private System.Windows.Forms.TrackBar TrackBarBackLight;
        private System.Windows.Forms.TrackBar TrackBarSharpness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label SaturationLabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar TrackBarSaturation;
        private System.Windows.Forms.Label LabelImage;
        private System.Windows.Forms.TrackBar TrackBarContrast;
        private System.Windows.Forms.TrackBar TrackBarBrightness;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox VerticalFlipCheck;
        private System.Windows.Forms.CheckBox HorizontalFlipCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.TextBox tb_cameraUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_compose;
        private Timer timer1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Timer timer2;
        private Label label8;
    }
}

