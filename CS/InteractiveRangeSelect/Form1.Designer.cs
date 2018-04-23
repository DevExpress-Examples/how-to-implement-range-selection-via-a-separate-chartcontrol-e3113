﻿namespace InteractiveRangeSelect
{
    partial class Form1
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView2 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel4 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartSelectRange = new DevExpress.XtraCharts.ChartControl();
            this.chartLine = new DevExpress.XtraCharts.ChartControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chartSelectRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSelectRange
            // 
            this.chartSelectRange.AppearanceName = "Gray";
            xyDiagram1.AxisX.DateTimeGridAlignment = DevExpress.XtraCharts.DateTimeMeasurementUnit.Hour;
            xyDiagram1.AxisX.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Minute;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = false;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartSelectRange.Diagram = xyDiagram1;
            this.chartSelectRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSelectRange.Legend.Visible = false;
            this.chartSelectRange.Location = new System.Drawing.Point(0, 0);
            this.chartSelectRange.Name = "chartSelectRange";
            this.chartSelectRange.PaletteName = "The Trees";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            pointSeriesLabel1.LineVisible = true;
            pointSeriesLabel1.Visible = false;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            areaSeriesView1.MarkerOptions.Visible = false;
            series1.View = areaSeriesView1;
            this.chartSelectRange.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.chartSelectRange.SeriesTemplate.Label = pointSeriesLabel2;
            areaSeriesView2.Transparency = ((byte)(0));
            this.chartSelectRange.SeriesTemplate.View = areaSeriesView2;
            this.chartSelectRange.Size = new System.Drawing.Size(775, 145);
            this.chartSelectRange.TabIndex = 0;
            this.chartSelectRange.CustomPaint += new DevExpress.XtraCharts.CustomPaintEventHandler(this.chartSelectRange_CustomPaint);
            this.chartSelectRange.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartSelectRange_MouseMove);
            this.chartSelectRange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chartSelectRange_MouseUp);
            this.chartSelectRange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartSelectRange_MouseDown);
            // 
            // chartLine
            // 
            this.chartLine.AppearanceName = "In A Fog";
            xyDiagram2.AxisX.DateTimeGridAlignment = DevExpress.XtraCharts.DateTimeMeasurementUnit.Hour;
            xyDiagram2.AxisX.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Minute;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = false;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartLine.Diagram = xyDiagram2;
            this.chartLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartLine.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartLine.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartLine.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartLine.Legend.Visible = false;
            this.chartLine.Location = new System.Drawing.Point(0, 0);
            this.chartLine.Name = "chartLine";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            pointSeriesLabel3.LineVisible = true;
            pointSeriesLabel3.Visible = false;
            series2.Label = pointSeriesLabel3;
            series2.Name = "Series 1";
            lineSeriesView1.LineMarkerOptions.Visible = false;
            series2.View = lineSeriesView1;
            this.chartLine.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            pointSeriesLabel4.LineVisible = true;
            this.chartLine.SeriesTemplate.Label = pointSeriesLabel4;
            this.chartLine.SeriesTemplate.View = lineSeriesView2;
            this.chartLine.Size = new System.Drawing.Size(775, 315);
            this.chartLine.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartLine);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartSelectRange);
            this.splitContainer1.Size = new System.Drawing.Size(775, 464);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 464);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSelectRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartSelectRange;
        private DevExpress.XtraCharts.ChartControl chartLine;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

