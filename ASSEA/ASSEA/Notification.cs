using System;
using System.Collections.Generic;
using ASSEA_Logic;
using System.Windows.Forms;

namespace ASSEA
{
     public partial class Notification : Form
     {
          public FormDashboard formDashboard { get; set; }

          public Notification(FormDashboard formDashboard)
          {
               this.formDashboard = formDashboard;
               InitializeComponent();
          }

          protected override void OnClosed(EventArgs e)
          {
               base.OnClosed(e);

          }

          private void yesButton_OnClick(object sender, EventArgs e)
          {
              // this.formDashboard.appSetting.receiveAnswer(AppSetting.eQuery , true);
              // this.Close();
          }

          private void laterButton_OnClick(object sender, EventArgs e)
          {
          }

          private void noButton_OnClick(object sender, EventArgs e)
          {
               // this.formDashboard.appSetting.receiveAnswer(AppSetting.eQuery, true);
          }
     }
}
