namespace CalculatorPon
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
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
            textBox1 = new TextBox();
            button17 = new Button();
            button18 = new Button();
            textBox2 = new TextBox();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(4, 178);
            button2.Name = "button2";
            button2.Size = new Size(87, 26);
            button2.TabIndex = 1;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButtonClick;
            // 
            // button3
            // 
            button3.Location = new Point(50, 149);
            button3.Name = "button3";
            button3.Size = new Size(41, 23);
            button3.TabIndex = 2;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButtonClick;
            // 
            // button4
            // 
            button4.Location = new Point(4, 149);
            button4.Name = "button4";
            button4.Size = new Size(40, 23);
            button4.TabIndex = 3;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(97, 149);
            button5.Name = "button5";
            button5.Size = new Size(45, 23);
            button5.TabIndex = 4;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButtonClick;
            // 
            // button6
            // 
            button6.Location = new Point(4, 120);
            button6.Name = "button6";
            button6.Size = new Size(40, 23);
            button6.TabIndex = 5;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButtonClick;
            // 
            // button1
            // 
            button1.Location = new Point(50, 92);
            button1.Name = "button1";
            button1.Size = new Size(41, 23);
            button1.TabIndex = 6;
            button1.Text = "8";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButtonClick;
            // 
            // button7
            // 
            button7.Location = new Point(4, 92);
            button7.Name = "button7";
            button7.Size = new Size(40, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButtonClick;
            // 
            // button8
            // 
            button8.Location = new Point(97, 92);
            button8.Name = "button8";
            button8.Size = new Size(45, 23);
            button8.TabIndex = 8;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButtonClick;
            // 
            // button9
            // 
            button9.Location = new Point(97, 120);
            button9.Name = "button9";
            button9.Size = new Size(45, 23);
            button9.TabIndex = 9;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButtonClick;
            // 
            // button10
            // 
            button10.Location = new Point(50, 120);
            button10.Name = "button10";
            button10.Size = new Size(41, 23);
            button10.TabIndex = 10;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButtonClick;
            // 
            // button11
            // 
            button11.Location = new Point(97, 178);
            button11.Name = "button11";
            button11.Size = new Size(45, 26);
            button11.TabIndex = 11;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += DotButtonClick;
            // 
            // button12
            // 
            button12.Location = new Point(148, 149);
            button12.Name = "button12";
            button12.Size = new Size(33, 26);
            button12.TabIndex = 12;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += OpertionButtonClick;
            // 
            // button13
            // 
            button13.Location = new Point(148, 120);
            button13.Name = "button13";
            button13.Size = new Size(33, 26);
            button13.TabIndex = 13;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += OpertionButtonClick;
            // 
            // button14
            // 
            button14.Location = new Point(186, 149);
            button14.Name = "button14";
            button14.Size = new Size(33, 55);
            button14.TabIndex = 14;
            button14.Text = "=";
            button14.UseVisualStyleBackColor = true;
            button14.Click += ResultButtonClick;
            // 
            // button15
            // 
            button15.Location = new Point(148, 92);
            button15.Name = "button15";
            button15.Size = new Size(33, 26);
            button15.TabIndex = 15;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            button15.Click += OpertionButtonClick;
            // 
            // button16
            // 
            button16.Location = new Point(148, 178);
            button16.Name = "button16";
            button16.Size = new Size(33, 26);
            button16.TabIndex = 16;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = true;
            button16.Click += OpertionButtonClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox1.Location = new Point(4, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 34);
            textBox1.TabIndex = 17;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button17
            // 
            button17.Location = new Point(186, 120);
            button17.Name = "button17";
            button17.Size = new Size(33, 26);
            button17.TabIndex = 18;
            button17.Text = "%";
            button17.UseVisualStyleBackColor = true;
            button17.Click += OpertionButtonClick;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button18.Location = new Point(64, 1);
            button18.Name = "button18";
            button18.Size = new Size(133, 45);
            button18.TabIndex = 19;
            button18.Text = "Dota 3";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 23);
            textBox2.TabIndex = 20;
            // 
            // button19
            // 
            button19.Location = new Point(186, 92);
            button19.Name = "button19";
            button19.Size = new Size(33, 26);
            button19.TabIndex = 21;
            button19.Text = "^";
            button19.UseVisualStyleBackColor = true;
            button19.Click += OpertionButtonClick;
            // 
            // button20
            // 
            button20.Location = new Point(187, 52);
            button20.Name = "button20";
            button20.Size = new Size(56, 34);
            button20.TabIndex = 22;
            button20.Text = "<---";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.Location = new Point(225, 92);
            button21.Name = "button21";
            button21.Size = new Size(33, 26);
            button21.TabIndex = 23;
            button21.Text = "√";
            button21.UseVisualStyleBackColor = true;
            button21.Click += OpertionButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 645);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(textBox2);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(textBox1);
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
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += OpertionButtonClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
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
        private TextBox textBox1;
        private Button button17;
        private Button button18;
        private TextBox textBox2;
        private Button button19;
        private Button button20;
        private Button button21;
    }
}
