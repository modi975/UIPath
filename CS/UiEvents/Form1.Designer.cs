namespace UiEventsSample
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyModifier_Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EventType_Combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Monitor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SpecialKey_Combo = new System.Windows.Forms.ComboBox();
            this.StartVMMonitor = new System.Windows.Forms.Button();
            this.MonitorUIObject = new System.Windows.Forms.Button();
            this.StopMonitoring = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Blocking_Combo = new System.Windows.Forms.ComboBox();
            this.IncludeChildren_Checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse button";
            // 
            // BTN_Combo
            // 
            this.BTN_Combo.FormattingEnabled = true;
            this.BTN_Combo.Items.AddRange(new object[] {
            "UI_CLICK_LEFT",
            "UI_CLICK_RIGHT",
            "UI_CLICK_MIDDLE"});
            this.BTN_Combo.Location = new System.Drawing.Point(93, 54);
            this.BTN_Combo.Name = "BTN_Combo";
            this.BTN_Combo.Size = new System.Drawing.Size(148, 21);
            this.BTN_Combo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key modifier";
            // 
            // KeyModifier_Combo
            // 
            this.KeyModifier_Combo.FormattingEnabled = true;
            this.KeyModifier_Combo.Items.AddRange(new object[] {
            "UiKeyEx_None",
            "UiKeyEx_Alt</option>",
            "UiKeyEx_Ctrl",
            "UiKeyEx_AltCtrl",
            "UiKeyEx_Shift",
            "UiKeyEx_ShiftAlt",
            "UiKeyEx_ShiftCtrl",
            "UiKeyEx_ShiftAltCtrl",
            "UiKeyEx_Win",
            "UiKeyEx_WinAlt",
            "UiKeyEx_WinCtrl",
            "UiKeyEx_WinAltCtrl",
            "UiKeyEx_WinShift",
            "UiKeyEx_WinShiftAlt",
            "UiKeyEx_WinShiftCtrl",
            "UiKeyEx_WinShiftAltCtrl"});
            this.KeyModifier_Combo.Location = new System.Drawing.Point(93, 134);
            this.KeyModifier_Combo.Name = "KeyModifier_Combo";
            this.KeyModifier_Combo.Size = new System.Drawing.Size(148, 21);
            this.KeyModifier_Combo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event type";
            // 
            // EventType_Combo
            // 
            this.EventType_Combo.FormattingEnabled = true;
            this.EventType_Combo.Items.AddRange(new object[] {
            "Asynchronous",
            "Synchronous"});
            this.EventType_Combo.Location = new System.Drawing.Point(93, 161);
            this.EventType_Combo.Name = "EventType_Combo";
            this.EventType_Combo.Size = new System.Drawing.Size(148, 21);
            this.EventType_Combo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(211, 81);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(30, 20);
            this.KeyTextBox.TabIndex = 7;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(13, 237);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(494, 152);
            this.LogTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Log Event";
            // 
            // Monitor
            // 
            this.Monitor.FormattingEnabled = true;
            this.Monitor.Items.AddRange(new object[] {
            "Mouse events",
            "Keyboard events"});
            this.Monitor.Location = new System.Drawing.Point(16, 13);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(225, 21);
            this.Monitor.TabIndex = 10;
            this.Monitor.SelectedIndexChanged += new System.EventHandler(this.Monitor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "or";
            // 
            // SpecialKey_Combo
            // 
            this.SpecialKey_Combo.FormattingEnabled = true;
            this.SpecialKey_Combo.Items.AddRange(new object[] {
            "Special key",
            "alt",
            "lalt",
            "ralt",
            "shift",
            "lshift",
            "rshift",
            "ctrl",
            "lctrl",
            "rctrl",
            "ins",
            "del",
            "home",
            "end",
            "pgup",
            "pgdn",
            "enter",
            "left",
            "right",
            "up",
            "down",
            "tab",
            "esc",
            "back",
            "pause",
            "f1",
            "f2",
            "f3",
            "f4",
            "f5",
            "f6",
            "f7",
            "f8",
            "f9",
            "f10",
            "f11",
            "f12",
            "caps",
            "num",
            "add",
            "sub",
            "mul",
            "div",
            "decimal",
            "break",
            "num0",
            "num1",
            "num2",
            "num3",
            "num4",
            "num5",
            "num6",
            "num7",
            "num8",
            "num9",
            "scroll",
            "sleep"});
            this.SpecialKey_Combo.Location = new System.Drawing.Point(93, 83);
            this.SpecialKey_Combo.Name = "SpecialKey_Combo";
            this.SpecialKey_Combo.Size = new System.Drawing.Size(92, 21);
            this.SpecialKey_Combo.TabIndex = 12;
            this.SpecialKey_Combo.SelectedIndexChanged += new System.EventHandler(this.SpecialKey_Combo_SelectedIndexChanged);
            // 
            // StartVMMonitor
            // 
            this.StartVMMonitor.Location = new System.Drawing.Point(259, 46);
            this.StartVMMonitor.Name = "StartVMMonitor";
            this.StartVMMonitor.Size = new System.Drawing.Size(108, 23);
            this.StartVMMonitor.TabIndex = 14;
            this.StartVMMonitor.Text = "Monitor system";
            this.StartVMMonitor.UseVisualStyleBackColor = true;
            this.StartVMMonitor.Click += new System.EventHandler(this.StartVMMonitor_Click);
            // 
            // MonitorUIObject
            // 
            this.MonitorUIObject.Location = new System.Drawing.Point(259, 81);
            this.MonitorUIObject.Name = "MonitorUIObject";
            this.MonitorUIObject.Size = new System.Drawing.Size(108, 23);
            this.MonitorUIObject.TabIndex = 15;
            this.MonitorUIObject.Text = "Monior UI object";
            this.MonitorUIObject.UseVisualStyleBackColor = true;
            this.MonitorUIObject.Click += new System.EventHandler(this.MonitorUIObject_Click);
            // 
            // StopMonitoring
            // 
            this.StopMonitoring.Location = new System.Drawing.Point(259, 134);
            this.StopMonitoring.Name = "StopMonitoring";
            this.StopMonitoring.Size = new System.Drawing.Size(108, 23);
            this.StopMonitoring.TabIndex = 16;
            this.StopMonitoring.Text = "Stop monitoring";
            this.StopMonitoring.UseVisualStyleBackColor = true;
            this.StopMonitoring.Click += new System.EventHandler(this.StopMonitoring_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Event mode";
            // 
            // Blocking_Combo
            // 
            this.Blocking_Combo.FormattingEnabled = true;
            this.Blocking_Combo.Items.AddRange(new object[] {
            "Forward",
            "Block"});
            this.Blocking_Combo.Location = new System.Drawing.Point(93, 189);
            this.Blocking_Combo.Name = "Blocking_Combo";
            this.Blocking_Combo.Size = new System.Drawing.Size(148, 21);
            this.Blocking_Combo.TabIndex = 18;
            // 
            // IncludeChildren_Checkbox
            // 
            this.IncludeChildren_Checkbox.AutoSize = true;
            this.IncludeChildren_Checkbox.Location = new System.Drawing.Point(17, 114);
            this.IncludeChildren_Checkbox.Name = "IncludeChildren_Checkbox";
            this.IncludeChildren_Checkbox.Size = new System.Drawing.Size(101, 17);
            this.IncludeChildren_Checkbox.TabIndex = 19;
            this.IncludeChildren_Checkbox.Text = "Include children";
            this.IncludeChildren_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 419);
            this.Controls.Add(this.IncludeChildren_Checkbox);
            this.Controls.Add(this.Blocking_Combo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StopMonitoring);
            this.Controls.Add(this.MonitorUIObject);
            this.Controls.Add(this.StartVMMonitor);
            this.Controls.Add(this.SpecialKey_Combo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Monitor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EventType_Combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyModifier_Combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Combo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UiEvents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BTN_Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KeyModifier_Combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EventType_Combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Monitor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SpecialKey_Combo;
        private System.Windows.Forms.Button StartVMMonitor;
        private System.Windows.Forms.Button MonitorUIObject;
        private System.Windows.Forms.Button StopMonitoring;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Blocking_Combo;
        private System.Windows.Forms.CheckBox IncludeChildren_Checkbox;
    }
}

