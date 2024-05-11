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
using static System.Net.Mime.MediaTypeNames;

namespace _11
{
    public partial class Form1 : Form
    {
        double MeanTeor, VarianceTeor;
        double MeanTrue, VarianceTrue, Xi1;
        double Hip = 9.488;

        int N, Ob = 7;
        int[] statistic;
        double[] Frequency;
        double[] PP;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();

            MeanTrue = 0;
            VarianceTrue = 0;

            MeanTeor = double.Parse(Prob1.Text);
            VarianceTeor = double.Parse(Prob2.Text);
            N = int.Parse(NN.Text);

            double[] Viborka = new double[N];

            double min = 100000, max = -10000, alfa1, alfa2;
            int interval = 4;

            statistic = new int[interval];
            Frequency = new double[interval];
            PP = new double[interval];
            Random random = new Random();

            for(int i  = 0; i < interval; i++)
            {
                statistic[i] = 0;
                Frequency[i] = 0;
                PP[i] = 0;
            }

            //Датчик на основе Преобразования Бокса-Мюллера
            for (int i = 0; i < N; i++)
            {
                alfa1 = random.NextDouble();
                alfa2 = random.NextDouble();

                Viborka[i] = Math.Sqrt(VarianceTeor) * (Math.Sqrt(-2 * Math.Log10(alfa1)) * Math.Cos(2 * Math.PI * alfa2)) + MeanTeor;
            }

            double delta;//диапазон/шаг

            for (int i = 0; i < N; i++)//границы
            {
                if(Viborka[i] <= min)
                {
                    min = Viborka[i];
                }
                if (Viborka[i] >= max)
                {
                    max = Viborka[i];
                }
            }

            delta = (max - min + 0.01) / interval;//диапазон/шаг

            double m = min;
            int j = 0;

            while(m < max)//цикл для подсчёта частоты попадания в промежуток
            {
                for(int i = 0; i < N; i++) 
                {
                    if (m < Viborka[i] && Viborka[i] <= m + delta)
                    {
                        statistic[j]++;
                    }
                    
                }
                j++;
                m += delta;
            }

            for (int i = 0; i < N; i++)
            {
                MeanTrue += Viborka[i];
            }
            MeanTrue = MeanTrue / N;//мат ожидание

            for (int i = 0; i < N; i++)
            {
                VarianceTrue += Math.Pow(Viborka[i] - MeanTrue, 2);
            }

            VarianceTrue = VarianceTrue / N; //Дисперсия

            for (int i = 0; i < interval; i++)
            {
                Frequency[i] = ((double)statistic[i] / (double)N);//относительная частота

                chart1.Series[0].Points.AddXY(i, Frequency[i]);
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 1, "(" + Math.Round((min + delta * i), 2).ToString() + "; " + Math.Round((min + delta * (i + 1)), 2).ToString() + "]", 0, LabelMarkStyle.None));
            }

            double P(double x)
            {
                return 1 / Math.Sqrt(2 * Math.PI * VarianceTeor) * Math.Exp(-1 * Math.Pow(x - MeanTeor, 2) / (2 * VarianceTeor));
            }

            double a = 0, b = 0;
            for (int i = 0; i < interval; i++) //вычисление теоретической вероятности
            {
                a = min + delta * i;
                b = min + delta * (i + 1);
                PP[i] = (b - a) * P((a + b) / 2);
            }

            double relErrMat, relErrDis;

            relErrMat = Math.Abs(MeanTrue - MeanTeor) / Math.Abs(MeanTeor);
            relErrDis = Math.Abs(VarianceTrue - VarianceTeor) / Math.Abs(VarianceTeor);

            string test = "good";

            if (Xi1 > Hip)
                test = "bad";

            Avarage.Text = MeanTrue.ToString() + " (error = " + Math.Round(relErrMat, 2).ToString() + "%)";
            Variance.Text = VarianceTrue.ToString() + " (error = " + Math.Round(relErrDis, 2).ToString() + "%)";

            for (int i = 0; i < interval; i++) //вычисление теоретической вероятности
            {
                Xi1 = Math.Pow(statistic[i], 2) / (N * PP[i]);
            }

            Xi1 = Xi1 - N;
            Xi.Text = Xi1.ToString() + " is " + test.ToString(); ;
        }
    }
}
