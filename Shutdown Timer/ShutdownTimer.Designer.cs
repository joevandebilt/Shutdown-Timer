namespace Shutdown_Timer
{
    partial class ShutdownTimer
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
            this.cmbTotalHours = new System.Windows.Forms.ComboBox();
            this.cmbTotalMinutes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrMainTimer = new System.Windows.Forms.Timer(this.components);
            this.cmdDoThings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTotalHours
            // 
            this.cmbTotalHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTotalHours.FormattingEnabled = true;
            this.cmbTotalHours.Location = new System.Drawing.Point(161, 35);
            this.cmbTotalHours.Name = "cmbTotalHours";
            this.cmbTotalHours.Size = new System.Drawing.Size(55, 21);
            this.cmbTotalHours.TabIndex = 0;
            // 
            // cmbTotalMinutes
            // 
            this.cmbTotalMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTotalMinutes.FormattingEnabled = true;
            this.cmbTotalMinutes.Location = new System.Drawing.Point(272, 35);
            this.cmbTotalMinutes.Name = "cmbTotalMinutes";
            this.cmbTotalMinutes.Size = new System.Drawing.Size(55, 21);
            this.cmbTotalMinutes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            // 
            // tmrMainTimer
            // 
            this.tmrMainTimer.Interval = 1000;
            this.tmrMainTimer.Tick += new System.EventHandler(this.tmrMainTimer_Tick);
            // 
            // cmdDoThings
            // 
            this.cmdDoThings.Location = new System.Drawing.Point(151, 166);
            this.cmdDoThings.Name = "cmdDoThings";
            this.cmdDoThings.Size = new System.Drawing.Size(187, 49);
            this.cmdDoThings.TabIndex = 4;
            this.cmdDoThings.Text = "Start";
            this.cmdDoThings.UseVisualStyleBackColor = true;
            this.cmdDoThings.Click += new System.EventHandler(this.cmdDoThings_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSeconds);
            this.panel1.Location = new System.Drawing.Point(61, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 87);
            this.panel1.TabIndex = 8;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(3, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(361, 87);
            this.lblSeconds.TabIndex = 11;
            this.lblSeconds.Text = "00";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(344, 166);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(84, 49);
            this.cmdQuit.TabIndex = 9;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(61, 166);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(84, 49);
            this.cmdReset.TabIndex = 10;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // ShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 262);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdDoThings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTotalMinutes);
            this.Controls.Add(this.cmbTotalHours);
            this.Name = "ShutdownTimer";
            this.Text = "Shutdown Timer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTotalHours;
        private System.Windows.Forms.ComboBox cmbTotalMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrMainTimer;
        private System.Windows.Forms.Button cmdDoThings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Button cmdReset;
    }
}

