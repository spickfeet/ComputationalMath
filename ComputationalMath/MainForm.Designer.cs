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
            richTextBoxIntermediateValues = new RichTextBox();
            SuspendLayout();
            // 
            // c
            // 
            c.Font = new Font("Segoe UI", 16F);
            c.Location = new Point(10, 190);
            c.Margin = new Padding(3, 2, 3, 2);
            c.Name = "c";
            c.Size = new Size(349, 38);
            c.TabIndex = 0;
            c.Text = "Найти";
            c.UseVisualStyleBackColor = true;
            c.Click += ButtonFind_Click;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Font = new Font("Segoe UI", 15F);
            richTextBoxResult.Location = new Point(365, 86);
            richTextBoxResult.Margin = new Padding(3, 2, 3, 2);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(356, 143);
            richTextBoxResult.TabIndex = 1;
            richTextBoxResult.Text = "";
            // 
            // comboBoxFunction
            // 
            comboBoxFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFunction.Font = new Font("Segoe UI", 16F);
            comboBoxFunction.FormattingEnabled = true;
            comboBoxFunction.Items.AddRange(new object[] { "f(x) = x^2 - 20sin (x) - 5", "f(x) = 100x^2 - 10000x - 1" });
            comboBoxFunction.Location = new Point(10, 86);
            comboBoxFunction.Margin = new Padding(3, 2, 3, 2);
            comboBoxFunction.Name = "comboBoxFunction";
            comboBoxFunction.Size = new Size(350, 38);
            comboBoxFunction.TabIndex = 3;
            // 
            // comboBoxMethod
            // 
            comboBoxMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMethod.Font = new Font("Segoe UI", 16F);
            comboBoxMethod.FormattingEnabled = true;
            comboBoxMethod.Items.AddRange(new object[] { "Метод простых итераций", "Метод Ньютона", "Метод половинного деления" });
            comboBoxMethod.Location = new Point(10, 152);
            comboBoxMethod.Margin = new Padding(3, 2, 3, 2);
            comboBoxMethod.Name = "comboBoxMethod";
            comboBoxMethod.Size = new Size(350, 38);
            comboBoxMethod.TabIndex = 4;
            // 
            // labelFunction
            // 
            labelFunction.AutoSize = true;
            labelFunction.Font = new Font("Segoe UI", 16F);
            labelFunction.Location = new Point(21, 56);
            labelFunction.Name = "labelFunction";
            labelFunction.Size = new Size(101, 30);
            labelFunction.TabIndex = 5;
            labelFunction.Text = "Функция";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(21, 122);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 6;
            label1.Text = "Метод";
            // 
            // richTextBoxIntermediateValues
            // 
            richTextBoxIntermediateValues.Font = new Font("Segoe UI", 15F);
            richTextBoxIntermediateValues.Location = new Point(365, 233);
            richTextBoxIntermediateValues.Margin = new Padding(3, 2, 3, 2);
            richTextBoxIntermediateValues.Name = "richTextBoxIntermediateValues";
            richTextBoxIntermediateValues.Size = new Size(356, 143);
            richTextBoxIntermediateValues.TabIndex = 7;
            richTextBoxIntermediateValues.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(731, 450);
            Controls.Add(richTextBoxIntermediateValues);
            Controls.Add(label1);
            Controls.Add(labelFunction);
            Controls.Add(comboBoxMethod);
            Controls.Add(comboBoxFunction);
            Controls.Add(richTextBoxResult);
            Controls.Add(c);
            Margin = new Padding(3, 2, 3, 2);
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
        private RichTextBox richTextBoxIntermediateValues;
    }
}
