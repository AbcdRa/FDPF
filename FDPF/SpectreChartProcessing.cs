using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


class Complex
{
    public double re;
    public double im;
    private static double w = 2 * Math.PI;
    public Complex(double re, double im=0)
    {
        this.re = re;
        this.im = im;
    }

    public Complex Add(Complex oth)
    {
        re += oth.re;
        im += oth.im;
        return this;
    }

    public double Abs()
    {
        return Math.Sqrt(re * re + im * im);
    }
    
    public Complex(int N, int k, Complex complex)
    {
        re = complex.re * Math.Cos(w * k / N);
        im = complex.im * Math.Sin(w * k / N);
    }
}


class SpectreChartProcessing
{

    private Chart chart;
    private SignalChartProcessing signalChartProcessing;

    private double eps = 0.00000001;
    private static double w = 2 * Math.PI;

    private double[] currentFs;
    private double[][] currentCns;

    

    public SpectreChartProcessing(Chart chart, SignalChartProcessing signalChartProcessing)
    {
        this.chart = chart;
        this.signalChartProcessing = signalChartProcessing;
    }


    private void UpdateCurrentCns()
    {
        double[] xs = signalChartProcessing.GetCurrentXs();
        double[] ys = signalChartProcessing.GetCurrentYs();
        int N = xs.Length;
        double[][] Cns = new double[N][];
        double[] Fs = new double[N];
        int i = 0;
        for (double f = 0; f < N; f += 1)
        {
            double[] Cn = GetCn(xs, ys, f);
            PrepareCn(ref Cn, eps);
            Cns[i] = Cn;
            Fs[i] = f;
            i++;
        }
        currentCns = Cns;
        currentFs = Fs;
            
    }

    public double[] FFT8(int k, double[] ys, int sI)
    {
        double arg = w * k;
        double cos8 = Math.Cos(arg / 8);
        double sin8 = Math.Sin(arg / 8);
        double cos4 = Math.Cos(arg / 4);
        double sin4 = Math.Sin(arg / 4);
        double cos2 = k % 2 == 0 ? 1 : -1;
        double re1 = ys[sI+0] + cos2 * ys[sI+1] + cos4 * (ys[sI+2] + cos2 * ys[sI+3]);
        double im1 = -sin4 * (ys[sI+2] + cos2 * ys[sI+3]);
        double re2 = ys[sI+4] + cos2 * ys[sI+5] + cos4 * (ys[sI+6] + cos2 * ys[sI+7]);
        double im2 = -sin4 * (ys[sI+6] + cos2 * ys[sI+7]);
        re1 += cos8 * re2 + sin8 * im2;
        im1 += -sin8 * re2 + cos8 * im2;
        return new double[] { re1, im1 };
    }

    public double[] FFT(int k, double[] ys, int N, int sI, int WsI, double[][] Ws)
    {
        double re, im;
        if (N < 3)
        {
            return new double[] { k % 2 == 0 ? ys[sI] + ys[sI+1] : ys[sI] - ys[sI+1], 0 };
        }
        if( N < 9)
        {
            return FFT8(k, ys, sI);
        }
        //Ws = [ WN, WN/2, WN/4]
        double[] fft_even = FFT(k, ys, N / 2, sI, WsI+1, Ws);
        double[] fft_odd = FFT(k, ys, N / 2, sI+N/2, WsI+1, Ws);

        re = fft_even[0] + fft_odd[0] * Ws[WsI][0] + fft_odd[1] * Ws[WsI][1];
        im = fft_even[1] - fft_odd[0] * Ws[WsI][1] + fft_odd[1] * Ws[WsI][0];
        return new double[] { re, im };
    }

    public double[][] GetXks(int N, double[] ys) 
    {
        double[][] Xks = new double[N][];
        Xks[0] = new double[2] { 0, 0 };
        ys = getRerangedYs(ys);
        for(int i=0; i < N; i++)
        {
            Xks[0][0] += ys[i];
        }
        double[][] Ws;
        for(int i = 1; i <= N/2; i++)
        {
            Ws = GetWs(i, N);
            //Complex[] Ws = GetWs(N, -i);
            double[] Xk = FFT(i, ys, N, 0, 0, Ws);
            Xks[i] = Xk;
            Xks[N-i] = new double[] { Xk[0], -Xk[1] };
        }
        Ws = GetWs(N/2, N);
        Xks[N / 2] = FFT(N / 2, ys, N, 0, 0, Ws);
        return Xks;
    }
    static private int getInvertIndex(int n, int N)
    {
        int newN = 0;
        while (n != 0)
        {
            newN += (n & 1) * (N >>= 1);
            n >>= 1;
        }
        return newN;
    }

    private double[][] GetWs(int k, int N)
    {
        int m = (int)Math.Log(N, 2) - 3;
        double[][] Ws = new double[m][];
        for(int i=0; i < m; i++)
        {
            double arg = w * k / N;
            double cos = Math.Cos(arg);
            double sin = Math.Sin(arg);
            Ws[i] = new double[] { cos, sin };
            N /= 2;
        }
        return Ws;
    }

    private double[] getRerangedYs(double[] ys)
    {
        int N = ys.Length;
        double[] rrYs = new double[N];
        for(int i = 0; i < N; i++)
        {
            rrYs[i] = ys[getInvertIndex(i, N)];
        }
        return rrYs;
    }


    public void ShowFastAmplitudeSpectre()
    {
        double[] ys = signalChartProcessing.GetCurrentYs();
        int N = ys.Length;
        double[][] Xks = GetXks(N, ys);
        chart.Series[0].Points.Clear();
        for (int i = 0; i < Xks.Length; i++)
        {
            chart.Series[0].Points.AddXY(i, GetAbsCn(Xks[i]));
        }
    }

    public void ShowFastPhaseSpectre()
    {
        double[] ys = signalChartProcessing.GetCurrentYs();
        int N = ys.Length;
        double[][] Xks = GetXks(N, ys);
        chart.Series[0].Points.Clear();
        for (int i = 0; i < Xks.Length; i++)
        {
            PrepareCn(ref Xks[i],  00001);
            chart.Series[0].Points.AddXY(i, GetArgCn(Xks[i]));
        }
    }



    public void ShowAmplitudeSpectre()
    {
        UpdateCurrentCns();

        double[][] Cns = currentCns;
        double[] Fs = currentFs;

            
        chart.Series[0].Points.Clear();
        for(int i = 0; i < Cns.Length; i++)
        {
            chart.Series[0].Points.AddXY(i, GetAbsCn(Cns[i]));
        }
    }


    public void ShowPhaseSpectre()
    {

        UpdateCurrentCns();

        double[][] Cns = currentCns;


        chart.Series[0].Points.Clear();
        for (int i = 0; i < Cns.Length; i++)
        {
            PrepareCn(ref Cns[i], 0.0000000001);
            chart.Series[0].Points.AddXY(i, GetArgCn(Cns[i]));
        }
    }


    private double GetAbsCn(double[] cnComplex) {
        return Math.Sqrt(cnComplex[0] * cnComplex[0] + cnComplex[1] * cnComplex[1]);
    }


    private void PrepareCn(ref double[] cnComplex, double eps)
    {
        if (Math.Abs(cnComplex[0]) < eps ) cnComplex[0] = 0;
        if (Math.Abs(cnComplex[1]) < eps ) cnComplex[1] = 0;
            
    }

    private double GetArgCn(double[] cnComplex)
    {

        return Math.Atan2(cnComplex[1], cnComplex[0]);
    }

    private double[] GetCn(double[] xs, double[] ys, double n)
    {
        int N = ys.Length;
        double re_sum = 0;
        double im_sum = 0;
        for(int i=0; i<N; i++)
        {
            re_sum += ys[i] * Math.Cos(2 * Math.PI * i * n / N)/N;
            im_sum += ys[i] * Math.Sin(2 * Math.PI * i * n / N)/N;
        }
        return new double[] { re_sum, -im_sum };
    }

   
}
