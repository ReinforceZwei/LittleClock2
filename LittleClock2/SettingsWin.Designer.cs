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
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationXInput = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.locationYInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.locationXInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationYInput)).BeginInit();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.Location = new System.Drawing.Point(71, 297);
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
            this.applyButton.Location = new System.Drawing.Point(152, 297);
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
            this.timeDisplayFormatComboBox.Location = new System.Drawing.Point(12, 143);
            this.timeDisplayFormatComboBox.Name = "timeDisplayFormatComboBox";
            this.timeDisplayFormatComboBox.Size = new System.Drawing.Size(121, 23);
            this.timeDisplayFormatComboBox.TabIndex = 6;
            this.timeDisplayFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.timeDisplayFormatComboBox_SelectedIndexChanged);
            // 
            // timeFormatLabel
            // 
            this.timeFormatLabel.AutoSize = true;
            this.timeFormatLabel.Location = new System.Drawing.Point(12, 125);
            this.timeFormatLabel.Name = "timeFormatLabel";
            this.timeFormatLabel.Size = new System.Drawing.Size(122, 15);
            this.timeFormatLabel.TabIndex = 7;
            this.timeFormatLabel.Text = "Time Display Format";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 187);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(56, 15);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "Location";
            // 
            // locationXInput
            // 
            this.locationXInput.Location = new System.Drawing.Point(12, 229);
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
            this.xLabel.Location = new System.Drawing.Point(12, 211);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 15);
            this.xLabel.TabIndex = 10;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(72, 211);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 15);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "Y";
            // 
            // locationYInput
            // 
            this.locationYInput.Location = new System.Drawing.Point(72, 229);
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
            // SettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 332);
            this.Controls.Add(this.locationYInput);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.locationXInput);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.timeFormatLabel);
            this.Controls.Add(this.timeDisplayFormatComboBox);
            this.Controls.Add(this.clickThroughCheckBox);
            this.Controls.Add(this.hideOnHoverCheckBox);
            this.Controls.Add(this.draggableCheckBox);
            this.Controls.Add(this.alwaysOnTopCheckBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.doneButton);
            this.MaximumSize = new System.Drawing.Size(255, 371);
            this.Name = "SettingsWin";
            this.Text = "SettingsWin";
            ((System.ComponentModel.ISupportInitialize)(this.locationXInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationYInput)).EndInit();
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
        private Label locationLabel;
        private NumericUpDown locationXInput;
        private Label xLabel;
        private Label yLabel;
        private NumericUpDown locationYInput;
    }
}