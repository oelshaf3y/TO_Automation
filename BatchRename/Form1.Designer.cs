namespace BatchRename
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button5 = new Button();
            button6 = new Button();
            checkBox1 = new CheckBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 4);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter Files By Extension";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(336, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 310);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(28, 409);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 4;
            button2.Text = "Select All Listed";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(232, 409);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 5;
            button3.Text = "Select None";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(863, 9);
            label2.Name = "label2";
            label2.Size = new Size(369, 60);
            label2.TabIndex = 6;
            label2.Text = "This is a simple find and replace action. so, in order to \r\nbatch rename the files listed in this folder you can find\r\n the most reoccuring centense and replace it";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(863, 111);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 7;
            label3.Text = "Find What?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(863, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(863, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 27);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(863, 178);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 9;
            label4.Text = "Replace With";
            // 
            // button4
            // 
            button4.Location = new Point(1138, 266);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Rename";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(863, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 27);
            textBox4.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(863, 312);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 14;
            label5.Text = "Suffix";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(863, 335);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 27);
            textBox5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(863, 245);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 12;
            label6.Text = "Prefix";
            // 
            // button5
            // 
            button5.Location = new Point(1138, 323);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 16;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(624, 27);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 17;
            button6.Text = "Browse";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(859, 377);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Copy new names to Clipboard?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1118, 421);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 19;
            label7.Text = "© Omar Elshafey | 2024";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button5;
            ClientSize = new Size(1330, 450);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Batch Rename";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Button button4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button5;
        private Button button6;
        private CheckBox checkBox1;
        private Label label7;
    }
}
