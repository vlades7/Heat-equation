﻿using Heat_equation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heat_equation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BTN_TEST_Click(object sender, EventArgs e)
        {
            Rtb_Result.Clear();
            Calculation obj = new Calculation();
            obj.Init();
            obj.Print(Rtb_Result);
            Rtb_Result.AppendText(Environment.NewLine);
            obj.Calc();
            obj.Print(Rtb_Result);
        }
    }
}