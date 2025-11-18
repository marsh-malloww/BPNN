namespace BPNN
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            button5 = new Button();
            button8 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(58, 12);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 68);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 5;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(58, 124);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 6;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(58, 180);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 7;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(188, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 36);
            textBox3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 87);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 11;
            label1.Text = "Output";
            // 
            // button6
            // 
            button6.Location = new Point(58, 247);
            button6.Name = "button6";
            button6.Size = new Size(100, 50);
            button6.TabIndex = 15;
            button6.Text = "Train";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(58, 317);
            button7.Name = "button7";
            button7.Size = new Size(230, 50);
            button7.TabIndex = 16;
            button7.Text = "Test";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Location = new Point(228, 12);
            button5.Name = "button5";
            button5.Size = new Size(60, 24);
            button5.TabIndex = 17;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.Location = new Point(188, 247);
            button8.Name = "button8";
            button8.Size = new Size(100, 50);
            button8.TabIndex = 18;
            button8.Text = "Reset and Train";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 144);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 19;
            label2.Text = "Rounded off";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 379);
            Controls.Add(label2);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "BPNN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Label label1;
        private Button button6;
        private Button button7;
        private Button button5;
        private Button button8;
        private Label label2;
    }
}
