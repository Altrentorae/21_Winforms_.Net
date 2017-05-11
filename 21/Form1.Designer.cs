namespace _21
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.gameStateLbl = new System.Windows.Forms.Label();
            this.dealbox5 = new System.Windows.Forms.Label();
            this.dealbox4 = new System.Windows.Forms.Label();
            this.dealbox3 = new System.Windows.Forms.Label();
            this.dealbox2 = new System.Windows.Forms.Label();
            this.dealbox1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.TrackBar();
            this.betLabel = new System.Windows.Forms.Label();
            this.openUrsSettings = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 150);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 150);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 150);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 150);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 408);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(136, 48);
            this.buttonDraw.TabIndex = 5;
            this.buttonDraw.Text = "Draw and Bet";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(154, 408);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(136, 48);
            this.buttonLock.TabIndex = 6;
            this.buttonLock.Text = "Stay and Bet";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // gameStateLbl
            // 
            this.gameStateLbl.BackColor = System.Drawing.Color.LightGray;
            this.gameStateLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameStateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStateLbl.Location = new System.Drawing.Point(669, 387);
            this.gameStateLbl.Name = "gameStateLbl";
            this.gameStateLbl.Size = new System.Drawing.Size(159, 69);
            this.gameStateLbl.TabIndex = 7;
            this.gameStateLbl.Text = "Your Turn";
            this.gameStateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealbox5
            // 
            this.dealbox5.BackColor = System.Drawing.Color.Linen;
            this.dealbox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealbox5.Location = new System.Drawing.Point(602, 9);
            this.dealbox5.Name = "dealbox5";
            this.dealbox5.Size = new System.Drawing.Size(101, 89);
            this.dealbox5.TabIndex = 12;
            this.dealbox5.Text = "0";
            this.dealbox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealbox4
            // 
            this.dealbox4.BackColor = System.Drawing.Color.Linen;
            this.dealbox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealbox4.Location = new System.Drawing.Point(485, 9);
            this.dealbox4.Name = "dealbox4";
            this.dealbox4.Size = new System.Drawing.Size(101, 89);
            this.dealbox4.TabIndex = 11;
            this.dealbox4.Text = "0";
            this.dealbox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealbox3
            // 
            this.dealbox3.BackColor = System.Drawing.Color.Linen;
            this.dealbox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealbox3.Location = new System.Drawing.Point(368, 9);
            this.dealbox3.Name = "dealbox3";
            this.dealbox3.Size = new System.Drawing.Size(101, 89);
            this.dealbox3.TabIndex = 10;
            this.dealbox3.Text = "0";
            this.dealbox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealbox2
            // 
            this.dealbox2.BackColor = System.Drawing.Color.Linen;
            this.dealbox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealbox2.Location = new System.Drawing.Point(251, 9);
            this.dealbox2.Name = "dealbox2";
            this.dealbox2.Size = new System.Drawing.Size(101, 89);
            this.dealbox2.TabIndex = 9;
            this.dealbox2.Text = "0";
            this.dealbox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealbox1
            // 
            this.dealbox1.BackColor = System.Drawing.Color.Linen;
            this.dealbox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealbox1.Location = new System.Drawing.Point(134, 9);
            this.dealbox1.Name = "dealbox1";
            this.dealbox1.Size = new System.Drawing.Size(101, 89);
            this.dealbox1.TabIndex = 8;
            this.dealbox1.Text = "0";
            this.dealbox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.DarkGray;
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(296, 408);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 48);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyLabel.Location = new System.Drawing.Point(548, 387);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(99, 16);
            this.moneyLabel.TabIndex = 15;
            this.moneyLabel.Text = "0\r\n";
            // 
            // betAmount
            // 
            this.betAmount.BackColor = System.Drawing.Color.LightGray;
            this.betAmount.Location = new System.Drawing.Point(548, 427);
            this.betAmount.Maximum = 25;
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(99, 45);
            this.betAmount.TabIndex = 16;
            this.betAmount.Value = 25;
            this.betAmount.Scroll += new System.EventHandler(this.betAmount_Scroll);
            // 
            // betLabel
            // 
            this.betLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betLabel.Location = new System.Drawing.Point(548, 408);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(99, 16);
            this.betLabel.TabIndex = 17;
            this.betLabel.Text = "0";
            // 
            // openUrsSettings
            // 
            this.openUrsSettings.Location = new System.Drawing.Point(392, 408);
            this.openUrsSettings.Name = "openUrsSettings";
            this.openUrsSettings.Size = new System.Drawing.Size(62, 48);
            this.openUrsSettings.TabIndex = 18;
            this.openUrsSettings.Text = "Settings";
            this.openUrsSettings.UseVisualStyleBackColor = true;
            this.openUrsSettings.Click += new System.EventHandler(this.openUrsSettings_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Money";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 468);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.openUrsSettings);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dealbox5);
            this.Controls.Add(this.dealbox4);
            this.Controls.Add(this.dealbox3);
            this.Controls.Add(this.dealbox2);
            this.Controls.Add(this.dealbox1);
            this.Controls.Add(this.gameStateLbl);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Label gameStateLbl;
        private System.Windows.Forms.Label dealbox5;
        private System.Windows.Forms.Label dealbox4;
        private System.Windows.Forms.Label dealbox3;
        private System.Windows.Forms.Label dealbox2;
        private System.Windows.Forms.Label dealbox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TrackBar betAmount;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Button openUrsSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

