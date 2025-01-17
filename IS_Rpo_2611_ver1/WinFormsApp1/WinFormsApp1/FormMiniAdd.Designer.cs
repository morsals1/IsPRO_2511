namespace WinFormsApp1
{
    partial class FormMiniAdd
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
            butSave = new Button();
            labelName = new Label();
            labelPic = new Label();
            txtImagePath = new TextBox();
            txtProductName = new TextBox();
            labelPrice = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            txtQuantity = new TextBox();
            label2 = new Label();
            txtManufacturer = new TextBox();
            button1 = new Button();
            butExit = new Button();
            SuspendLayout();
            // 
            // butSave
            // 
            butSave.BackColor = Color.LightGray;
            butSave.Location = new Point(14, 503);
            butSave.Margin = new Padding(3, 4, 3, 4);
            butSave.Name = "butSave";
            butSave.Size = new Size(414, 31);
            butSave.TabIndex = 0;
            butSave.Text = "Сохранить";
            butSave.UseVisualStyleBackColor = false;
            butSave.Click += btnSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(14, 84);
            labelName.Name = "labelName";
            labelName.Size = new Size(61, 32);
            labelName.TabIndex = 1;
            labelName.Text = "Имя";
            // 
            // labelPic
            // 
            labelPic.AutoSize = true;
            labelPic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPic.Location = new Point(14, 12);
            labelPic.Name = "labelPic";
            labelPic.Size = new Size(116, 32);
            labelPic.TabIndex = 2;
            labelPic.Text = "Картинка";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(14, 49);
            txtImagePath.Margin = new Padding(3, 4, 3, 4);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(230, 27);
            txtImagePath.TabIndex = 3;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(14, 121);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(230, 27);
            txtProductName.TabIndex = 4;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(14, 156);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(71, 32);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Цена";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(14, 193);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(230, 27);
            txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 228);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 7;
            label1.Text = "Количество";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(14, 265);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(230, 27);
            txtQuantity.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 300);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 9;
            label2.Text = "Производитель";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(14, 337);
            txtManufacturer.Margin = new Padding(3, 4, 3, 4);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(230, 27);
            txtManufacturer.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(275, 49);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(152, 31);
            button1.TabIndex = 11;
            button1.Text = "выбрать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnBrowseImage_Click;
            // 
            // butExit
            // 
            butExit.BackColor = Color.LightGray;
            butExit.Location = new Point(14, 542);
            butExit.Margin = new Padding(3, 4, 3, 4);
            butExit.Name = "butExit";
            butExit.Size = new Size(414, 31);
            butExit.TabIndex = 12;
            butExit.Text = "Выйти";
            butExit.UseVisualStyleBackColor = false;
            butExit.Click += butExit_Click;
            // 
            // FormMiniAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(440, 619);
            Controls.Add(butExit);
            Controls.Add(button1);
            Controls.Add(txtManufacturer);
            Controls.Add(label2);
            Controls.Add(txtQuantity);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(labelPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtImagePath);
            Controls.Add(labelPic);
            Controls.Add(labelName);
            Controls.Add(butSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMiniAdd";
            Text = "FormMiniAdd";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butSave;
        private Label labelName;
        private Label labelPic;
        private TextBox txtImagePath;
        private TextBox txtProductName;
        private Label labelPrice;
        private TextBox txtPrice;
        private Label label1;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtManufacturer;
        private Button button1;
        private Button butExit;
    }
}