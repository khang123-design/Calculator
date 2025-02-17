namespace Calculator
{
    partial class Form1
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
            lbl_31_Khang = new Label();
            lblSoA_31_Khang = new Label();
            lblSoB = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lbl_31_Khang
            // 
            lbl_31_Khang.Dock = DockStyle.Top;
            lbl_31_Khang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_31_Khang.Location = new Point(0, 0);
            lbl_31_Khang.Name = "lbl_31_Khang";
            lbl_31_Khang.Size = new Size(800, 31);
            lbl_31_Khang.TabIndex = 0;
            lbl_31_Khang.Text = "Tính Toán";
            lbl_31_Khang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoA_31_Khang
            // 
            lblSoA_31_Khang.AutoSize = true;
            lblSoA_31_Khang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoA_31_Khang.Location = new Point(153, 131);
            lblSoA_31_Khang.Name = "lblSoA_31_Khang";
            lblSoA_31_Khang.Size = new Size(60, 28);
            lblSoA_31_Khang.TabIndex = 1;
            lblSoA_31_Khang.Text = "Số A:";
            lblSoA_31_Khang.Click += lblSoA_31_Khang_Click;
            // 
            // lblSoB
            // 
            lblSoB.AutoSize = true;
            lblSoB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoB.Location = new Point(153, 194);
            lblSoB.Name = "lblSoB";
            lblSoB.Size = new Size(59, 28);
            lblSoB.TabIndex = 1;
            lblSoB.Text = "Số B:";
            lblSoB.Click += lblSoA_31_Khang_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblSoB);
            Controls.Add(lblSoA_31_Khang);
            Controls.Add(lbl_31_Khang);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_31_Khang;
        private Label lblSoA_31_Khang;
        private Label lblSoB;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
