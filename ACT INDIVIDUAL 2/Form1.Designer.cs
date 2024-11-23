namespace ACT_INDIVIDUAL_2
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 43);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 0;
            label1.Text = "Hello, Mundo!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(181, 23);
            label2.TabIndex = 1;
            label2.Text = "Cual es tu nombre?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 234);
            label3.Name = "label3";
            label3.Size = new Size(210, 23);
            label3.TabIndex = 2;
            label3.Text = "Hello, alguien especial!";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(113, 288);
            button1.Name = "button1";
            button1.Size = new Size(174, 34);
            button1.TabIndex = 3;
            button1.Text = "Diga \"Hello\"";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(45, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
    }
}
