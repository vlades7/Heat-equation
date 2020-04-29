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
            this.components = new System.ComponentModel.Container();
            this.ParamsPanel = new System.Windows.Forms.Panel();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.CB_TypeBorders = new System.Windows.Forms.ComboBox();
            this.BTN_TEST = new System.Windows.Forms.Button();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.Rtb_Result = new System.Windows.Forms.RichTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Btn_Visualization = new System.Windows.Forms.Button();
            this.ParamsPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParamsPanel
            // 
            this.ParamsPanel.Controls.Add(this.Btn_Visualization);
            this.ParamsPanel.Controls.Add(this.Btn_Start);
            this.ParamsPanel.Controls.Add(this.CB_TypeBorders);
            this.ParamsPanel.Controls.Add(this.BTN_TEST);
            this.ParamsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ParamsPanel.Location = new System.Drawing.Point(0, 0);
            this.ParamsPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ParamsPanel.Name = "ParamsPanel";
            this.ParamsPanel.Size = new System.Drawing.Size(291, 410);
            this.ParamsPanel.TabIndex = 0;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(40, 143);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(145, 41);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "START";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // CB_TypeBorders
            // 
            this.CB_TypeBorders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TypeBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_TypeBorders.FormattingEnabled = true;
            this.CB_TypeBorders.Items.AddRange(new object[] {
            "Границы 1-го рода",
            "Границы 2-го рода",
            "Границы 3-го рода"});
            this.CB_TypeBorders.Location = new System.Drawing.Point(40, 14);
            this.CB_TypeBorders.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CB_TypeBorders.Name = "CB_TypeBorders";
            this.CB_TypeBorders.Size = new System.Drawing.Size(221, 26);
            this.CB_TypeBorders.TabIndex = 1;
            this.CB_TypeBorders.SelectedIndexChanged += new System.EventHandler(this.CB_TypeBorders_SelectedIndexChanged);
            // 
            // BTN_TEST
            // 
            this.BTN_TEST.Location = new System.Drawing.Point(40, 71);
            this.BTN_TEST.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_TEST.Name = "BTN_TEST";
            this.BTN_TEST.Size = new System.Drawing.Size(145, 41);
            this.BTN_TEST.TabIndex = 0;
            this.BTN_TEST.Text = "TEST";
            this.BTN_TEST.UseVisualStyleBackColor = true;
            this.BTN_TEST.Click += new System.EventHandler(this.BTN_TEST_Click);
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.Rtb_Result);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(291, 0);
            this.OutputPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(602, 410);
            this.OutputPanel.TabIndex = 1;
            // 
            // Rtb_Result
            // 
            this.Rtb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rtb_Result.Location = new System.Drawing.Point(0, 0);
            this.Rtb_Result.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Rtb_Result.Name = "Rtb_Result";
            this.Rtb_Result.Size = new System.Drawing.Size(602, 410);
            this.Rtb_Result.TabIndex = 0;
            this.Rtb_Result.Text = "";
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Btn_Visualization
            // 
            this.Btn_Visualization.Location = new System.Drawing.Point(40, 266);
            this.Btn_Visualization.Name = "Btn_Visualization";
            this.Btn_Visualization.Size = new System.Drawing.Size(145, 41);
            this.Btn_Visualization.TabIndex = 3;
            this.Btn_Visualization.Text = "Vizualization";
            this.Btn_Visualization.UseVisualStyleBackColor = true;
            this.Btn_Visualization.Click += new System.EventHandler(this.Btn_Visualization_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 410);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.ParamsPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уравнение теплопроводности";
            this.ParamsPanel.ResumeLayout(false);
            this.OutputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParamsPanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Button BTN_TEST;
        public System.Windows.Forms.RichTextBox Rtb_Result;
        private System.Windows.Forms.ComboBox CB_TypeBorders;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Visualization;
    }
}

