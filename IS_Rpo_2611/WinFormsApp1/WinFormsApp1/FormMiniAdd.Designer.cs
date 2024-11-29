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
            SuspendLayout();
            // 
            // butSave
            // 
            butSave.Location = new Point(12, 377);
            butSave.Name = "butSave";
            butSave.Size = new Size(362, 23);
            butSave.TabIndex = 0;
            butSave.Text = "Сохранить";
            butSave.UseVisualStyleBackColor = true;
            butSave.Click += btnSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(12, 63);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Имя";
            // 
            // labelPic
            // 
            labelPic.AutoSize = true;
            labelPic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPic.Location = new Point(12, 9);
            labelPic.Name = "labelPic";
            labelPic.Size = new Size(93, 25);
            labelPic.TabIndex = 2;
            labelPic.Text = "Картинка";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(12, 37);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(202, 23);
            txtImagePath.TabIndex = 3;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(12, 91);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(202, 23);
            txtProductName.TabIndex = 4;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(12, 117);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(57, 25);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Цена";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 145);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 23);
            txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 171);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 7;
            label1.Text = "Количество";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(12, 199);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(202, 23);
            txtQuantity.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 9;
            label2.Text = "Производитель";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(12, 253);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(202, 23);
            txtManufacturer.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(241, 37);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 11;
            button1.Text = "выбрать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBrowseImage_Click;
            // 
            // FormMiniAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 412);
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
            Name = "FormMiniAdd";
            Text = "FormMiniAdd";
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
    }
}