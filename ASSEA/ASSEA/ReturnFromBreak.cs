using ASSEA_Logic;
using System.Windows.Forms;

namespace ASSEA
{
     public partial class ReturnFromBreak : Form
     {
          public AppSetting appSetting { get; set; }

          public ReturnFromBreak(AppSetting appSetting)
          {
               this.appSetting = appSetting;
               InitializeComponent();
          }

          private void returnButton_OnClick(object sender, System.EventArgs e)
          {
               this.appSetting.returnFromBreak();
          }
     }
}
