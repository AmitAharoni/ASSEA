namespace ASSEA
{
    partial class FormDashboard
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
               this.Physical_ProgressBar = new System.Windows.Forms.ProgressBar();
               this.Mental_ProgressBar = new System.Windows.Forms.ProgressBar();
               this.labelHunger = new System.Windows.Forms.Label();
               this.labelTirednessState = new System.Windows.Forms.Label();
               this.EndShift_Button = new System.Windows.Forms.Button();
               this.Settings_Button = new System.Windows.Forms.PictureBox();
               this.Physical_TrackBar = new System.Windows.Forms.TrackBar();
               this.Mental_TrackBar = new System.Windows.Forms.TrackBar();
               this.Physical_TextBox = new System.Windows.Forms.TextBox();
               this.Mental_TextBox = new System.Windows.Forms.TextBox();
               this.Welcome_TextBox = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.Settings_Button)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Physical_TrackBar)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Mental_TrackBar)).BeginInit();
               this.SuspendLayout();
               // 
               // Physical_ProgressBar
               // 
               this.Physical_ProgressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.Physical_ProgressBar.Location = new System.Drawing.Point(213, 194);
               this.Physical_ProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.Physical_ProgressBar.Name = "Physical_ProgressBar";
               this.Physical_ProgressBar.Size = new System.Drawing.Size(598, 45);
               this.Physical_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
               this.Physical_ProgressBar.TabIndex = 0;
               this.Physical_ProgressBar.Value = 50;
               // 
               // Mental_ProgressBar
               // 
               this.Mental_ProgressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.Mental_ProgressBar.Location = new System.Drawing.Point(213, 346);
               this.Mental_ProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.Mental_ProgressBar.Name = "Mental_ProgressBar";
               this.Mental_ProgressBar.Size = new System.Drawing.Size(598, 45);
               this.Mental_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
               this.Mental_ProgressBar.TabIndex = 1;
               this.Mental_ProgressBar.Value = 50;
               // 
               // labelHunger
               // 
               this.labelHunger.AutoSize = true;
               this.labelHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelHunger.Location = new System.Drawing.Point(437, 141);
               this.labelHunger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelHunger.Name = "labelHunger";
               this.labelHunger.Size = new System.Drawing.Size(159, 29);
               this.labelHunger.TabIndex = 3;
               this.labelHunger.Text = "Physical state";
               // 
               // labelTirednessState
               // 
               this.labelTirednessState.AutoSize = true;
               this.labelTirednessState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelTirednessState.Location = new System.Drawing.Point(445, 302);
               this.labelTirednessState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelTirednessState.Name = "labelTirednessState";
               this.labelTirednessState.Size = new System.Drawing.Size(142, 29);
               this.labelTirednessState.TabIndex = 4;
               this.labelTirednessState.Text = "Mental state";
               // 
               // EndShift_Button
               // 
               this.EndShift_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.EndShift_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
               this.EndShift_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.EndShift_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.EndShift_Button.Location = new System.Drawing.Point(854, 488);
               this.EndShift_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.EndShift_Button.Name = "EndShift_Button";
               this.EndShift_Button.Size = new System.Drawing.Size(144, 61);
               this.EndShift_Button.TabIndex = 5;
               this.EndShift_Button.Text = "End shift";
               this.EndShift_Button.UseVisualStyleBackColor = false;
               this.EndShift_Button.Click += new System.EventHandler(this.EndShift_OnClick);
               // 
               // Settings_Button
               // 
               this.Settings_Button.ErrorImage = global::ASSEA.Properties.Resources.SettngsIcon;
               this.Settings_Button.Image = global::ASSEA.Properties.Resources.SettngsIcon;
               this.Settings_Button.Location = new System.Drawing.Point(8, 8);
               this.Settings_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.Settings_Button.Name = "Settings_Button";
               this.Settings_Button.Size = new System.Drawing.Size(69, 70);
               this.Settings_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.Settings_Button.TabIndex = 8;
               this.Settings_Button.TabStop = false;
               this.Settings_Button.Click += new System.EventHandler(this.settingsButton_OnClick);
               // 
               // Physical_TrackBar
               // 
               this.Physical_TrackBar.Location = new System.Drawing.Point(204, 230);
               this.Physical_TrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.Physical_TrackBar.Maximum = 100;
               this.Physical_TrackBar.Name = "Physical_TrackBar";
               this.Physical_TrackBar.Size = new System.Drawing.Size(614, 69);
               this.Physical_TrackBar.TabIndex = 9;
               this.Physical_TrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
               this.Physical_TrackBar.Value = 50;
               this.Physical_TrackBar.ValueChanged += new System.EventHandler(this.physicalTrackBar_OnValueChanged);
               // 
               // Mental_TrackBar
               // 
               this.Mental_TrackBar.Location = new System.Drawing.Point(204, 388);
               this.Mental_TrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.Mental_TrackBar.Maximum = 100;
               this.Mental_TrackBar.Name = "Mental_TrackBar";
               this.Mental_TrackBar.Size = new System.Drawing.Size(614, 69);
               this.Mental_TrackBar.TabIndex = 10;
               this.Mental_TrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
               this.Mental_TrackBar.Value = 50;
               this.Mental_TrackBar.ValueChanged += new System.EventHandler(this.mentalTrackBar_OnValueChanged);
               // 
               // Physical_TextBox
               // 
               this.Physical_TextBox.BackColor = System.Drawing.SystemColors.Window;
               this.Physical_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Physical_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Physical_TextBox.Location = new System.Drawing.Point(838, 194);
               this.Physical_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.Physical_TextBox.Name = "Physical_TextBox";
               this.Physical_TextBox.ReadOnly = true;
               this.Physical_TextBox.Size = new System.Drawing.Size(64, 28);
               this.Physical_TextBox.TabIndex = 11;
               this.Physical_TextBox.Text = "50%";
               this.Physical_TextBox.BindingContextChanged += new System.EventHandler(this.physicalTrackBar_OnValueChanged);
               // 
               // Mental_TextBox
               // 
               this.Mental_TextBox.BackColor = System.Drawing.SystemColors.Window;
               this.Mental_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Mental_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Mental_TextBox.Location = new System.Drawing.Point(829, 346);
               this.Mental_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.Mental_TextBox.Name = "Mental_TextBox";
               this.Mental_TextBox.ReadOnly = true;
               this.Mental_TextBox.Size = new System.Drawing.Size(64, 28);
               this.Mental_TextBox.TabIndex = 12;
               this.Mental_TextBox.Text = "50%";
               // 
               // Welcome_TextBox
               // 
               this.Welcome_TextBox.BackColor = System.Drawing.SystemColors.Window;
               this.Welcome_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Welcome_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Welcome_TextBox.Location = new System.Drawing.Point(300, 44);
               this.Welcome_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.Welcome_TextBox.Name = "Welcome_TextBox";
               this.Welcome_TextBox.ReadOnly = true;
               this.Welcome_TextBox.Size = new System.Drawing.Size(449, 28);
               this.Welcome_TextBox.TabIndex = 13;
               this.Welcome_TextBox.Text = "Hi {username}, update your states.";
               this.Welcome_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // FormDashboard
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1016, 567);
               this.Controls.Add(this.Welcome_TextBox);
               this.Controls.Add(this.Mental_TextBox);
               this.Controls.Add(this.Physical_TextBox);
               this.Controls.Add(this.Mental_TrackBar);
               this.Controls.Add(this.Physical_TrackBar);
               this.Controls.Add(this.Settings_Button);
               this.Controls.Add(this.EndShift_Button);
               this.Controls.Add(this.labelTirednessState);
               this.Controls.Add(this.labelHunger);
               this.Controls.Add(this.Mental_ProgressBar);
               this.Controls.Add(this.Physical_ProgressBar);
               this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.MinimumSize = new System.Drawing.Size(1038, 623);
               this.Name = "FormDashboard";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Dashboard";
               ((System.ComponentModel.ISupportInitialize)(this.Settings_Button)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Physical_TrackBar)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Mental_TrackBar)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Physical_ProgressBar;
        private System.Windows.Forms.ProgressBar Mental_ProgressBar;
        private System.Windows.Forms.Label labelHunger;
        private System.Windows.Forms.Label labelTirednessState;
        private System.Windows.Forms.Button EndShift_Button;
          private System.Windows.Forms.PictureBox Settings_Button;
          private System.Windows.Forms.TrackBar Physical_TrackBar;
          private System.Windows.Forms.TrackBar Mental_TrackBar;
          private System.Windows.Forms.TextBox Physical_TextBox;
          private System.Windows.Forms.TextBox Mental_TextBox;
          private System.Windows.Forms.TextBox Welcome_TextBox;
     }
}