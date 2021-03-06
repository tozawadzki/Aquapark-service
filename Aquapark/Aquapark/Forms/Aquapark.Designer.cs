﻿namespace Aquapark
{
    partial class Aquapark
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
            this.label1 = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGymEntry = new System.Windows.Forms.Button();
            this.buttonGymExit = new System.Windows.Forms.Button();
            this.buttonPoolExit = new System.Windows.Forms.Button();
            this.buttonPoolEntry = new System.Windows.Forms.Button();
            this.buttonSaunaExit = new System.Windows.Forms.Button();
            this.buttonSaunaEntry = new System.Windows.Forms.Button();
            this.buttonAquaparkExit = new System.Windows.Forms.Button();
            this.buttonAquaparkEntry = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chargeTextBox = new System.Windows.Forms.TextBox();
            this.leaveButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelElapsed = new System.Windows.Forms.Label();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.labelExitTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(198, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strefa:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceLabel.Location = new System.Drawing.Point(263, 132);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(100, 20);
            this.serviceLabel.TabIndex = 1;
            this.serviceLabel.Text = "serviceName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Siłownia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sauny";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Park wodny";
            // 
            // buttonGymEntry
            // 
            this.buttonGymEntry.Location = new System.Drawing.Point(141, 25);
            this.buttonGymEntry.Name = "buttonGymEntry";
            this.buttonGymEntry.Size = new System.Drawing.Size(75, 23);
            this.buttonGymEntry.TabIndex = 7;
            this.buttonGymEntry.Text = "Wejdź Siłownia";
            this.buttonGymEntry.UseVisualStyleBackColor = true;
            this.buttonGymEntry.Click += new System.EventHandler(this.buttonGymEntry_Click);
            // 
            // buttonGymExit
            // 
            this.buttonGymExit.Location = new System.Drawing.Point(141, 54);
            this.buttonGymExit.Name = "buttonGymExit";
            this.buttonGymExit.Size = new System.Drawing.Size(75, 23);
            this.buttonGymExit.TabIndex = 8;
            this.buttonGymExit.Text = "Wyjdź Siłownia";
            this.buttonGymExit.UseVisualStyleBackColor = true;
            this.buttonGymExit.Click += new System.EventHandler(this.buttonGymExit_Click);
            // 
            // buttonPoolExit
            // 
            this.buttonPoolExit.Location = new System.Drawing.Point(222, 54);
            this.buttonPoolExit.Name = "buttonPoolExit";
            this.buttonPoolExit.Size = new System.Drawing.Size(75, 23);
            this.buttonPoolExit.TabIndex = 10;
            this.buttonPoolExit.Text = "Wyjdź Basen";
            this.buttonPoolExit.UseVisualStyleBackColor = true;
            this.buttonPoolExit.Click += new System.EventHandler(this.buttonPoolExit_Click);
            // 
            // buttonPoolEntry
            // 
            this.buttonPoolEntry.Location = new System.Drawing.Point(222, 25);
            this.buttonPoolEntry.Name = "buttonPoolEntry";
            this.buttonPoolEntry.Size = new System.Drawing.Size(75, 23);
            this.buttonPoolEntry.TabIndex = 9;
            this.buttonPoolEntry.Text = "Wejdź Basen";
            this.buttonPoolEntry.UseVisualStyleBackColor = true;
            this.buttonPoolEntry.Click += new System.EventHandler(this.buttonPoolEntry_Click);
            // 
            // buttonSaunaExit
            // 
            this.buttonSaunaExit.Location = new System.Drawing.Point(303, 54);
            this.buttonSaunaExit.Name = "buttonSaunaExit";
            this.buttonSaunaExit.Size = new System.Drawing.Size(75, 23);
            this.buttonSaunaExit.TabIndex = 12;
            this.buttonSaunaExit.Text = "Wyjdź Sauna";
            this.buttonSaunaExit.UseVisualStyleBackColor = true;
            this.buttonSaunaExit.Click += new System.EventHandler(this.buttonSaunaExit_Click);
            // 
            // buttonSaunaEntry
            // 
            this.buttonSaunaEntry.Location = new System.Drawing.Point(303, 25);
            this.buttonSaunaEntry.Name = "buttonSaunaEntry";
            this.buttonSaunaEntry.Size = new System.Drawing.Size(75, 23);
            this.buttonSaunaEntry.TabIndex = 11;
            this.buttonSaunaEntry.Text = "Wejdź Sauna";
            this.buttonSaunaEntry.UseVisualStyleBackColor = true;
            this.buttonSaunaEntry.Click += new System.EventHandler(this.buttonSaunaEntry_Click);
            // 
            // buttonAquaparkExit
            // 
            this.buttonAquaparkExit.Location = new System.Drawing.Point(388, 54);
            this.buttonAquaparkExit.Name = "buttonAquaparkExit";
            this.buttonAquaparkExit.Size = new System.Drawing.Size(75, 23);
            this.buttonAquaparkExit.TabIndex = 14;
            this.buttonAquaparkExit.Text = "Wyjdź Aquapark";
            this.buttonAquaparkExit.UseVisualStyleBackColor = true;
            this.buttonAquaparkExit.Click += new System.EventHandler(this.buttonAquaparkExit_Click);
            // 
            // buttonAquaparkEntry
            // 
            this.buttonAquaparkEntry.Location = new System.Drawing.Point(388, 25);
            this.buttonAquaparkEntry.Name = "buttonAquaparkEntry";
            this.buttonAquaparkEntry.Size = new System.Drawing.Size(75, 23);
            this.buttonAquaparkEntry.TabIndex = 13;
            this.buttonAquaparkEntry.Text = "Wejdź Aquapark";
            this.buttonAquaparkEntry.UseVisualStyleBackColor = true;
            this.buttonAquaparkEntry.Click += new System.EventHandler(this.buttonAquaparkEntry_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Czas na strefie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Obciążenie:";
            // 
            // chargeTextBox
            // 
            this.chargeTextBox.Location = new System.Drawing.Point(80, 237);
            this.chargeTextBox.Name = "chargeTextBox";
            this.chargeTextBox.Size = new System.Drawing.Size(45, 20);
            this.chargeTextBox.TabIndex = 22;
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(484, 234);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(75, 23);
            this.leaveButton.TabIndex = 23;
            this.leaveButton.Text = "Opuść";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "zł";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Obsługa obiektu";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(23, 32);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 26;
            this.adminButton.Text = "Zaloguj";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(20, 214);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Pozostały czas:";
            // 
            // labelElapsed
            // 
            this.labelElapsed.AutoSize = true;
            this.labelElapsed.Location = new System.Drawing.Point(492, 30);
            this.labelElapsed.Name = "labelElapsed";
            this.labelElapsed.Size = new System.Drawing.Size(0, 13);
            this.labelElapsed.TabIndex = 31;
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Location = new System.Drawing.Point(254, 214);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(44, 13);
            this.labelTimeLeft.TabIndex = 32;
            this.labelTimeLeft.Text = "timeLeft";
            // 
            // timerLeft
            // 
            this.timerLeft.Tick += new System.EventHandler(this.timerLeft_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Opuść obiekt przed:";
            // 
            // labelExitTime
            // 
            this.labelExitTime.AutoSize = true;
            this.labelExitTime.Location = new System.Drawing.Point(254, 240);
            this.labelExitTime.Name = "labelExitTime";
            this.labelExitTime.Size = new System.Drawing.Size(46, 13);
            this.labelExitTime.TabIndex = 34;
            this.labelExitTime.Text = "exitTime";
            // 
            // Aquapark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 265);
            this.Controls.Add(this.labelExitTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.labelElapsed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.chargeTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAquaparkExit);
            this.Controls.Add(this.buttonAquaparkEntry);
            this.Controls.Add(this.buttonSaunaExit);
            this.Controls.Add(this.buttonSaunaEntry);
            this.Controls.Add(this.buttonPoolExit);
            this.Controls.Add(this.buttonPoolEntry);
            this.Controls.Add(this.buttonGymExit);
            this.Controls.Add(this.buttonGymEntry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.label1);
            this.Name = "Aquapark";
            this.Text = "Aquapark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGymEntry;
        private System.Windows.Forms.Button buttonGymExit;
        private System.Windows.Forms.Button buttonPoolExit;
        private System.Windows.Forms.Button buttonPoolEntry;
        private System.Windows.Forms.Button buttonSaunaExit;
        private System.Windows.Forms.Button buttonSaunaEntry;
        private System.Windows.Forms.Button buttonAquaparkExit;
        private System.Windows.Forms.Button buttonAquaparkEntry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox chargeTextBox;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelElapsed;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Timer timerLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelExitTime;
    }
}