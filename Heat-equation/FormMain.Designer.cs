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
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.Rtb_Result = new System.Windows.Forms.RichTextBox();
            this.BTN_TEST = new System.Windows.Forms.Button();
            this.ParamsPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParamsPanel
            // 
            this.ParamsPanel.Controls.Add(this.BTN_TEST);
            this.ParamsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ParamsPanel.Location = new System.Drawing.Point(0, 0);
            this.ParamsPanel.Name = "ParamsPanel";
            this.ParamsPanel.Size = new System.Drawing.Size(279, 552);
            this.ParamsPanel.TabIndex = 0;
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
        private System.Windows.Forms.RichTextBox Rtb_Result;
        private System.Windows.Forms.Button BTN_TEST;
    }
}

