using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASSEA
{
     public partial class FormFirstEntry : Form
     {

          public FormFirstEntry()
          {
               InitializeComponent();
               // Header_TextBox.BackColor = Color.Transparent;
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
               RadioButton rbChecked;

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
                    Error_TextBox.Hide();
                    //// new logic. 
                    //Form dialog = new DashboardForm();
                    //dialog.ShowDialog();
                    //this.Close();
               }
          }
     }
}
