namespace PSGuiAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showVoltBtn = new System.Windows.Forms.Button();
            this.showCurrentBtn = new System.Windows.Forms.Button();
            this.SetVolt = new System.Windows.Forms.Button();
            this.setVoltTxtBox = new System.Windows.Forms.TextBox();
            this.VoltULabel = new System.Windows.Forms.Label();
            this.ShowVoltULabel = new System.Windows.Forms.Label();
            this.CurrentILabel = new System.Windows.Forms.Label();
            this.ShowCurrentILabel = new System.Windows.Forms.Label();
            this.SetRemoteControlCheckBox = new System.Windows.Forms.CheckBox();
            this.PowerOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nominalVoltageLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nominalCurrentlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.articleNumberLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.softwareVerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showVoltBtn
            // 
            this.showVoltBtn.Location = new System.Drawing.Point(71, 107);
            this.showVoltBtn.Name = "showVoltBtn";
            this.showVoltBtn.Size = new System.Drawing.Size(106, 29);
            this.showVoltBtn.TabIndex = 0;
            this.showVoltBtn.Text = "Show Volt(U)";
            this.showVoltBtn.UseVisualStyleBackColor = true;
            this.showVoltBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showCurrentBtn
            // 
            this.showCurrentBtn.Location = new System.Drawing.Point(71, 163);
            this.showCurrentBtn.Name = "showCurrentBtn";
            this.showCurrentBtn.Size = new System.Drawing.Size(146, 29);
            this.showCurrentBtn.TabIndex = 1;
            this.showCurrentBtn.Text = "Show Current(I)";
            this.showCurrentBtn.UseVisualStyleBackColor = true;
            this.showCurrentBtn.Click += new System.EventHandler(this.showVoltageBtn_Click);
            // 
            // SetVolt
            // 
            this.SetVolt.Location = new System.Drawing.Point(71, 222);
            this.SetVolt.Name = "SetVolt";
            this.SetVolt.Size = new System.Drawing.Size(94, 29);
            this.SetVolt.TabIndex = 2;
            this.SetVolt.Text = "Set Volt(U)";
            this.SetVolt.UseVisualStyleBackColor = true;
            this.SetVolt.Click += new System.EventHandler(this.SetVolt_Click);
            // 
            // setVoltTxtBox
            // 
            this.setVoltTxtBox.Location = new System.Drawing.Point(221, 224);
            this.setVoltTxtBox.Name = "setVoltTxtBox";
            this.setVoltTxtBox.Size = new System.Drawing.Size(125, 27);
            this.setVoltTxtBox.TabIndex = 6;
            // 
            // VoltULabel
            // 
            this.VoltULabel.AutoSize = true;
            this.VoltULabel.Location = new System.Drawing.Point(234, 116);
            this.VoltULabel.Name = "VoltULabel";
            this.VoltULabel.Size = new System.Drawing.Size(66, 20);
            this.VoltULabel.TabIndex = 7;
            this.VoltULabel.Text = "Volt(U) : ";
            // 
            // ShowVoltULabel
            // 
            this.ShowVoltULabel.AutoSize = true;
            this.ShowVoltULabel.Location = new System.Drawing.Point(306, 116);
            this.ShowVoltULabel.Name = "ShowVoltULabel";
            this.ShowVoltULabel.Size = new System.Drawing.Size(50, 20);
            this.ShowVoltULabel.TabIndex = 8;
            this.ShowVoltULabel.Text = "label1";
            // 
            // CurrentILabel
            // 
            this.CurrentILabel.AutoSize = true;
            this.CurrentILabel.Location = new System.Drawing.Point(234, 172);
            this.CurrentILabel.Name = "CurrentILabel";
            this.CurrentILabel.Size = new System.Drawing.Size(74, 20);
            this.CurrentILabel.TabIndex = 9;
            this.CurrentILabel.Text = "Current(I):";
            // 
            // ShowCurrentILabel
            // 
            this.ShowCurrentILabel.AutoSize = true;
            this.ShowCurrentILabel.Location = new System.Drawing.Point(323, 172);
            this.ShowCurrentILabel.Name = "ShowCurrentILabel";
            this.ShowCurrentILabel.Size = new System.Drawing.Size(50, 20);
            this.ShowCurrentILabel.TabIndex = 10;
            this.ShowCurrentILabel.Text = "label1";
            // 
            // SetRemoteControlCheckBox
            // 
            this.SetRemoteControlCheckBox.AutoSize = true;
            this.SetRemoteControlCheckBox.Location = new System.Drawing.Point(79, 364);
            this.SetRemoteControlCheckBox.Name = "SetRemoteControlCheckBox";
            this.SetRemoteControlCheckBox.Size = new System.Drawing.Size(136, 24);
            this.SetRemoteControlCheckBox.TabIndex = 11;
            this.SetRemoteControlCheckBox.Text = "Remote Control";
            this.SetRemoteControlCheckBox.UseVisualStyleBackColor = true;
            this.SetRemoteControlCheckBox.CheckedChanged += new System.EventHandler(this.SetRemoteControlCheckBox_CheckedChanged);
            // 
            // PowerOutputCheckBox
            // 
            this.PowerOutputCheckBox.AutoSize = true;
            this.PowerOutputCheckBox.Location = new System.Drawing.Point(76, 404);
            this.PowerOutputCheckBox.Name = "PowerOutputCheckBox";
            this.PowerOutputCheckBox.Size = new System.Drawing.Size(178, 24);
            this.PowerOutputCheckBox.TabIndex = 12;
            this.PowerOutputCheckBox.Text = "Power Output ON/OFF";
            this.PowerOutputCheckBox.UseVisualStyleBackColor = true;
            this.PowerOutputCheckBox.CheckedChanged += new System.EventHandler(this.PowerOutputCheckBox_CheckedChanged);
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.AutoSize = true;
            this.serialNumberLabel.Location = new System.Drawing.Point(618, 77);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(50, 20);
            this.serialNumberLabel.TabIndex = 13;
            this.serialNumberLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serialnumber: ";
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.AutoSize = true;
            this.deviceTypeLabel.Location = new System.Drawing.Point(618, 33);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(50, 20);
            this.deviceTypeLabel.TabIndex = 15;
            this.deviceTypeLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Device Type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nominal Voltage:";
            // 
            // nominalVoltageLabel
            // 
            this.nominalVoltageLabel.AutoSize = true;
            this.nominalVoltageLabel.Location = new System.Drawing.Point(618, 116);
            this.nominalVoltageLabel.Name = "nominalVoltageLabel";
            this.nominalVoltageLabel.Size = new System.Drawing.Size(50, 20);
            this.nominalVoltageLabel.TabIndex = 18;
            this.nominalVoltageLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nominal Current: ";
            // 
            // nominalCurrentlabel
            // 
            this.nominalCurrentlabel.AutoSize = true;
            this.nominalCurrentlabel.Location = new System.Drawing.Point(618, 163);
            this.nominalCurrentlabel.Name = "nominalCurrentlabel";
            this.nominalCurrentlabel.Size = new System.Drawing.Size(50, 20);
            this.nominalCurrentlabel.TabIndex = 20;
            this.nominalCurrentlabel.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Article Number: ";
            // 
            // articleNumberLabel
            // 
            this.articleNumberLabel.AutoSize = true;
            this.articleNumberLabel.Location = new System.Drawing.Point(618, 202);
            this.articleNumberLabel.Name = "articleNumberLabel";
            this.articleNumberLabel.Size = new System.Drawing.Size(50, 20);
            this.articleNumberLabel.TabIndex = 22;
            this.articleNumberLabel.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Manufacturer: ";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(618, 244);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(50, 20);
            this.manufacturerLabel.TabIndex = 24;
            this.manufacturerLabel.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Software Version: ";
            // 
            // softwareVerLabel
            // 
            this.softwareVerLabel.AutoSize = true;
            this.softwareVerLabel.Location = new System.Drawing.Point(618, 287);
            this.softwareVerLabel.Name = "softwareVerLabel";
            this.softwareVerLabel.Size = new System.Drawing.Size(50, 20);
            this.softwareVerLabel.TabIndex = 26;
            this.softwareVerLabel.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.softwareVerLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.articleNumberLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nominalCurrentlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nominalVoltageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceTypeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialNumberLabel);
            this.Controls.Add(this.PowerOutputCheckBox);
            this.Controls.Add(this.SetRemoteControlCheckBox);
            this.Controls.Add(this.ShowCurrentILabel);
            this.Controls.Add(this.CurrentILabel);
            this.Controls.Add(this.ShowVoltULabel);
            this.Controls.Add(this.VoltULabel);
            this.Controls.Add(this.setVoltTxtBox);
            this.Controls.Add(this.SetVolt);
            this.Controls.Add(this.showCurrentBtn);
            this.Controls.Add(this.showVoltBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showVoltBtn;
        private Button showCurrentBtn;
        private Button SetVolt;
        private TextBox setVoltTxtBox;
        private Label VoltULabel;
        private Label ShowVoltULabel;
        private Label CurrentILabel;
        private Label ShowCurrentILabel;
        private CheckBox SetRemoteControlCheckBox;
        private CheckBox PowerOutputCheckBox;
        private Label serialNumberLabel;
        private Label label1;
        private Label deviceTypeLabel;
        private Label label2;
        private Label label3;
        private Label nominalVoltageLabel;
        private Label label4;
        private Label nominalCurrentlabel;
        private Label label5;
        private Label articleNumberLabel;
        private Label label6;
        private Label manufacturerLabel;
        private Label label7;
        private Label softwareVerLabel;
    }
}