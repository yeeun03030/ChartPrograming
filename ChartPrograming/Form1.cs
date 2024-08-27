using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartPrograming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void highBtn_Click(object sender, EventArgs e)
        {
            // Start
            timer1.Enabled = true;

            //chart1.Series[0].Points.AddXY(DateTime.Now.ToString(), 1);
            //chart1.ChartAreas[0].RecalculateAxesScale(); // 축에 대한 알아서 조정,,,
        }

        private void lowBtn_Click(object sender, EventArgs e)
        {
            // Stop
            timer1.Enabled = false;

            //chart1.Series[0].Points.AddXY(DateTime.Now.ToString(), 0);
            //chart1.ChartAreas[0].RecalculateAxesScale(); // 축에 대한 알아서 조정,,,
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 타이머가 켜지면 100m/s 마다 행동을 여기다 기재

            if (chart1.Series[0].Points.Count > 30)
            {
                chart1.Series[0].Points.RemoveAt(0); // 가장 오래된 것 지우기
            }
            // JOB
            Random rnd = new Random();

            double rndValue = rnd.NextDouble() * 10;

            chart1.Series[0].Points.AddXY(DateTime.Now.ToString(), rndValue);
            //chart1.Series[0].Points.AddXY(DateTime.Now.ToString(), rnd.Next() % 10); // 위와 동일한 코드

            chart1.ChartAreas[0].RecalculateAxesScale();

            circularGauge1.Unit = "mm";
            circularGauge1.Minimum = 0;
            circularGauge1.Maximum = 10;
            circularGauge1.Value = Math.Floor(rndValue);

            linearGauge1.Unit = "mm";
            linearGauge1.Minimum = 0;
            linearGauge1.Maximum = 10;
            linearGauge1.Value = Math.Floor(rndValue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
