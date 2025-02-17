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
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            btnCong = new Button();
            lblKQ = new Label();
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
            // txtSoA
            // 
            txtSoA.Location = new Point(250, 135);
            txtSoA.Name = "txtSoA";
            txtSoA.Size = new Size(175, 27);
            txtSoA.TabIndex = 2;
            txtSoA.TextChanged += textBox1_TextChanged;
            // 
            // txtSoB
            // 
            txtSoB.Location = new Point(250, 195);
            txtSoB.Name = "txtSoB";
            txtSoB.Size = new Size(175, 27);
            txtSoB.TabIndex = 2;
            txtSoB.TextChanged += textBox1_TextChanged;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(577, 181);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(94, 29);
            btnCong.TabIndex = 3;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(304, 293);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(63, 20);
            lblKQ.TabIndex = 4;
            lblKQ.Text = "Kết quả:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKQ);
            Controls.Add(btnCong);
            Controls.Add(txtSoB);
            Controls.Add(txtSoA);
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
        private TextBox txtSoA;
        private TextBox txtSoB;
        private Button btnCong;
        private Label lblKQ;
    }
}
