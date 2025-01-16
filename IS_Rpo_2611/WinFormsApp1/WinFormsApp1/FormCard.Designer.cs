namespace WinFormsApp1
{
    partial class FormCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(592, 409);
            button1.Name = "button1";
            button1.Size = new Size(196, 29);
            button1.TabIndex = 1;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(571, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(34, 201);
            label1.Name = "label1";
            label1.Size = new Size(56, 31);
            label1.TabIndex = 5;
            label1.Text = "CVV";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 91);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(315, 228);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "month/year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 242);
            label3.Name = "label3";
            label3.Size = new Size(41, 40);
            label3.TabIndex = 8;
            label3.Text = "valid\r\nthru\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(421, 9);
            label4.Name = "label4";
            label4.Size = new Size(367, 62);
            label4.TabIndex = 9;
            label4.Text = "Menshikov Bank";
            // 
            // FormCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FormCard";
            Text = "FormCard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}