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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWin));
            doneButton = new Button();
            applyButton = new Button();
            alwaysOnTopCheckBox = new CheckBox();
            draggableCheckBox = new CheckBox();
            hideOnHoverCheckBox = new CheckBox();
            clickThroughCheckBox = new CheckBox();
            timeDisplayFormatComboBox = new ComboBox();
            timeFormatLabel = new Label();
            locationXInput = new NumericUpDown();
            xLabel = new Label();
            yLabel = new Label();
            locationYInput = new NumericUpDown();
            locationGroupBox = new GroupBox();
            useAbsoluteLocationCheckbox = new CheckBox();
            bottomRightLocationButton = new RadioButton();
            bottomLocationButton = new RadioButton();
            bottomLeftLocation = new RadioButton();
            rightLocationButton = new RadioButton();
            centerLocationButton = new RadioButton();
            leftLocationButton = new RadioButton();
            topRightLocationButton = new RadioButton();
            topLocationButton = new RadioButton();
            topLeftLocationButton = new RadioButton();
            idleOpacityInput = new NumericUpDown();
            label1 = new Label();
            idleTimeoutInput = new NumericUpDown();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            forceAlwaysOnTopCheckbox = new CheckBox();
            settingModeLabel = new Label();
            linkLabel1 = new LinkLabel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            useRoundedCornerCheckbox = new CheckBox();
            label6 = new Label();
            bottomPaddingInput = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pickBackgroundColorBtn = new Button();
            pickTextColorBtn = new Button();
            backgroundColorDisplay = new PictureBox();
            textColorDisplay = new PictureBox();
            fontSizeInput = new NumericUpDown();
            fontStyleSelectBox = new ComboBox();
            fontSelectBox = new ComboBox();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)locationXInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationYInput).BeginInit();
            locationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idleOpacityInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idleTimeoutInput).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bottomPaddingInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundColorDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textColorDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeInput).BeginInit();
            SuspendLayout();
            // 
            // doneButton
            // 
            doneButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            doneButton.Location = new Point(192, 231);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(75, 23);
            doneButton.TabIndex = 0;
            doneButton.Text = "Close";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += OnDoneButtonClicked;
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyButton.Location = new Point(273, 231);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 1;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += OnApplyButtonClicked;
            // 
            // alwaysOnTopCheckBox
            // 
            alwaysOnTopCheckBox.AutoSize = true;
            alwaysOnTopCheckBox.Location = new Point(6, 6);
            alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox";
            alwaysOnTopCheckBox.Size = new Size(110, 19);
            alwaysOnTopCheckBox.TabIndex = 2;
            alwaysOnTopCheckBox.Text = "Always On Top";
            alwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            alwaysOnTopCheckBox.CheckedChanged += alwaysOnTopCheckBox_CheckedChanged;
            // 
            // draggableCheckBox
            // 
            draggableCheckBox.AutoSize = true;
            draggableCheckBox.Location = new Point(6, 56);
            draggableCheckBox.Name = "draggableCheckBox";
            draggableCheckBox.Size = new Size(87, 19);
            draggableCheckBox.TabIndex = 3;
            draggableCheckBox.Text = "Draggable";
            draggableCheckBox.UseVisualStyleBackColor = true;
            draggableCheckBox.CheckedChanged += draggableCheckBox_CheckedChanged;
            // 
            // hideOnHoverCheckBox
            // 
            hideOnHoverCheckBox.AutoSize = true;
            hideOnHoverCheckBox.Location = new Point(6, 81);
            hideOnHoverCheckBox.Name = "hideOnHoverCheckBox";
            hideOnHoverCheckBox.Size = new Size(152, 19);
            hideOnHoverCheckBox.TabIndex = 4;
            hideOnHoverCheckBox.Text = "Hide On Mouse Hover";
            hideOnHoverCheckBox.UseVisualStyleBackColor = true;
            hideOnHoverCheckBox.CheckedChanged += hideOnHoverCheckBox_CheckedChanged;
            // 
            // clickThroughCheckBox
            // 
            clickThroughCheckBox.AutoSize = true;
            clickThroughCheckBox.Location = new Point(6, 106);
            clickThroughCheckBox.Name = "clickThroughCheckBox";
            clickThroughCheckBox.Size = new Size(105, 19);
            clickThroughCheckBox.TabIndex = 5;
            clickThroughCheckBox.Text = "Click-Through";
            clickThroughCheckBox.UseVisualStyleBackColor = true;
            clickThroughCheckBox.CheckedChanged += clickThroughCheckBox_CheckedChanged;
            // 
            // timeDisplayFormatComboBox
            // 
            timeDisplayFormatComboBox.FormattingEnabled = true;
            timeDisplayFormatComboBox.Location = new Point(162, 24);
            timeDisplayFormatComboBox.Name = "timeDisplayFormatComboBox";
            timeDisplayFormatComboBox.Size = new Size(155, 23);
            timeDisplayFormatComboBox.TabIndex = 6;
            timeDisplayFormatComboBox.TextChanged += timeDisplayFormatComboBox_TextUpdate;
            // 
            // timeFormatLabel
            // 
            timeFormatLabel.AutoSize = true;
            timeFormatLabel.Location = new Point(162, 7);
            timeFormatLabel.Name = "timeFormatLabel";
            timeFormatLabel.Size = new Size(122, 15);
            timeFormatLabel.TabIndex = 7;
            timeFormatLabel.Text = "Time Display Format";
            // 
            // locationXInput
            // 
            locationXInput.Location = new Point(177, 20);
            locationXInput.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            locationXInput.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            locationXInput.Name = "locationXInput";
            locationXInput.Size = new Size(50, 23);
            locationXInput.TabIndex = 9;
            locationXInput.ValueChanged += locationXInput_ValueChanged;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(156, 23);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(15, 15);
            xLabel.TabIndex = 10;
            xLabel.Text = "X";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(233, 23);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(14, 15);
            yLabel.TabIndex = 11;
            yLabel.Text = "Y";
            // 
            // locationYInput
            // 
            locationYInput.Location = new Point(253, 20);
            locationYInput.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            locationYInput.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            locationYInput.Name = "locationYInput";
            locationYInput.Size = new Size(50, 23);
            locationYInput.TabIndex = 12;
            locationYInput.ValueChanged += locationYInput_ValueChanged;
            // 
            // locationGroupBox
            // 
            locationGroupBox.Controls.Add(useAbsoluteLocationCheckbox);
            locationGroupBox.Controls.Add(bottomRightLocationButton);
            locationGroupBox.Controls.Add(bottomLocationButton);
            locationGroupBox.Controls.Add(bottomLeftLocation);
            locationGroupBox.Controls.Add(rightLocationButton);
            locationGroupBox.Controls.Add(centerLocationButton);
            locationGroupBox.Controls.Add(leftLocationButton);
            locationGroupBox.Controls.Add(topRightLocationButton);
            locationGroupBox.Controls.Add(topLocationButton);
            locationGroupBox.Controls.Add(topLeftLocationButton);
            locationGroupBox.Controls.Add(xLabel);
            locationGroupBox.Controls.Add(locationYInput);
            locationGroupBox.Controls.Add(locationXInput);
            locationGroupBox.Controls.Add(yLabel);
            locationGroupBox.Location = new Point(6, 6);
            locationGroupBox.Name = "locationGroupBox";
            locationGroupBox.Size = new Size(311, 165);
            locationGroupBox.TabIndex = 13;
            locationGroupBox.TabStop = false;
            locationGroupBox.Text = "Location";
            // 
            // useAbsoluteLocationCheckbox
            // 
            useAbsoluteLocationCheckbox.AutoSize = true;
            useAbsoluteLocationCheckbox.Location = new Point(7, 22);
            useAbsoluteLocationCheckbox.Name = "useAbsoluteLocationCheckbox";
            useAbsoluteLocationCheckbox.Size = new Size(148, 19);
            useAbsoluteLocationCheckbox.TabIndex = 22;
            useAbsoluteLocationCheckbox.Text = "Use Absolute Position";
            useAbsoluteLocationCheckbox.UseVisualStyleBackColor = true;
            useAbsoluteLocationCheckbox.CheckedChanged += useAbsoluteLocationCheckbox_CheckedChanged;
            // 
            // bottomRightLocationButton
            // 
            bottomRightLocationButton.AutoSize = true;
            bottomRightLocationButton.Location = new Point(190, 132);
            bottomRightLocationButton.Name = "bottomRightLocationButton";
            bottomRightLocationButton.Size = new Size(100, 19);
            bottomRightLocationButton.TabIndex = 21;
            bottomRightLocationButton.TabStop = true;
            bottomRightLocationButton.Text = "Bottom Right";
            bottomRightLocationButton.UseVisualStyleBackColor = true;
            // 
            // bottomLocationButton
            // 
            bottomLocationButton.AutoSize = true;
            bottomLocationButton.Location = new Point(104, 132);
            bottomLocationButton.Name = "bottomLocationButton";
            bottomLocationButton.Size = new Size(67, 19);
            bottomLocationButton.TabIndex = 20;
            bottomLocationButton.TabStop = true;
            bottomLocationButton.Text = "Bottom";
            bottomLocationButton.UseVisualStyleBackColor = true;
            // 
            // bottomLeftLocation
            // 
            bottomLeftLocation.AutoSize = true;
            bottomLeftLocation.Location = new Point(7, 132);
            bottomLeftLocation.Name = "bottomLeftLocation";
            bottomLeftLocation.Size = new Size(91, 19);
            bottomLeftLocation.TabIndex = 19;
            bottomLeftLocation.TabStop = true;
            bottomLeftLocation.Text = "Bottom Left";
            bottomLeftLocation.UseVisualStyleBackColor = true;
            // 
            // rightLocationButton
            // 
            rightLocationButton.AutoSize = true;
            rightLocationButton.Location = new Point(190, 93);
            rightLocationButton.Name = "rightLocationButton";
            rightLocationButton.Size = new Size(55, 19);
            rightLocationButton.TabIndex = 18;
            rightLocationButton.TabStop = true;
            rightLocationButton.Text = "Right";
            rightLocationButton.UseVisualStyleBackColor = true;
            // 
            // centerLocationButton
            // 
            centerLocationButton.AutoSize = true;
            centerLocationButton.Location = new Point(104, 93);
            centerLocationButton.Name = "centerLocationButton";
            centerLocationButton.Size = new Size(62, 19);
            centerLocationButton.TabIndex = 17;
            centerLocationButton.TabStop = true;
            centerLocationButton.Text = "Center";
            centerLocationButton.UseVisualStyleBackColor = true;
            // 
            // leftLocationButton
            // 
            leftLocationButton.AutoSize = true;
            leftLocationButton.Location = new Point(7, 93);
            leftLocationButton.Name = "leftLocationButton";
            leftLocationButton.Size = new Size(46, 19);
            leftLocationButton.TabIndex = 16;
            leftLocationButton.TabStop = true;
            leftLocationButton.Text = "Left";
            leftLocationButton.UseVisualStyleBackColor = true;
            // 
            // topRightLocationButton
            // 
            topRightLocationButton.AutoSize = true;
            topRightLocationButton.Location = new Point(190, 51);
            topRightLocationButton.Name = "topRightLocationButton";
            topRightLocationButton.Size = new Size(81, 19);
            topRightLocationButton.TabIndex = 15;
            topRightLocationButton.TabStop = true;
            topRightLocationButton.Text = "Top Right";
            topRightLocationButton.UseVisualStyleBackColor = true;
            // 
            // topLocationButton
            // 
            topLocationButton.AutoSize = true;
            topLocationButton.Location = new Point(104, 51);
            topLocationButton.Name = "topLocationButton";
            topLocationButton.Size = new Size(48, 19);
            topLocationButton.TabIndex = 14;
            topLocationButton.TabStop = true;
            topLocationButton.Text = "Top";
            topLocationButton.UseVisualStyleBackColor = true;
            // 
            // topLeftLocationButton
            // 
            topLeftLocationButton.AutoSize = true;
            topLeftLocationButton.Location = new Point(7, 51);
            topLeftLocationButton.Name = "topLeftLocationButton";
            topLeftLocationButton.Size = new Size(72, 19);
            topLeftLocationButton.TabIndex = 13;
            topLeftLocationButton.TabStop = true;
            topLeftLocationButton.Text = "Top Left";
            topLeftLocationButton.UseVisualStyleBackColor = true;
            // 
            // idleOpacityInput
            // 
            idleOpacityInput.DecimalPlaces = 2;
            idleOpacityInput.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            idleOpacityInput.Location = new Point(267, 53);
            idleOpacityInput.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            idleOpacityInput.Name = "idleOpacityInput";
            idleOpacityInput.Size = new Size(50, 23);
            idleOpacityInput.TabIndex = 14;
            idleOpacityInput.ValueChanged += idleOpacityInput_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 55);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 15;
            label1.Text = "Idle Opacity";
            // 
            // idleTimeoutInput
            // 
            idleTimeoutInput.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            idleTimeoutInput.Location = new Point(267, 80);
            idleTimeoutInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            idleTimeoutInput.Name = "idleTimeoutInput";
            idleTimeoutInput.Size = new Size(50, 23);
            idleTimeoutInput.TabIndex = 16;
            idleTimeoutInput.ValueChanged += idleTimeoutInput_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 82);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 17;
            label2.Text = "Idle Timeout (ms)";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(336, 210);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(forceAlwaysOnTopCheckbox);
            tabPage1.Controls.Add(settingModeLabel);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(alwaysOnTopCheckBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(draggableCheckBox);
            tabPage1.Controls.Add(idleTimeoutInput);
            tabPage1.Controls.Add(hideOnHoverCheckBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(clickThroughCheckBox);
            tabPage1.Controls.Add(idleOpacityInput);
            tabPage1.Controls.Add(timeDisplayFormatComboBox);
            tabPage1.Controls.Add(timeFormatLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(328, 182);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // forceAlwaysOnTopCheckbox
            // 
            forceAlwaysOnTopCheckbox.AutoSize = true;
            forceAlwaysOnTopCheckbox.Location = new Point(25, 31);
            forceAlwaysOnTopCheckbox.Name = "forceAlwaysOnTopCheckbox";
            forceAlwaysOnTopCheckbox.Size = new Size(57, 19);
            forceAlwaysOnTopCheckbox.TabIndex = 20;
            forceAlwaysOnTopCheckbox.Text = "Force";
            forceAlwaysOnTopCheckbox.UseVisualStyleBackColor = true;
            forceAlwaysOnTopCheckbox.CheckedChanged += forceAlwaysOnTopCheckbox_CheckedChanged;
            // 
            // settingModeLabel
            // 
            settingModeLabel.Location = new Point(122, 159);
            settingModeLabel.Name = "settingModeLabel";
            settingModeLabel.Size = new Size(203, 23);
            settingModeLabel.TabIndex = 19;
            settingModeLabel.Text = "Using AppData settings";
            settingModeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(3, 164);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 15);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Fork me on GitHub";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(locationGroupBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(328, 182);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Position";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(useRoundedCornerCheckbox);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(bottomPaddingInput);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(pickBackgroundColorBtn);
            tabPage3.Controls.Add(pickTextColorBtn);
            tabPage3.Controls.Add(backgroundColorDisplay);
            tabPage3.Controls.Add(textColorDisplay);
            tabPage3.Controls.Add(fontSizeInput);
            tabPage3.Controls.Add(fontStyleSelectBox);
            tabPage3.Controls.Add(fontSelectBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(328, 182);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Style";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // useRoundedCornerCheckbox
            // 
            useRoundedCornerCheckbox.AutoSize = true;
            useRoundedCornerCheckbox.Location = new Point(6, 141);
            useRoundedCornerCheckbox.Name = "useRoundedCornerCheckbox";
            useRoundedCornerCheckbox.Size = new Size(144, 19);
            useRoundedCornerCheckbox.TabIndex = 13;
            useRoundedCornerCheckbox.Text = "Use Rounded Corner";
            useRoundedCornerCheckbox.UseVisualStyleBackColor = true;
            useRoundedCornerCheckbox.CheckedChanged += useRoundedCornerCheckbox_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 94);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 12;
            label6.Text = "Bottom Padding";
            // 
            // bottomPaddingInput
            // 
            bottomPaddingInput.Location = new Point(83, 112);
            bottomPaddingInput.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            bottomPaddingInput.Name = "bottomPaddingInput";
            bottomPaddingInput.Size = new Size(57, 23);
            bottomPaddingInput.TabIndex = 11;
            bottomPaddingInput.ValueChanged += bottomPaddingInput_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 94);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Font Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 47);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Font Style";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Font";
            // 
            // pickBackgroundColorBtn
            // 
            pickBackgroundColorBtn.Location = new Point(189, 108);
            pickBackgroundColorBtn.Name = "pickBackgroundColorBtn";
            pickBackgroundColorBtn.Size = new Size(133, 23);
            pickBackgroundColorBtn.TabIndex = 6;
            pickBackgroundColorBtn.Text = "Background Color";
            pickBackgroundColorBtn.UseVisualStyleBackColor = true;
            pickBackgroundColorBtn.Click += pickBackgroundColorBtn_Click;
            // 
            // pickTextColorBtn
            // 
            pickTextColorBtn.Location = new Point(189, 50);
            pickTextColorBtn.Name = "pickTextColorBtn";
            pickTextColorBtn.Size = new Size(133, 23);
            pickTextColorBtn.TabIndex = 5;
            pickTextColorBtn.Text = "Text Color";
            pickTextColorBtn.UseVisualStyleBackColor = true;
            pickTextColorBtn.Click += pickTextColorBtn_Click;
            // 
            // backgroundColorDisplay
            // 
            backgroundColorDisplay.BorderStyle = BorderStyle.FixedSingle;
            backgroundColorDisplay.Location = new Point(189, 137);
            backgroundColorDisplay.Name = "backgroundColorDisplay";
            backgroundColorDisplay.Size = new Size(133, 23);
            backgroundColorDisplay.TabIndex = 4;
            backgroundColorDisplay.TabStop = false;
            // 
            // textColorDisplay
            // 
            textColorDisplay.BorderStyle = BorderStyle.FixedSingle;
            textColorDisplay.Location = new Point(189, 79);
            textColorDisplay.Name = "textColorDisplay";
            textColorDisplay.Size = new Size(133, 23);
            textColorDisplay.TabIndex = 3;
            textColorDisplay.TabStop = false;
            // 
            // fontSizeInput
            // 
            fontSizeInput.Location = new Point(6, 112);
            fontSizeInput.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            fontSizeInput.Name = "fontSizeInput";
            fontSizeInput.Size = new Size(53, 23);
            fontSizeInput.TabIndex = 2;
            fontSizeInput.ValueChanged += fontSizeInput_ValueChanged;
            // 
            // fontStyleSelectBox
            // 
            fontStyleSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontStyleSelectBox.FormattingEnabled = true;
            fontStyleSelectBox.Location = new Point(6, 68);
            fontStyleSelectBox.Name = "fontStyleSelectBox";
            fontStyleSelectBox.Size = new Size(134, 23);
            fontStyleSelectBox.TabIndex = 1;
            fontStyleSelectBox.SelectedIndexChanged += fontStyleSelectBox_SelectedIndexChanged;
            // 
            // fontSelectBox
            // 
            fontSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontSelectBox.FormattingEnabled = true;
            fontSelectBox.Location = new Point(6, 21);
            fontSelectBox.Name = "fontSelectBox";
            fontSelectBox.Size = new Size(316, 23);
            fontSelectBox.TabIndex = 0;
            fontSelectBox.SelectedIndexChanged += fontSelectBox_SelectedIndexChanged;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(12, 231);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 19;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // SettingsWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 266);
            Controls.Add(resetBtn);
            Controls.Add(tabControl1);
            Controls.Add(applyButton);
            Controls.Add(doneButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsWin";
            Text = "LittleClock 2 Settings";
            ((System.ComponentModel.ISupportInitialize)locationXInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationYInput).EndInit();
            locationGroupBox.ResumeLayout(false);
            locationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idleOpacityInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)idleTimeoutInput).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bottomPaddingInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundColorDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)textColorDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeInput).EndInit();
            ResumeLayout(false);

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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button pickBackgroundColorBtn;
        private Button pickTextColorBtn;
        private PictureBox backgroundColorDisplay;
        private PictureBox textColorDisplay;
        private NumericUpDown fontSizeInput;
        private ComboBox fontStyleSelectBox;
        private ComboBox fontSelectBox;
        private Label label6;
        private NumericUpDown bottomPaddingInput;
        private LinkLabel linkLabel1;
        private Button resetBtn;
        private CheckBox useRoundedCornerCheckbox;
        private Label settingModeLabel;
        private CheckBox forceAlwaysOnTopCheckbox;
    }
}