namespace WinFormsApp3
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
            Label label3;
            btn_qs = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_ms = new Button();
            btn_si = new Button();
            btn_ss = new Button();
            btn_sb = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 277);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            label3.Click += label3_Click;
            // 
            // btn_qs
            // 
            btn_qs.Location = new Point(642, 346);
            btn_qs.Name = "btn_qs";
            btn_qs.Size = new Size(94, 29);
            btn_qs.TabIndex = 0;
            btn_qs.Text = "SQ";
            btn_qs.UseVisualStyleBackColor = true;
            btn_qs.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btn_ms
            // 
            btn_ms.Location = new Point(497, 346);
            btn_ms.Name = "btn_ms";
            btn_ms.Size = new Size(94, 29);
            btn_ms.TabIndex = 3;
            btn_ms.Text = "SM";
            btn_ms.UseVisualStyleBackColor = true;
            btn_ms.Click += button1_Click_1;
            // 
            // btn_si
            // 
            btn_si.Location = new Point(357, 346);
            btn_si.Name = "btn_si";
            btn_si.Size = new Size(94, 29);
            btn_si.TabIndex = 4;
            btn_si.Text = "SI";
            btn_si.UseVisualStyleBackColor = true;
            btn_si.Click += btn_si_Click;
            // 
            // btn_ss
            // 
            btn_ss.Location = new Point(216, 346);
            btn_ss.Name = "btn_ss";
            btn_ss.Size = new Size(94, 29);
            btn_ss.TabIndex = 5;
            btn_ss.Text = "SS";
            btn_ss.UseVisualStyleBackColor = true;
            btn_ss.Click += btn_ss_Click;
            // 
            // btn_sb
            // 
            btn_sb.Location = new Point(74, 346);
            btn_sb.Name = "btn_sb";
            btn_sb.Size = new Size(94, 29);
            btn_sb.TabIndex = 6;
            btn_sb.Text = "SB";
            btn_sb.UseVisualStyleBackColor = true;
            btn_sb.Click += button1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 215);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 7;
            label1.Text = "czas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 215);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "wynik:";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(541, 215);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 10;
            label4.Text = "...";
            label4.Click += label4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(605, 56);
            numericUpDown1.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 150000, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(635, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "generuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(456, 58);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_sb);
            Controls.Add(btn_ss);
            Controls.Add(btn_si);
            Controls.Add(btn_ms);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_qs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_qs;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_ms;
        private Button btn_si;
        private Button btn_ss;
        private Button btn_sb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private CheckBox checkBox1;
    }
}