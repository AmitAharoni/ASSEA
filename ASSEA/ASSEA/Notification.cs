using System;
using System.Collections.Generic;
using ASSEA_Logic;
using System.Windows.Forms;

namespace ASSEA
{
     public partial class Notification : Form
     {
          private AppSetting appSetting;
          public Notification(AppSetting appSetting)
          {
               this.appSetting = appSetting;
               InitializeComponent();
          }

          protected override void OnClosed(EventArgs e)
          {
               base.OnClosed(e);

          }

          private void yesButton_OnClick(object sender, EventArgs e)
          {
               appSetting.recieveAnswer( , true);
               this.Close()
          }

          private void laterButton_OnClick(object sender, EventArgs e)
          {
          }

          private void noButton_OnClick(object sender, EventArgs e)
          {
               appSetting.recieveAnswer( , false);
          }
     }
}
