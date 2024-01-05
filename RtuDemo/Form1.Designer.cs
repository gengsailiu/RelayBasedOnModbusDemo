namespace RtuDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRelays = new SeeSharpTools.JY.GUI.ButtonSwitchArray();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ledConnected = new SeeSharpTools.JY.GUI.LED();
            this.btnReadDoStatus = new System.Windows.Forms.Button();
            this.ledDoStatus = new SeeSharpTools.JY.GUI.LEDArray();
            this.SuspendLayout();
            // 
            // btnRelays
            // 
            this.btnRelays.ControlHeight = 30;
            this.btnRelays.ControlWidth = 80;
            this.btnRelays.Dimension = ((uint)(8u));
            this.btnRelays.Direction = false;
            this.btnRelays.Location = new System.Drawing.Point(44, 102);
            this.btnRelays.Name = "btnRelays";
            this.btnRelays.Size = new System.Drawing.Size(705, 55);
            this.btnRelays.Style = SeeSharpTools.JY.GUI.ButtonSwitch.ButtonSwitchStyle.Metro;
            this.btnRelays.TabIndex = 0;
            this.btnRelays.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            this.btnRelays.ControlValueChanged += new SeeSharpTools.JY.GUI.ButtonSwitchArray.ValueChangedEventHandler(this.btnRelays_ControlValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relay";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(44, 28);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(152, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ledConnected
            // 
            this.ledConnected.BlinkColor = System.Drawing.Color.Lime;
            this.ledConnected.BlinkInterval = 1000;
            this.ledConnected.BlinkOn = false;
            this.ledConnected.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ledConnected.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.ledConnected.Location = new System.Drawing.Point(257, 21);
            this.ledConnected.Name = "ledConnected";
            this.ledConnected.OffColor = System.Drawing.Color.Gray;
            this.ledConnected.OnColor = System.Drawing.Color.Lime;
            this.ledConnected.Size = new System.Drawing.Size(30, 30);
            this.ledConnected.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledConnected.TabIndex = 3;
            this.ledConnected.Value = false;
            // 
            // btnReadDoStatus
            // 
            this.btnReadDoStatus.Location = new System.Drawing.Point(44, 231);
            this.btnReadDoStatus.Name = "btnReadDoStatus";
            this.btnReadDoStatus.Size = new System.Drawing.Size(136, 23);
            this.btnReadDoStatus.TabIndex = 4;
            this.btnReadDoStatus.Text = "Read DO Status";
            this.btnReadDoStatus.UseVisualStyleBackColor = true;
            this.btnReadDoStatus.Click += new System.EventHandler(this.btnReadDoStatus_Click);
            // 
            // ledDoStatus
            // 
            this.ledDoStatus.ControlHeight = 30;
            this.ledDoStatus.ControlWidth = 30;
            this.ledDoStatus.Dimension = ((uint)(8u));
            this.ledDoStatus.Direction = false;
            this.ledDoStatus.LEDOffColor = System.Drawing.Color.Gray;
            this.ledDoStatus.LEDOnColor = System.Drawing.Color.Lime;
            this.ledDoStatus.LEDStyle = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledDoStatus.Location = new System.Drawing.Point(44, 286);
            this.ledDoStatus.Name = "ledDoStatus";
            this.ledDoStatus.Size = new System.Drawing.Size(316, 55);
            this.ledDoStatus.TabIndex = 5;
            this.ledDoStatus.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ledDoStatus);
            this.Controls.Add(this.btnReadDoStatus);
            this.Controls.Add(this.ledConnected);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.ButtonSwitchArray btnRelays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private SeeSharpTools.JY.GUI.LED ledConnected;
        private System.Windows.Forms.Button btnReadDoStatus;
        private SeeSharpTools.JY.GUI.LEDArray ledDoStatus;
    }
}

