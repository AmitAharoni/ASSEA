
namespace ASSEA
{
     partial class ReturnFromBreak
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
               this.Return_Button = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.Return_Button)).BeginInit();
               this.SuspendLayout();
               // 
               // Return_Button
               // 
               this.Return_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.Return_Button.Image = global::ASSEA.Properties.Resources.button_returned_from_break;
               this.Return_Button.Location = new System.Drawing.Point(1, -1);
               this.Return_Button.Name = "Return_Button";
               this.Return_Button.Size = new System.Drawing.Size(514, 102);
               this.Return_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.Return_Button.TabIndex = 0;
               this.Return_Button.TabStop = false;
               this.Return_Button.Click += new System.EventHandler(this.returnButton_OnClick);
               // 
               // ReturnFromBreak
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(520, 107);
               this.Controls.Add(this.Return_Button);
               this.Name = "ReturnFromBreak";
               this.ShowIcon = false;
               this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
               this.Text = "Return From Break";
               ((System.ComponentModel.ISupportInitialize)(this.Return_Button)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.PictureBox Return_Button;
     }
}