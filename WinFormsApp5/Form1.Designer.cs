namespace WinFormsApp5
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
            pictureBox1 = new PictureBox();
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 544);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay.Location = new Point(52, 87);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(389, 43);
            txtDisplay.TabIndex = 1;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(52, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 47);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonAll;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(133, 136);
            button2.Name = "button2";
            button2.Size = new Size(80, 47);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonAll;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(219, 136);
            button3.Name = "button3";
            button3.Size = new Size(79, 47);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonAll;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(52, 185);
            button4.Name = "button4";
            button4.Size = new Size(75, 43);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonAll;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(133, 185);
            button5.Name = "button5";
            button5.Size = new Size(80, 43);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonAll;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(219, 185);
            button6.Name = "button6";
            button6.Size = new Size(79, 43);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonAll;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(52, 234);
            button7.Name = "button7";
            button7.Size = new Size(75, 39);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonAll;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(133, 234);
            button8.Name = "button8";
            button8.Size = new Size(80, 39);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonAll;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(219, 234);
            button9.Name = "button9";
            button9.Size = new Size(79, 39);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonAll;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(52, 279);
            button10.Name = "button10";
            button10.Size = new Size(246, 39);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ButtonAll;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(304, 141);
            button11.Name = "button11";
            button11.Size = new Size(137, 37);
            button11.TabIndex = 12;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(304, 189);
            button12.Name = "button12";
            button12.Size = new Size(137, 39);
            button12.TabIndex = 13;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(304, 234);
            button13.Name = "button13";
            button13.Size = new Size(137, 39);
            button13.TabIndex = 14;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(304, 279);
            button14.Name = "button14";
            button14.Size = new Size(137, 39);
            button14.TabIndex = 15;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(257, 319);
            button15.Name = "button15";
            button15.Size = new Size(184, 137);
            button15.TabIndex = 16;
            button15.Text = "Clear";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(52, 319);
            button16.Name = "button16";
            button16.Size = new Size(199, 137);
            button16.TabIndex = 17;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 544);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Controls.Add(pictureBox1);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}