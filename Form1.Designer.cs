namespace CalculaterProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtCalculation = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnx = new Button();
            bnt4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btny = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnz = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();

            // txtCalculation
            txtCalculation.Location = new Point(12, 12);
            txtCalculation.Multiline = true;
            txtCalculation.Name = "txtCalculation";
            txtCalculation.Size = new Size(564, 141);
            txtCalculation.TabIndex = 0;

            // btn1
            btn1.Location = new Point(37, 216);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;

            // btn2
            btn2.Location = new Point(174, 216);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;

            // btn3
            btn3.Location = new Point(320, 216);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;

            // btnx (+)
            btnx.Location = new Point(471, 216);
            btnx.Name = "btnx";
            btnx.Size = new Size(94, 29);
            btnx.Text = "+";
            btnx.UseVisualStyleBackColor = true;
            btnx.Click += btnx_Click;

            // bnt4
            bnt4.Location = new Point(37, 277);
            bnt4.Name = "bnt4";
            bnt4.Size = new Size(94, 29);
            bnt4.Text = "4";
            bnt4.UseVisualStyleBackColor = true;
            bnt4.Click += bnt4_Click;

            // btn5
            btn5.Location = new Point(174, 277);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 29);
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;

            // btn6
            btn6.Location = new Point(320, 289);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 29);
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;

            // btny (-)
            btny.Location = new Point(471, 289);
            btny.Name = "btny";
            btny.Size = new Size(94, 29);
            btny.Text = "-";
            btny.UseVisualStyleBackColor = true;
            btny.Click += btny_Click;

            // btn7
            btn7.Location = new Point(37, 336);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 29);
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;

            // btn8
            btn8.Location = new Point(174, 336);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 29);
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;

            // btn9
            btn9.Location = new Point(320, 336);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 29);
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;

            // btnz (*)
            btnz.Location = new Point(471, 345);
            btnz.Name = "btnz";
            btnz.Size = new Size(94, 29);
            btnz.Text = "*";
            btnz.UseVisualStyleBackColor = true;
            btnz.Click += btnz_Click;

            // button1 (/)
            button1.Location = new Point(37, 395);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.Text = "/";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // button2 (.)
            button2.Location = new Point(320, 400);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.Text = ".";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            // button3 (%)
            button3.Location = new Point(174, 395);
            button3.Size = new Size(94, 34);
            button3.Text = "%";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;

            // button4 (^)
            button4.Location = new Point(471, 410);
            button4.Size = new Size(94, 29);
            button4.Text = "^";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;

            // button5 (!)
            button5.Location = new Point(37, 461);
            button5.Size = new Size(94, 29);
            button5.Text = "!";
            button5.UseVisualStyleBackColor = true;

            // button6 (:)
            button6.Location = new Point(174, 461);
            button6.Size = new Size(94, 29);
            button6.Text = ":";
            button6.UseVisualStyleBackColor = true;

            // button7 (0)
            button7.Location = new Point(320, 471);
            button7.Size = new Size(94, 29);
            button7.Text = "0";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;

            // button8 (=)
            button8.Location = new Point(471, 471);
            button8.Size = new Size(94, 29);
            button8.Text = "=";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;

            // Form1
            ClientSize = new Size(588, 523);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnz);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btny);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(bnt4);
            Controls.Add(btnx);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtCalculation);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalculation;
        private Button btn1, btn2, btn3, btnx, bnt4, btn5, btn6, btny, btn7, btn8, btn9, btnz;
        private Button button1, button2, button3, button4, button5, button6, button7, button8;
    }
}
