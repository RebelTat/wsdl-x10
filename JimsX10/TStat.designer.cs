namespace JimsX10
{
    partial class TStat
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TStat));
            this.CoolingDesiredMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeatDesiredMin = new System.Windows.Forms.NumericUpDown();
            this.DesiredConditionsGp = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxInDP = new System.Windows.Forms.NumericUpDown();
            this.DesHumudityLabel = new System.Windows.Forms.Label();
            this.DesHumidity = new System.Windows.Forms.NumericUpDown();
            this.UseAppTemp = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxSplit = new System.Windows.Forms.NumericUpDown();
            this.ActCondGroup = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AveHumLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IndoorTemp1Label = new System.Windows.Forms.Label();
            this.AveIndTempLabel = new System.Windows.Forms.Label();
            this.HideButton = new System.Windows.Forms.Button();
            this.StatusGp = new System.Windows.Forms.GroupBox();
            this.FreshAdd = new System.Windows.Forms.TextBox();
            this.FreshAirFan = new System.Windows.Forms.CheckBox();
            this.HumidifierAddress = new System.Windows.Forms.TextBox();
            this.HumidifierCheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CoolAddress = new System.Windows.Forms.TextBox();
            this.HeatAddress = new System.Windows.Forms.TextBox();
            this.FanAddress = new System.Windows.Forms.TextBox();
            this.MixFan = new System.Windows.Forms.CheckBox();
            this.Heat = new System.Windows.Forms.CheckBox();
            this.CoolCompressor = new System.Windows.Forms.CheckBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Sprinkler = new System.Windows.Forms.GroupBox();
            this.Rain24Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RainThresh = new System.Windows.Forms.TextBox();
            this.SprinklerAddressLabel = new System.Windows.Forms.Label();
            this.SprinklerAddress = new System.Windows.Forms.TextBox();
            this.SprinklersBox = new System.Windows.Forms.CheckBox();
            this.SaveSet = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.BarnGroup = new System.Windows.Forms.GroupBox();
            this.BarnUseAppTemp = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BarnSensor = new System.Windows.Forms.ComboBox();
            this.BarnDesMin = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.BarnHeatAdd = new System.Windows.Forms.TextBox();
            this.BarnHeat = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BarnDesMax = new System.Windows.Forms.NumericUpDown();
            this.BarnCoolAdd = new System.Windows.Forms.TextBox();
            this.BarnCool = new System.Windows.Forms.CheckBox();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usb = new UsbLibrary.UsbHidPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CoolingDesiredMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeatDesiredMin)).BeginInit();
            this.DesiredConditionsGp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxInDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSplit)).BeginInit();
            this.ActCondGroup.SuspendLayout();
            this.StatusGp.SuspendLayout();
            this.Sprinkler.SuspendLayout();
            this.BarnGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarnDesMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarnDesMax)).BeginInit();
            this.SuspendLayout();
            // 
            // CoolingDesiredMax
            // 
            this.helpProvider1.SetHelpKeyword(this.CoolingDesiredMax, "HVAC Cooling");
            this.helpProvider1.SetHelpString(this.CoolingDesiredMax, "Use this control to set the temperature threshold for engaging your cooling syste" +
                    "m X10 device.");
            this.CoolingDesiredMax.Location = new System.Drawing.Point(111, 35);
            this.CoolingDesiredMax.Minimum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.CoolingDesiredMax.Name = "CoolingDesiredMax";
            this.helpProvider1.SetShowHelp(this.CoolingDesiredMax, true);
            this.CoolingDesiredMax.Size = new System.Drawing.Size(47, 20);
            this.CoolingDesiredMax.TabIndex = 0;
            this.CoolingDesiredMax.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.CoolingDesiredMax.ValueChanged += new System.EventHandler(this.CoolingDesiredMax_changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cooling engages at:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Heat engages at:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HeatDesiredMin
            // 
            this.helpProvider1.SetHelpKeyword(this.HeatDesiredMin, "HVAC Heat");
            this.helpProvider1.SetHelpString(this.HeatDesiredMin, "This is the temperature where the heat X10 control engages.");
            this.HeatDesiredMin.Location = new System.Drawing.Point(111, 61);
            this.HeatDesiredMin.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.HeatDesiredMin.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.HeatDesiredMin.Name = "HeatDesiredMin";
            this.helpProvider1.SetShowHelp(this.HeatDesiredMin, true);
            this.HeatDesiredMin.Size = new System.Drawing.Size(47, 20);
            this.HeatDesiredMin.TabIndex = 4;
            this.HeatDesiredMin.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.HeatDesiredMin.ValueChanged += new System.EventHandler(this.HeatDesiredMin_Changed);
            // 
            // DesiredConditionsGp
            // 
            this.DesiredConditionsGp.Controls.Add(this.label13);
            this.DesiredConditionsGp.Controls.Add(this.MaxInDP);
            this.DesiredConditionsGp.Controls.Add(this.DesHumudityLabel);
            this.DesiredConditionsGp.Controls.Add(this.DesHumidity);
            this.DesiredConditionsGp.Controls.Add(this.UseAppTemp);
            this.DesiredConditionsGp.Controls.Add(this.label5);
            this.DesiredConditionsGp.Controls.Add(this.MaxSplit);
            this.DesiredConditionsGp.Controls.Add(this.label2);
            this.DesiredConditionsGp.Controls.Add(this.HeatDesiredMin);
            this.DesiredConditionsGp.Controls.Add(this.CoolingDesiredMax);
            this.DesiredConditionsGp.Controls.Add(this.label3);
            this.DesiredConditionsGp.Location = new System.Drawing.Point(3, 12);
            this.DesiredConditionsGp.Name = "DesiredConditionsGp";
            this.DesiredConditionsGp.Size = new System.Drawing.Size(293, 140);
            this.DesiredConditionsGp.TabIndex = 5;
            this.DesiredConditionsGp.TabStop = false;
            this.DesiredConditionsGp.Text = "Desired HVAC Conditions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Max Indoor Dew Point";
            // 
            // MaxInDP
            // 
            this.helpProvider1.SetHelpKeyword(this.MaxInDP, "HVAC Dew Point");
            this.helpProvider1.SetHelpString(this.MaxInDP, "This sets the maximum dew point for insode the building.  This is used to prevent" +
                    " the fresh air fan from engaging when the outside dew point is too high.");
            this.MaxInDP.Location = new System.Drawing.Point(239, 113);
            this.MaxInDP.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.MaxInDP.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaxInDP.Name = "MaxInDP";
            this.helpProvider1.SetShowHelp(this.MaxInDP, true);
            this.MaxInDP.Size = new System.Drawing.Size(47, 20);
            this.MaxInDP.TabIndex = 12;
            this.MaxInDP.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // DesHumudityLabel
            // 
            this.DesHumudityLabel.AutoSize = true;
            this.DesHumudityLabel.Location = new System.Drawing.Point(16, 115);
            this.DesHumudityLabel.Name = "DesHumudityLabel";
            this.DesHumudityLabel.Size = new System.Drawing.Size(89, 13);
            this.DesHumudityLabel.TabIndex = 11;
            this.DesHumudityLabel.Text = "Desired Humidity:";
            this.DesHumudityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DesHumidity
            // 
            this.helpProvider1.SetHelpKeyword(this.DesHumidity, "HVAC Humidity");
            this.helpProvider1.SetHelpString(this.DesHumidity, resources.GetString("DesHumidity.HelpString"));
            this.DesHumidity.Location = new System.Drawing.Point(111, 113);
            this.DesHumidity.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.DesHumidity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DesHumidity.Name = "DesHumidity";
            this.helpProvider1.SetShowHelp(this.DesHumidity, true);
            this.DesHumidity.Size = new System.Drawing.Size(47, 20);
            this.DesHumidity.TabIndex = 10;
            this.DesHumidity.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // UseAppTemp
            // 
            this.UseAppTemp.AutoSize = true;
            this.UseAppTemp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UseAppTemp.Checked = true;
            this.UseAppTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpProvider1.SetHelpKeyword(this.UseAppTemp, "HVAC apparent temp");
            this.helpProvider1.SetHelpString(this.UseAppTemp, "When this box is checked, the controls in this group will use the apparent temper" +
                    "ature to control to, rather than the actual temperature.");
            this.UseAppTemp.Location = new System.Drawing.Point(37, 15);
            this.UseAppTemp.Name = "UseAppTemp";
            this.helpProvider1.SetShowHelp(this.UseAppTemp, true);
            this.UseAppTemp.Size = new System.Drawing.Size(121, 17);
            this.UseAppTemp.TabIndex = 9;
            this.UseAppTemp.Text = "Use Apparent Temp";
            this.UseAppTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UseAppTemp.UseVisualStyleBackColor = true;
            this.UseAppTemp.CheckedChanged += new System.EventHandler(this.TStat_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Split:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaxSplit
            // 
            this.helpProvider1.SetHelpKeyword(this.MaxSplit, "HVAC Split");
            this.helpProvider1.SetHelpString(this.MaxSplit, resources.GetString("MaxSplit.HelpString"));
            this.MaxSplit.Location = new System.Drawing.Point(111, 87);
            this.MaxSplit.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MaxSplit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxSplit.Name = "MaxSplit";
            this.helpProvider1.SetShowHelp(this.MaxSplit, true);
            this.MaxSplit.Size = new System.Drawing.Size(47, 20);
            this.MaxSplit.TabIndex = 5;
            this.MaxSplit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxSplit.ValueChanged += new System.EventHandler(this.TStat_TextChanged);
            // 
            // ActCondGroup
            // 
            this.ActCondGroup.Controls.Add(this.label15);
            this.ActCondGroup.Controls.Add(this.label14);
            this.ActCondGroup.Controls.Add(this.AveHumLabel);
            this.ActCondGroup.Controls.Add(this.label6);
            this.ActCondGroup.Controls.Add(this.label4);
            this.ActCondGroup.Controls.Add(this.label1);
            this.ActCondGroup.Controls.Add(this.IndoorTemp1Label);
            this.ActCondGroup.Controls.Add(this.AveIndTempLabel);
            this.ActCondGroup.Location = new System.Drawing.Point(302, 32);
            this.ActCondGroup.Name = "ActCondGroup";
            this.ActCondGroup.Size = new System.Drawing.Size(562, 365);
            this.ActCondGroup.TabIndex = 6;
            this.ActCondGroup.TabStop = false;
            this.ActCondGroup.Text = "Actual Conditions";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(420, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Heat Index";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(490, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Wind Chill";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AveHumLabel
            // 
            this.AveHumLabel.AutoSize = true;
            this.AveHumLabel.Location = new System.Drawing.Point(211, 349);
            this.AveHumLabel.Name = "AveHumLabel";
            this.AveHumLabel.Size = new System.Drawing.Size(90, 13);
            this.AveHumLabel.TabIndex = 12;
            this.AveHumLabel.Text = "Average Humidity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apparent \r\nTemperature";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Humidity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dew Point";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IndoorTemp1Label
            // 
            this.IndoorTemp1Label.AutoSize = true;
            this.IndoorTemp1Label.Location = new System.Drawing.Point(140, 21);
            this.IndoorTemp1Label.Name = "IndoorTemp1Label";
            this.IndoorTemp1Label.Size = new System.Drawing.Size(67, 13);
            this.IndoorTemp1Label.TabIndex = 0;
            this.IndoorTemp1Label.Text = "Temperature";
            this.IndoorTemp1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AveIndTempLabel
            // 
            this.AveIndTempLabel.AutoSize = true;
            this.AveIndTempLabel.Location = new System.Drawing.Point(6, 349);
            this.AveIndTempLabel.Name = "AveIndTempLabel";
            this.AveIndTempLabel.Size = new System.Drawing.Size(89, 13);
            this.AveIndTempLabel.TabIndex = 1;
            this.AveIndTempLabel.Text = "Ave Indoor Temp";
            // 
            // HideButton
            // 
            this.HideButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HideButton.Location = new System.Drawing.Point(741, 2);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(40, 23);
            this.HideButton.TabIndex = 7;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // StatusGp
            // 
            this.StatusGp.Controls.Add(this.FreshAdd);
            this.StatusGp.Controls.Add(this.FreshAirFan);
            this.StatusGp.Controls.Add(this.HumidifierAddress);
            this.StatusGp.Controls.Add(this.HumidifierCheck);
            this.StatusGp.Controls.Add(this.label9);
            this.StatusGp.Controls.Add(this.CoolAddress);
            this.StatusGp.Controls.Add(this.HeatAddress);
            this.StatusGp.Controls.Add(this.FanAddress);
            this.StatusGp.Controls.Add(this.MixFan);
            this.StatusGp.Controls.Add(this.Heat);
            this.StatusGp.Controls.Add(this.CoolCompressor);
            this.StatusGp.Location = new System.Drawing.Point(3, 158);
            this.StatusGp.Name = "StatusGp";
            this.StatusGp.Size = new System.Drawing.Size(293, 150);
            this.StatusGp.TabIndex = 8;
            this.StatusGp.TabStop = false;
            this.StatusGp.Text = "HVAC Control";
            // 
            // FreshAdd
            // 
            this.helpProvider1.SetHelpKeyword(this.FreshAdd, "HVAC Fresh Air");
            this.helpProvider1.SetHelpString(this.FreshAdd, resources.GetString("FreshAdd.HelpString"));
            this.FreshAdd.Location = new System.Drawing.Point(108, 122);
            this.FreshAdd.MaxLength = 3;
            this.FreshAdd.Name = "FreshAdd";
            this.helpProvider1.SetShowHelp(this.FreshAdd, true);
            this.FreshAdd.Size = new System.Drawing.Size(30, 20);
            this.FreshAdd.TabIndex = 14;
            // 
            // FreshAirFan
            // 
            this.FreshAirFan.AutoSize = true;
            this.FreshAirFan.Location = new System.Drawing.Point(9, 124);
            this.FreshAirFan.Name = "FreshAirFan";
            this.FreshAirFan.Size = new System.Drawing.Size(86, 17);
            this.FreshAirFan.TabIndex = 13;
            this.FreshAirFan.Text = "Fresh Air ON";
            this.FreshAirFan.UseVisualStyleBackColor = true;
            this.FreshAirFan.CheckedChanged += new System.EventHandler(this.FreshAirFan_CheckedChanged);
            // 
            // HumidifierAddress
            // 
            this.helpProvider1.SetHelpKeyword(this.HumidifierAddress, "HVAC Humidifier ON");
            this.helpProvider1.SetHelpString(this.HumidifierAddress, resources.GetString("HumidifierAddress.HelpString"));
            this.HumidifierAddress.Location = new System.Drawing.Point(108, 99);
            this.HumidifierAddress.MaxLength = 3;
            this.HumidifierAddress.Name = "HumidifierAddress";
            this.helpProvider1.SetShowHelp(this.HumidifierAddress, true);
            this.HumidifierAddress.Size = new System.Drawing.Size(30, 20);
            this.HumidifierAddress.TabIndex = 11;
            // 
            // HumidifierCheck
            // 
            this.HumidifierCheck.AutoSize = true;
            this.HumidifierCheck.Location = new System.Drawing.Point(9, 101);
            this.HumidifierCheck.Name = "HumidifierCheck";
            this.HumidifierCheck.Size = new System.Drawing.Size(91, 17);
            this.HumidifierCheck.TabIndex = 10;
            this.HumidifierCheck.Text = "Humidifier ON";
            this.HumidifierCheck.UseVisualStyleBackColor = true;
            this.HumidifierCheck.CheckedChanged += new System.EventHandler(this.HumidifierCheck_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "X10 Address";
            // 
            // CoolAddress
            // 
            this.helpProvider1.SetHelpKeyword(this.CoolAddress, "HVAC Cooling ON");
            this.helpProvider1.SetHelpString(this.CoolAddress, resources.GetString("CoolAddress.HelpString"));
            this.CoolAddress.Location = new System.Drawing.Point(108, 30);
            this.CoolAddress.MaxLength = 3;
            this.CoolAddress.Name = "CoolAddress";
            this.helpProvider1.SetShowHelp(this.CoolAddress, true);
            this.CoolAddress.Size = new System.Drawing.Size(30, 20);
            this.CoolAddress.TabIndex = 8;
            // 
            // HeatAddress
            // 
            this.helpProvider1.SetHelpKeyword(this.HeatAddress, "HVAC Heating ON");
            this.helpProvider1.SetHelpString(this.HeatAddress, resources.GetString("HeatAddress.HelpString"));
            this.HeatAddress.Location = new System.Drawing.Point(108, 76);
            this.HeatAddress.MaxLength = 3;
            this.HeatAddress.Name = "HeatAddress";
            this.helpProvider1.SetShowHelp(this.HeatAddress, true);
            this.HeatAddress.Size = new System.Drawing.Size(30, 20);
            this.HeatAddress.TabIndex = 6;
            // 
            // FanAddress
            // 
            this.helpProvider1.SetHelpKeyword(this.FanAddress, "HVAC Fan ON");
            this.helpProvider1.SetHelpString(this.FanAddress, resources.GetString("FanAddress.HelpString"));
            this.FanAddress.Location = new System.Drawing.Point(108, 53);
            this.FanAddress.MaxLength = 3;
            this.FanAddress.Name = "FanAddress";
            this.helpProvider1.SetShowHelp(this.FanAddress, true);
            this.FanAddress.Size = new System.Drawing.Size(30, 20);
            this.FanAddress.TabIndex = 4;
            this.FanAddress.Text = "a2";
            // 
            // MixFan
            // 
            this.MixFan.AutoSize = true;
            this.MixFan.Location = new System.Drawing.Point(9, 55);
            this.MixFan.Name = "MixFan";
            this.MixFan.Size = new System.Drawing.Size(85, 17);
            this.MixFan.TabIndex = 3;
            this.MixFan.Text = "Mix Fan  ON";
            this.MixFan.UseVisualStyleBackColor = true;
            this.MixFan.CheckedChanged += new System.EventHandler(this.MixFan_CheckedChanged);
            // 
            // Heat
            // 
            this.Heat.AutoSize = true;
            this.Heat.Location = new System.Drawing.Point(9, 78);
            this.Heat.Name = "Heat";
            this.Heat.Size = new System.Drawing.Size(82, 17);
            this.Heat.TabIndex = 2;
            this.Heat.Text = "Heating ON";
            this.Heat.UseVisualStyleBackColor = true;
            this.Heat.CheckedChanged += new System.EventHandler(this.Heat_CheckedChanged);
            // 
            // CoolCompressor
            // 
            this.CoolCompressor.AutoSize = true;
            this.CoolCompressor.Location = new System.Drawing.Point(9, 32);
            this.CoolCompressor.Name = "CoolCompressor";
            this.CoolCompressor.Size = new System.Drawing.Size(80, 17);
            this.CoolCompressor.TabIndex = 0;
            this.CoolCompressor.Text = "Cooling ON";
            this.CoolCompressor.UseVisualStyleBackColor = true;
            this.CoolCompressor.CheckedChanged += new System.EventHandler(this.CoolCompressor_CheckedChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(682, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(54, 23);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.TStat_TextChanged);
            // 
            // Sprinkler
            // 
            this.Sprinkler.Controls.Add(this.Rain24Label);
            this.Sprinkler.Controls.Add(this.label7);
            this.Sprinkler.Controls.Add(this.RainThresh);
            this.Sprinkler.Controls.Add(this.SprinklerAddressLabel);
            this.Sprinkler.Controls.Add(this.SprinklerAddress);
            this.Sprinkler.Controls.Add(this.SprinklersBox);
            this.Sprinkler.Location = new System.Drawing.Point(3, 314);
            this.Sprinkler.Name = "Sprinkler";
            this.Sprinkler.Size = new System.Drawing.Size(293, 164);
            this.Sprinkler.TabIndex = 10;
            this.Sprinkler.TabStop = false;
            this.Sprinkler.Text = "Sprinkler Control";
            // 
            // Rain24Label
            // 
            this.Rain24Label.AutoSize = true;
            this.Rain24Label.Location = new System.Drawing.Point(137, 43);
            this.Rain24Label.Name = "Rain24Label";
            this.Rain24Label.Size = new System.Drawing.Size(70, 13);
            this.Rain24Label.TabIndex = 5;
            this.Rain24Label.Text = "24 Hour Rain";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Rain Threshold (in)";
            // 
            // RainThresh
            // 
            this.helpProvider1.SetHelpKeyword(this.RainThresh, "Rain threshold");
            this.helpProvider1.SetHelpString(this.RainThresh, resources.GetString("RainThresh.HelpString"));
            this.RainThresh.Location = new System.Drawing.Point(239, 16);
            this.RainThresh.Name = "RainThresh";
            this.helpProvider1.SetShowHelp(this.RainThresh, true);
            this.RainThresh.Size = new System.Drawing.Size(36, 20);
            this.RainThresh.TabIndex = 3;
            this.RainThresh.Text = "0.15";
            this.RainThresh.TextChanged += new System.EventHandler(this.RainThresh_TextChanged);
            // 
            // SprinklerAddressLabel
            // 
            this.SprinklerAddressLabel.AutoSize = true;
            this.SprinklerAddressLabel.Location = new System.Drawing.Point(38, 46);
            this.SprinklerAddressLabel.Name = "SprinklerAddressLabel";
            this.SprinklerAddressLabel.Size = new System.Drawing.Size(67, 13);
            this.SprinklerAddressLabel.TabIndex = 2;
            this.SprinklerAddressLabel.Text = "X10 Address";
            // 
            // SprinklerAddress
            // 
            this.helpProvider1.SetHelpKeyword(this.SprinklerAddress, "Sprinlers enable");
            this.helpProvider1.SetHelpString(this.SprinklerAddress, resources.GetString("SprinklerAddress.HelpString"));
            this.SprinklerAddress.Location = new System.Drawing.Point(6, 43);
            this.SprinklerAddress.MaxLength = 3;
            this.SprinklerAddress.Name = "SprinklerAddress";
            this.helpProvider1.SetShowHelp(this.SprinklerAddress, true);
            this.SprinklerAddress.Size = new System.Drawing.Size(30, 20);
            this.SprinklerAddress.TabIndex = 1;
            this.SprinklerAddress.Text = "a1";
            this.SprinklerAddress.TextChanged += new System.EventHandler(this.X10Address_TextChanged);
            // 
            // SprinklersBox
            // 
            this.SprinklersBox.AutoSize = true;
            this.SprinklersBox.Checked = true;
            this.SprinklersBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SprinklersBox.Location = new System.Drawing.Point(6, 19);
            this.SprinklersBox.Name = "SprinklersBox";
            this.SprinklersBox.Size = new System.Drawing.Size(114, 17);
            this.SprinklersBox.TabIndex = 0;
            this.SprinklersBox.Text = "Sprinklers Enabled";
            this.SprinklersBox.UseVisualStyleBackColor = true;
            this.SprinklersBox.CheckedChanged += new System.EventHandler(this.SprinklersBox_CheckedChanged);
            // 
            // SaveSet
            // 
            this.SaveSet.Location = new System.Drawing.Point(483, 3);
            this.SaveSet.Name = "SaveSet";
            this.SaveSet.Size = new System.Drawing.Size(95, 21);
            this.SaveSet.TabIndex = 11;
            this.SaveSet.Text = "Save Settings";
            this.SaveSet.UseVisualStyleBackColor = true;
            this.SaveSet.Click += new System.EventHandler(this.SaveSet_Click);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(584, 2);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(92, 22);
            this.Reload.TabIndex = 12;
            this.Reload.Text = "Reload Settings";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // BarnGroup
            // 
            this.BarnGroup.Controls.Add(this.BarnUseAppTemp);
            this.BarnGroup.Controls.Add(this.label12);
            this.BarnGroup.Controls.Add(this.BarnSensor);
            this.BarnGroup.Controls.Add(this.BarnDesMin);
            this.BarnGroup.Controls.Add(this.label11);
            this.BarnGroup.Controls.Add(this.BarnHeatAdd);
            this.BarnGroup.Controls.Add(this.BarnHeat);
            this.BarnGroup.Controls.Add(this.label10);
            this.BarnGroup.Controls.Add(this.label8);
            this.BarnGroup.Controls.Add(this.BarnDesMax);
            this.BarnGroup.Controls.Add(this.BarnCoolAdd);
            this.BarnGroup.Controls.Add(this.BarnCool);
            this.BarnGroup.Location = new System.Drawing.Point(302, 403);
            this.BarnGroup.Name = "BarnGroup";
            this.BarnGroup.Size = new System.Drawing.Size(562, 94);
            this.BarnGroup.TabIndex = 13;
            this.BarnGroup.TabStop = false;
            this.BarnGroup.Text = "Barn Control";
            // 
            // BarnUseAppTemp
            // 
            this.BarnUseAppTemp.AutoSize = true;
            this.BarnUseAppTemp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BarnUseAppTemp.Checked = true;
            this.BarnUseAppTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BarnUseAppTemp.Location = new System.Drawing.Point(325, 14);
            this.BarnUseAppTemp.Name = "BarnUseAppTemp";
            this.BarnUseAppTemp.Size = new System.Drawing.Size(121, 17);
            this.BarnUseAppTemp.TabIndex = 17;
            this.BarnUseAppTemp.Text = "Use Apparent Temp";
            this.BarnUseAppTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BarnUseAppTemp.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Barn Temperature Sensor";
            // 
            // BarnSensor
            // 
            this.BarnSensor.FormattingEnabled = true;
            this.BarnSensor.Location = new System.Drawing.Point(322, 60);
            this.BarnSensor.Name = "BarnSensor";
            this.BarnSensor.Size = new System.Drawing.Size(240, 21);
            this.BarnSensor.TabIndex = 15;
            this.BarnSensor.SelectedIndexChanged += new System.EventHandler(this.BarnSensor_SelectedIndexChanged);
            // 
            // BarnDesMin
            // 
            this.BarnDesMin.Location = new System.Drawing.Point(270, 60);
            this.BarnDesMin.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.BarnDesMin.Name = "BarnDesMin";
            this.BarnDesMin.Size = new System.Drawing.Size(46, 20);
            this.BarnDesMin.TabIndex = 14;
            this.BarnDesMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BarnDesMin.ValueChanged += new System.EventHandler(this.BarnDesMin_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Heating engages at:";
            // 
            // BarnHeatAdd
            // 
            this.helpProvider1.SetHelpKeyword(this.BarnHeatAdd, "Barn heating");
            this.helpProvider1.SetHelpString(this.BarnHeatAdd, resources.GetString("BarnHeatAdd.HelpString"));
            this.BarnHeatAdd.Location = new System.Drawing.Point(111, 58);
            this.BarnHeatAdd.Name = "BarnHeatAdd";
            this.helpProvider1.SetShowHelp(this.BarnHeatAdd, true);
            this.BarnHeatAdd.Size = new System.Drawing.Size(27, 20);
            this.BarnHeatAdd.TabIndex = 12;
            // 
            // BarnHeat
            // 
            this.BarnHeat.AutoSize = true;
            this.BarnHeat.Location = new System.Drawing.Point(17, 58);
            this.BarnHeat.Name = "BarnHeat";
            this.BarnHeat.Size = new System.Drawing.Size(82, 17);
            this.BarnHeat.TabIndex = 11;
            this.BarnHeat.Text = "Heating ON";
            this.BarnHeat.UseVisualStyleBackColor = true;
            this.BarnHeat.CheckedChanged += new System.EventHandler(this.BarnHeat_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "X10 Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cooling engages at:";
            // 
            // BarnDesMax
            // 
            this.BarnDesMax.Location = new System.Drawing.Point(270, 32);
            this.BarnDesMax.Name = "BarnDesMax";
            this.BarnDesMax.Size = new System.Drawing.Size(46, 20);
            this.BarnDesMax.TabIndex = 2;
            this.BarnDesMax.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.BarnDesMax.ValueChanged += new System.EventHandler(this.BarnDesMax_ValueChanged);
            // 
            // BarnCoolAdd
            // 
            this.helpProvider1.SetHelpKeyword(this.BarnCoolAdd, "Barn cooling");
            this.helpProvider1.SetHelpString(this.BarnCoolAdd, resources.GetString("BarnCoolAdd.HelpString"));
            this.BarnCoolAdd.Location = new System.Drawing.Point(111, 32);
            this.BarnCoolAdd.Name = "BarnCoolAdd";
            this.helpProvider1.SetShowHelp(this.BarnCoolAdd, true);
            this.BarnCoolAdd.Size = new System.Drawing.Size(27, 20);
            this.BarnCoolAdd.TabIndex = 1;
            // 
            // BarnCool
            // 
            this.BarnCool.AutoSize = true;
            this.BarnCool.Location = new System.Drawing.Point(19, 35);
            this.BarnCool.Name = "BarnCool";
            this.BarnCool.Size = new System.Drawing.Size(80, 17);
            this.BarnCool.TabIndex = 0;
            this.BarnCool.Text = "Cooling ON";
            this.BarnCool.UseVisualStyleBackColor = true;
            this.BarnCool.CheckedChanged += new System.EventHandler(this.BarnCool_CheckedChanged);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(312, 12);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(67, 13);
            this.UpdateLabel.TabIndex = 14;
            this.UpdateLabel.Text = "Initializing.....";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 485);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Press F1 for help on the current selection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usb
            // 
            this.usb.ProductId = 1;
            this.usb.Shared = true;
            this.usb.VendorId = 3015;
            // 
            // TStat
            // 
            this.AcceptButton = this.RefreshButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.HideButton;
            this.ClientSize = new System.Drawing.Size(872, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.BarnGroup);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.SaveSet);
            this.Controls.Add(this.Sprinkler);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.StatusGp);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ActCondGroup);
            this.Controls.Add(this.DesiredConditionsGp);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TStat";
            this.Text = "Home Control";
            this.Load += new System.EventHandler(this.TStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoolingDesiredMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeatDesiredMin)).EndInit();
            this.DesiredConditionsGp.ResumeLayout(false);
            this.DesiredConditionsGp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxInDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSplit)).EndInit();
            this.ActCondGroup.ResumeLayout(false);
            this.ActCondGroup.PerformLayout();
            this.StatusGp.ResumeLayout(false);
            this.StatusGp.PerformLayout();
            this.Sprinkler.ResumeLayout(false);
            this.Sprinkler.PerformLayout();
            this.BarnGroup.ResumeLayout(false);
            this.BarnGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarnDesMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarnDesMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CoolingDesiredMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown HeatDesiredMin;
        private System.Windows.Forms.GroupBox DesiredConditionsGp;
        private System.Windows.Forms.GroupBox ActCondGroup;
        public System.Windows.Forms.Label IndoorTemp1Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MaxSplit;
        private System.Windows.Forms.GroupBox StatusGp;
        private System.Windows.Forms.CheckBox CoolCompressor;
        private System.Windows.Forms.Label AveIndTempLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox UseAppTemp;
        private System.Windows.Forms.CheckBox MixFan;
        private System.Windows.Forms.CheckBox Heat;
        private System.Windows.Forms.GroupBox Sprinkler;
        private System.Windows.Forms.CheckBox SprinklersBox;
        private System.Windows.Forms.Label SprinklerAddressLabel;
        private System.Windows.Forms.TextBox SprinklerAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RainThresh;
        private System.Windows.Forms.TextBox FanAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CoolAddress;
        private System.Windows.Forms.TextBox HeatAddress;
        private System.Windows.Forms.TextBox HumidifierAddress;
        private System.Windows.Forms.CheckBox HumidifierCheck;
        private System.Windows.Forms.Label DesHumudityLabel;
        private System.Windows.Forms.NumericUpDown DesHumidity;
        private System.Windows.Forms.Label AveHumLabel;
        private System.Windows.Forms.Button SaveSet;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Label Rain24Label;
        private System.Windows.Forms.GroupBox BarnGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown BarnDesMax;
        private System.Windows.Forms.TextBox BarnCoolAdd;
        private System.Windows.Forms.CheckBox BarnCool;
        private System.Windows.Forms.CheckBox BarnHeat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown BarnDesMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BarnHeatAdd;
        private System.Windows.Forms.CheckBox BarnUseAppTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox BarnSensor;
        private System.Windows.Forms.TextBox FreshAdd;
        private System.Windows.Forms.CheckBox FreshAirFan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown MaxInDP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private UsbLibrary.UsbHidPort usb;
    }
}