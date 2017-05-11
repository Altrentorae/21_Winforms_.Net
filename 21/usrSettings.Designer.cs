namespace _21
{
    partial class usrSettings
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
            this.minBetRadioLinear = new System.Windows.Forms.RadioButton();
            this.minBetRadioExponent = new System.Windows.Forms.RadioButton();
            this.minBetRadioFract = new System.Windows.Forms.RadioButton();
            this.linearInput = new System.Windows.Forms.NumericUpDown();
            this.exponentInput = new System.Windows.Forms.NumericUpDown();
            this.fractional = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minBetGroup = new System.Windows.Forms.GroupBox();
            this.incrementLinear = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.linearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fractional)).BeginInit();
            this.minBetGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // minBetRadioLinear
            // 
            this.minBetRadioLinear.AutoSize = true;
            this.minBetRadioLinear.Location = new System.Drawing.Point(6, 19);
            this.minBetRadioLinear.Name = "minBetRadioLinear";
            this.minBetRadioLinear.Size = new System.Drawing.Size(54, 17);
            this.minBetRadioLinear.TabIndex = 0;
            this.minBetRadioLinear.TabStop = true;
            this.minBetRadioLinear.Text = "Linear";
            this.minBetRadioLinear.UseVisualStyleBackColor = true;
            this.minBetRadioLinear.CheckedChanged += new System.EventHandler(this.minBetRadioLinear_CheckedChanged);
            // 
            // minBetRadioExponent
            // 
            this.minBetRadioExponent.AutoSize = true;
            this.minBetRadioExponent.Location = new System.Drawing.Point(6, 42);
            this.minBetRadioExponent.Name = "minBetRadioExponent";
            this.minBetRadioExponent.Size = new System.Drawing.Size(80, 17);
            this.minBetRadioExponent.TabIndex = 1;
            this.minBetRadioExponent.TabStop = true;
            this.minBetRadioExponent.Text = "Exponential";
            this.minBetRadioExponent.UseVisualStyleBackColor = true;
            this.minBetRadioExponent.CheckedChanged += new System.EventHandler(this.minBetRadioExponent_CheckedChanged);
            // 
            // minBetRadioFract
            // 
            this.minBetRadioFract.AutoSize = true;
            this.minBetRadioFract.Location = new System.Drawing.Point(6, 64);
            this.minBetRadioFract.Name = "minBetRadioFract";
            this.minBetRadioFract.Size = new System.Drawing.Size(71, 17);
            this.minBetRadioFract.TabIndex = 2;
            this.minBetRadioFract.TabStop = true;
            this.minBetRadioFract.Text = "Fractional";
            this.minBetRadioFract.UseVisualStyleBackColor = true;
            this.minBetRadioFract.CheckedChanged += new System.EventHandler(this.minBetRadioFract_CheckedChanged);
            // 
            // linearInput
            // 
            this.linearInput.Location = new System.Drawing.Point(126, 22);
            this.linearInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.linearInput.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.linearInput.Name = "linearInput";
            this.linearInput.Size = new System.Drawing.Size(99, 20);
            this.linearInput.TabIndex = 3;
            this.linearInput.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // exponentInput
            // 
            this.exponentInput.Location = new System.Drawing.Point(126, 48);
            this.exponentInput.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.exponentInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.exponentInput.Name = "exponentInput";
            this.exponentInput.Size = new System.Drawing.Size(99, 20);
            this.exponentInput.TabIndex = 4;
            this.exponentInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // fractional
            // 
            this.fractional.Location = new System.Drawing.Point(153, 74);
            this.fractional.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.fractional.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fractional.Name = "fractional";
            this.fractional.Size = new System.Drawing.Size(72, 20);
            this.fractional.TabIndex = 5;
            this.fractional.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "1 /";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minBetGroup
            // 
            this.minBetGroup.Controls.Add(this.minBetRadioFract);
            this.minBetGroup.Controls.Add(this.minBetRadioExponent);
            this.minBetGroup.Controls.Add(this.minBetRadioLinear);
            this.minBetGroup.Location = new System.Drawing.Point(12, 9);
            this.minBetGroup.Name = "minBetGroup";
            this.minBetGroup.Size = new System.Drawing.Size(95, 89);
            this.minBetGroup.TabIndex = 8;
            this.minBetGroup.TabStop = false;
            this.minBetGroup.Text = "Minimum Bet";
            // 
            // incrementLinear
            // 
            this.incrementLinear.AutoSize = true;
            this.incrementLinear.Checked = true;
            this.incrementLinear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.incrementLinear.Location = new System.Drawing.Point(18, 104);
            this.incrementLinear.Name = "incrementLinear";
            this.incrementLinear.Size = new System.Drawing.Size(73, 17);
            this.incrementLinear.TabIndex = 9;
            this.incrementLinear.Text = "Increment";
            this.incrementLinear.UseVisualStyleBackColor = true;
            // 
            // usrSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 215);
            this.Controls.Add(this.incrementLinear);
            this.Controls.Add(this.minBetGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fractional);
            this.Controls.Add(this.exponentInput);
            this.Controls.Add(this.linearInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "usrSettings";
            this.Text = "usrSettings";
            this.Load += new System.EventHandler(this.usrSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fractional)).EndInit();
            this.minBetGroup.ResumeLayout(false);
            this.minBetGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton minBetRadioLinear;
        private System.Windows.Forms.RadioButton minBetRadioExponent;
        private System.Windows.Forms.RadioButton minBetRadioFract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox minBetGroup;
        private System.Windows.Forms.NumericUpDown linearInput;
        private System.Windows.Forms.NumericUpDown exponentInput;
        private System.Windows.Forms.NumericUpDown fractional;
        private System.Windows.Forms.CheckBox incrementLinear;
    }
}