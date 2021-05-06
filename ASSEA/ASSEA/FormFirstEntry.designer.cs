using System.Windows.Forms;

namespace ASSEA
{
     partial class FormFirstEntry
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
               if(disposing && (components != null))
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
               this.Header_TextBox = new System.Windows.Forms.TextBox();
               this.DinnerTime_TimePicker = new System.Windows.Forms.DateTimePicker();
               this.LunceTime_TimePicker = new System.Windows.Forms.DateTimePicker();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.Username_TextBox = new System.Windows.Forms.TextBox();
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.textBox4 = new System.Windows.Forms.TextBox();
               this.textBox5 = new System.Windows.Forms.TextBox();
               this.FriendlyTime_TimePicker = new System.Windows.Forms.DateTimePicker();
               this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
               this.Soft_RadioButton = new System.Windows.Forms.RadioButton();
               this.Normal_RadioButton = new System.Windows.Forms.RadioButton();
               this.Extreme_RadioButton = new System.Windows.Forms.RadioButton();
               this.textBox6 = new System.Windows.Forms.TextBox();
               this.Interests_ComboBox = new System.Windows.Forms.ComboBox();
               this.textBox7 = new System.Windows.Forms.TextBox();
               this.Notifications_Panel = new System.Windows.Forms.Panel();
               this.Error_TextBox = new System.Windows.Forms.TextBox();
               this.Submit_Button = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
               this.Notifications_Panel.SuspendLayout();
               this.SuspendLayout();
               // 
               // Header_TextBox
               // 
               this.Header_TextBox.BackColor = System.Drawing.SystemColors.Window;
               this.Header_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Header_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Header_TextBox.Location = new System.Drawing.Point(192, 412);
               this.Header_TextBox.Multiline = true;
               this.Header_TextBox.Name = "Header_TextBox";
               this.Header_TextBox.ReadOnly = true;
               this.Header_TextBox.Size = new System.Drawing.Size(1219, 151);
               this.Header_TextBox.TabIndex = 2;
               this.Header_TextBox.Text = "Hello, Welcome to ASSEA.\r\n Let\'s set up your application";
               this.Header_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // DinnerTime_TimePicker
               // 
               this.DinnerTime_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.DinnerTime_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
               this.DinnerTime_TimePicker.Location = new System.Drawing.Point(659, 812);
               this.DinnerTime_TimePicker.Name = "DinnerTime_TimePicker";
               this.DinnerTime_TimePicker.Size = new System.Drawing.Size(241, 48);
               this.DinnerTime_TimePicker.TabIndex = 3;
               this.DinnerTime_TimePicker.Value = new System.DateTime(2021, 5, 6, 18, 0, 0, 0);
               // 
               // LunceTime_TimePicker
               // 
               this.LunceTime_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.LunceTime_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
               this.LunceTime_TimePicker.Location = new System.Drawing.Point(659, 709);
               this.LunceTime_TimePicker.Name = "LunceTime_TimePicker";
               this.LunceTime_TimePicker.Size = new System.Drawing.Size(241, 48);
               this.LunceTime_TimePicker.TabIndex = 4;
               this.LunceTime_TimePicker.Value = new System.DateTime(2021, 5, 6, 12, 0, 0, 0);
               // 
               // textBox1
               // 
               this.textBox1.BackColor = System.Drawing.SystemColors.Window;
               this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(192, 607);
               this.textBox1.Name = "textBox1";
               this.textBox1.ReadOnly = true;
               this.textBox1.Size = new System.Drawing.Size(667, 41);
               this.textBox1.TabIndex = 5;
               this.textBox1.Text = "Name : ";
               // 
               // contextMenuStrip1
               // 
               this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
               this.contextMenuStrip1.Name = "contextMenuStrip1";
               this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
               // 
               // Username_TextBox
               // 
               this.Username_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Username_TextBox.Location = new System.Drawing.Point(382, 607);
               this.Username_TextBox.Name = "Username_TextBox";
               this.Username_TextBox.Size = new System.Drawing.Size(518, 48);
               this.Username_TextBox.TabIndex = 7;
               // 
               // textBox3
               // 
               this.textBox3.BackColor = System.Drawing.SystemColors.Window;
               this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox3.Location = new System.Drawing.Point(192, 709);
               this.textBox3.Name = "textBox3";
               this.textBox3.ReadOnly = true;
               this.textBox3.Size = new System.Drawing.Size(334, 41);
               this.textBox3.TabIndex = 8;
               this.textBox3.Text = "Lunch Start Time :";
               // 
               // textBox4
               // 
               this.textBox4.BackColor = System.Drawing.SystemColors.Window;
               this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox4.Location = new System.Drawing.Point(192, 812);
               this.textBox4.Name = "textBox4";
               this.textBox4.ReadOnly = true;
               this.textBox4.Size = new System.Drawing.Size(367, 41);
               this.textBox4.TabIndex = 9;
               this.textBox4.Text = "Dinner Start Time :";
               // 
               // textBox5
               // 
               this.textBox5.BackColor = System.Drawing.SystemColors.Window;
               this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox5.Location = new System.Drawing.Point(192, 919);
               this.textBox5.Name = "textBox5";
               this.textBox5.ReadOnly = true;
               this.textBox5.Size = new System.Drawing.Size(386, 41);
               this.textBox5.TabIndex = 11;
               this.textBox5.Text = "Friendly Break Time :";
               // 
               // FriendlyTime_TimePicker
               // 
               this.FriendlyTime_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.FriendlyTime_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
               this.FriendlyTime_TimePicker.Location = new System.Drawing.Point(659, 919);
               this.FriendlyTime_TimePicker.Name = "FriendlyTime_TimePicker";
               this.FriendlyTime_TimePicker.Size = new System.Drawing.Size(241, 48);
               this.FriendlyTime_TimePicker.TabIndex = 10;
               this.FriendlyTime_TimePicker.Value = new System.DateTime(2021, 5, 6, 16, 20, 0, 0);
               // 
               // Logo_PictureBox
               // 
               this.Logo_PictureBox.Image = global::ASSEA.Properties.Resources.AppLogo;
               this.Logo_PictureBox.Location = new System.Drawing.Point(324, 67);
               this.Logo_PictureBox.Name = "Logo_PictureBox";
               this.Logo_PictureBox.Size = new System.Drawing.Size(959, 296);
               this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.Logo_PictureBox.TabIndex = 1;
               this.Logo_PictureBox.TabStop = false;
               // 
               // Soft_RadioButton
               // 
               this.Soft_RadioButton.AutoSize = true;
               this.Soft_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Soft_RadioButton.Location = new System.Drawing.Point(31, 16);
               this.Soft_RadioButton.Name = "Soft_RadioButton";
               this.Soft_RadioButton.Size = new System.Drawing.Size(112, 44);
               this.Soft_RadioButton.TabIndex = 13;
               this.Soft_RadioButton.TabStop = true;
               this.Soft_RadioButton.Text = "Soft";
               this.Soft_RadioButton.UseVisualStyleBackColor = true;
               // 
               // Normal_RadioButton
               // 
               this.Normal_RadioButton.AutoSize = true;
               this.Normal_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Normal_RadioButton.Location = new System.Drawing.Point(186, 16);
               this.Normal_RadioButton.Name = "Normal_RadioButton";
               this.Normal_RadioButton.Size = new System.Drawing.Size(164, 44);
               this.Normal_RadioButton.TabIndex = 14;
               this.Normal_RadioButton.TabStop = true;
               this.Normal_RadioButton.Text = "Normal";
               this.Normal_RadioButton.UseVisualStyleBackColor = true;
               // 
               // Extreme_RadioButton
               // 
               this.Extreme_RadioButton.AutoSize = true;
               this.Extreme_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Extreme_RadioButton.Location = new System.Drawing.Point(383, 16);
               this.Extreme_RadioButton.Name = "Extreme_RadioButton";
               this.Extreme_RadioButton.Size = new System.Drawing.Size(182, 44);
               this.Extreme_RadioButton.TabIndex = 15;
               this.Extreme_RadioButton.TabStop = true;
               this.Extreme_RadioButton.Text = "Extreme";
               this.Extreme_RadioButton.UseVisualStyleBackColor = true;
               // 
               // textBox6
               // 
               this.textBox6.BackColor = System.Drawing.SystemColors.Window;
               this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox6.Location = new System.Drawing.Point(192, 1019);
               this.textBox6.Name = "textBox6";
               this.textBox6.ReadOnly = true;
               this.textBox6.Size = new System.Drawing.Size(386, 41);
               this.textBox6.TabIndex = 16;
               this.textBox6.Text = "Notifications Frequency : ";
               // 
               // Interests_ComboBox
               // 
               this.Interests_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Interests_ComboBox.FormattingEnabled = true;
               this.Interests_ComboBox.Items.AddRange(new object[] {
            "Sport",
            "News",
            "Music",
            "All"});
               this.Interests_ComboBox.Location = new System.Drawing.Point(659, 1117);
               this.Interests_ComboBox.Name = "Interests_ComboBox";
               this.Interests_ComboBox.Size = new System.Drawing.Size(241, 48);
               this.Interests_ComboBox.TabIndex = 17;
               this.Interests_ComboBox.Text = "All";
               // 
               // textBox7
               // 
               this.textBox7.BackColor = System.Drawing.SystemColors.Window;
               this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox7.Location = new System.Drawing.Point(192, 1117);
               this.textBox7.Name = "textBox7";
               this.textBox7.ReadOnly = true;
               this.textBox7.Size = new System.Drawing.Size(386, 41);
               this.textBox7.TabIndex = 18;
               this.textBox7.Text = "Interests";
               // 
               // Notifications_Panel
               // 
               this.Notifications_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.Notifications_Panel.Controls.Add(this.Extreme_RadioButton);
               this.Notifications_Panel.Controls.Add(this.Normal_RadioButton);
               this.Notifications_Panel.Controls.Add(this.Soft_RadioButton);
               this.Notifications_Panel.Location = new System.Drawing.Point(638, 1005);
               this.Notifications_Panel.Name = "Notifications_Panel";
               this.Notifications_Panel.Size = new System.Drawing.Size(595, 75);
               this.Notifications_Panel.TabIndex = 20;
               // 
               // Error_TextBox
               // 
               this.Error_TextBox.BackColor = System.Drawing.SystemColors.Window;
               this.Error_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Error_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Error_TextBox.ForeColor = System.Drawing.Color.Red;
               this.Error_TextBox.Location = new System.Drawing.Point(1214, 1134);
               this.Error_TextBox.Name = "Error_TextBox";
               this.Error_TextBox.ReadOnly = true;
               this.Error_TextBox.Size = new System.Drawing.Size(360, 41);
               this.Error_TextBox.TabIndex = 21;
               this.Error_TextBox.Text = "Please enter all fields";
               this.Error_TextBox.Visible = false;
               // 
               // Submit_Button
               // 
               this.Submit_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
               this.Submit_Button.FlatAppearance.BorderSize = 0;
               this.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.Submit_Button.Image = global::ASSEA.Properties.Resources.LetsGoButton;
               this.Submit_Button.Location = new System.Drawing.Point(1244, 1188);
               this.Submit_Button.Margin = new System.Windows.Forms.Padding(10, 10, 60, 60);
               this.Submit_Button.Name = "Submit_Button";
               this.Submit_Button.Size = new System.Drawing.Size(305, 126);
               this.Submit_Button.TabIndex = 12;
               this.Submit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
               this.Submit_Button.UseVisualStyleBackColor = true;
               this.Submit_Button.Click += new System.EventHandler(this.SubmitForm_OnClick);
               // 
               // FormFirstEntry
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.BackColor = System.Drawing.SystemColors.Window;
               this.ClientSize = new System.Drawing.Size(1634, 1364);
               this.Controls.Add(this.Error_TextBox);
               this.Controls.Add(this.Notifications_Panel);
               this.Controls.Add(this.textBox7);
               this.Controls.Add(this.Interests_ComboBox);
               this.Controls.Add(this.textBox6);
               this.Controls.Add(this.Submit_Button);
               this.Controls.Add(this.textBox5);
               this.Controls.Add(this.FriendlyTime_TimePicker);
               this.Controls.Add(this.textBox4);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.Username_TextBox);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.LunceTime_TimePicker);
               this.Controls.Add(this.DinnerTime_TimePicker);
               this.Controls.Add(this.Header_TextBox);
               this.Controls.Add(this.Logo_PictureBox);
               this.MinimumSize = new System.Drawing.Size(1662, 1443);
               this.Name = "FormFirstEntry";
               this.ShowIcon = false;
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
               this.Notifications_Panel.ResumeLayout(false);
               this.Notifications_Panel.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox Logo_PictureBox;
          private System.Windows.Forms.TextBox Header_TextBox;
          private System.Windows.Forms.DateTimePicker DinnerTime_TimePicker;
          private System.Windows.Forms.DateTimePicker LunceTime_TimePicker;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
          private System.Windows.Forms.TextBox Username_TextBox;
          private System.ComponentModel.BackgroundWorker backgroundWorker1;
          private System.Windows.Forms.TextBox textBox3;
          private System.Windows.Forms.TextBox textBox4;
          private TextBox textBox5;
          private DateTimePicker FriendlyTime_TimePicker;
          private RadioButton Soft_RadioButton;
          private RadioButton Normal_RadioButton;
          private RadioButton Extreme_RadioButton;
          private TextBox textBox6;
          private ComboBox Interests_ComboBox;
          private TextBox textBox7;
          private Panel Notifications_Panel;
          private TextBox Error_TextBox;
          private Button Submit_Button;
     }
}

