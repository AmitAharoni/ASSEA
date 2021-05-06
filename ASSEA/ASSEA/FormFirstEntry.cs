using System;
using ASSEA_Logic;
using System.Windows.Forms;

namespace ASSEA
{
     public partial class FormFirstEntry : Form
     {
          public FormFirstEntry()
          {
               InitializeComponent();
               Error_TextBox.Hide();
               setTimePickers(LunceTime_TimePicker);
               setTimePickers(DinnerTime_TimePicker);
               setTimePickers(FriendlyTime_TimePicker);
          }

          private void setTimePickers(DateTimePicker datePicker)
          {
               datePicker.ShowUpDown = true;
               datePicker.BringToFront();
          }

          private void SubmitForm_OnClick(object sender, EventArgs e)
          {
               bool bChecked = false;
               RadioButton rbChecked = null;

               foreach (Control control in Notifications_Panel.Controls)
               {
                    if ((control as RadioButton).Checked)
                    {
                         rbChecked = control as RadioButton;
                         bChecked = true;
                    }
               }

               if (String.IsNullOrEmpty(Username_TextBox.Text) || !bChecked)
               {
                    Error_TextBox.Show();
               }
               else
               {
                    AppSetting.eNotificationsLevel notificationsLevel = getNotificationLevel(rbChecked);
                    AppSetting.eInterset interest = getInterest(Interests_ComboBox.Text);
                    Error_TextBox.Hide();
                    AppSetting appSetting = new AppSetting(Username_TextBox.Text, LunceTime_TimePicker.Value,
                         DinnerTime_TimePicker.Value, FriendlyTime_TimePicker.Value, interest, notificationsLevel);
                    FormDashboard dashboard = new FormDashboard(appSetting);

                    this.Hide();
                    dashboard.ShowDialog();
               }
          }

          private AppSetting.eNotificationsLevel getNotificationLevel(RadioButton rbChecked)
          {
               AppSetting.eNotificationsLevel notificationsLevel = AppSetting.eNotificationsLevel.normal;
               String value = rbChecked.Text.ToLower();

               if (value.Equals(AppSetting.eNotificationsLevel.soft))
               {
                    notificationsLevel = AppSetting.eNotificationsLevel.soft;
               }
               else if (value.Equals(AppSetting.eNotificationsLevel.extreme))
               {
                    notificationsLevel = AppSetting.eNotificationsLevel.extreme;
               }

               return notificationsLevel;
          }

          private AppSetting.eInterset getInterest(String Interest)
          {
               AppSetting.eInterset interest = AppSetting.eInterset.All;

               if (Interest.Equals(AppSetting.eInterset.Music))
               {
                    interest = AppSetting.eInterset.Music;
               }
               else if (Interest.Equals(AppSetting.eInterset.Sport))
               {
                    interest = AppSetting.eInterset.Sport;
               }
               else if (Interest.Equals(AppSetting.eInterset.News))
               {
                    interest = AppSetting.eInterset.News;
               }

               return interest;
          }
     }
}