using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace InteractiveRangeSelect {

    public partial class Form1 : Form {
        DataTable dt = new DataTable();
        bool draggingStart = false;
        bool draggingEnd = false;

        Cursor defaultCursor;
        DateTime minRange, maxRange;

        XYDiagram Diagram { get { return chartSelectRange.Diagram as XYDiagram; } }
        ConstantLine lineStart, lineEnd;

        public Form1 () {
            InitializeComponent();

        }

        private void InitRangeIndicators () {
            lineStart = new ConstantLine(string.Empty, minRange);
            lineStart.LineStyle.DashStyle = DashStyle.Dash;
            lineStart.LineStyle.Thickness = 4;
            lineStart.ShowInLegend = false;

            lineEnd = new ConstantLine(string.Empty, maxRange);
            lineEnd.LineStyle.DashStyle = DashStyle.Dash;
            lineEnd.LineStyle.Thickness = 4;
            lineEnd.ShowInLegend = false;
            Diagram.AxisX.ConstantLines.AddRange(new ConstantLine[] { lineStart, lineEnd });
        }

        void SetCursor (DateTime dateTime) {
            if (defaultCursor == null)
                defaultCursor = Cursor.Current;
            Cursor.Current = Cursors.VSplit;
        }

        void RestoreCursor () {
            if (defaultCursor != null) {
                Cursor.Current = defaultCursor;
                defaultCursor = null;
            }
        }

        void AdjustRange (DateTime dateTime) {

            if (draggingStart) {

                if (dateTime >= maxRange.AddMinutes(-5))
                    dateTime = maxRange.AddMinutes(-5);
                lineStart.AxisValue = dateTime;
                minRange = dateTime;
            }
            else if (draggingEnd) {
                if (dateTime <= minRange.AddMinutes(5))
                    dateTime = minRange.AddMinutes(5);
                lineEnd.AxisValue = dateTime;
                maxRange = dateTime;
            }


        }

        private void Form1_Load (object sender, EventArgs e) {
            PopulateDataSet();
            InitRangeIndicators();
        }


        private void PopulateDataSet () {
            Random rnd = new Random(DateTime.Now.Millisecond);

            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Value", typeof(double)));
            for (int i = 0; i < 100; i++) {
                dt.Rows.Add(new object[] { DateTime.Now.Date.AddMinutes(i), rnd.NextDouble() * 5 + 15 });
            }

            chartSelectRange.Series[0].ArgumentDataMember = "Date";
            chartSelectRange.Series[0].ValueDataMembers.AddRange(new string[] { "Value" });
            chartLine.Series[0].ArgumentDataMember = "Date";
            chartLine.Series[0].ValueDataMembers.AddRange(new string[] { "Value" });

            chartSelectRange.Series[0].DataSource = dt;
            chartLine.Series[0].DataSource = dt;

            minRange = 
                Convert.ToDateTime(chartSelectRange.Series[0].Points[0].Argument).AddMinutes(5);
            maxRange = 
                Convert.ToDateTime(chartSelectRange.Series[0].Points[chartSelectRange.Series[0].Points.Count - 1].Argument).AddMinutes(-5);

            Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute;
            Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Hour;
            Diagram.AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom;
            Diagram.AxisX.Label.DateTimeOptions.FormatString = "MM/dd/yy HH:mm";

            ((XYDiagram)chartLine.Diagram).AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute;
            ((XYDiagram)chartLine.Diagram).AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Minute;
            ((XYDiagram)chartLine.Diagram).AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom;
            ((XYDiagram)chartLine.Diagram).AxisX.Label.DateTimeOptions.FormatString = "HH:mm";
        }

        private void chartSelectRange_MouseDown (object sender, MouseEventArgs e) {
            if (Diagram == null)
                return;
            ChartHitInfo hitInfo = chartSelectRange.CalcHitInfo(e.Location);
            DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
            if (hitInfo.InConstantLine) {
                chartSelectRange.Capture = true;
                if (hitInfo.ConstantLine == lineStart) {
                    draggingStart = true;
                    draggingEnd = false;

                    SetCursor(coords.DateTimeArgument);
                }
                else if (hitInfo.ConstantLine == lineEnd) {
                    draggingEnd = true;
                    draggingStart = false;

                    SetCursor(coords.DateTimeArgument);
                }
            }
        }

        private void chartSelectRange_MouseUp (object sender, MouseEventArgs e) {
            if (Diagram == null)
                return;
            draggingStart = false;
            draggingEnd = false;
            chartSelectRange.Capture = false;
            ((XYDiagram)chartLine.Diagram).AxisX.VisualRange.SetMinMaxValues(minRange, maxRange);
        }

        private void chartSelectRange_MouseMove (object sender, MouseEventArgs e) {
            if (Diagram == null)
                return;
            if ((draggingStart || draggingEnd) && (e.Button & MouseButtons.Left) == 0) {
                draggingStart = false;
                draggingEnd = false;
                chartSelectRange.Capture = false;
            }

            DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
            if (coords.IsEmpty)
                RestoreCursor();
            else {
                if (draggingStart || draggingEnd) {

                    AdjustRange(coords.DateTimeArgument);
                }

                else
                    RestoreCursor();
            }
        }


        private void chartSelectRange_CustomPaint (object sender, CustomPaintEventArgs e) {
            if (Diagram == null)
                return;
            ControlCoordinates leftBottom = Diagram.DiagramToPoint(minRange, 
                Convert.ToDouble(Diagram.AxisY.VisualRange.MinValue));
            ControlCoordinates leftTop = Diagram.DiagramToPoint(minRange,
                Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue));
            ControlCoordinates rightTop = Diagram.DiagramToPoint(maxRange,
                Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue));

            ControlCoordinates leftZero = Diagram.DiagramToPoint(Convert.ToDateTime(Diagram.AxisX.VisualRange.MinValue),
                Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue));
            ControlCoordinates rightMax = Diagram.DiagramToPoint(Convert.ToDateTime(Diagram.AxisX.VisualRange.MaxValue),
                Convert.ToDouble(Diagram.AxisY.VisualRange.MaxValue));


            int width = rightTop.Point.X - leftBottom.Point.X;
            int height = leftBottom.Point.Y - leftTop.Point.Y;

            SolidBrush highlight = new SolidBrush(Color.FromArgb(128, Color.LightGoldenrodYellow));
            e.Graphics.FillRectangle(highlight, leftZero.Point.X, leftZero.Point.Y, 
                leftTop.Point.X - leftZero.Point.X - 1, height);
            e.Graphics.FillRectangle(highlight, leftTop.Point.X + width + 1, leftTop.Point.Y, 
                rightMax.Point.X - rightTop.Point.X - 1, height);
        }

    }
}
