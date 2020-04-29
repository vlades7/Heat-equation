using Heat_equation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heat_equation
{
    public partial class FormMain : Form
    {
        Calculation mathSolver;
        Graphics2D graph;

        public FormMain()
        {
            InitializeComponent();
            CB_TypeBorders.SelectedIndex = Global.IndexTypeBorders;
            Timer.Interval = 1;

            mathSolver = new Calculation();
            mathSolver.Init();
        }

        private void BTN_TEST_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            mathSolver.CalcIteration();
            sw.Stop();
            Rtb_Result.AppendText("Time = " + sw.ElapsedMilliseconds);
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
        }

        private void CB_TypeBorders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.IndexTypeBorders = CB_TypeBorders.SelectedIndex;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
        }

        private void Btn_Visualization_Click(object sender, EventArgs e)
        {
            Graphics2D testGraph = new Graphics2D();
            testGraph.Run();
        }



        //x = (int) Math.Truncate((double)(bm.Width - 1) * (i - 0) / (X - 0));
        //y = (int) Math.Truncate((double)(bm.Height - 1) * (j - 0) / (Y - 0));
        //bm.SetPixel(x, y, color);
        //g.DrawRectangle(pen, i* bm.Width / X, j* bm.Height / Y, bm.Width / X, bm.Height / Y);
        //g.FillRectangle(brush, i* bm.Width / X, j* bm.Height / Y, bm.Width / X, bm.Height / Y);

    }
}
