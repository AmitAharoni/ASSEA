using System.Drawing;
using ASSEA_Logic;
using System.Windows.Forms;
using System;

namespace ASSEA
{
    public partial class FormDashboard : Form
    {
          public AppSetting appSetting { get; set; }

          public FormDashboard()
          {
               this.appSetting = AppSetting.UserExist() ? appSetting = AppSetting.LoadFromFile() : null;
               InitializeComponent();

               if (appSetting == null)
               {
                    initSetting();
               }
          }

          protected override void OnShown(EventArgs e)
          {
               base.OnShown(e);
               // AppSetting.msgNotifier += new EventHandler(handleNotificationEvent);
          }

          protected override void OnFormClosing(FormClosingEventArgs e)
          {
               base.OnFormClosing(e);

               // too tip... going to close...

               if (this.appSetting != null)
               {
                    this.appSetting.SaveToFile();
               }
          }


          public FormDashboard(AppSetting appSetting)
          {
               InitializeComponent();
               this.appSetting = appSetting;
               appSetting.SaveToFile();
          }

          private void initSetting()
          {
               FormFirstEntry firstEntry = new FormFirstEntry(this);
               firstEntry.ShowDialog();
          }

          private void EndShift_OnClick(object sender, System.EventArgs e)
          {
               // start last analystic form
          }

          private void mentalTrackBar_OnValueChanged(object sender, System.EventArgs e)
          {
               Mental_ProgressBar.Value = Mental_TrackBar.Value;
               Mental_TextBox.Text = Mental_TrackBar.Value + "%";
          }

          private void physicalTrackBar_OnValueChanged(object sender, System.EventArgs e)
          {
               Physical_ProgressBar.Value = Physical_TrackBar.Value;
               Physical_TextBox.Text = Physical_TrackBar.Value + "%";
          }

          private void settingsButton_OnClick(object sender, System.EventArgs e)
          {
               // open settings
          }
     }
}
