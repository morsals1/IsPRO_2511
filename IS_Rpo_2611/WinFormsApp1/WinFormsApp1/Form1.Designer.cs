namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Buyer = new Button();
            dealer = new Button();
            RegBut = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            EntraceBut = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Buyer
            // 
            Buyer.BackColor = Color.LightGray;
            Buyer.Location = new Point(10, 10);
            Buyer.Name = "Buyer";
            Buyer.Size = new Size(91, 23);
            Buyer.TabIndex = 0;
            Buyer.Text = "покупатель";
            Buyer.UseVisualStyleBackColor = false;
            Buyer.Click += Buyer_Click;
            // 
            // dealer
            // 
            dealer.BackColor = Color.LightGray;
            dealer.Location = new Point(10, 39);
            dealer.Name = "dealer";
            dealer.Size = new Size(91, 23);
            dealer.TabIndex = 1;
            dealer.Text = "продавец";
            dealer.UseVisualStyleBackColor = false;
            dealer.Click += dealer_Click;
            // 
            // RegBut
            // 
            RegBut.BackColor = Color.LightGray;
            RegBut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegBut.Location = new Point(54, 404);
            RegBut.Name = "RegBut";
            RegBut.Size = new Size(226, 36);
            RegBut.TabIndex = 2;
            RegBut.Text = "зарегистрироваться";
            RegBut.UseVisualStyleBackColor = false;
            RegBut.Click += RegBut_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(109, 141);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 5;
            label1.Text = "почта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(107, 200);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9727537;
            pictureBox1.Location = new Point(107, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // EntraceBut
            // 
            EntraceBut.BackColor = Color.LightGray;
            EntraceBut.Font = new Font("Segoe UI", 14.25F);
            EntraceBut.Location = new Point(293, 404);
            EntraceBut.Name = "EntraceBut";
            EntraceBut.Size = new Size(116, 36);
            EntraceBut.TabIndex = 9;
            EntraceBut.Text = "войти";
            EntraceBut.UseVisualStyleBackColor = false;
            EntraceBut.Click += EntraceBut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(331, 227);
            label4.Name = "label4";
            label4.Size = new Size(32, 21);
            label4.TabIndex = 10;
            label4.Text = "👁";
            label4.MouseLeave += label4_MouseLeave;
            label4.MouseMove += label4_MouseMove;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(107, 258);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 11;
            label5.Text = "требования к паролю";
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseMove += label5_MouseMove;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Location = new Point(54, 294);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 105);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(21, 12);
            label6.Name = "label6";
            label6.Size = new Size(275, 78);
            label6.TabIndex = 0;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(474, 491);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EntraceBut);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(RegBut);
            Controls.Add(dealer);
            Controls.Add(Buyer);
            Name = "Form1";
            Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Buyer;
        private Button dealer;
        private Button RegBut;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button EntraceBut;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
    }
}
