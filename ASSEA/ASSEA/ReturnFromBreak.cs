using ASSEA_Logic;
using System;
using System.Drawing;
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

          protected override void OnLoad(EventArgs e)
          {
               var screen = Screen.FromPoint(this.Location);
               this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
               base.OnLoad(e);
          }

          private void returnButton_OnClick(object sender, System.EventArgs e)
          {
               this.appSetting.returnFromBreak();
               this.Close();
          }
     }
}
