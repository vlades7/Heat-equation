using Heat_equation.Classes;
using System;
using System.Windows.Forms;

namespace Heat_equation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitForm();
        }
        
        private void InitForm()
        {
            CB_TypeBorders.SelectedIndex = Global.IndexTypeBorders;
            switch (CB_TypeBorders.SelectedIndex)
            {
                case 0:
                    GB_Second.Enabled = false;
                    GB_Second.Visible = false;
                    GB_Third.Enabled = false;
                    GB_Third.Visible = false;
                    break;
                case 1:
                    GB_First.Enabled = false;
                    GB_First.Visible = false;
                    GB_Third.Enabled = false;
                    GB_Third.Visible = false;
                    break;
                case 2:
                    GB_First.Enabled = false;
                    GB_First.Visible = false;
                    GB_Second.Enabled = false;
                    GB_Second.Visible = false;
                    break;
            }
            Check_SaveFile.Checked = Global.SaveFile;

            TB_Lx.Text = Global.Lx.ToString();
            TB_Ly.Text = Global.Ly.ToString();
            TB_Hx.Text = Global.Hx.ToString();
            TB_Hy.Text = Global.Hy.ToString();
            TB_Tau.Text = Global.Tau.ToString();
            TB_A.Text = Global.A.ToString();
            TB_Lamda.Text = Global.Lamda.ToString();

            TB_MinTemp.Text = Global.MinTemp.ToString();
            TB_MaxTemp.Text = Global.MaxTemp.ToString();
            TB_LastIteration.Text = Global.LastIteration.ToString();

            TB_T1.Text = Global.T1.ToString();
            TB_T2.Text = Global.T2.ToString();
            TB_T3.Text = Global.T3.ToString();
            TB_T4.Text = Global.T4.ToString();

            TB_Q1.Text = Global.Q1.ToString();
            TB_Q2.Text = Global.Q2.ToString();
            TB_Q3.Text = Global.Q3.ToString();
            TB_Q4.Text = Global.Q4.ToString();

            TB_Tout1.Text = Global.Tout1.ToString();
            TB_Tout2.Text = Global.Tout2.ToString();
            TB_Tout3.Text = Global.Tout3.ToString();
            TB_Tout4.Text = Global.Tout4.ToString();
            TB_Alpha1.Text = Global.Alpha1.ToString();
            TB_Alpha2.Text = Global.Alpha2.ToString();
            TB_Alpha3.Text = Global.Alpha3.ToString();
            TB_Alpha4.Text = Global.Alpha4.ToString();
        }

        private void Btn_CalcToLast_Click(object sender, EventArgs e)
        {
            if (Condition())
            {
                Calculation calculation = new Calculation();
                calculation.Init();
                calculation.CalcAll();
                if (Check_SaveFile.Checked)
                {
                    calculation.SaveState();
                }
            }
            else
            {
                WarningMessage();
            }
        }

        private void Btn_Visualization_Click(object sender, EventArgs e)
        {
            if (Condition())
            {
                Hide();
                Graphics2D graph = new Graphics2D();
                graph.Run();
                Show();
            }
            else
            {
                WarningMessage();
            }
        }

        private bool Condition()
        {
            return Global.Lx >= Global.Hx &&
                Global.Ly >= Global.Hy &&
                Global.Tau <= Math.Pow(Math.Min(Global.Hx, Global.Hy), 2) / (4 * Math.Pow(Global.A, 2));
        }

        private void WarningMessage()
        {
            string str = "Проверьте выполнение следующих условий:\n" +
                "- Длина пластины >= Шаг по OX\n" +
                "- Ширина пластины >= Шаг по OY\n" +
                "- Критерий устойчивости";
            MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CB_TypeBorders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.IndexTypeBorders = CB_TypeBorders.SelectedIndex;
            switch (CB_TypeBorders.SelectedIndex)
            {
                case 0:
                    GB_First.Enabled = true;
                    GB_First.Visible = true;
                    GB_Second.Enabled = false;
                    GB_Second.Visible = false;
                    GB_Third.Enabled = false;
                    GB_Third.Visible = false;
                    break;
                case 1:
                    GB_First.Enabled = false;
                    GB_First.Visible = false;
                    GB_Second.Enabled = true;
                    GB_Second.Visible = true;
                    GB_Third.Enabled = false;
                    GB_Third.Visible = false;
                    break;
                case 2:
                    GB_First.Enabled = false;
                    GB_First.Visible = false;
                    GB_Second.Enabled = false;
                    GB_Second.Visible = false;
                    GB_Third.Enabled = true;
                    GB_Third.Visible = true;
                    break;
            }
        }

        private void TB_MinTemp_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_MinTemp.Text) >= Global.MaxTemp)
                {
                    TB_MinTemp.Text = (Global.MaxTemp - 100).ToString();
                }
                Global.MinTemp = double.Parse(TB_MinTemp.Text);
                TB_MinTemp.Text = Global.MinTemp.ToString();
            }
            catch
            {
                TB_MinTemp.Text = (Global.MaxTemp - 100).ToString();
                Global.MinTemp = double.Parse(TB_MinTemp.Text);
            }
        }

        private void TB_MaxTemp_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_MaxTemp.Text) <= Global.MinTemp)
                {
                    TB_MaxTemp.Text = (Global.MinTemp + 100).ToString();
                }
                Global.MaxTemp = double.Parse(TB_MaxTemp.Text);
                TB_MaxTemp.Text = Global.MaxTemp.ToString();
            }
            catch
            {
                TB_MaxTemp.Text = (Global.MinTemp + 100).ToString();
                Global.MaxTemp = double.Parse(TB_MaxTemp.Text);
            }
        }

        private void TB_LastIteration_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(TB_LastIteration.Text) <= 0)
                {
                    TB_LastIteration.Text = "100000";
                }
                Global.LastIteration = int.Parse(TB_LastIteration.Text);
                TB_LastIteration.Text = Global.LastIteration.ToString();
            }
            catch
            {
                TB_LastIteration.Text = "100000";
                Global.LastIteration = int.Parse(TB_LastIteration.Text);
            }
        }

        private void Check_SaveFile_CheckedChanged(object sender, EventArgs e)
        {
            Global.SaveFile = Check_SaveFile.Checked;
        }

        #region Валидация данных для общих параметров
        private void TB_Lx_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_Lx.Text) < Global.Hx)
                {
                    TB_Lx.Text = "50";
                }
                Global.Lx = double.Parse(TB_Lx.Text);
                TB_Lx.Text = Global.Lx.ToString();
            }
            catch
            {
                TB_Lx.Text = "50";
                Global.Lx = double.Parse(TB_Lx.Text);
            }
        }

        private void TB_Ly_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_Ly.Text) < Global.Hy)
                {
                    TB_Ly.Text = "50";
                }
                Global.Ly = double.Parse(TB_Ly.Text);
                TB_Ly.Text = Global.Ly.ToString();
            }
            catch
            {
                TB_Ly.Text = "50";
                Global.Ly = double.Parse(TB_Ly.Text);
            }
        }

        private void TB_Hx_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_Hx.Text) <= 0)
                {
                    TB_Hx.Text = "0,2";
                }
                Global.Hx = double.Parse(TB_Hx.Text);
                TB_Hx.Text = Global.Hx.ToString();
            }
            catch
            {
                TB_Hx.Text = "0,2";
                Global.Hx = double.Parse(TB_Hx.Text);
            }
        }

        private void TB_Hy_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_Hy.Text) <= 0)
                {
                    TB_Hy.Text = "0,2";
                }
                Global.Hy = double.Parse(TB_Hy.Text);
                TB_Hy.Text = Global.Hy.ToString();
            }
            catch
            {
                TB_Hy.Text = "0,2";
                Global.Hy = double.Parse(TB_Hy.Text);
            }
        }

        private void TB_Tau_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_Tau.Text) <= 0)
                {
                    TB_Tau.Text = "1000";
                }
                Global.Tau = double.Parse(TB_Tau.Text);
                TB_Tau.Text = Global.Tau.ToString();
            }
            catch
            {
                TB_Tau.Text = "1000";
                Global.Tau = double.Parse(TB_Tau.Text);
            }
        }

        private void TB_A_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_A.Text) <= 0)
                {
                    TB_A.Text = "0,000619";
                }
                Global.A = double.Parse(TB_A.Text);
                TB_A.Text = Global.A.ToString();
            }
            catch
            {
                TB_A.Text = "0,000619";
                Global.A = double.Parse(TB_A.Text);
            }
        }

        private void TB_Lamda_Leave(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TB_Lamda.Text) <= 0)
                {
                    TB_Lamda.Text = "1,51";
                }
                Global.Lamda = double.Parse(TB_Lamda.Text);
                TB_Lamda.Text = Global.Lamda.ToString();
            }
            catch
            {
                TB_Lamda.Text = "1,51";
                Global.Lamda = double.Parse(TB_Lamda.Text);
            }
        }
        #endregion

        #region Валидация данных для параметров 1-го рода
        private void TB_T1_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.T1 = double.Parse(TB_T1.Text);
                TB_T1.Text = Global.T1.ToString();
            }
            catch
            {
                TB_T1.Text = "-100";
                Global.T1 = double.Parse(TB_T1.Text);
            }
        }

        private void TB_T2_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.T2 = double.Parse(TB_T2.Text);
                TB_T2.Text = Global.T2.ToString();
            }
            catch
            {
                TB_T2.Text = "100";
                Global.T2 = double.Parse(TB_T2.Text);
            }
        }

        private void TB_T3_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.T3 = double.Parse(TB_T3.Text);
                TB_T3.Text = Global.T3.ToString();
            }
            catch
            {
                TB_T3.Text = "-100";
                Global.T3 = double.Parse(TB_T3.Text);
            }
        }

        private void TB_T4_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.T4 = double.Parse(TB_T4.Text);
                TB_T4.Text = Global.T4.ToString();
            }
            catch
            {
                TB_T4.Text = "100";
                Global.T4 = double.Parse(TB_T4.Text);
            }
        }
        #endregion

        #region Валидация данных для параметров 2-го рода
        private void TB_Q1_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Q1 = double.Parse(TB_Q1.Text);
                TB_Q1.Text = Global.Q1.ToString();
            }
            catch
            {
                TB_Q1.Text = "-4";
                Global.Q1 = double.Parse(TB_Q1.Text);
            }
        }

        private void TB_Q2_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Q2 = double.Parse(TB_Q2.Text);
                TB_Q2.Text = Global.Q2.ToString();
            }
            catch
            {
                TB_Q2.Text = "-4";
                Global.Q2 = double.Parse(TB_Q2.Text);
            }
        }

        private void TB_Q3_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Q3 = double.Parse(TB_Q3.Text);
                TB_Q3.Text = Global.Q3.ToString();
            }
            catch
            {
                TB_Q3.Text = "4";
                Global.Q3 = double.Parse(TB_Q3.Text);
            }
        }

        private void TB_Q4_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Q4 = double.Parse(TB_Q4.Text);
                TB_Q4.Text = Global.Q4.ToString();
            }
            catch
            {
                TB_Q4.Text = "4";
                Global.Q4 = double.Parse(TB_Q4.Text);
            }
        }
        #endregion

        #region Валидация данных для параметров 3-го рода
        private void TB_Tout1_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Tout1 = double.Parse(TB_Tout1.Text);
                TB_Tout1.Text = Global.Tout1.ToString();
            }
            catch
            {
                TB_Tout1.Text = "100";
                Global.Tout1 = double.Parse(TB_Tout1.Text);
            }
        }

        private void TB_Tout2_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Tout2 = double.Parse(TB_Tout2.Text);
                TB_Tout2.Text = Global.Tout2.ToString();
            }
            catch
            {
                TB_Tout2.Text = "240";
                Global.Tout2 = double.Parse(TB_Tout2.Text);
            }
        }

        private void TB_Tout3_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Tout3 = double.Parse(TB_Tout3.Text);
                TB_Tout3.Text = Global.Tout3.ToString();
            }
            catch
            {
                TB_Tout3.Text = "0";
                Global.Tout3 = double.Parse(TB_Tout3.Text);
            }
        }

        private void TB_Tout4_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Tout4 = double.Parse(TB_Tout4.Text);
                TB_Tout4.Text = Global.Tout4.ToString();
            }
            catch
            {
                TB_Tout4.Text = "240";
                Global.Tout4 = double.Parse(TB_Tout4.Text);
            }
        }

        private void TB_Alpha1_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Alpha1 = double.Parse(TB_Alpha1.Text);
                TB_Alpha1.Text = Global.Alpha1.ToString();
            }
            catch
            {
                TB_Alpha1.Text = "23";
                Global.Alpha1 = double.Parse(TB_Alpha1.Text);
            }
        }

        private void TB_Alpha2_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Alpha2 = double.Parse(TB_Alpha2.Text);
                TB_Alpha2.Text = Global.Alpha2.ToString();
            }
            catch
            {
                TB_Alpha2.Text = "23";
                Global.Alpha2 = double.Parse(TB_Alpha2.Text);
            }
        }

        private void TB_Alpha3_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Alpha3 = double.Parse(TB_Alpha3.Text);
                TB_Alpha3.Text = Global.Alpha3.ToString();
            }
            catch
            {
                TB_Alpha3.Text = "23";
                Global.Alpha3 = double.Parse(TB_Alpha3.Text);
            }
        }

        private void TB_Alpha4_Leave(object sender, EventArgs e)
        {
            try
            {
                Global.Alpha4 = double.Parse(TB_Alpha4.Text);
                TB_Alpha4.Text = Global.Alpha4.ToString();
            }
            catch
            {
                TB_Alpha4.Text = "23";
                Global.Alpha4 = double.Parse(TB_Alpha4.Text);
            }
        }
        #endregion

    }
}
