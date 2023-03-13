namespace im4
{
    partial class MAIN_WINDOW
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
            this.TimerLife = new System.Windows.Forms.Timer(this.components);
            this.lifeBox = new System.Windows.Forms.PictureBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboPreset = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lifeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerLife
            // 
            this.TimerLife.Enabled = true;
            this.TimerLife.Interval = 1;
            this.TimerLife.Tick += new System.EventHandler(this.TimerLife_Tick);
            // 
            // lifeBox
            // 
            this.lifeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.lifeBox.Location = new System.Drawing.Point(0, 0);
            this.lifeBox.Name = "lifeBox";
            this.lifeBox.Size = new System.Drawing.Size(692, 372);
            this.lifeBox.TabIndex = 0;
            this.lifeBox.TabStop = false;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStartStop.Location = new System.Drawing.Point(692, 0);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(110, 23);
            this.buttonStartStop.TabIndex = 1;
            this.buttonStartStop.Text = "PAUSE";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStep.Enabled = false;
            this.buttonStep.Location = new System.Drawing.Point(692, 23);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(110, 23);
            this.buttonStep.TabIndex = 2;
            this.buttonStep.Text = "STEP";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.ButtonStep_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReset.Location = new System.Drawing.Point(692, 46);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(110, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // comboPreset
            // 
            this.comboPreset.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboPreset.FormattingEnabled = true;
            this.comboPreset.Items.AddRange(new object[] {
            "Random"});
            this.comboPreset.Location = new System.Drawing.Point(692, 69);
            this.comboPreset.Name = "comboPreset";
            this.comboPreset.Size = new System.Drawing.Size(110, 21);
            this.comboPreset.TabIndex = 4;
            this.comboPreset.SelectedIndexChanged += new System.EventHandler(this.comboPreset_SelectedIndexChanged);
            // 
            // MAIN_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 372);
            this.Controls.Add(this.comboPreset);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.lifeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MAIN_WINDOW";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "im4_maryasov";
            ((System.ComponentModel.ISupportInitialize)(this.lifeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerLife;
        private System.Windows.Forms.PictureBox lifeBox;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboPreset;
    }
}

