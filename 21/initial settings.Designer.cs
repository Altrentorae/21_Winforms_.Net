namespace _21
{
    partial class initial_settings
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
            this.diff0 = new System.Windows.Forms.RadioButton();
            this.difficultyGroup = new System.Windows.Forms.GroupBox();
            this.diff4 = new System.Windows.Forms.RadioButton();
            this.diff3 = new System.Windows.Forms.RadioButton();
            this.diff2 = new System.Windows.Forms.RadioButton();
            this.diff1 = new System.Windows.Forms.RadioButton();
            this.moneyGroupBox = new System.Windows.Forms.GroupBox();
            this.moneyInput = new System.Windows.Forms.NumericUpDown();
            this.aceBox = new System.Windows.Forms.GroupBox();
            this.aceHigh = new System.Windows.Forms.CheckBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.difficultyGroup.SuspendLayout();
            this.moneyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyInput)).BeginInit();
            this.aceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // diff0
            // 
            this.diff0.AutoSize = true;
            this.diff0.Location = new System.Drawing.Point(6, 19);
            this.diff0.Name = "diff0";
            this.diff0.Size = new System.Drawing.Size(112, 17);
            this.diff0.TabIndex = 0;
            this.diff0.Text = "Unbelievably Easy";
            this.diff0.UseVisualStyleBackColor = true;
            // 
            // difficultyGroup
            // 
            this.difficultyGroup.Controls.Add(this.diff4);
            this.difficultyGroup.Controls.Add(this.diff3);
            this.difficultyGroup.Controls.Add(this.diff2);
            this.difficultyGroup.Controls.Add(this.diff1);
            this.difficultyGroup.Controls.Add(this.diff0);
            this.difficultyGroup.Location = new System.Drawing.Point(12, 12);
            this.difficultyGroup.Name = "difficultyGroup";
            this.difficultyGroup.Size = new System.Drawing.Size(121, 139);
            this.difficultyGroup.TabIndex = 1;
            this.difficultyGroup.TabStop = false;
            this.difficultyGroup.Text = "Difficulty";
            this.difficultyGroup.Enter += new System.EventHandler(this.difficultyGroup_Enter);
            // 
            // diff4
            // 
            this.diff4.AutoSize = true;
            this.diff4.Location = new System.Drawing.Point(6, 111);
            this.diff4.Name = "diff4";
            this.diff4.Size = new System.Drawing.Size(57, 17);
            this.diff4.TabIndex = 4;
            this.diff4.Text = "Insane";
            this.diff4.UseVisualStyleBackColor = true;
            // 
            // diff3
            // 
            this.diff3.AutoSize = true;
            this.diff3.Location = new System.Drawing.Point(6, 88);
            this.diff3.Name = "diff3";
            this.diff3.Size = new System.Drawing.Size(48, 17);
            this.diff3.TabIndex = 3;
            this.diff3.Text = "Hard";
            this.diff3.UseVisualStyleBackColor = true;
            // 
            // diff2
            // 
            this.diff2.AutoSize = true;
            this.diff2.Checked = true;
            this.diff2.Location = new System.Drawing.Point(6, 65);
            this.diff2.Name = "diff2";
            this.diff2.Size = new System.Drawing.Size(58, 17);
            this.diff2.TabIndex = 2;
            this.diff2.TabStop = true;
            this.diff2.Text = "Normal";
            this.diff2.UseVisualStyleBackColor = true;
            // 
            // diff1
            // 
            this.diff1.AutoSize = true;
            this.diff1.Location = new System.Drawing.Point(6, 42);
            this.diff1.Name = "diff1";
            this.diff1.Size = new System.Drawing.Size(48, 17);
            this.diff1.TabIndex = 1;
            this.diff1.Text = "Easy";
            this.diff1.UseVisualStyleBackColor = true;
            // 
            // moneyGroupBox
            // 
            this.moneyGroupBox.Controls.Add(this.moneyInput);
            this.moneyGroupBox.Location = new System.Drawing.Point(139, 92);
            this.moneyGroupBox.Name = "moneyGroupBox";
            this.moneyGroupBox.Size = new System.Drawing.Size(93, 59);
            this.moneyGroupBox.TabIndex = 2;
            this.moneyGroupBox.TabStop = false;
            this.moneyGroupBox.Text = "Money";
            // 
            // moneyInput
            // 
            this.moneyInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.moneyInput.Location = new System.Drawing.Point(6, 19);
            this.moneyInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.moneyInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(70, 20);
            this.moneyInput.TabIndex = 0;
            this.moneyInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // aceBox
            // 
            this.aceBox.Controls.Add(this.aceHigh);
            this.aceBox.Location = new System.Drawing.Point(139, 12);
            this.aceBox.Name = "aceBox";
            this.aceBox.Size = new System.Drawing.Size(93, 70);
            this.aceBox.TabIndex = 3;
            this.aceBox.TabStop = false;
            this.aceBox.Text = "Ace";
            // 
            // aceHigh
            // 
            this.aceHigh.AutoSize = true;
            this.aceHigh.Checked = true;
            this.aceHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aceHigh.Location = new System.Drawing.Point(6, 19);
            this.aceHigh.Name = "aceHigh";
            this.aceHigh.Size = new System.Drawing.Size(78, 17);
            this.aceHigh.TabIndex = 0;
            this.aceHigh.Text = "Switchable";
            this.aceHigh.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(238, 100);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(115, 51);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // initial_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 165);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.aceBox);
            this.Controls.Add(this.moneyGroupBox);
            this.Controls.Add(this.difficultyGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "initial_settings";
            this.Text = "initial_settings";
            this.difficultyGroup.ResumeLayout(false);
            this.difficultyGroup.PerformLayout();
            this.moneyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moneyInput)).EndInit();
            this.aceBox.ResumeLayout(false);
            this.aceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton diff0;
        private System.Windows.Forms.GroupBox difficultyGroup;
        private System.Windows.Forms.RadioButton diff4;
        private System.Windows.Forms.RadioButton diff3;
        private System.Windows.Forms.RadioButton diff2;
        private System.Windows.Forms.RadioButton diff1;
        private System.Windows.Forms.GroupBox moneyGroupBox;
        private System.Windows.Forms.NumericUpDown moneyInput;
        private System.Windows.Forms.GroupBox aceBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.CheckBox aceHigh;
    }
}