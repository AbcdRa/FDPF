using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


    class SignalChartProcessing
    {
        private Chart chart;
        private Signal signal;
        private TableLayoutPanel tlbGraphParams;
        private TableLayoutPanel tlbSignalParams;
        private List<Control> tbParams;

        private double x0;
        private double x1;

        private int N;

        private double[] currentXs = null;
        private double[] currentYs = null;

        public double[] GetCurrentXs() { return currentXs; }
        public double[] GetCurrentYs() { return currentYs; }

        //Заменить на чекбокс
        private bool isShowError = true;

        public SignalChartProcessing(Chart chart, TableLayoutPanel tlbGraphParams, TableLayoutPanel tlbSignalParams )
        {
            this.chart = chart;
            this.tlbGraphParams = tlbGraphParams;
            this.tlbSignalParams = tlbSignalParams;
        }
     
        public void UpdateGraphParams()
        {
            x0 = decimal.ToDouble(((NumericUpDown) tlbGraphParams.Controls[3]).Value);
            x1 = decimal.ToDouble(((NumericUpDown)tlbGraphParams.Controls[4]).Value);
            N = (int) Math.Pow(2, decimal.ToInt32(((NumericUpDown)tlbGraphParams.Controls[5]).Value));
        }


        public void SetSignal(Signal signal)
        {
            tlbSignalParams.Enabled = true;
            this.signal = signal;
            int rowCount = tlbSignalParams.RowCount;
            int paramCount = signal.paramNames.Length;
            int i = 0;
            tbParams = new List<Control>();
            
            for(; i < paramCount; i++)
            {
                tlbSignalParams.GetControlFromPosition(0, i).Visible = true;
                tlbSignalParams.GetControlFromPosition(1, i).Enabled = true;
                tlbSignalParams.GetControlFromPosition(0, i).Text = signal.paramNames[i];
                tlbSignalParams.GetControlFromPosition(1, i).Text = $"{signal.paramValues[i]}";
                tbParams.Add(tlbSignalParams.GetControlFromPosition(1, i));
            }
            
            for(; i < rowCount; i++)
            {
                tlbSignalParams.GetControlFromPosition(0, i).Visible = false;
                tlbSignalParams.GetControlFromPosition(1, i).Enabled = false;
            }
            
            Func<double[], double[]> updateFunc = (currentParamValues) =>
            {
                double[] paramValues = new double[paramCount];
                for (int j = 0; j < tbParams.Count; j++)
                {
                    try
                    {
                        paramValues[j] = double.Parse(tbParams[j].Text);
                    } catch
                    {
                        if (isShowError) MessageBox.Show($"Не удалось преобразовать {tbParams[j].Text} в число");
                        paramValues[j] = currentParamValues[j];
                    }
                }
                return paramValues;
            };

            signal.updateFunc = updateFunc;
        }

        public void Show()
        {
            if (signal is null) return;

            UpdateGraphParams();
            double[] xs = GetXs();
            xs = signal.transformXs(xs);
            List<double> list_xs = (new List<double>(xs));
            list_xs.Sort();
            xs = list_xs.ToArray();
            double[] ys = signal.GetYs(xs);
            currentXs = xs;
            currentYs = ys;

            ShowCurrentPoints();
        }


        private void ShowCurrentPoints(int series_index=0)
        {
            double[] xs = currentXs;
            double[] ys = currentYs;
            ShowXY(xs, ys, series_index);
        }

        public void ShowXY(double[] xs, double[] ys, int series_index, bool withClear=true)
        {
            if(withClear) chart.Series[series_index].Points.Clear();
            for (int i = 0; i < xs.Length; i++)
            {
                chart.Series[series_index].Points.AddXY(xs[i], ys[i]);
            }
        }

        public void ShowXY(double[] xs, Func<double, double> f, int series_index, bool withClear = true)
        {
            if (withClear) chart.Series[series_index].Points.Clear();
            for (int i = 0; i < xs.Length; i++)
            {
                double y = f(xs[i]);
                chart.Series[series_index].Points.AddXY(xs[i], y);
            }
        }


        public void AddNoise(double noise)
        {

            double[] ys = currentYs;
            chart.Series[0].Points.Clear();
            Random random = new Random();
            
            for (int i = 0; i < ys.Length; i++)
            {
                ys[i] = ys[i]+noise*(random.NextDouble()-0.5);
            }

            currentYs = ys;
            ShowCurrentPoints();
        }

        private double[] GetXs()
        {
            double x = x0;
            double dx = (x1 - x0) / N;
            double[] xs = new double[N];
            for(int i=0; i < N; i++, x+=dx)
            {
                xs[i] = x;
            }
            return xs;
        }

        public void SetCurrentXsYs(double[] xs, double[] ys)
        {
            currentXs = xs;
            currentYs = ys;
        }
        

        public void SaveCurrentPoints()
        {
            ResetOldPoints();
            ShowCurrentPoints(2);
        }

        public void ResetOldPoints()
        {
            chart.Series[2].Points.Clear();
        }
   
}
