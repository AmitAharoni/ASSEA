using System;
using System.Collections.Generic;
using ASSEA_Logic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.ComponentModel;

namespace ASSEA
{
     public partial class FormNotification : Form
     {
          public FormDashboard formDashboard { get; set; }
          private AppSetting.eQuery query;
          private System.Windows.Forms.Timer tmr;
          private bool SelectYes = false;

          public FormNotification(FormDashboard formDashboard, string message, AppSetting.eQuery query)
          {
               InitializeComponent();
               this.formDashboard = formDashboard;
               Notification_TextBox.Text = message;
               this.query = query;

               tmr = new System.Windows.Forms.Timer();
               tmr.Tick += delegate
               {
                    this.Close();
               };
               tmr.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
               tmr.Start();
          }

          protected override void OnLoad(EventArgs e)
          {
               var screen = Screen.FromPoint(this.Location);
               this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
               base.OnLoad(e);
          }

          protected override void OnFormClosed(FormClosedEventArgs e)
          {
               base.OnFormClosed(e);
               if (this.SelectYes)
               {
                    ReturnFromBreak returnFrom = new ReturnFromBreak(formDashboard.appSetting);
                    returnFrom.ShowDialog();
               }
          }

          private void yesButton_OnClick(object sender, EventArgs e)
          {
               this.formDashboard.appSetting.receiveAnswer(query, true);
               this.SelectYes = true;
               this.Hide();
               this.Close();
          }

          private void laterButton_OnClick(object sender, EventArgs e)
          {
               this.Close();
          }

          private void noButton_OnClick(object sender, EventArgs e)
          {
               this.formDashboard.appSetting.receiveAnswer(query, false);
               this.Close();
          }
     }
}
