using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FigureLibrary;

namespace FigureApp
{
    public partial class Form1 : Form
    {
        Figures data = new Figures();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCircle(double centerX, double centerY, double radius)
        {
            var series = new Series()
            {
                ChartType = SeriesChartType.Line, 
                Color = Color.Red,
                BorderWidth = 2 
            };

            int segments = 100; 
            for (int i = 0; i <= segments; i++)
            {
                double angle = i * 2 * Math.PI / segments; 
                double x = centerX + radius * Math.Cos(angle); 
                double y = centerY + radius * Math.Sin(angle); 
                series.Points.AddXY(x, y); 
            }
            data.AddFigure(new Circle(new XY(centerX, centerY), radius));
            dataGridView1.Rows.Add(data.FiguresCount() -1,"Circle", $"[{centerX};{centerY}] radius: {radius}");
            chart.Series.Add(series); 
        }

        private void AddParallelogram(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            
            var series = new Series
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                BorderWidth = 2,
            };

            Parallelogram temp = new Parallelogram(new XY(x1,y1), new XY(x2, y2), new XY(x3, y3));
            
            series.Points.AddXY(x1, y1);
            series.Points.AddXY(x2, y2); 
            series.Points.AddXY(x3, y3);
            series.Points.AddXY(temp.point4.x, temp.point4.y);
            series.Points.AddXY(x1, y1);

            data.AddFigure(temp);
            dataGridView1.Rows.Add(data.FiguresCount() - 1, "Parallelogram", $"{temp.point1},{temp.point2},{temp.point3},{temp.point4}");
            chart.Series.Add(series);
        }

        private void AddRectangle(double x1, double y1, double side1, double side2)
        {
            
            var series = new Series
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2,
            };

            MyRectangle temp = new MyRectangle(new XY(x1,y1),side1, side2);
            
            series.Points.AddXY(x1, y1);
            series.Points.AddXY(temp.point2.x, temp.point2.y);
            series.Points.AddXY(temp.point3.x, temp.point3.y);
            series.Points.AddXY(temp.point4.x, temp.point4.y);
            series.Points.AddXY(x1, y1);

            data.AddFigure(temp);
            dataGridView1.Rows.Add(data.FiguresCount() - 1, "Rectangle", $"{temp.point1},{temp.point2},{temp.point3},{temp.point4}");
            chart.Series.Add(series);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(data.FiguresCount() < 10)
            {
                AddCircle(Convert.ToDouble(selectXcircle.Value), Convert.ToDouble(selectYcircle.Value), Convert.ToDouble(selectRcircle.Value));
            }
        }

        private void buttonCreateParallelogram_Click(object sender, EventArgs e)
        {
            AddParallelogram(Convert.ToDouble(selectParX1.Value), Convert.ToDouble(selectParY1.Value), Convert.ToDouble(selectParX2.Value), Convert.ToDouble(selectParY2.Value), Convert.ToDouble(selectParX3.Value), Convert.ToDouble(selectParY3.Value));
        }

        private void buttonCreateRectangle_Click(object sender, EventArgs e)
        {
            AddRectangle(Convert.ToDouble(selectRecX.Value), Convert.ToDouble(selectRecY.Value), Convert.ToDouble(selectRecA.Value), Convert.ToDouble(selectRecB.Value));
        }

        private void mainControlArea_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                int idx = Convert.ToInt32(selectedCell.Value);
                double result = data.figures[idx].Area();
                MessageBox.Show($"The area of figure №{idx} is: {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mainControlPerimeter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var selectedCell = dataGridView1.SelectedCells[0];
                int idx = Convert.ToInt32(selectedCell.Value);
                double result = data.figures[idx].Perimeter();
                MessageBox.Show($"The Perimeter of figure №{idx} is: {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mainControlPop_Click(object sender, EventArgs e)
        {
            if(data.FiguresCount() > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                if (chart.Series.Count > 0)
                {
                    // Remove the last series
                    chart.Series.RemoveAt(chart.Series.Count - 1);
                }
                data.PopFigure();
            }
        }
    }
}
