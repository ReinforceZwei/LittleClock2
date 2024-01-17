namespace LittleClock2
{
    partial class SettingsWin
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
            this.doneButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.alwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.draggableCheckBox = new System.Windows.Forms.CheckBox();
            this.hideOnHoverCheckBox = new System.Windows.Forms.CheckBox();
            this.clickThroughCheckBox = new System.Windows.Forms.CheckBox();
            this.timeDisplayFormatComboBox = new System.Windows.Forms.ComboBox();
            this.timeFormatLabel = new System.Windows.Forms.Label();
            this.locationXInput = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.locationYInput = new System.Windows.Forms.NumericUpDown();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.useAbsoluteLocationCheckbox = new System.Windows.Forms.CheckBox();
            this.bottomRightLocationButton = new System.Windows.Forms.RadioButton();
            this.bottomLocationButton = new System.Windows.Forms.RadioButton();
            this.bottomLeftLocation = new System.Windows.Forms.RadioButton();
            this.rightLocationButton = new System.Windows.Forms.RadioButton();
            this.centerLocationButton = new System.Windows.Forms.RadioButton();
            this.leftLocationButton = new System.Windows.Forms.RadioButton();
            this.topRightLocationButton = new System.Windows.Forms.RadioButton();
            this.topLocationButton = new System.Windows.Forms.RadioButton();
            this.topLeftLocationButton = new System.Windows.Forms.RadioButton();
            this.idleOpacityInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.idleTimeoutInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationXInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationYInput)).BeginInit();
            this.locationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idleOpacityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idleTimeoutInput)).BeginInit();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.Location = new System.Drawing.Point(168, 287);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Close";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.OnDoneButtonClicked);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(249, 287);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.OnApplyButtonClicked);
            // 
            // alwaysOnTopCheckBox
            // 
            this.alwaysOnTopCheckBox.AutoSize = true;
            this.alwaysOnTopCheckBox.Location = new System.Drawing.Point(12, 12);
            this.alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox";
            this.alwaysOnTopCheckBox.Size = new System.Drawing.Size(110, 19);
            this.alwaysOnTopCheckBox.TabIndex = 2;
            this.alwaysOnTopCheckBox.Text = "Always On Top";
            this.alwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            this.alwaysOnTopCheckBox.CheckedChanged += new System.EventHandler(this.alwaysOnTopCheckBox_CheckedChanged);
            // 
            // draggableCheckBox
            // 
            this.draggableCheckBox.AutoSize = true;
            this.draggableCheckBox.Location = new System.Drawing.Point(12, 37);
            this.draggableCheckBox.Name = "draggableCheckBox";
            this.draggableCheckBox.Size = new System.Drawing.Size(87, 19);
            this.draggableCheckBox.TabIndex = 3;
            this.draggableCheckBox.Text = "Draggable";
            this.draggableCheckBox.UseVisualStyleBackColor = true;
            this.draggableCheckBox.CheckedChanged += new System.EventHandler(this.draggableCheckBox_CheckedChanged);
            // 
            // hideOnHoverCheckBox
            // 
            this.hideOnHoverCheckBox.AutoSize = true;
            this.hideOnHoverCheckBox.Location = new System.Drawing.Point(12, 62);
            this.hideOnHoverCheckBox.Name = "hideOnHoverCheckBox";
            this.hideOnHoverCheckBox.Size = new System.Drawing.Size(152, 19);
            this.hideOnHoverCheckBox.TabIndex = 4;
            this.hideOnHoverCheckBox.Text = "Hide On Mouse Hover";
            this.hideOnHoverCheckBox.UseVisualStyleBackColor = true;
            this.hideOnHoverCheckBox.CheckedChanged += new System.EventHandler(this.hideOnHoverCheckBox_CheckedChanged);
            // 
            // clickThroughCheckBox
            // 
            this.clickThroughCheckBox.AutoSize = true;
            this.clickThroughCheckBox.Location = new System.Drawing.Point(12, 87);
            this.clickThroughCheckBox.Name = "clickThroughCheckBox";
            this.clickThroughCheckBox.Size = new System.Drawing.Size(105, 19);
            this.clickThroughCheckBox.TabIndex = 5;
            this.clickThroughCheckBox.Text = "Click-Through";
            this.clickThroughCheckBox.UseVisualStyleBackColor = true;
            this.clickThroughCheckBox.CheckedChanged += new System.EventHandler(this.clickThroughCheckBox_CheckedChanged);
            // 
            // timeDisplayFormatComboBox
            // 
            this.timeDisplayFormatComboBox.FormattingEnabled = true;
            this.timeDisplayFormatComboBox.Location = new System.Drawing.Point(168, 30);
            this.timeDisplayFormatComboBox.Name = "timeDisplayFormatComboBox";
            this.timeDisplayFormatComboBox.Size = new System.Drawing.Size(155, 23);
            this.timeDisplayFormatComboBox.TabIndex = 6;
            this.timeDisplayFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.timeDisplayFormatComboBox_SelectedIndexChanged);
            // 
            // timeFormatLabel
            // 
            this.timeFormatLabel.AutoSize = true;
            this.timeFormatLabel.Location = new System.Drawing.Point(168, 13);
            this.timeFormatLabel.Name = "timeFormatLabel";
            this.timeFormatLabel.Size = new System.Drawing.Size(122, 15);
            this.timeFormatLabel.TabIndex = 7;
            this.timeFormatLabel.Text = "Time Display Format";
            // 
            // locationXInput
            // 
            this.locationXInput.Location = new System.Drawing.Point(177, 20);
            this.locationXInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.locationXInput.Name = "locationXInput";
            this.locationXInput.Size = new System.Drawing.Size(50, 23);
            this.locationXInput.TabIndex = 9;
            this.locationXInput.ValueChanged += new System.EventHandler(this.locationXInput_ValueChanged);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(156, 23);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 15);
            this.xLabel.TabIndex = 10;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(233, 23);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 15);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "Y";
            // 
            // locationYInput
            // 
            this.locationYInput.Location = new System.Drawing.Point(253, 20);
            this.locationYInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.locationYInput.Name = "locationYInput";
            this.locationYInput.Size = new System.Drawing.Size(50, 23);
            this.locationYInput.TabIndex = 12;
            this.locationYInput.ValueChanged += new System.EventHandler(this.locationYInput_ValueChanged);
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.useAbsoluteLocationCheckbox);
            this.locationGroupBox.Controls.Add(this.bottomRightLocationButton);
            this.locationGroupBox.Controls.Add(this.bottomLocationButton);
            this.locationGroupBox.Controls.Add(this.bottomLeftLocation);
            this.locationGroupBox.Controls.Add(this.rightLocationButton);
            this.locationGroupBox.Controls.Add(this.centerLocationButton);
            this.locationGroupBox.Controls.Add(this.leftLocationButton);
            this.locationGroupBox.Controls.Add(this.topRightLocationButton);
            this.locationGroupBox.Controls.Add(this.topLocationButton);
            this.locationGroupBox.Controls.Add(this.topLeftLocationButton);
            this.locationGroupBox.Controls.Add(this.xLabel);
            this.locationGroupBox.Controls.Add(this.locationYInput);
            this.locationGroupBox.Controls.Add(this.locationXInput);
            this.locationGroupBox.Controls.Add(this.yLabel);
            this.locationGroupBox.Location = new System.Drawing.Point(12, 112);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(311, 165);
            this.locationGroupBox.TabIndex = 13;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // useAbsoluteLocationCheckbox
            // 
            this.useAbsoluteLocationCheckbox.AutoSize = true;
            this.useAbsoluteLocationCheckbox.Location = new System.Drawing.Point(7, 22);
            this.useAbsoluteLocationCheckbox.Name = "useAbsoluteLocationCheckbox";
            this.useAbsoluteLocationCheckbox.Size = new System.Drawing.Size(148, 19);
            this.useAbsoluteLocationCheckbox.TabIndex = 22;
            this.useAbsoluteLocationCheckbox.Text = "Use Absolute Position";
            this.useAbsoluteLocationCheckbox.UseVisualStyleBackColor = true;
            this.useAbsoluteLocationCheckbox.CheckedChanged += new System.EventHandler(this.useAbsoluteLocationCheckbox_CheckedChanged);
            // 
            // bottomRightLocationButton
            // 
            this.bottomRightLocationButton.AutoSize = true;
            this.bottomRightLocationButton.Location = new System.Drawing.Point(190, 132);
            this.bottomRightLocationButton.Name = "bottomRightLocationButton";
            this.bottomRightLocationButton.Size = new System.Drawing.Size(100, 19);
            this.bottomRightLocationButton.TabIndex = 21;
            this.bottomRightLocationButton.TabStop = true;
            this.bottomRightLocationButton.Text = "Bottom Right";
            this.bottomRightLocationButton.UseVisualStyleBackColor = true;
            // 
            // bottomLocationButton
            // 
            this.bottomLocationButton.AutoSize = true;
            this.bottomLocationButton.Location = new System.Drawing.Point(104, 132);
            this.bottomLocationButton.Name = "bottomLocationButton";
            this.bottomLocationButton.Size = new System.Drawing.Size(67, 19);
            this.bottomLocationButton.TabIndex = 20;
            this.bottomLocationButton.TabStop = true;
            this.bottomLocationButton.Text = "Bottom";
            this.bottomLocationButton.UseVisualStyleBackColor = true;
            // 
            // bottomLeftLocation
            // 
            this.bottomLeftLocation.AutoSize = true;
            this.bottomLeftLocation.Location = new System.Drawing.Point(7, 132);
            this.bottomLeftLocation.Name = "bottomLeftLocation";
            this.bottomLeftLocation.Size = new System.Drawing.Size(91, 19);
            this.bottomLeftLocation.TabIndex = 19;
            this.bottomLeftLocation.TabStop = true;
            this.bottomLeftLocation.Text = "Bottom Left";
            this.bottomLeftLocation.UseVisualStyleBackColor = true;
            // 
            // rightLocationButton
            // 
            this.rightLocationButton.AutoSize = true;
            this.rightLocationButton.Location = new System.Drawing.Point(190, 93);
            this.rightLocationButton.Name = "rightLocationButton";
            this.rightLocationButton.Size = new System.Drawing.Size(55, 19);
            this.rightLocationButton.TabIndex = 18;
            this.rightLocationButton.TabStop = true;
            this.rightLocationButton.Text = "Right";
            this.rightLocationButton.UseVisualStyleBackColor = true;
            // 
            // centerLocationButton
            // 
            this.centerLocationButton.AutoSize = true;
            this.centerLocationButton.Location = new System.Drawing.Point(104, 93);
            this.centerLocationButton.Name = "centerLocationButton";
            this.centerLocationButton.Size = new System.Drawing.Size(62, 19);
            this.centerLocationButton.TabIndex = 17;
            this.centerLocationButton.TabStop = true;
            this.centerLocationButton.Text = "Center";
            this.centerLocationButton.UseVisualStyleBackColor = true;
            // 
            // leftLocationButton
            // 
            this.leftLocationButton.AutoSize = true;
            this.leftLocationButton.Location = new System.Drawing.Point(7, 93);
            this.leftLocationButton.Name = "leftLocationButton";
            this.leftLocationButton.Size = new System.Drawing.Size(46, 19);
            this.leftLocationButton.TabIndex = 16;
            this.leftLocationButton.TabStop = true;
            this.leftLocationButton.Text = "Left";
            this.leftLocationButton.UseVisualStyleBackColor = true;
            // 
            // topRightLocationButton
            // 
            this.topRightLocationButton.AutoSize = true;
            this.topRightLocationButton.Location = new System.Drawing.Point(190, 51);
            this.topRightLocationButton.Name = "topRightLocationButton";
            this.topRightLocationButton.Size = new System.Drawing.Size(81, 19);
            this.topRightLocationButton.TabIndex = 15;
            this.topRightLocationButton.TabStop = true;
            this.topRightLocationButton.Text = "Top Right";
            this.topRightLocationButton.UseVisualStyleBackColor = true;
            // 
            // topLocationButton
            // 
            this.topLocationButton.AutoSize = true;
            this.topLocationButton.Location = new System.Drawing.Point(104, 51);
            this.topLocationButton.Name = "topLocationButton";
            this.topLocationButton.Size = new System.Drawing.Size(48, 19);
            this.topLocationButton.TabIndex = 14;
            this.topLocationButton.TabStop = true;
            this.topLocationButton.Text = "Top";
            this.topLocationButton.UseVisualStyleBackColor = true;
            // 
            // topLeftLocationButton
            // 
            this.topLeftLocationButton.AutoSize = true;
            this.topLeftLocationButton.Location = new System.Drawing.Point(7, 51);
            this.topLeftLocationButton.Name = "topLeftLocationButton";
            this.topLeftLocationButton.Size = new System.Drawing.Size(72, 19);
            this.topLeftLocationButton.TabIndex = 13;
            this.topLeftLocationButton.TabStop = true;
            this.topLeftLocationButton.Text = "Top Left";
            this.topLeftLocationButton.UseVisualStyleBackColor = true;
            // 
            // idleOpacityInput
            // 
            this.idleOpacityInput.DecimalPlaces = 2;
            this.idleOpacityInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.idleOpacityInput.Location = new System.Drawing.Point(273, 59);
            this.idleOpacityInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idleOpacityInput.Name = "idleOpacityInput";
            this.idleOpacityInput.Size = new System.Drawing.Size(50, 23);
            this.idleOpacityInput.TabIndex = 14;
            this.idleOpacityInput.ValueChanged += new System.EventHandler(this.idleOpacityInput_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Idle Opacity";
            // 
            // idleTimeoutInput
            // 
            this.idleTimeoutInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.idleTimeoutInput.Location = new System.Drawing.Point(273, 86);
            this.idleTimeoutInput.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.idleTimeoutInput.Name = "idleTimeoutInput";
            this.idleTimeoutInput.Size = new System.Drawing.Size(50, 23);
            this.idleTimeoutInput.TabIndex = 16;
            this.idleTimeoutInput.ValueChanged += new System.EventHandler(this.idleTimeoutInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Idle Timeout (ms)";
            // 
            // SettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idleTimeoutInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idleOpacityInput);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.timeFormatLabel);
            this.Controls.Add(this.timeDisplayFormatComboBox);
            this.Controls.Add(this.clickThroughCheckBox);
            this.Controls.Add(this.hideOnHoverCheckBox);
            this.Controls.Add(this.draggableCheckBox);
            this.Controls.Add(this.alwaysOnTopCheckBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.doneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsWin";
            this.Text = "SettingsWin";
            ((System.ComponentModel.ISupportInitialize)(this.locationXInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationYInput)).EndInit();
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idleOpacityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idleTimeoutInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button doneButton;
        private Button applyButton;
        private CheckBox alwaysOnTopCheckBox;
        private CheckBox draggableCheckBox;
        private CheckBox hideOnHoverCheckBox;
        private CheckBox clickThroughCheckBox;
        private ComboBox timeDisplayFormatComboBox;
        private Label timeFormatLabel;
        private NumericUpDown locationXInput;
        private Label xLabel;
        private Label yLabel;
        private NumericUpDown locationYInput;
        private GroupBox locationGroupBox;
        private CheckBox useAbsoluteLocationCheckbox;
        private RadioButton bottomRightLocationButton;
        private RadioButton bottomLocationButton;
        private RadioButton bottomLeftLocation;
        private RadioButton rightLocationButton;
        private RadioButton centerLocationButton;
        private RadioButton leftLocationButton;
        private RadioButton topRightLocationButton;
        private RadioButton topLocationButton;
        private RadioButton topLeftLocationButton;
        private NumericUpDown idleOpacityInput;
        private Label label1;
        private NumericUpDown idleTimeoutInput;
        private Label label2;
    }
}