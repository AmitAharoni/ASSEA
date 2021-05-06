using System.Drawing;
using ASSEA_Logic;
using System.Windows.Forms;

namespace ASSEA
{
    public partial class FormDashboard : Form
    {
          private AppSetting appSetting = null;

          public FormDashboard()
          {
               this.appSetting = AppSetting.UserExist() ? appSetting = AppSetting.LoadFromFile() : null;

               if (appSetting == null)
               {
                    initSetting();
               }
               
               InitializeComponent();
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
               FormFirstEntry firstEntry = new FormFirstEntry();
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
