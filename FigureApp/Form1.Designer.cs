namespace FigureApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainControlPop = new System.Windows.Forms.Button();
            this.mainControlPerimeter = new System.Windows.Forms.Button();
            this.mainControlArea = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCircle = new System.Windows.Forms.TabPage();
            this.selectRcircle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCircleCenter = new System.Windows.Forms.Label();
            this.selectYcircle = new System.Windows.Forms.NumericUpDown();
            this.selectXcircle = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCircle = new System.Windows.Forms.Label();
            this.tabParallelogram = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectParY3 = new System.Windows.Forms.NumericUpDown();
            this.selectParY2 = new System.Windows.Forms.NumericUpDown();
            this.selectParY1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.selectParX3 = new System.Windows.Forms.NumericUpDown();
            this.selectParX2 = new System.Windows.Forms.NumericUpDown();
            this.selectParX1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateParallelogram = new System.Windows.Forms.Button();
            this.labelParallelogram = new System.Windows.Forms.Label();
            this.tabRectangle = new System.Windows.Forms.TabPage();
            this.selectRecB = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.selectRecA = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectRecY = new System.Windows.Forms.NumericUpDown();
            this.selectRecX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCreateRectangle = new System.Windows.Forms.Button();
            this.labelRectangle = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCircle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectRcircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectYcircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectXcircle)).BeginInit();
            this.tabParallelogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectParY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParX1)).BeginInit();
            this.tabRectangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.Maximum = 15D;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.Minimum = -15D;
            chartArea1.AxisX.MinorGrid.Interval = 1D;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisX.ScrollBar.Enabled = false;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisY.LabelStyle.Interval = 1D;
            chartArea1.AxisY.MajorGrid.Interval = 1D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorTickMark.Interval = 1D;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.AxisY.MinorGrid.Interval = 1D;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.ScaleView.Zoomable = false;
            chartArea1.AxisY.ScrollBar.Enabled = false;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(318, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(672, 684);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.mainControlPop);
            this.panel1.Controls.Add(this.mainControlPerimeter);
            this.panel1.Controls.Add(this.mainControlArea);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 684);
            this.panel1.TabIndex = 1;
            // 
            // mainControlPop
            // 
            this.mainControlPop.BackColor = System.Drawing.Color.Red;
            this.mainControlPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainControlPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainControlPop.Location = new System.Drawing.Point(210, 630);
            this.mainControlPop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainControlPop.Name = "mainControlPop";
            this.mainControlPop.Size = new System.Drawing.Size(104, 52);
            this.mainControlPop.TabIndex = 4;
            this.mainControlPop.Text = "Pop Last";
            this.mainControlPop.UseVisualStyleBackColor = false;
            this.mainControlPop.Click += new System.EventHandler(this.mainControlPop_Click);
            // 
            // mainControlPerimeter
            // 
            this.mainControlPerimeter.BackColor = System.Drawing.Color.Blue;
            this.mainControlPerimeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainControlPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainControlPerimeter.Location = new System.Drawing.Point(106, 630);
            this.mainControlPerimeter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainControlPerimeter.Name = "mainControlPerimeter";
            this.mainControlPerimeter.Size = new System.Drawing.Size(104, 52);
            this.mainControlPerimeter.TabIndex = 3;
            this.mainControlPerimeter.Text = "Perimeter";
            this.mainControlPerimeter.UseVisualStyleBackColor = false;
            this.mainControlPerimeter.Click += new System.EventHandler(this.mainControlPerimeter_Click);
            // 
            // mainControlArea
            // 
            this.mainControlArea.BackColor = System.Drawing.Color.Lime;
            this.mainControlArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainControlArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainControlArea.Location = new System.Drawing.Point(3, 630);
            this.mainControlArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainControlArea.Name = "mainControlArea";
            this.mainControlArea.Size = new System.Drawing.Size(104, 52);
            this.mainControlArea.TabIndex = 2;
            this.mainControlArea.Text = "Area";
            this.mainControlArea.UseVisualStyleBackColor = false;
            this.mainControlArea.Click += new System.EventHandler(this.mainControlArea_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(3, 297);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(308, 331);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCircle);
            this.tabControl1.Controls.Add(this.tabParallelogram);
            this.tabControl1.Controls.Add(this.tabRectangle);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCircle
            // 
            this.tabCircle.BackColor = System.Drawing.Color.MistyRose;
            this.tabCircle.Controls.Add(this.selectRcircle);
            this.tabCircle.Controls.Add(this.label1);
            this.tabCircle.Controls.Add(this.labelCircleCenter);
            this.tabCircle.Controls.Add(this.selectYcircle);
            this.tabCircle.Controls.Add(this.selectXcircle);
            this.tabCircle.Controls.Add(this.button1);
            this.tabCircle.Controls.Add(this.labelCircle);
            this.tabCircle.Location = new System.Drawing.Point(4, 25);
            this.tabCircle.Name = "tabCircle";
            this.tabCircle.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCircle.Size = new System.Drawing.Size(300, 263);
            this.tabCircle.TabIndex = 0;
            this.tabCircle.Text = "Circle";
            // 
            // selectRcircle
            // 
            this.selectRcircle.Location = new System.Drawing.Point(160, 92);
            this.selectRcircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectRcircle.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectRcircle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectRcircle.Name = "selectRcircle";
            this.selectRcircle.Size = new System.Drawing.Size(86, 22);
            this.selectRcircle.TabIndex = 8;
            this.selectRcircle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter radius:";
            // 
            // labelCircleCenter
            // 
            this.labelCircleCenter.AutoSize = true;
            this.labelCircleCenter.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCircleCenter.Location = new System.Drawing.Point(28, 50);
            this.labelCircleCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCircleCenter.Name = "labelCircleCenter";
            this.labelCircleCenter.Size = new System.Drawing.Size(128, 16);
            this.labelCircleCenter.TabIndex = 6;
            this.labelCircleCenter.Text = "Enter center cords:";
            // 
            // selectYcircle
            // 
            this.selectYcircle.Location = new System.Drawing.Point(206, 49);
            this.selectYcircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectYcircle.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectYcircle.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectYcircle.Name = "selectYcircle";
            this.selectYcircle.Size = new System.Drawing.Size(40, 22);
            this.selectYcircle.TabIndex = 5;
            // 
            // selectXcircle
            // 
            this.selectXcircle.Location = new System.Drawing.Point(160, 49);
            this.selectXcircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectXcircle.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectXcircle.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectXcircle.Name = "selectXcircle";
            this.selectXcircle.Size = new System.Drawing.Size(40, 22);
            this.selectXcircle.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCircle
            // 
            this.labelCircle.AutoSize = true;
            this.labelCircle.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircle.Location = new System.Drawing.Point(125, 12);
            this.labelCircle.Name = "labelCircle";
            this.labelCircle.Size = new System.Drawing.Size(64, 22);
            this.labelCircle.TabIndex = 0;
            this.labelCircle.Text = "Circle";
            // 
            // tabParallelogram
            // 
            this.tabParallelogram.BackColor = System.Drawing.Color.PaleGreen;
            this.tabParallelogram.Controls.Add(this.label6);
            this.tabParallelogram.Controls.Add(this.label5);
            this.tabParallelogram.Controls.Add(this.label4);
            this.tabParallelogram.Controls.Add(this.selectParY3);
            this.tabParallelogram.Controls.Add(this.selectParY2);
            this.tabParallelogram.Controls.Add(this.selectParY1);
            this.tabParallelogram.Controls.Add(this.label3);
            this.tabParallelogram.Controls.Add(this.selectParX3);
            this.tabParallelogram.Controls.Add(this.selectParX2);
            this.tabParallelogram.Controls.Add(this.selectParX1);
            this.tabParallelogram.Controls.Add(this.panel2);
            this.tabParallelogram.Controls.Add(this.label2);
            this.tabParallelogram.Controls.Add(this.buttonCreateParallelogram);
            this.tabParallelogram.Controls.Add(this.labelParallelogram);
            this.tabParallelogram.Location = new System.Drawing.Point(4, 25);
            this.tabParallelogram.Name = "tabParallelogram";
            this.tabParallelogram.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabParallelogram.Size = new System.Drawing.Size(300, 263);
            this.tabParallelogram.TabIndex = 1;
            this.tabParallelogram.Text = "Parallelogram";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "x4;y4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "x3;y3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "x2;y2";
            // 
            // selectParY3
            // 
            this.selectParY3.Location = new System.Drawing.Point(228, 87);
            this.selectParY3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectParY3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectParY3.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectParY3.Name = "selectParY3";
            this.selectParY3.Size = new System.Drawing.Size(33, 22);
            this.selectParY3.TabIndex = 14;
            // 
            // selectParY2
            // 
            this.selectParY2.Location = new System.Drawing.Point(228, 168);
            this.selectParY2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectParY2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectParY2.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectParY2.Name = "selectParY2";
            this.selectParY2.Size = new System.Drawing.Size(33, 22);
            this.selectParY2.TabIndex = 12;
            // 
            // selectParY1
            // 
            this.selectParY1.Location = new System.Drawing.Point(78, 171);
            this.selectParY1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectParY1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectParY1.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectParY1.Name = "selectParY1";
            this.selectParY1.Size = new System.Drawing.Size(33, 22);
            this.selectParY1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "x1;y1";
            // 
            // selectParX3
            // 
            this.selectParX3.Location = new System.Drawing.Point(190, 87);
            this.selectParX3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectParX3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectParX3.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectParX3.Name = "selectParX3";
            this.selectParX3.Size = new System.Drawing.Size(33, 22);
            this.selectParX3.TabIndex = 8;
            // 
            // selectParX2
            // 
            this.selectParX2.Location = new System.Drawing.Point(190, 168);
            this.selectParX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectParX2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectParX2.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectParX2.Name = "selectParX2";
            this.selectParX2.Size = new System.Drawing.Size(33, 22);
            this.selectParX2.TabIndex = 7;
            // 
            // selectParX1
            // 
            this.selectParX1.Location = new System.Drawing.Point(40, 171);
            this.selectParX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectParX1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectParX1.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectParX1.Name = "selectParX1";
            this.selectParX1.Size = new System.Drawing.Size(33, 22);
            this.selectParX1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(76, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 81);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter points:";
            // 
            // buttonCreateParallelogram
            // 
            this.buttonCreateParallelogram.Location = new System.Drawing.Point(116, 234);
            this.buttonCreateParallelogram.Name = "buttonCreateParallelogram";
            this.buttonCreateParallelogram.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateParallelogram.TabIndex = 3;
            this.buttonCreateParallelogram.Text = "Create";
            this.buttonCreateParallelogram.UseVisualStyleBackColor = true;
            this.buttonCreateParallelogram.Click += new System.EventHandler(this.buttonCreateParallelogram_Click);
            // 
            // labelParallelogram
            // 
            this.labelParallelogram.AutoSize = true;
            this.labelParallelogram.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParallelogram.Location = new System.Drawing.Point(86, 17);
            this.labelParallelogram.Name = "labelParallelogram";
            this.labelParallelogram.Size = new System.Drawing.Size(140, 22);
            this.labelParallelogram.TabIndex = 1;
            this.labelParallelogram.Text = "Parallelogram";
            // 
            // tabRectangle
            // 
            this.tabRectangle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabRectangle.Controls.Add(this.selectRecB);
            this.tabRectangle.Controls.Add(this.label10);
            this.tabRectangle.Controls.Add(this.selectRecA);
            this.tabRectangle.Controls.Add(this.label9);
            this.tabRectangle.Controls.Add(this.label8);
            this.tabRectangle.Controls.Add(this.selectRecY);
            this.tabRectangle.Controls.Add(this.selectRecX);
            this.tabRectangle.Controls.Add(this.label7);
            this.tabRectangle.Controls.Add(this.buttonCreateRectangle);
            this.tabRectangle.Controls.Add(this.labelRectangle);
            this.tabRectangle.Location = new System.Drawing.Point(4, 25);
            this.tabRectangle.Name = "tabRectangle";
            this.tabRectangle.Size = new System.Drawing.Size(300, 263);
            this.tabRectangle.TabIndex = 2;
            this.tabRectangle.Text = "Rectangle";
            // 
            // selectRecB
            // 
            this.selectRecB.Location = new System.Drawing.Point(128, 142);
            this.selectRecB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectRecB.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.selectRecB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectRecB.Name = "selectRecB";
            this.selectRecB.Size = new System.Drawing.Size(44, 22);
            this.selectRecB.TabIndex = 10;
            this.selectRecB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "b (vertical)";
            // 
            // selectRecA
            // 
            this.selectRecA.Location = new System.Drawing.Point(128, 113);
            this.selectRecA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectRecA.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.selectRecA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectRecA.Name = "selectRecA";
            this.selectRecA.Size = new System.Drawing.Size(44, 22);
            this.selectRecA.TabIndex = 8;
            this.selectRecA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "a (horisontal)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Enter sides";
            // 
            // selectRecY
            // 
            this.selectRecY.Location = new System.Drawing.Point(196, 56);
            this.selectRecY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectRecY.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectRecY.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectRecY.Name = "selectRecY";
            this.selectRecY.Size = new System.Drawing.Size(44, 22);
            this.selectRecY.TabIndex = 5;
            // 
            // selectRecX
            // 
            this.selectRecX.Location = new System.Drawing.Point(148, 56);
            this.selectRecX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectRecX.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.selectRecX.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.selectRecX.Name = "selectRecX";
            this.selectRecX.Size = new System.Drawing.Size(44, 22);
            this.selectRecX.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Enter start point";
            // 
            // buttonCreateRectangle
            // 
            this.buttonCreateRectangle.Location = new System.Drawing.Point(116, 234);
            this.buttonCreateRectangle.Name = "buttonCreateRectangle";
            this.buttonCreateRectangle.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateRectangle.TabIndex = 2;
            this.buttonCreateRectangle.Text = "Create";
            this.buttonCreateRectangle.UseVisualStyleBackColor = true;
            this.buttonCreateRectangle.Click += new System.EventHandler(this.buttonCreateRectangle_Click);
            // 
            // labelRectangle
            // 
            this.labelRectangle.AutoSize = true;
            this.labelRectangle.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRectangle.Location = new System.Drawing.Point(103, 15);
            this.labelRectangle.Name = "labelRectangle";
            this.labelRectangle.Size = new System.Drawing.Size(100, 22);
            this.labelRectangle.TabIndex = 1;
            this.labelRectangle.Text = "Rectangle";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(FigureApp.Form1);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Index";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Figure";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Points";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCircle.ResumeLayout(false);
            this.tabCircle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectRcircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectYcircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectXcircle)).EndInit();
            this.tabParallelogram.ResumeLayout(false);
            this.tabParallelogram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectParY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParX1)).EndInit();
            this.tabRectangle.ResumeLayout(false);
            this.tabRectangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRecX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCircle;
        private System.Windows.Forms.TabPage tabParallelogram;
        private System.Windows.Forms.TabPage tabRectangle;
        private System.Windows.Forms.Label labelCircle;
        private System.Windows.Forms.Label labelParallelogram;
        private System.Windows.Forms.Button buttonCreateRectangle;
        private System.Windows.Forms.Label labelRectangle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCreateParallelogram;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.NumericUpDown selectYcircle;
        private System.Windows.Forms.NumericUpDown selectXcircle;
        private System.Windows.Forms.NumericUpDown selectRcircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCircleCenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown selectParX3;
        private System.Windows.Forms.NumericUpDown selectParX2;
        private System.Windows.Forms.NumericUpDown selectParX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown selectParY1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown selectParY3;
        private System.Windows.Forms.NumericUpDown selectParY2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown selectRecB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown selectRecA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown selectRecY;
        private System.Windows.Forms.NumericUpDown selectRecX;
        private System.Windows.Forms.Button mainControlPop;
        private System.Windows.Forms.Button mainControlPerimeter;
        private System.Windows.Forms.Button mainControlArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

