using System;
using System.Collections.Generic;
using ASSEA_Logic;
using System.Windows.Forms;
using System.Threading;

namespace ASSEA
{
     public partial class FormNotification : Form
     {
          public FormDashboard formDashboard { get; set; }
          private AppSetting.eQuery query;
          private System.Windows.Forms.Timer tmr;

          public FormNotification(FormDashboard formDashboard, string message, AppSetting.eQuery query)
          {
               InitializeComponent();
               this.formDashboard = formDashboard;
               Notification_TextBox.Text = message;
               this.query = query;

               tmr = new System.Windows.Forms.Timer();
               tmr.Tick += delegate {
                    this.Close();
               };
               tmr.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
               tmr.Start();
          }

          protected override void OnClosed(EventArgs e)
          {
               base.OnClosed(e);
          }

          private void yesButton_OnClick(object sender, EventArgs e)
          {
              this.formDashboard.appSetting.receiveAnswer(query , true);
              this.Close();
          }

          private void laterButton_OnClick(object sender, EventArgs e)
          {
               // 
          }

          private void noButton_OnClick(object sender, EventArgs e)
          {
               this.formDashboard.appSetting.receiveAnswer(query, true);
               this.formDashboard.Show();
               this.Close();
          }
     }
}
