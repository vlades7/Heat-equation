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
            this.BTN_TEST = new System.Windows.Forms.Button();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.Rtb_Result = new System.Windows.Forms.RichTextBox();
            this.CB_TypeBorders = new System.Windows.Forms.ComboBox();
            this.ParamsPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParamsPanel
            // 
            this.ParamsPanel.Controls.Add(this.CB_TypeBorders);
            this.ParamsPanel.Controls.Add(this.BTN_TEST);
            this.ParamsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ParamsPanel.Location = new System.Drawing.Point(0, 0);
            this.ParamsPanel.Name = "ParamsPanel";
            this.ParamsPanel.Size = new System.Drawing.Size(279, 552);
            this.ParamsPanel.TabIndex = 0;
            // 
            // BTN_TEST
            // 
            this.BTN_TEST.Location = new System.Drawing.Point(36, 213);
            this.BTN_TEST.Name = "BTN_TEST";
            this.BTN_TEST.Size = new System.Drawing.Size(197, 210);
            this.BTN_TEST.TabIndex = 0;
            this.BTN_TEST.Text = "TEST";
            this.BTN_TEST.UseVisualStyleBackColor = true;
            this.BTN_TEST.Click += new System.EventHandler(this.BTN_TEST_Click);
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.Rtb_Result);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(279, 0);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(742, 552);
            this.OutputPanel.TabIndex = 1;
            // 
            // Rtb_Result
            // 
            this.Rtb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_Result.Location = new System.Drawing.Point(0, 0);
            this.Rtb_Result.Name = "Rtb_Result";
            this.Rtb_Result.Size = new System.Drawing.Size(742, 552);
            this.Rtb_Result.TabIndex = 0;
            this.Rtb_Result.Text = "";
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
            this.CB_TypeBorders.Location = new System.Drawing.Point(36, 57);
            this.CB_TypeBorders.Name = "CB_TypeBorders";
            this.CB_TypeBorders.Size = new System.Drawing.Size(197, 26);
            this.CB_TypeBorders.TabIndex = 1;
            this.CB_TypeBorders.SelectedIndexChanged += new System.EventHandler(this.CB_TypeBorders_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 552);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.ParamsPanel);
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
    }
}

