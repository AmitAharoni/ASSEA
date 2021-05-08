namespace ASSEA
{
    partial class FormDailySettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used..
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
            this.checkBoxSetReminder = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxSetReminder
            // 
            this.checkBoxSetReminder.AutoSize = true;
            this.checkBoxSetReminder.Location = new System.Drawing.Point(154, 57);
            this.checkBoxSetReminder.Name = "checkBoxSetReminder";
            this.checkBoxSetReminder.Size = new System.Drawing.Size(162, 17);
            this.checkBoxSetReminder.TabIndex = 1;
            this.checkBoxSetReminder.Text = "Set a reminder before launch";
            this.checkBoxSetReminder.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(151, 96);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(44, 13);
            this.labelMinutes.TabIndex = 3;
            this.labelMinutes.Text = "Minutes";
            // 
            // FormDailySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 227);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxSetReminder);
            this.Name = "FormDailySettings";
            this.Text = "FormDailySettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSetReminder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelMinutes;
    }
}