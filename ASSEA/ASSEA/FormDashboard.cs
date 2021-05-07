using System.Drawing;
using ASSEA_Logic;
using System.Windows.Forms;
using System;
using System.Threading;

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
               else
               {
                    this.appSetting.setThreads();
               }
          }

          protected override void OnClosed(EventArgs e)
          {
               base.OnClosed(e);
               System.Environment.Exit(-1);
          }

          protected override void OnShown(EventArgs e)
          {
               base.OnShown(e);
               this.appSetting.msgNotifier += opeNotification;
               this.appSetting.updateScalesNotifier += updateScales;
               Welcome_TextBox.Text = String.Format("Hi {0}, update your states.", this.appSetting.userName);
          }

          public void updateScales(int physical, int mental)
          {
               Invoke(new Action(() =>
               {
                    if (mental <= 100)
                    {
                         Mental_TrackBar.Value = mental;
                    }
                    if (physical <= 100)
                    {
                         Physical_TrackBar.Value = physical;
                    }
               }));
          }

          public void opeNotification(string message, AppSetting.eQuery query)
          {
               FormNotification formNotification = new FormNotification(this, message, query);
               formNotification.ShowDialog();
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
               this.appSetting.mentalScale = Mental_TrackBar.Value;
               Mental_TextBox.Text = Mental_TrackBar.Value + "%";
          }

          private void physicalTrackBar_OnValueChanged(object sender, System.EventArgs e)
          {
               Physical_ProgressBar.Value = Physical_TrackBar.Value;
               this.appSetting.physicalScale = Physical_TrackBar.Value;
               Physical_TextBox.Text = Physical_TrackBar.Value + "%";
          }

          private void settingsButton_OnClick(object sender, System.EventArgs e)
          {
               // open settings
          }

     }
}
