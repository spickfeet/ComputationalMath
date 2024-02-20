namespace ComputationalMath
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            c = new Button();
            richTextBoxResult = new RichTextBox();
            comboBoxFunction = new ComboBox();
            comboBoxMethod = new ComboBox();
            labelFunction = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // c
            // 
            c.Font = new Font("Segoe UI", 16F);
            c.Location = new Point(12, 254);
            c.Name = "c";
            c.Size = new Size(399, 50);
            c.TabIndex = 0;
            c.Text = "Найти";
            c.UseVisualStyleBackColor = true;
            c.Click += ButtonFind_Click;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Font = new Font("Segoe UI", 10F);
            richTextBoxResult.Location = new Point(417, 115);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(406, 189);
            richTextBoxResult.TabIndex = 1;
            richTextBoxResult.Text = "";
            // 
            // comboBoxFunction
            // 
            comboBoxFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFunction.Font = new Font("Segoe UI", 16F);
            comboBoxFunction.FormattingEnabled = true;
            comboBoxFunction.Items.AddRange(new object[] { "f(x) = x^2 - 20sin (x) - 5", "f(x) = 100x^2 - 10000x - 1" });
            comboBoxFunction.Location = new Point(12, 115);
            comboBoxFunction.Name = "comboBoxFunction";
            comboBoxFunction.Size = new Size(399, 45);
            comboBoxFunction.TabIndex = 3;
            // 
            // comboBoxMethod
            // 
            comboBoxMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMethod.Font = new Font("Segoe UI", 16F);
            comboBoxMethod.FormattingEnabled = true;
            comboBoxMethod.Items.AddRange(new object[] { "Метод простых итераций", "Метод Ньютона", "Метод половинного деления" });
            comboBoxMethod.Location = new Point(12, 203);
            comboBoxMethod.Name = "comboBoxMethod";
            comboBoxMethod.Size = new Size(399, 45);
            comboBoxMethod.TabIndex = 4;
            // 
            // labelFunction
            // 
            labelFunction.AutoSize = true;
            labelFunction.Font = new Font("Segoe UI", 16F);
            labelFunction.Location = new Point(24, 75);
            labelFunction.Name = "labelFunction";
            labelFunction.Size = new Size(125, 37);
            labelFunction.TabIndex = 5;
            labelFunction.Text = "Функция";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(24, 163);
            label1.Name = "label1";
            label1.Size = new Size(97, 37);
            label1.TabIndex = 6;
            label1.Text = "Метод";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(835, 402);
            Controls.Add(label1);
            Controls.Add(labelFunction);
            Controls.Add(comboBoxMethod);
            Controls.Add(comboBoxFunction);
            Controls.Add(richTextBoxResult);
            Controls.Add(c);
            Name = "MainForm";
            Text = "SolvingEquations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button c;
        private RichTextBox richTextBoxResult;
        private ComboBox comboBoxFunction;
        private ComboBox comboBoxMethod;
        private Label labelFunction;
        private Label label1;
    }
}
