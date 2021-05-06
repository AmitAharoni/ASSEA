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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.labelHunger = new System.Windows.Forms.Label();
            this.labelTirednessState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelConcentrationState = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar1.Location = new System.Drawing.Point(137, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 29);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar2.Location = new System.Drawing.Point(137, 152);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(395, 29);
            this.progressBar2.TabIndex = 1;
            this.progressBar2.Value = 50;
            // 
            // labelHunger
            // 
            this.labelHunger.AutoSize = true;
            this.labelHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHunger.Location = new System.Drawing.Point(294, 20);
            this.labelHunger.Name = "labelHunger";
            this.labelHunger.Size = new System.Drawing.Size(102, 20);
            this.labelHunger.TabIndex = 3;
            this.labelHunger.Text = "Hunger state";
            // 
            // labelTirednessState
            // 
            this.labelTirednessState.AutoSize = true;
            this.labelTirednessState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTirednessState.Location = new System.Drawing.Point(294, 123);
            this.labelTirednessState.Name = "labelTirednessState";
            this.labelTirednessState.Size = new System.Drawing.Size(118, 20);
            this.labelTirednessState.TabIndex = 4;
            this.labelTirednessState.Text = "Tiredness state";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(569, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "End shift";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelConcentrationState
            // 
            this.labelConcentrationState.AutoSize = true;
            this.labelConcentrationState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConcentrationState.Location = new System.Drawing.Point(298, 221);
            this.labelConcentrationState.Name = "labelConcentrationState";
            this.labelConcentrationState.Size = new System.Drawing.Size(149, 20);
            this.labelConcentrationState.TabIndex = 7;
            this.labelConcentrationState.Text = "Concentration state";
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar3.Location = new System.Drawing.Point(141, 250);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(395, 29);
            this.progressBar3.TabIndex = 6;
            this.progressBar3.Value = 50;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 352);
            this.Controls.Add(this.labelConcentrationState);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTirednessState);
            this.Controls.Add(this.labelHunger);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Name = "FormDashboard";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label labelHunger;
        private System.Windows.Forms.Label labelTirednessState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelConcentrationState;
        private System.Windows.Forms.ProgressBar progressBar3;
    }
}