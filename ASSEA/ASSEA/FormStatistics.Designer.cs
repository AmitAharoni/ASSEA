
namespace ASSEA
{
     partial class Statistics
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
               this.chartPiePhysical = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.chartPieMental = new System.Windows.Forms.DataVisualization.Charting.Chart();
               ((System.ComponentModel.ISupportInitialize)(this.chartPiePhysical)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartPieMental)).BeginInit();
               this.SuspendLayout();
               // 
               // chartPiePhysical
               // 
               this.chartPiePhysical.BorderlineColor = System.Drawing.Color.Transparent;
               chartArea3.Name = "ChartArea1";
               this.chartPiePhysical.ChartAreas.Add(chartArea3);
               legend3.Name = "Legend1";
               this.chartPiePhysical.Legends.Add(legend3);
               this.chartPiePhysical.Location = new System.Drawing.Point(179, 313);
               this.chartPiePhysical.Name = "chartPiePhysical";
               series3.ChartArea = "ChartArea1";
               series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
               series3.Legend = "Legend1";
               series3.Name = "ChartPie";
               this.chartPiePhysical.Series.Add(series3);
               this.chartPiePhysical.Size = new System.Drawing.Size(833, 879);
               this.chartPiePhysical.TabIndex = 0;
               this.chartPiePhysical.Text = "chart1";
               // 
               // textBox1
               // 
               this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.textBox1.BackColor = System.Drawing.SystemColors.Window;
               this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(490, 46);
               this.textBox1.Name = "textBox1";
               this.textBox1.ReadOnly = true;
               this.textBox1.Size = new System.Drawing.Size(1076, 136);
               this.textBox1.TabIndex = 1;
               this.textBox1.Text = "Day Summary";
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // chartPieMental
               // 
               this.chartPieMental.BorderlineColor = System.Drawing.Color.Transparent;
               chartArea4.Name = "ChartArea1";
               this.chartPieMental.ChartAreas.Add(chartArea4);
               legend4.Name = "Legend1";
               this.chartPieMental.Legends.Add(legend4);
               this.chartPieMental.Location = new System.Drawing.Point(1049, 313);
               this.chartPieMental.Name = "chartPieMental";
               series4.ChartArea = "ChartArea1";
               series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
               series4.Legend = "Legend1";
               series4.Name = "ChartPie";
               this.chartPieMental.Series.Add(series4);
               this.chartPieMental.Size = new System.Drawing.Size(833, 879);
               this.chartPieMental.TabIndex = 2;
               this.chartPieMental.Text = "chart1";
               // 
               // Statistics
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.BackColor = System.Drawing.SystemColors.Window;
               this.ClientSize = new System.Drawing.Size(2129, 1123);
               this.Controls.Add(this.chartPieMental);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.chartPiePhysical);
               this.MinimumSize = new System.Drawing.Size(1538, 1202);
               this.Name = "Statistics";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Statistics";
               ((System.ComponentModel.ISupportInitialize)(this.chartPiePhysical)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartPieMental)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataVisualization.Charting.Chart chartPiePhysical;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.DataVisualization.Charting.Chart chartPieMental;
     }
}