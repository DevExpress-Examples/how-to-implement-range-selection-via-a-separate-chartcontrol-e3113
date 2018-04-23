Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace InteractiveRangeSelect

	Partial Public Class Form1
		Inherits Form
		Private dt As New DataTable()
		Private draggingStart As Boolean = False
		Private draggingEnd As Boolean = False

		Private defaultCursor As Cursor
		Private minRange, maxRange As DateTime

		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chartSelectRange.Diagram, XYDiagram)
			End Get
		End Property
		Private lineStart, lineEnd As ConstantLine

		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub InitRangeIndicators()
			lineStart = New ConstantLine(String.Empty, minRange)
			lineStart.LineStyle.DashStyle = DashStyle.Dash
			lineStart.LineStyle.Thickness = 4
			lineStart.ShowInLegend = False

			lineEnd = New ConstantLine(String.Empty, maxRange)
			lineEnd.LineStyle.DashStyle = DashStyle.Dash
			lineEnd.LineStyle.Thickness = 4
			lineEnd.ShowInLegend = False
			Diagram.AxisX.ConstantLines.AddRange(New ConstantLine() { lineStart, lineEnd })
		End Sub

		Private Sub SetCursor(ByVal dateTime As DateTime)
			If defaultCursor Is Nothing Then
				defaultCursor = Cursor.Current
			End If
			Cursor.Current = Cursors.VSplit
		End Sub

		Private Sub RestoreCursor()
			If defaultCursor IsNot Nothing Then
				Cursor.Current = defaultCursor
				defaultCursor = Nothing
			End If
		End Sub

		Private Sub AdjustRange(ByVal dateTime As DateTime)

			If draggingStart Then

				If dateTime >= maxRange.AddMinutes(-5) Then
					dateTime = maxRange.AddMinutes(-5)
				End If
				lineStart.AxisValue = dateTime
				minRange = dateTime
			ElseIf draggingEnd Then
				If dateTime <= minRange.AddMinutes(5) Then
					dateTime = minRange.AddMinutes(5)
				End If
				lineEnd.AxisValue = dateTime
				maxRange = dateTime
			End If


		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PopulateDataSet()
			InitRangeIndicators()
		End Sub


		Private Sub PopulateDataSet()
			Dim rnd As New Random(DateTime.Now.Millisecond)

			dt.Columns.Add(New DataColumn("Date", GetType(DateTime)))
			dt.Columns.Add(New DataColumn("Value", GetType(Double)))
			For i As Integer = 0 To 99
				dt.Rows.Add(New Object() { DateTime.Now.Date.AddMinutes(i), rnd.NextDouble() * 5 + 15 })
			Next i

			chartSelectRange.Series(0).ArgumentDataMember = "Date"
			chartSelectRange.Series(0).ValueDataMembers.AddRange(New String() { "Value" })
			chartLine.Series(0).ArgumentDataMember = "Date"
			chartLine.Series(0).ValueDataMembers.AddRange(New String() { "Value" })

			chartSelectRange.Series(0).DataSource = dt
			chartLine.Series(0).DataSource = dt

			minRange = Convert.ToDateTime(chartSelectRange.Series(0).Points(0).Argument).AddMinutes(5)
			maxRange = Convert.ToDateTime(chartSelectRange.Series(0).Points(chartSelectRange.Series(0).Points.Count - 1).Argument).AddMinutes(-5)

			Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute
			Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Hour
			Diagram.AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom
			Diagram.AxisX.Label.DateTimeOptions.FormatString = "MM/dd/yy HH:mm"

			CType(chartLine.Diagram, XYDiagram).AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute
			CType(chartLine.Diagram, XYDiagram).AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Minute
			CType(chartLine.Diagram, XYDiagram).AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom
			CType(chartLine.Diagram, XYDiagram).AxisX.Label.DateTimeOptions.FormatString = "HH:mm"
		End Sub

		Private Sub chartSelectRange_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartSelectRange.MouseDown
			If Diagram Is Nothing Then
				Return
			End If
			Dim hitInfo As ChartHitInfo = chartSelectRange.CalcHitInfo(e.Location)
			Dim coords As DiagramCoordinates = Diagram.PointToDiagram(e.Location)
			If hitInfo.InConstantLine Then
				chartSelectRange.Capture = True
				If hitInfo.ConstantLine Is lineStart Then
					draggingStart = True
					draggingEnd = False

					SetCursor(coords.DateTimeArgument)
				ElseIf hitInfo.ConstantLine Is lineEnd Then
					draggingEnd = True
					draggingStart = False

					SetCursor(coords.DateTimeArgument)
				End If
			End If
		End Sub

		Private Sub chartSelectRange_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartSelectRange.MouseUp
			If Diagram Is Nothing Then
				Return
			End If
			draggingStart = False
			draggingEnd = False
			chartSelectRange.Capture = False
			CType(chartLine.Diagram, XYDiagram).AxisX.VisualRange.SetMinMaxValues(minRange, maxRange)
		End Sub

		Private Sub chartSelectRange_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartSelectRange.MouseMove
			If Diagram Is Nothing Then
				Return
			End If
			If (draggingStart OrElse draggingEnd) AndAlso (e.Button And MouseButtons.Left) = 0 Then
				draggingStart = False
				draggingEnd = False
				chartSelectRange.Capture = False
			End If

			Dim coords As DiagramCoordinates = Diagram.PointToDiagram(e.Location)
			If coords.IsEmpty Then
				RestoreCursor()
			Else
				If draggingStart OrElse draggingEnd Then

					AdjustRange(coords.DateTimeArgument)

				Else
					RestoreCursor()
				End If
			End If
		End Sub


		Private Sub chartSelectRange_CustomPaint(ByVal sender As Object, ByVal e As CustomPaintEventArgs) Handles chartSelectRange.CustomPaint
			If Diagram Is Nothing Then
				Return
			End If
			Dim leftBottom As ControlCoordinates = Diagram.DiagramToPoint(minRange, Convert.ToDouble(Diagram.AxisY.VisualRange.MinValue))
			Dim leftTop As ControlCoordinates = Diagram.DiagramToPoint(minRange, Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue))
			Dim rightTop As ControlCoordinates = Diagram.DiagramToPoint(maxRange, Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue))

			Dim leftZero As ControlCoordinates = Diagram.DiagramToPoint(Convert.ToDateTime(Diagram.AxisX.VisualRange.MinValue), Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue))
			Dim rightMax As ControlCoordinates = Diagram.DiagramToPoint(Convert.ToDateTime(Diagram.AxisX.VisualRange.MaxValue), Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue))


			Dim width As Integer = rightTop.Point.X - leftBottom.Point.X
			Dim height As Integer = leftBottom.Point.Y - leftTop.Point.Y

			Dim highlight As New SolidBrush(Color.FromArgb(128, Color.LightGoldenrodYellow))
			e.Graphics.FillRectangle(highlight, leftZero.Point.X, leftZero.Point.Y, leftTop.Point.X - leftZero.Point.X - 1, height)
			e.Graphics.FillRectangle(highlight, leftTop.Point.X + width + 1, leftTop.Point.Y, rightMax.Point.X - rightTop.Point.X - 1, height)
		End Sub

	End Class
End Namespace
