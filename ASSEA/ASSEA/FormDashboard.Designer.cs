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
               this.Physical_TrackBar = new System.Windows.Forms.TrackBar();
               this.Mental_TrackBar = new System.Windows.Forms.TrackBar();
               ((System.ComponentModel.ISupportInitialize)(this.Physical_TrackBar)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Mental_TrackBar)).BeginInit();
               this.SuspendLayout();
               // 
               // progressBar1
               // 
               this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.progressBar1.Location = new System.Drawing.Point(320, 118);
               this.progressBar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
               this.progressBar1.Name = "progressBar1";
               this.progressBar1.Size = new System.Drawing.Size(922, 65);
               this.progressBar1.TabIndex = 0;
               this.progressBar1.Value = 50;
               // 
               // progressBar2
               // 
               this.progressBar2.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.progressBar2.Location = new System.Drawing.Point(320, 339);
               this.progressBar2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
               this.progressBar2.Name = "progressBar2";
               this.progressBar2.Size = new System.Drawing.Size(922, 65);
               this.progressBar2.TabIndex = 1;
               this.progressBar2.Value = 50;
               // 
               // labelHunger
               // 
               this.labelHunger.AutoSize = true;
               this.labelHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelHunger.Location = new System.Drawing.Point(686, 43);
               this.labelHunger.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelHunger.Name = "labelHunger";
               this.labelHunger.Size = new System.Drawing.Size(239, 40);
               this.labelHunger.TabIndex = 3;
               this.labelHunger.Text = "Physical state";
               // 
               // labelTirednessState
               // 
               this.labelTirednessState.AutoSize = true;
               this.labelTirednessState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelTirednessState.Location = new System.Drawing.Point(686, 274);
               this.labelTirednessState.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelTirednessState.Name = "labelTirednessState";
               this.labelTirednessState.Size = new System.Drawing.Size(213, 40);
               this.labelTirednessState.TabIndex = 4;
               this.labelTirednessState.Text = "Mental state";
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.button1.Location = new System.Drawing.Point(1328, 669);
               this.button1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(224, 89);
               this.button1.TabIndex = 5;
               this.button1.Text = "End shift";
               this.button1.UseVisualStyleBackColor = false;
               // 
               // Physical_TrackBar
               // 
               this.Physical_TrackBar.Location = new System.Drawing.Point(298, 183);
               this.Physical_TrackBar.Name = "Physical_TrackBar";
               this.Physical_TrackBar.Size = new System.Drawing.Size(955, 101);
               this.Physical_TrackBar.TabIndex = 6;
               // 
               // Mental_TrackBar
               // 
               this.Mental_TrackBar.Location = new System.Drawing.Point(298, 404);
               this.Mental_TrackBar.Name = "Mental_TrackBar";
               this.Mental_TrackBar.Size = new System.Drawing.Size(955, 101);
               this.Mental_TrackBar.TabIndex = 7;
               // 
               // FormDashboard
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1580, 785);
               this.Controls.Add(this.Mental_TrackBar);
               this.Controls.Add(this.Physical_TrackBar);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.labelTirednessState);
               this.Controls.Add(this.labelHunger);
               this.Controls.Add(this.progressBar2);
               this.Controls.Add(this.progressBar1);
               this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
               this.Name = "FormDashboard";
               this.Text = " ";
               ((System.ComponentModel.ISupportInitialize)(this.Physical_TrackBar)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Mental_TrackBar)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label labelHunger;
        private System.Windows.Forms.Label labelTirednessState;
        private System.Windows.Forms.Button button1;
          private System.Windows.Forms.TrackBar Physical_TrackBar;
          private System.Windows.Forms.TrackBar Mental_TrackBar;
     }
}