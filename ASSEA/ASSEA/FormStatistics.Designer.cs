
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
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
               this.chartPiePhysical = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.chartPieMental = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.textBox2 = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.chartPiePhysical)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartPieMental)).BeginInit();
               this.SuspendLayout();
               // 
               // chartPiePhysical
               // 
               this.chartPiePhysical.BorderlineColor = System.Drawing.Color.Transparent;
               chartArea1.Name = "ChartArea1";
               this.chartPiePhysical.ChartAreas.Add(chartArea1);
               legend1.Name = "Legend1";
               this.chartPiePhysical.Legends.Add(legend1);
               this.chartPiePhysical.Location = new System.Drawing.Point(0, 270);
               this.chartPiePhysical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.chartPiePhysical.Name = "chartPiePhysical";
               series1.ChartArea = "ChartArea1";
               series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
               series1.Legend = "Legend1";
               series1.Name = "ChartPie";
               this.chartPiePhysical.Series.Add(series1);
               this.chartPiePhysical.Size = new System.Drawing.Size(649, 488);
               this.chartPiePhysical.TabIndex = 0;
               this.chartPiePhysical.Text = "chart1";
               // 
               // textBox1
               // 
               this.textBox1.BackColor = System.Drawing.SystemColors.Window;
               this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(0, 0);
               this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.textBox1.Name = "textBox1";
               this.textBox1.ReadOnly = true;
               this.textBox1.Size = new System.Drawing.Size(1237, 59);
               this.textBox1.TabIndex = 1;
               this.textBox1.Text = "Hi! here\'s your day summary";
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // chartPieMental
               // 
               this.chartPieMental.BorderlineColor = System.Drawing.Color.Transparent;
               chartArea2.Name = "ChartArea1";
               this.chartPieMental.ChartAreas.Add(chartArea2);
               legend2.Name = "Legend1";
               this.chartPieMental.Legends.Add(legend2);
               this.chartPieMental.Location = new System.Drawing.Point(748, 270);
               this.chartPieMental.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.chartPieMental.Name = "chartPieMental";
               series2.ChartArea = "ChartArea1";
               series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
               series2.Legend = "Legend1";
               series2.Name = "ChartPie";
               this.chartPieMental.Series.Add(series2);
               this.chartPieMental.Size = new System.Drawing.Size(620, 497);
               this.chartPieMental.TabIndex = 2;
               this.chartPieMental.Text = "chart1";
               // 
               // textBox2
               // 
               this.textBox2.BackColor = System.Drawing.SystemColors.Window;
               this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox2.Location = new System.Drawing.Point(0, 82);
               this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.textBox2.Name = "textBox2";
               this.textBox2.ReadOnly = true;
               this.textBox2.Size = new System.Drawing.Size(1369, 50);
               this.textBox2.TabIndex = 3;
               this.textBox2.Text = "Today you\'ve worked 06:37 hours. Received 13 messages.";
               this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // Statistics
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.BackColor = System.Drawing.SystemColors.Window;
               this.ClientSize = new System.Drawing.Size(1237, 724);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.chartPieMental);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.chartPiePhysical);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MinimumSize = new System.Drawing.Size(997, 719);
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
          private System.Windows.Forms.TextBox textBox2;
     }
}