namespace Calc
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            panel1 = new Panel();
            panel2 = new Panel();
            btn_Factorial = new Button();
            btn_Dot = new Button();
            btn_RemoveAll = new Button();
            button0 = new Button();
            btn_Equal = new Button();
            btn_Multiply = new Button();
            btn_Divide = new Button();
            btn_Minus = new Button();
            btn_Plus = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            calcDisplay = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(calcDisplay);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 459);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Factorial);
            panel2.Controls.Add(btn_Dot);
            panel2.Controls.Add(btn_RemoveAll);
            panel2.Controls.Add(button0);
            panel2.Controls.Add(btn_Equal);
            panel2.Controls.Add(btn_Multiply);
            panel2.Controls.Add(btn_Divide);
            panel2.Controls.Add(btn_Minus);
            panel2.Controls.Add(btn_Plus);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 391);
            panel2.TabIndex = 2;
            // 
            // btn_Factorial
            // 
            btn_Factorial.FlatAppearance.BorderColor = Color.White;
            btn_Factorial.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Factorial.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Factorial.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Factorial.Location = new Point(3, 10);
            btn_Factorial.Name = "btn_Factorial";
            btn_Factorial.Size = new Size(156, 45);
            btn_Factorial.TabIndex = 19;
            btn_Factorial.Text = "!";
            btn_Factorial.UseVisualStyleBackColor = true;
            btn_Factorial.Click += btn_Factorial_Click;
            // 
            // btn_Dot
            // 
            btn_Dot.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Dot.Location = new Point(3, 304);
            btn_Dot.Name = "btn_Dot";
            btn_Dot.Size = new Size(75, 75);
            btn_Dot.TabIndex = 18;
            btn_Dot.Text = ",";
            btn_Dot.UseVisualStyleBackColor = true;
            btn_Dot.Click += btn_Dot_Click;
            // 
            // btn_RemoveAll
            // 
            btn_RemoveAll.Font = new Font("Unispace", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RemoveAll.Location = new Point(165, 10);
            btn_RemoveAll.Name = "btn_RemoveAll";
            btn_RemoveAll.Size = new Size(156, 45);
            btn_RemoveAll.TabIndex = 16;
            btn_RemoveAll.Text = "C";
            btn_RemoveAll.UseVisualStyleBackColor = true;
            btn_RemoveAll.Click += RemoveAll_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(84, 304);
            button0.Name = "button0";
            button0.Size = new Size(75, 75);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // btn_Equal
            // 
            btn_Equal.FlatAppearance.BorderColor = Color.White;
            btn_Equal.FlatAppearance.BorderSize = 7;
            btn_Equal.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btn_Equal.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btn_Equal.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Equal.Location = new Point(165, 304);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(156, 75);
            btn_Equal.TabIndex = 14;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            btn_Equal.Click += btn_Equal_Click;
            // 
            // btn_Multiply
            // 
            btn_Multiply.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Multiply.Location = new Point(246, 241);
            btn_Multiply.Name = "btn_Multiply";
            btn_Multiply.Size = new Size(75, 50);
            btn_Multiply.TabIndex = 13;
            btn_Multiply.Text = "*";
            btn_Multiply.UseVisualStyleBackColor = true;
            btn_Multiply.Click += btn_Multiply_Click;
            // 
            // btn_Divide
            // 
            btn_Divide.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Divide.Location = new Point(246, 185);
            btn_Divide.Name = "btn_Divide";
            btn_Divide.Size = new Size(75, 50);
            btn_Divide.TabIndex = 12;
            btn_Divide.Text = "/";
            btn_Divide.UseVisualStyleBackColor = true;
            btn_Divide.Click += btn_Divide_Click;
            // 
            // btn_Minus
            // 
            btn_Minus.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Minus.Location = new Point(246, 129);
            btn_Minus.Name = "btn_Minus";
            btn_Minus.Size = new Size(75, 50);
            btn_Minus.TabIndex = 11;
            btn_Minus.Text = "-";
            btn_Minus.UseVisualStyleBackColor = true;
            btn_Minus.Click += btn_Minus_Click;
            // 
            // btn_Plus
            // 
            btn_Plus.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Plus.Location = new Point(246, 73);
            btn_Plus.Name = "btn_Plus";
            btn_Plus.Size = new Size(75, 50);
            btn_Plus.TabIndex = 10;
            btn_Plus.Text = "+";
            btn_Plus.UseVisualStyleBackColor = true;
            btn_Plus.Click += btn_Plus_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(3, 223);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(84, 223);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(165, 223);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(3, 142);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(84, 142);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(165, 142);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(165, 61);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(84, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Unispace", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // calcDisplay
            // 
            calcDisplay.AutoWordSelection = true;
            calcDisplay.Font = new Font("Unispace", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            calcDisplay.Location = new Point(3, 3);
            calcDisplay.Name = "calcDisplay";
            calcDisplay.ReadOnly = true;
            calcDisplay.ScrollBars = RichTextBoxScrollBars.None;
            calcDisplay.Size = new Size(321, 66);
            calcDisplay.TabIndex = 0;
            calcDisplay.Text = "0";
            // 
            // Calculator
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(352, 481);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculator";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculatur";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private RichTextBox calcDisplay;
        private Button button0;
        private Button btn_Equal;
        private Button btn_Multiply;
        private Button btn_Divide;
        private Button btn_Minus;
        private Button btn_Plus;
        private Button btn_RemoveAll;
        private Button btn_Dot;
        private Button btn_Factorial;
    }
}