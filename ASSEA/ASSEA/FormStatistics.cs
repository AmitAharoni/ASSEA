using System;
using ASSEA_Logic;
using System.Windows.Forms;

namespace ASSEA
{
     public partial class Statistics : Form
     {
          public int mentalYes { get; set; }
          public int mentalNo { get; set; }
          public int physicalYes { get; set; }
          public int physicalNo { get; set; }
          public Statistics(AppSetting app)
          {
               this.mentalYes = app.mentalAnswersYes;
               this.mentalNo = app.mentalAnswerNo;
               this.physicalYes = app.physicalAnswerYes;
               this.physicalNo = app.physicalAnswerNo;
               InitializeComponent();
               chartPieMental.Series["ChartPie"].Points.AddXY("Mental Answers Yes", mentalYes);
               chartPieMental.Series["ChartPie"].Points.AddXY("Mental Answers No", mentalNo);
               chartPiePhysical.Series["ChartPie"].Points.AddXY("Physical Answers Yes", physicalYes);
               chartPiePhysical.Series["ChartPie"].Points.AddXY("Physical Answers Yes", physicalNo);
          }

          protected override void OnClosed(EventArgs e)
          {
               base.OnClosed(e);
               System.Environment.Exit(-1);
          }

     }
}
