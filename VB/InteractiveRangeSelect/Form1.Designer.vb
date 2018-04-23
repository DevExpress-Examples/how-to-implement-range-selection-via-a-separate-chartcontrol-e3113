Imports Microsoft.VisualBasic
Imports System
Namespace InteractiveRangeSelect
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim areaSeriesView2 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim pointSeriesLabel4 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Me.chartSelectRange = New DevExpress.XtraCharts.ChartControl()
			Me.chartLine = New DevExpress.XtraCharts.ChartControl()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			CType(Me.chartSelectRange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartLine, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' chartSelectRange
			' 
			Me.chartSelectRange.AppearanceName = "Gray"
			xyDiagram1.AxisX.DateTimeGridAlignment = DevExpress.XtraCharts.DateTimeMeasurementUnit.Hour
			xyDiagram1.AxisX.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Minute
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = False
			xyDiagram1.AxisX.Range.SideMarginsEnabled = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartSelectRange.Diagram = xyDiagram1
			Me.chartSelectRange.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartSelectRange.Legend.Visible = False
			Me.chartSelectRange.Location = New System.Drawing.Point(0, 0)
			Me.chartSelectRange.Name = "chartSelectRange"
			Me.chartSelectRange.PaletteName = "The Trees"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			pointSeriesLabel1.LineVisible = True
			pointSeriesLabel1.Visible = False
			series1.Label = pointSeriesLabel1
			series1.Name = "Series 1"
			areaSeriesView1.MarkerOptions.Visible = False
			series1.View = areaSeriesView1
			Me.chartSelectRange.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			pointSeriesLabel2.LineVisible = True
			Me.chartSelectRange.SeriesTemplate.Label = pointSeriesLabel2
			areaSeriesView2.Transparency = (CByte(0))
			Me.chartSelectRange.SeriesTemplate.View = areaSeriesView2
			Me.chartSelectRange.Size = New System.Drawing.Size(775, 145)
			Me.chartSelectRange.TabIndex = 0
'			Me.chartSelectRange.CustomPaint += New DevExpress.XtraCharts.CustomPaintEventHandler(Me.chartSelectRange_CustomPaint);
'			Me.chartSelectRange.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chartSelectRange_MouseMove);
'			Me.chartSelectRange.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.chartSelectRange_MouseUp);
'			Me.chartSelectRange.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chartSelectRange_MouseDown);
			' 
			' chartLine
			' 
			Me.chartLine.AppearanceName = "In A Fog"
			xyDiagram2.AxisX.DateTimeGridAlignment = DevExpress.XtraCharts.DateTimeMeasurementUnit.Hour
			xyDiagram2.AxisX.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Minute
			xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisX.Range.SideMarginsEnabled = False
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisY.Range.SideMarginsEnabled = True
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartLine.Diagram = xyDiagram2
			Me.chartLine.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartLine.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chartLine.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chartLine.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chartLine.Legend.Visible = False
			Me.chartLine.Location = New System.Drawing.Point(0, 0)
			Me.chartLine.Name = "chartLine"
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			pointSeriesLabel3.LineVisible = True
			pointSeriesLabel3.Visible = False
			series2.Label = pointSeriesLabel3
			series2.Name = "Series 1"
			lineSeriesView1.LineMarkerOptions.Visible = False
			series2.View = lineSeriesView1
			Me.chartLine.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			pointSeriesLabel4.LineVisible = True
			Me.chartLine.SeriesTemplate.Label = pointSeriesLabel4
			Me.chartLine.SeriesTemplate.View = lineSeriesView2
			Me.chartLine.Size = New System.Drawing.Size(775, 315)
			Me.chartLine.TabIndex = 1
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.chartLine)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.chartSelectRange)
			Me.splitContainer1.Size = New System.Drawing.Size(775, 464)
			Me.splitContainer1.SplitterDistance = 315
			Me.splitContainer1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(775, 464)
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartSelectRange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartLine, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartSelectRange As DevExpress.XtraCharts.ChartControl
		Private chartLine As DevExpress.XtraCharts.ChartControl
		Private splitContainer1 As System.Windows.Forms.SplitContainer
	End Class
End Namespace

