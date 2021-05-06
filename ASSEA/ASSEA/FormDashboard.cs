using System.Drawing;
using ASSEA_Logic;
using System.Windows.Forms;

namespace ASSEA
{
    public partial class FormDashboard : Form
    {
          private AppSetting user;
          public FormDashboard()
          {
               Physical_TrackBar.BackColor = Color.Green;
               this.user = AppSetting.UserExist() ? user = AppSetting.LoadFromFile() : null;

               if (user == null)
               {
                    initSetting();
               }
               else
               {
                    InitializeComponent();
               }
          }

          public FormDashboard(AppSetting user)
          {
               this.user = user;
          }

          private void initSetting()
          {
               // User user = new User();
               FormFirstEntry firstEntry = new FormFirstEntry();
               firstEntry.ShowDialog();
               this.Close();
          }
     }
}
