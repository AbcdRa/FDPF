
namespace FDPF
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lTS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bFFTP = new System.Windows.Forms.Button();
            this.bDFTP = new System.Windows.Forms.Button();
            this.bFTFA = new System.Windows.Forms.Button();
            this.bDFTA = new System.Windows.Forms.Button();
            this.tlpSignalParams = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tlpGraphParams = new System.Windows.Forms.TableLayoutPanel();
            this.lx0 = new System.Windows.Forms.Label();
            this.lx1 = new System.Windows.Forms.Label();
            this.lm = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.lbSignals = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tlpSignalParams.SuspendLayout();
            this.tlpGraphParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lTS);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.bFFTP);
            this.splitContainer1.Panel2.Controls.Add(this.bDFTP);
            this.splitContainer1.Panel2.Controls.Add(this.bFTFA);
            this.splitContainer1.Panel2.Controls.Add(this.bDFTA);
            this.splitContainer1.Panel2.Controls.Add(this.tlpSignalParams);
            this.splitContainer1.Panel2.Controls.Add(this.tlpGraphParams);
            this.splitContainer1.Panel2.Controls.Add(this.lbSignals);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chart2);
            this.splitContainer2.Size = new System.Drawing.Size(800, 300);
            this.splitContainer2.SplitterDistance = 568;
            this.splitContainer2.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(568, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.cSignal_Click);
            // 
            // chart2
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2.ImeMode = System.Windows.Forms.ImeMode.On;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(228, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // lTS
            // 
            this.lTS.AutoSize = true;
            this.lTS.Location = new System.Drawing.Point(533, 79);
            this.lTS.Name = "lTS";
            this.lTS.Size = new System.Drawing.Size(0, 13);
            this.lTS.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Время:";
            // 
            // bFFTP
            // 
            this.bFFTP.Location = new System.Drawing.Point(690, 23);
            this.bFFTP.Name = "bFFTP";
            this.bFFTP.Size = new System.Drawing.Size(75, 23);
            this.bFFTP.TabIndex = 6;
            this.bFFTP.Text = "БДПФ_Ф";
            this.bFFTP.UseVisualStyleBackColor = true;
            this.bFFTP.Click += new System.EventHandler(this.bFFTP_Click);
            // 
            // bDFTP
            // 
            this.bDFTP.Location = new System.Drawing.Point(543, 23);
            this.bDFTP.Name = "bDFTP";
            this.bDFTP.Size = new System.Drawing.Size(60, 23);
            this.bDFTP.TabIndex = 5;
            this.bDFTP.Text = "ДПФ_Ф";
            this.bDFTP.UseVisualStyleBackColor = true;
            this.bDFTP.Click += new System.EventHandler(this.bDFTP_Click);
            // 
            // bFTFA
            // 
            this.bFTFA.Location = new System.Drawing.Point(609, 23);
            this.bFTFA.Name = "bFTFA";
            this.bFTFA.Size = new System.Drawing.Size(75, 23);
            this.bFTFA.TabIndex = 4;
            this.bFTFA.Text = "БДПФ_А";
            this.bFTFA.UseVisualStyleBackColor = true;
            this.bFTFA.Click += new System.EventHandler(this.bFTFA_Click);
            // 
            // bDFTA
            // 
            this.bDFTA.Location = new System.Drawing.Point(480, 23);
            this.bDFTA.Name = "bDFTA";
            this.bDFTA.Size = new System.Drawing.Size(57, 23);
            this.bDFTA.TabIndex = 3;
            this.bDFTA.Text = "ДПФ_A";
            this.bDFTA.UseVisualStyleBackColor = true;
            this.bDFTA.Click += new System.EventHandler(this.bDFTA_Click);
            // 
            // tlpSignalParams
            // 
            this.tlpSignalParams.ColumnCount = 2;
            this.tlpSignalParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.94737F));
            this.tlpSignalParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.05264F));
            this.tlpSignalParams.Controls.Add(this.label1, 0, 0);
            this.tlpSignalParams.Controls.Add(this.label2, 0, 1);
            this.tlpSignalParams.Controls.Add(this.label3, 0, 2);
            this.tlpSignalParams.Controls.Add(this.label4, 0, 3);
            this.tlpSignalParams.Controls.Add(this.label5, 0, 4);
            this.tlpSignalParams.Controls.Add(this.textBox1, 1, 0);
            this.tlpSignalParams.Controls.Add(this.textBox2, 1, 1);
            this.tlpSignalParams.Controls.Add(this.textBox3, 1, 2);
            this.tlpSignalParams.Controls.Add(this.textBox4, 1, 3);
            this.tlpSignalParams.Controls.Add(this.textBox5, 1, 4);
            this.tlpSignalParams.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpSignalParams.Location = new System.Drawing.Point(279, 0);
            this.tlpSignalParams.Name = "tlpSignalParams";
            this.tlpSignalParams.RowCount = 5;
            this.tlpSignalParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tlpSignalParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tlpSignalParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpSignalParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpSignalParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSignalParams.Size = new System.Drawing.Size(160, 146);
            this.tlpSignalParams.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(49, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(49, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // tlpGraphParams
            // 
            this.tlpGraphParams.ColumnCount = 2;
            this.tlpGraphParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.78947F));
            this.tlpGraphParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.21053F));
            this.tlpGraphParams.Controls.Add(this.lx0, 0, 0);
            this.tlpGraphParams.Controls.Add(this.lx1, 0, 1);
            this.tlpGraphParams.Controls.Add(this.lm, 0, 2);
            this.tlpGraphParams.Controls.Add(this.numericUpDown1, 1, 0);
            this.tlpGraphParams.Controls.Add(this.numericUpDown2, 1, 1);
            this.tlpGraphParams.Controls.Add(this.numericUpDown3, 1, 2);
            this.tlpGraphParams.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpGraphParams.Location = new System.Drawing.Point(120, 0);
            this.tlpGraphParams.Name = "tlpGraphParams";
            this.tlpGraphParams.RowCount = 3;
            this.tlpGraphParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.31183F));
            this.tlpGraphParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.68817F));
            this.tlpGraphParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpGraphParams.Size = new System.Drawing.Size(159, 146);
            this.tlpGraphParams.TabIndex = 1;
            // 
            // lx0
            // 
            this.lx0.AutoSize = true;
            this.lx0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lx0.Location = new System.Drawing.Point(3, 0);
            this.lx0.Name = "lx0";
            this.lx0.Size = new System.Drawing.Size(35, 46);
            this.lx0.TabIndex = 0;
            this.lx0.Text = "x0:";
            this.lx0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lx1
            // 
            this.lx1.AutoSize = true;
            this.lx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lx1.Location = new System.Drawing.Point(3, 46);
            this.lx1.Name = "lx1";
            this.lx1.Size = new System.Drawing.Size(35, 51);
            this.lx1.TabIndex = 1;
            this.lx1.Text = "x1:";
            this.lx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lm.Location = new System.Drawing.Point(3, 97);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(35, 49);
            this.lm.TabIndex = 2;
            this.lm.Text = "m:";
            this.lm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(44, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Location = new System.Drawing.Point(44, 49);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown3.Location = new System.Drawing.Point(44, 100);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbSignals
            // 
            this.lbSignals.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSignals.FormattingEnabled = true;
            this.lbSignals.Location = new System.Drawing.Point(0, 0);
            this.lbSignals.Name = "lbSignals";
            this.lbSignals.Size = new System.Drawing.Size(120, 146);
            this.lbSignals.TabIndex = 0;
            this.lbSignals.SelectedIndexChanged += new System.EventHandler(this.lbSignals_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tlpSignalParams.ResumeLayout(false);
            this.tlpSignalParams.PerformLayout();
            this.tlpGraphParams.ResumeLayout(false);
            this.tlpGraphParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tlpSignalParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TableLayoutPanel tlpGraphParams;
        private System.Windows.Forms.Label lx0;
        private System.Windows.Forms.Label lx1;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ListBox lbSignals;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button bFTFA;
        private System.Windows.Forms.Button bDFTA;
        private System.Windows.Forms.Button bFFTP;
        private System.Windows.Forms.Button bDFTP;
        private System.Windows.Forms.Label lTS;
        private System.Windows.Forms.Label label6;
    }
}

