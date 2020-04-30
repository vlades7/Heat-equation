namespace Heat_equation
{
    partial class FormMain
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
            this.ParamsPanel = new System.Windows.Forms.Panel();
            this.GB_CommonParams = new System.Windows.Forms.GroupBox();
            this.TB_Lamda = new System.Windows.Forms.TextBox();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.TB_Tau = new System.Windows.Forms.TextBox();
            this.TB_Hy = new System.Windows.Forms.TextBox();
            this.TB_Hx = new System.Windows.Forms.TextBox();
            this.Label_Lamda = new System.Windows.Forms.Label();
            this.Label_Hx = new System.Windows.Forms.Label();
            this.Label_A = new System.Windows.Forms.Label();
            this.Label_Hy = new System.Windows.Forms.Label();
            this.Label_Lx = new System.Windows.Forms.Label();
            this.TB_Lx = new System.Windows.Forms.TextBox();
            this.Label_Ly = new System.Windows.Forms.Label();
            this.TB_Ly = new System.Windows.Forms.TextBox();
            this.Label_Tau = new System.Windows.Forms.Label();
            this.Btn_Simulation = new System.Windows.Forms.Button();
            this.CB_TypeBorders = new System.Windows.Forms.ComboBox();
            this.GB_First = new System.Windows.Forms.GroupBox();
            this.TB_T4 = new System.Windows.Forms.TextBox();
            this.TB_T3 = new System.Windows.Forms.TextBox();
            this.TB_T2 = new System.Windows.Forms.TextBox();
            this.TB_T1 = new System.Windows.Forms.TextBox();
            this.Label_T4 = new System.Windows.Forms.Label();
            this.Label_T3 = new System.Windows.Forms.Label();
            this.Label_T2 = new System.Windows.Forms.Label();
            this.Label_T1 = new System.Windows.Forms.Label();
            this.GB_Second = new System.Windows.Forms.GroupBox();
            this.Label_Q1 = new System.Windows.Forms.Label();
            this.TB_Q4 = new System.Windows.Forms.TextBox();
            this.TB_Q3 = new System.Windows.Forms.TextBox();
            this.TB_Q2 = new System.Windows.Forms.TextBox();
            this.TB_Q1 = new System.Windows.Forms.TextBox();
            this.Label_Q4 = new System.Windows.Forms.Label();
            this.Label_Q3 = new System.Windows.Forms.Label();
            this.Label_Q2 = new System.Windows.Forms.Label();
            this.GB_Third = new System.Windows.Forms.GroupBox();
            this.TB_Alpha3 = new System.Windows.Forms.TextBox();
            this.TB_Alpha2 = new System.Windows.Forms.TextBox();
            this.TB_Alpha1 = new System.Windows.Forms.TextBox();
            this.Label_Alpha4 = new System.Windows.Forms.Label();
            this.Label_Alpha3 = new System.Windows.Forms.Label();
            this.Label_Alpha2 = new System.Windows.Forms.Label();
            this.Label_Alpha1 = new System.Windows.Forms.Label();
            this.TB_Tout4 = new System.Windows.Forms.TextBox();
            this.TB_Tout3 = new System.Windows.Forms.TextBox();
            this.TB_Tout2 = new System.Windows.Forms.TextBox();
            this.TB_Tout1 = new System.Windows.Forms.TextBox();
            this.Label_Tout4 = new System.Windows.Forms.Label();
            this.Label_Tout3 = new System.Windows.Forms.Label();
            this.Label_Tout2 = new System.Windows.Forms.Label();
            this.Label_Tout1 = new System.Windows.Forms.Label();
            this.TB_Alpha4 = new System.Windows.Forms.TextBox();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.Rtb_Result = new System.Windows.Forms.RichTextBox();
            this.Label_MinTemp = new System.Windows.Forms.Label();
            this.Label_MaxTemp = new System.Windows.Forms.Label();
            this.TB_MinTemp = new System.Windows.Forms.TextBox();
            this.TB_MaxTemp = new System.Windows.Forms.TextBox();
            this.Check_SaveFile = new System.Windows.Forms.CheckBox();
            this.Btn_CalcToLast = new System.Windows.Forms.Button();
            this.Label_LastIteration = new System.Windows.Forms.Label();
            this.TB_LastIteration = new System.Windows.Forms.TextBox();
            this.ParamsPanel.SuspendLayout();
            this.GB_CommonParams.SuspendLayout();
            this.GB_First.SuspendLayout();
            this.GB_Second.SuspendLayout();
            this.GB_Third.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParamsPanel
            // 
            this.ParamsPanel.Controls.Add(this.TB_LastIteration);
            this.ParamsPanel.Controls.Add(this.Label_LastIteration);
            this.ParamsPanel.Controls.Add(this.Btn_CalcToLast);
            this.ParamsPanel.Controls.Add(this.Check_SaveFile);
            this.ParamsPanel.Controls.Add(this.TB_MaxTemp);
            this.ParamsPanel.Controls.Add(this.TB_MinTemp);
            this.ParamsPanel.Controls.Add(this.Label_MaxTemp);
            this.ParamsPanel.Controls.Add(this.Label_MinTemp);
            this.ParamsPanel.Controls.Add(this.GB_CommonParams);
            this.ParamsPanel.Controls.Add(this.Btn_Simulation);
            this.ParamsPanel.Controls.Add(this.CB_TypeBorders);
            this.ParamsPanel.Controls.Add(this.GB_First);
            this.ParamsPanel.Controls.Add(this.GB_Second);
            this.ParamsPanel.Controls.Add(this.GB_Third);
            this.ParamsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ParamsPanel.Location = new System.Drawing.Point(0, 0);
            this.ParamsPanel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ParamsPanel.Name = "ParamsPanel";
            this.ParamsPanel.Size = new System.Drawing.Size(1148, 437);
            this.ParamsPanel.TabIndex = 0;
            // 
            // GB_CommonParams
            // 
            this.GB_CommonParams.Controls.Add(this.TB_Lamda);
            this.GB_CommonParams.Controls.Add(this.TB_A);
            this.GB_CommonParams.Controls.Add(this.TB_Tau);
            this.GB_CommonParams.Controls.Add(this.TB_Hy);
            this.GB_CommonParams.Controls.Add(this.TB_Hx);
            this.GB_CommonParams.Controls.Add(this.Label_Lamda);
            this.GB_CommonParams.Controls.Add(this.Label_Hx);
            this.GB_CommonParams.Controls.Add(this.Label_A);
            this.GB_CommonParams.Controls.Add(this.Label_Hy);
            this.GB_CommonParams.Controls.Add(this.Label_Lx);
            this.GB_CommonParams.Controls.Add(this.TB_Lx);
            this.GB_CommonParams.Controls.Add(this.Label_Ly);
            this.GB_CommonParams.Controls.Add(this.TB_Ly);
            this.GB_CommonParams.Controls.Add(this.Label_Tau);
            this.GB_CommonParams.Location = new System.Drawing.Point(9, 9);
            this.GB_CommonParams.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GB_CommonParams.Name = "GB_CommonParams";
            this.GB_CommonParams.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GB_CommonParams.Size = new System.Drawing.Size(385, 418);
            this.GB_CommonParams.TabIndex = 6;
            this.GB_CommonParams.TabStop = false;
            this.GB_CommonParams.Text = "Общие параметры";
            // 
            // TB_Lamda
            // 
            this.TB_Lamda.Location = new System.Drawing.Point(202, 270);
            this.TB_Lamda.Name = "TB_Lamda";
            this.TB_Lamda.Size = new System.Drawing.Size(145, 26);
            this.TB_Lamda.TabIndex = 17;
            this.TB_Lamda.Leave += new System.EventHandler(this.TB_Lamda_Leave);
            // 
            // TB_A
            // 
            this.TB_A.Location = new System.Drawing.Point(202, 230);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(145, 26);
            this.TB_A.TabIndex = 16;
            this.TB_A.Leave += new System.EventHandler(this.TB_A_Leave);
            // 
            // TB_Tau
            // 
            this.TB_Tau.Location = new System.Drawing.Point(202, 190);
            this.TB_Tau.Name = "TB_Tau";
            this.TB_Tau.Size = new System.Drawing.Size(145, 26);
            this.TB_Tau.TabIndex = 15;
            this.TB_Tau.Leave += new System.EventHandler(this.TB_Tau_Leave);
            // 
            // TB_Hy
            // 
            this.TB_Hy.Location = new System.Drawing.Point(202, 150);
            this.TB_Hy.Name = "TB_Hy";
            this.TB_Hy.Size = new System.Drawing.Size(145, 26);
            this.TB_Hy.TabIndex = 14;
            this.TB_Hy.Leave += new System.EventHandler(this.TB_Hy_Leave);
            // 
            // TB_Hx
            // 
            this.TB_Hx.Location = new System.Drawing.Point(202, 110);
            this.TB_Hx.Name = "TB_Hx";
            this.TB_Hx.Size = new System.Drawing.Size(145, 26);
            this.TB_Hx.TabIndex = 13;
            this.TB_Hx.Leave += new System.EventHandler(this.TB_Hx_Leave);
            // 
            // Label_Lamda
            // 
            this.Label_Lamda.AutoSize = true;
            this.Label_Lamda.Location = new System.Drawing.Point(11, 270);
            this.Label_Lamda.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Lamda.Name = "Label_Lamda";
            this.Label_Lamda.Size = new System.Drawing.Size(137, 19);
            this.Label_Lamda.TabIndex = 10;
            this.Label_Lamda.Text = "Коэффициент λ:";
            // 
            // Label_Hx
            // 
            this.Label_Hx.AutoSize = true;
            this.Label_Hx.Location = new System.Drawing.Point(11, 110);
            this.Label_Hx.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Hx.Name = "Label_Hx";
            this.Label_Hx.Size = new System.Drawing.Size(98, 19);
            this.Label_Hx.TabIndex = 6;
            this.Label_Hx.Text = "Шаг по OX:";
            // 
            // Label_A
            // 
            this.Label_A.AutoSize = true;
            this.Label_A.Location = new System.Drawing.Point(11, 230);
            this.Label_A.Margin = new System.Windows.Forms.Padding(0);
            this.Label_A.Name = "Label_A";
            this.Label_A.Size = new System.Drawing.Size(138, 19);
            this.Label_A.TabIndex = 9;
            this.Label_A.Text = "Коэффициент A:";
            // 
            // Label_Hy
            // 
            this.Label_Hy.AutoSize = true;
            this.Label_Hy.Location = new System.Drawing.Point(11, 150);
            this.Label_Hy.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Hy.Name = "Label_Hy";
            this.Label_Hy.Size = new System.Drawing.Size(97, 19);
            this.Label_Hy.TabIndex = 7;
            this.Label_Hy.Text = "Шаг по OY:";
            // 
            // Label_Lx
            // 
            this.Label_Lx.AutoSize = true;
            this.Label_Lx.Location = new System.Drawing.Point(11, 30);
            this.Label_Lx.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Lx.Name = "Label_Lx";
            this.Label_Lx.Size = new System.Drawing.Size(140, 19);
            this.Label_Lx.TabIndex = 4;
            this.Label_Lx.Text = "Длина пластины:";
            // 
            // TB_Lx
            // 
            this.TB_Lx.Location = new System.Drawing.Point(202, 30);
            this.TB_Lx.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TB_Lx.Name = "TB_Lx";
            this.TB_Lx.Size = new System.Drawing.Size(145, 26);
            this.TB_Lx.TabIndex = 11;
            this.TB_Lx.Leave += new System.EventHandler(this.TB_Lx_Leave);
            // 
            // Label_Ly
            // 
            this.Label_Ly.AutoSize = true;
            this.Label_Ly.Location = new System.Drawing.Point(11, 70);
            this.Label_Ly.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Ly.Name = "Label_Ly";
            this.Label_Ly.Size = new System.Drawing.Size(153, 19);
            this.Label_Ly.TabIndex = 5;
            this.Label_Ly.Text = "Ширина пластины:";
            // 
            // TB_Ly
            // 
            this.TB_Ly.Location = new System.Drawing.Point(202, 70);
            this.TB_Ly.Name = "TB_Ly";
            this.TB_Ly.Size = new System.Drawing.Size(145, 26);
            this.TB_Ly.TabIndex = 12;
            this.TB_Ly.Leave += new System.EventHandler(this.TB_Ly_Leave);
            // 
            // Label_Tau
            // 
            this.Label_Tau.AutoSize = true;
            this.Label_Tau.Location = new System.Drawing.Point(11, 190);
            this.Label_Tau.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Tau.Name = "Label_Tau";
            this.Label_Tau.Size = new System.Drawing.Size(140, 19);
            this.Label_Tau.TabIndex = 8;
            this.Label_Tau.Text = "Шаг по времени:";
            // 
            // Btn_Simulation
            // 
            this.Btn_Simulation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Simulation.Location = new System.Drawing.Point(926, 314);
            this.Btn_Simulation.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Btn_Simulation.Name = "Btn_Simulation";
            this.Btn_Simulation.Size = new System.Drawing.Size(210, 55);
            this.Btn_Simulation.TabIndex = 3;
            this.Btn_Simulation.Text = "Симуляция";
            this.Btn_Simulation.UseVisualStyleBackColor = true;
            this.Btn_Simulation.Click += new System.EventHandler(this.Btn_Visualization_Click);
            // 
            // CB_TypeBorders
            // 
            this.CB_TypeBorders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TypeBorders.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_TypeBorders.FormattingEnabled = true;
            this.CB_TypeBorders.Items.AddRange(new object[] {
            "Границы 1-го рода",
            "Границы 2-го рода",
            "Границы 3-го рода"});
            this.CB_TypeBorders.Location = new System.Drawing.Point(805, 31);
            this.CB_TypeBorders.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.CB_TypeBorders.Name = "CB_TypeBorders";
            this.CB_TypeBorders.Size = new System.Drawing.Size(316, 27);
            this.CB_TypeBorders.TabIndex = 1;
            this.CB_TypeBorders.SelectedIndexChanged += new System.EventHandler(this.CB_TypeBorders_SelectedIndexChanged);
            // 
            // GB_First
            // 
            this.GB_First.Controls.Add(this.TB_T4);
            this.GB_First.Controls.Add(this.TB_T3);
            this.GB_First.Controls.Add(this.TB_T2);
            this.GB_First.Controls.Add(this.TB_T1);
            this.GB_First.Controls.Add(this.Label_T4);
            this.GB_First.Controls.Add(this.Label_T3);
            this.GB_First.Controls.Add(this.Label_T2);
            this.GB_First.Controls.Add(this.Label_T1);
            this.GB_First.Location = new System.Drawing.Point(406, 9);
            this.GB_First.Name = "GB_First";
            this.GB_First.Size = new System.Drawing.Size(385, 418);
            this.GB_First.TabIndex = 9;
            this.GB_First.TabStop = false;
            this.GB_First.Text = "Параметры для 1 рода";
            // 
            // TB_T4
            // 
            this.TB_T4.Location = new System.Drawing.Point(224, 150);
            this.TB_T4.Name = "TB_T4";
            this.TB_T4.Size = new System.Drawing.Size(143, 26);
            this.TB_T4.TabIndex = 7;
            this.TB_T4.Leave += new System.EventHandler(this.TB_T4_Leave);
            // 
            // TB_T3
            // 
            this.TB_T3.Location = new System.Drawing.Point(224, 110);
            this.TB_T3.Name = "TB_T3";
            this.TB_T3.Size = new System.Drawing.Size(143, 26);
            this.TB_T3.TabIndex = 6;
            this.TB_T3.Leave += new System.EventHandler(this.TB_T3_Leave);
            // 
            // TB_T2
            // 
            this.TB_T2.Location = new System.Drawing.Point(224, 70);
            this.TB_T2.Name = "TB_T2";
            this.TB_T2.Size = new System.Drawing.Size(143, 26);
            this.TB_T2.TabIndex = 5;
            this.TB_T2.Leave += new System.EventHandler(this.TB_T2_Leave);
            // 
            // TB_T1
            // 
            this.TB_T1.Location = new System.Drawing.Point(224, 30);
            this.TB_T1.Name = "TB_T1";
            this.TB_T1.Size = new System.Drawing.Size(143, 26);
            this.TB_T1.TabIndex = 4;
            this.TB_T1.Leave += new System.EventHandler(this.TB_T1_Leave);
            // 
            // Label_T4
            // 
            this.Label_T4.AutoSize = true;
            this.Label_T4.Location = new System.Drawing.Point(16, 150);
            this.Label_T4.Name = "Label_T4";
            this.Label_T4.Size = new System.Drawing.Size(162, 19);
            this.Label_T4.TabIndex = 3;
            this.Label_T4.Text = "Температура снизу:";
            // 
            // Label_T3
            // 
            this.Label_T3.AutoSize = true;
            this.Label_T3.Location = new System.Drawing.Point(16, 110);
            this.Label_T3.Name = "Label_T3";
            this.Label_T3.Size = new System.Drawing.Size(172, 19);
            this.Label_T3.TabIndex = 2;
            this.Label_T3.Text = "Температура справа:";
            // 
            // Label_T2
            // 
            this.Label_T2.AutoSize = true;
            this.Label_T2.Location = new System.Drawing.Point(16, 70);
            this.Label_T2.Name = "Label_T2";
            this.Label_T2.Size = new System.Drawing.Size(172, 19);
            this.Label_T2.TabIndex = 1;
            this.Label_T2.Text = "Температура сверху:";
            // 
            // Label_T1
            // 
            this.Label_T1.AutoSize = true;
            this.Label_T1.Location = new System.Drawing.Point(16, 30);
            this.Label_T1.Name = "Label_T1";
            this.Label_T1.Size = new System.Drawing.Size(163, 19);
            this.Label_T1.TabIndex = 0;
            this.Label_T1.Text = "Температура слева:";
            // 
            // GB_Second
            // 
            this.GB_Second.Controls.Add(this.Label_Q1);
            this.GB_Second.Controls.Add(this.TB_Q4);
            this.GB_Second.Controls.Add(this.TB_Q3);
            this.GB_Second.Controls.Add(this.TB_Q2);
            this.GB_Second.Controls.Add(this.TB_Q1);
            this.GB_Second.Controls.Add(this.Label_Q4);
            this.GB_Second.Controls.Add(this.Label_Q3);
            this.GB_Second.Controls.Add(this.Label_Q2);
            this.GB_Second.Location = new System.Drawing.Point(406, 9);
            this.GB_Second.Name = "GB_Second";
            this.GB_Second.Size = new System.Drawing.Size(385, 418);
            this.GB_Second.TabIndex = 7;
            this.GB_Second.TabStop = false;
            this.GB_Second.Text = "Параметры для 2 рода";
            // 
            // Label_Q1
            // 
            this.Label_Q1.AutoSize = true;
            this.Label_Q1.Location = new System.Drawing.Point(16, 30);
            this.Label_Q1.Name = "Label_Q1";
            this.Label_Q1.Size = new System.Drawing.Size(189, 19);
            this.Label_Q1.TabIndex = 1;
            this.Label_Q1.Text = "Тепловой поток слева:";
            // 
            // TB_Q4
            // 
            this.TB_Q4.Location = new System.Drawing.Point(228, 150);
            this.TB_Q4.Name = "TB_Q4";
            this.TB_Q4.Size = new System.Drawing.Size(141, 26);
            this.TB_Q4.TabIndex = 8;
            this.TB_Q4.Leave += new System.EventHandler(this.TB_Q4_Leave);
            // 
            // TB_Q3
            // 
            this.TB_Q3.Location = new System.Drawing.Point(228, 110);
            this.TB_Q3.Name = "TB_Q3";
            this.TB_Q3.Size = new System.Drawing.Size(141, 26);
            this.TB_Q3.TabIndex = 7;
            this.TB_Q3.Leave += new System.EventHandler(this.TB_Q3_Leave);
            // 
            // TB_Q2
            // 
            this.TB_Q2.Location = new System.Drawing.Point(228, 70);
            this.TB_Q2.Name = "TB_Q2";
            this.TB_Q2.Size = new System.Drawing.Size(141, 26);
            this.TB_Q2.TabIndex = 6;
            this.TB_Q2.Leave += new System.EventHandler(this.TB_Q2_Leave);
            // 
            // TB_Q1
            // 
            this.TB_Q1.Location = new System.Drawing.Point(228, 30);
            this.TB_Q1.Name = "TB_Q1";
            this.TB_Q1.Size = new System.Drawing.Size(141, 26);
            this.TB_Q1.TabIndex = 5;
            this.TB_Q1.Leave += new System.EventHandler(this.TB_Q1_Leave);
            // 
            // Label_Q4
            // 
            this.Label_Q4.AutoSize = true;
            this.Label_Q4.Location = new System.Drawing.Point(16, 150);
            this.Label_Q4.Name = "Label_Q4";
            this.Label_Q4.Size = new System.Drawing.Size(188, 19);
            this.Label_Q4.TabIndex = 4;
            this.Label_Q4.Text = "Тепловой поток снизу:";
            // 
            // Label_Q3
            // 
            this.Label_Q3.AutoSize = true;
            this.Label_Q3.Location = new System.Drawing.Point(16, 110);
            this.Label_Q3.Name = "Label_Q3";
            this.Label_Q3.Size = new System.Drawing.Size(198, 19);
            this.Label_Q3.TabIndex = 3;
            this.Label_Q3.Text = "Тепловой поток справа:";
            // 
            // Label_Q2
            // 
            this.Label_Q2.AutoSize = true;
            this.Label_Q2.Location = new System.Drawing.Point(16, 70);
            this.Label_Q2.Name = "Label_Q2";
            this.Label_Q2.Size = new System.Drawing.Size(198, 19);
            this.Label_Q2.TabIndex = 2;
            this.Label_Q2.Text = "Тепловой поток сверху:";
            // 
            // GB_Third
            // 
            this.GB_Third.Controls.Add(this.TB_Alpha3);
            this.GB_Third.Controls.Add(this.TB_Alpha2);
            this.GB_Third.Controls.Add(this.TB_Alpha1);
            this.GB_Third.Controls.Add(this.Label_Alpha4);
            this.GB_Third.Controls.Add(this.Label_Alpha3);
            this.GB_Third.Controls.Add(this.Label_Alpha2);
            this.GB_Third.Controls.Add(this.Label_Alpha1);
            this.GB_Third.Controls.Add(this.TB_Tout4);
            this.GB_Third.Controls.Add(this.TB_Tout3);
            this.GB_Third.Controls.Add(this.TB_Tout2);
            this.GB_Third.Controls.Add(this.TB_Tout1);
            this.GB_Third.Controls.Add(this.Label_Tout4);
            this.GB_Third.Controls.Add(this.Label_Tout3);
            this.GB_Third.Controls.Add(this.Label_Tout2);
            this.GB_Third.Controls.Add(this.Label_Tout1);
            this.GB_Third.Controls.Add(this.TB_Alpha4);
            this.GB_Third.Location = new System.Drawing.Point(406, 9);
            this.GB_Third.Name = "GB_Third";
            this.GB_Third.Size = new System.Drawing.Size(385, 418);
            this.GB_Third.TabIndex = 8;
            this.GB_Third.TabStop = false;
            this.GB_Third.Text = "Параметры для 3 рода";
            // 
            // TB_Alpha3
            // 
            this.TB_Alpha3.Location = new System.Drawing.Point(257, 280);
            this.TB_Alpha3.Name = "TB_Alpha3";
            this.TB_Alpha3.Size = new System.Drawing.Size(110, 26);
            this.TB_Alpha3.TabIndex = 15;
            this.TB_Alpha3.Leave += new System.EventHandler(this.TB_Alpha3_Leave);
            // 
            // TB_Alpha2
            // 
            this.TB_Alpha2.Location = new System.Drawing.Point(257, 240);
            this.TB_Alpha2.Name = "TB_Alpha2";
            this.TB_Alpha2.Size = new System.Drawing.Size(110, 26);
            this.TB_Alpha2.TabIndex = 14;
            this.TB_Alpha2.Leave += new System.EventHandler(this.TB_Alpha2_Leave);
            // 
            // TB_Alpha1
            // 
            this.TB_Alpha1.Location = new System.Drawing.Point(257, 200);
            this.TB_Alpha1.Name = "TB_Alpha1";
            this.TB_Alpha1.Size = new System.Drawing.Size(110, 26);
            this.TB_Alpha1.TabIndex = 13;
            this.TB_Alpha1.Leave += new System.EventHandler(this.TB_Alpha1_Leave);
            // 
            // Label_Alpha4
            // 
            this.Label_Alpha4.AutoSize = true;
            this.Label_Alpha4.Location = new System.Drawing.Point(8, 320);
            this.Label_Alpha4.Name = "Label_Alpha4";
            this.Label_Alpha4.Size = new System.Drawing.Size(215, 19);
            this.Label_Alpha4.TabIndex = 12;
            this.Label_Alpha4.Text = "Коэф. теплообмена снизу:";
            // 
            // Label_Alpha3
            // 
            this.Label_Alpha3.AutoSize = true;
            this.Label_Alpha3.Location = new System.Drawing.Point(8, 280);
            this.Label_Alpha3.Name = "Label_Alpha3";
            this.Label_Alpha3.Size = new System.Drawing.Size(225, 19);
            this.Label_Alpha3.TabIndex = 11;
            this.Label_Alpha3.Text = "Коэф. теплообмена справа:";
            // 
            // Label_Alpha2
            // 
            this.Label_Alpha2.AutoSize = true;
            this.Label_Alpha2.Location = new System.Drawing.Point(8, 240);
            this.Label_Alpha2.Name = "Label_Alpha2";
            this.Label_Alpha2.Size = new System.Drawing.Size(225, 19);
            this.Label_Alpha2.TabIndex = 10;
            this.Label_Alpha2.Text = "Коэф. теплообмена сверху:";
            // 
            // Label_Alpha1
            // 
            this.Label_Alpha1.AutoSize = true;
            this.Label_Alpha1.Location = new System.Drawing.Point(8, 200);
            this.Label_Alpha1.Name = "Label_Alpha1";
            this.Label_Alpha1.Size = new System.Drawing.Size(216, 19);
            this.Label_Alpha1.TabIndex = 9;
            this.Label_Alpha1.Text = "Коэф. теплообмена слева:";
            // 
            // TB_Tout4
            // 
            this.TB_Tout4.Location = new System.Drawing.Point(257, 150);
            this.TB_Tout4.Name = "TB_Tout4";
            this.TB_Tout4.Size = new System.Drawing.Size(110, 26);
            this.TB_Tout4.TabIndex = 8;
            this.TB_Tout4.Leave += new System.EventHandler(this.TB_Tout4_Leave);
            // 
            // TB_Tout3
            // 
            this.TB_Tout3.Location = new System.Drawing.Point(257, 110);
            this.TB_Tout3.Name = "TB_Tout3";
            this.TB_Tout3.Size = new System.Drawing.Size(110, 26);
            this.TB_Tout3.TabIndex = 7;
            this.TB_Tout3.Leave += new System.EventHandler(this.TB_Tout3_Leave);
            // 
            // TB_Tout2
            // 
            this.TB_Tout2.Location = new System.Drawing.Point(257, 70);
            this.TB_Tout2.Name = "TB_Tout2";
            this.TB_Tout2.Size = new System.Drawing.Size(110, 26);
            this.TB_Tout2.TabIndex = 6;
            this.TB_Tout2.Leave += new System.EventHandler(this.TB_Tout2_Leave);
            // 
            // TB_Tout1
            // 
            this.TB_Tout1.Location = new System.Drawing.Point(257, 30);
            this.TB_Tout1.Name = "TB_Tout1";
            this.TB_Tout1.Size = new System.Drawing.Size(110, 26);
            this.TB_Tout1.TabIndex = 5;
            this.TB_Tout1.Leave += new System.EventHandler(this.TB_Tout1_Leave);
            // 
            // Label_Tout4
            // 
            this.Label_Tout4.AutoSize = true;
            this.Label_Tout4.Location = new System.Drawing.Point(8, 150);
            this.Label_Tout4.Name = "Label_Tout4";
            this.Label_Tout4.Size = new System.Drawing.Size(233, 19);
            this.Label_Tout4.TabIndex = 4;
            this.Label_Tout4.Text = "Температура снаружи снизу:";
            // 
            // Label_Tout3
            // 
            this.Label_Tout3.AutoSize = true;
            this.Label_Tout3.Location = new System.Drawing.Point(8, 110);
            this.Label_Tout3.Name = "Label_Tout3";
            this.Label_Tout3.Size = new System.Drawing.Size(243, 19);
            this.Label_Tout3.TabIndex = 3;
            this.Label_Tout3.Text = "Температура снаружи справа:";
            // 
            // Label_Tout2
            // 
            this.Label_Tout2.AutoSize = true;
            this.Label_Tout2.Location = new System.Drawing.Point(8, 70);
            this.Label_Tout2.Name = "Label_Tout2";
            this.Label_Tout2.Size = new System.Drawing.Size(243, 19);
            this.Label_Tout2.TabIndex = 2;
            this.Label_Tout2.Text = "Температура снаружи сверху:";
            // 
            // Label_Tout1
            // 
            this.Label_Tout1.AutoSize = true;
            this.Label_Tout1.Location = new System.Drawing.Point(8, 30);
            this.Label_Tout1.Name = "Label_Tout1";
            this.Label_Tout1.Size = new System.Drawing.Size(234, 19);
            this.Label_Tout1.TabIndex = 1;
            this.Label_Tout1.Text = "Температура снаружи слева:";
            // 
            // TB_Alpha4
            // 
            this.TB_Alpha4.Location = new System.Drawing.Point(257, 320);
            this.TB_Alpha4.Name = "TB_Alpha4";
            this.TB_Alpha4.Size = new System.Drawing.Size(110, 26);
            this.TB_Alpha4.TabIndex = 16;
            this.TB_Alpha4.Leave += new System.EventHandler(this.TB_Alpha4_Leave);
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.Rtb_Result);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(0, 437);
            this.OutputPanel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1148, 85);
            this.OutputPanel.TabIndex = 1;
            // 
            // Rtb_Result
            // 
            this.Rtb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_Result.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rtb_Result.Location = new System.Drawing.Point(0, 0);
            this.Rtb_Result.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Rtb_Result.Name = "Rtb_Result";
            this.Rtb_Result.Size = new System.Drawing.Size(1148, 85);
            this.Rtb_Result.TabIndex = 0;
            this.Rtb_Result.Text = "";
            // 
            // Label_MinTemp
            // 
            this.Label_MinTemp.AutoSize = true;
            this.Label_MinTemp.Location = new System.Drawing.Point(801, 77);
            this.Label_MinTemp.Name = "Label_MinTemp";
            this.Label_MinTemp.Size = new System.Drawing.Size(221, 19);
            this.Label_MinTemp.TabIndex = 10;
            this.Label_MinTemp.Text = "Минимальная температура:";
            // 
            // Label_MaxTemp
            // 
            this.Label_MaxTemp.AutoSize = true;
            this.Label_MaxTemp.Location = new System.Drawing.Point(801, 117);
            this.Label_MaxTemp.Name = "Label_MaxTemp";
            this.Label_MaxTemp.Size = new System.Drawing.Size(229, 19);
            this.Label_MaxTemp.TabIndex = 11;
            this.Label_MaxTemp.Text = "Максимальная температура:";
            // 
            // TB_MinTemp
            // 
            this.TB_MinTemp.Location = new System.Drawing.Point(1028, 77);
            this.TB_MinTemp.Name = "TB_MinTemp";
            this.TB_MinTemp.Size = new System.Drawing.Size(100, 26);
            this.TB_MinTemp.TabIndex = 12;
            this.TB_MinTemp.Leave += new System.EventHandler(this.TB_MinTemp_Leave);
            // 
            // TB_MaxTemp
            // 
            this.TB_MaxTemp.Location = new System.Drawing.Point(1028, 117);
            this.TB_MaxTemp.Name = "TB_MaxTemp";
            this.TB_MaxTemp.Size = new System.Drawing.Size(100, 26);
            this.TB_MaxTemp.TabIndex = 13;
            this.TB_MaxTemp.Leave += new System.EventHandler(this.TB_MaxTemp_Leave);
            // 
            // Check_SaveFile
            // 
            this.Check_SaveFile.AutoSize = true;
            this.Check_SaveFile.Location = new System.Drawing.Point(805, 197);
            this.Check_SaveFile.Name = "Check_SaveFile";
            this.Check_SaveFile.Size = new System.Drawing.Size(286, 23);
            this.Check_SaveFile.TabIndex = 14;
            this.Check_SaveFile.Text = "Сохранение последней итерации";
            this.Check_SaveFile.UseVisualStyleBackColor = true;
            this.Check_SaveFile.CheckedChanged += new System.EventHandler(this.Check_SaveFile_CheckedChanged);
            // 
            // Btn_CalcToLast
            // 
            this.Btn_CalcToLast.Location = new System.Drawing.Point(926, 372);
            this.Btn_CalcToLast.Name = "Btn_CalcToLast";
            this.Btn_CalcToLast.Size = new System.Drawing.Size(210, 55);
            this.Btn_CalcToLast.TabIndex = 15;
            this.Btn_CalcToLast.Text = "Подсчитать до последней итерации";
            this.Btn_CalcToLast.UseVisualStyleBackColor = true;
            this.Btn_CalcToLast.Click += new System.EventHandler(this.Btn_CalcToLast_Click);
            // 
            // Label_LastIteration
            // 
            this.Label_LastIteration.AutoSize = true;
            this.Label_LastIteration.Location = new System.Drawing.Point(801, 157);
            this.Label_LastIteration.Name = "Label_LastIteration";
            this.Label_LastIteration.Size = new System.Drawing.Size(141, 19);
            this.Label_LastIteration.TabIndex = 16;
            this.Label_LastIteration.Text = "Номер итерации:";
            // 
            // TB_LastIteration
            // 
            this.TB_LastIteration.Location = new System.Drawing.Point(1028, 157);
            this.TB_LastIteration.Name = "TB_LastIteration";
            this.TB_LastIteration.Size = new System.Drawing.Size(100, 26);
            this.TB_LastIteration.TabIndex = 17;
            this.TB_LastIteration.Leave += new System.EventHandler(this.TB_LastIteration_Leave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1148, 522);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.ParamsPanel);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уравнение теплопроводности";
            this.ParamsPanel.ResumeLayout(false);
            this.ParamsPanel.PerformLayout();
            this.GB_CommonParams.ResumeLayout(false);
            this.GB_CommonParams.PerformLayout();
            this.GB_First.ResumeLayout(false);
            this.GB_First.PerformLayout();
            this.GB_Second.ResumeLayout(false);
            this.GB_Second.PerformLayout();
            this.GB_Third.ResumeLayout(false);
            this.GB_Third.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParamsPanel;
        private System.Windows.Forms.Panel OutputPanel;
        public System.Windows.Forms.RichTextBox Rtb_Result;
        private System.Windows.Forms.ComboBox CB_TypeBorders;
        private System.Windows.Forms.Button Btn_Simulation;
        private System.Windows.Forms.GroupBox GB_CommonParams;
        private System.Windows.Forms.Label Label_Ly;
        private System.Windows.Forms.Label Label_Lx;
        private System.Windows.Forms.Label Label_A;
        private System.Windows.Forms.Label Label_Tau;
        private System.Windows.Forms.Label Label_Hy;
        private System.Windows.Forms.Label Label_Hx;
        private System.Windows.Forms.Label Label_Lamda;
        private System.Windows.Forms.TextBox TB_Lx;
        private System.Windows.Forms.TextBox TB_Ly;
        private System.Windows.Forms.TextBox TB_Lamda;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.TextBox TB_Tau;
        private System.Windows.Forms.TextBox TB_Hy;
        private System.Windows.Forms.TextBox TB_Hx;
        private System.Windows.Forms.GroupBox GB_Second;
        private System.Windows.Forms.GroupBox GB_Third;
        private System.Windows.Forms.Label Label_Q1;
        private System.Windows.Forms.TextBox TB_Q4;
        private System.Windows.Forms.TextBox TB_Q3;
        private System.Windows.Forms.TextBox TB_Q2;
        private System.Windows.Forms.TextBox TB_Q1;
        private System.Windows.Forms.Label Label_Q4;
        private System.Windows.Forms.Label Label_Q3;
        private System.Windows.Forms.Label Label_Q2;
        private System.Windows.Forms.Label Label_Tout1;
        private System.Windows.Forms.Label Label_Tout4;
        private System.Windows.Forms.Label Label_Tout3;
        private System.Windows.Forms.Label Label_Tout2;
        private System.Windows.Forms.TextBox TB_Tout4;
        private System.Windows.Forms.TextBox TB_Tout3;
        private System.Windows.Forms.TextBox TB_Tout2;
        private System.Windows.Forms.TextBox TB_Tout1;
        private System.Windows.Forms.Label Label_Alpha4;
        private System.Windows.Forms.Label Label_Alpha3;
        private System.Windows.Forms.Label Label_Alpha2;
        private System.Windows.Forms.Label Label_Alpha1;
        private System.Windows.Forms.TextBox TB_Alpha4;
        private System.Windows.Forms.TextBox TB_Alpha3;
        private System.Windows.Forms.TextBox TB_Alpha2;
        private System.Windows.Forms.TextBox TB_Alpha1;
        private System.Windows.Forms.GroupBox GB_First;
        private System.Windows.Forms.TextBox TB_T4;
        private System.Windows.Forms.TextBox TB_T3;
        private System.Windows.Forms.TextBox TB_T2;
        private System.Windows.Forms.TextBox TB_T1;
        private System.Windows.Forms.Label Label_T4;
        private System.Windows.Forms.Label Label_T3;
        private System.Windows.Forms.Label Label_T2;
        private System.Windows.Forms.Label Label_T1;
        private System.Windows.Forms.TextBox TB_MaxTemp;
        private System.Windows.Forms.TextBox TB_MinTemp;
        private System.Windows.Forms.Label Label_MaxTemp;
        private System.Windows.Forms.Label Label_MinTemp;
        private System.Windows.Forms.CheckBox Check_SaveFile;
        private System.Windows.Forms.Button Btn_CalcToLast;
        private System.Windows.Forms.TextBox TB_LastIteration;
        private System.Windows.Forms.Label Label_LastIteration;
    }
}

