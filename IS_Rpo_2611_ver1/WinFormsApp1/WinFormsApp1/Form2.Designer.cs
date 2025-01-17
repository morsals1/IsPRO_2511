namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tabPersonal = new TabPage();
            button5 = new Button();
            label1 = new Label();
            pictureBoxLk = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPayment = new TabPage();
            tabBaslet = new TabPage();
            basketPanel = new FlowLayoutPanel();
            tabFin = new TabPage();
            button4 = new Button();
            button2 = new Button();
            phinDataGridView = new DataGridView();
            ColumnIdPhin = new DataGridViewTextBoxColumn();
            ColumnNamePhin = new DataGridViewTextBoxColumn();
            ColumnQuantPhin = new DataGridViewTextBoxColumn();
            ColumnSummPhin = new DataGridViewTextBoxColumn();
            tabSklad = new TabPage();
            button3 = new Button();
            button1 = new Button();
            skladDataGridView = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnQuant = new DataGridViewTextBoxColumn();
            ColumnPoint = new DataGridViewTextBoxColumn();
            ColumnDepot = new DataGridViewTextBoxColumn();
            ColumnVehicle = new DataGridViewTextBoxColumn();
            tabOrder = new TabPage();
            loadButton = new Button();
            saveButton = new Button();
            ordersDataGridView = new DataGridView();
            Название = new DataGridViewTextBoxColumn();
            Цена = new DataGridViewTextBoxColumn();
            Пункт_выдачи = new DataGridViewTextBoxColumn();
            Количество = new DataGridViewTextBoxColumn();
            tabCat = new TabPage();
            butAdd = new Button();
            catalogPanel = new FlowLayoutPanel();
            tabControl1 = new TabControl();
            tabPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLk).BeginInit();
            tabBaslet.SuspendLayout();
            tabFin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phinDataGridView).BeginInit();
            tabSklad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skladDataGridView).BeginInit();
            tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            tabCat.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPersonal
            // 
            tabPersonal.Controls.Add(button5);
            tabPersonal.Controls.Add(label1);
            tabPersonal.Controls.Add(pictureBoxLk);
            tabPersonal.Controls.Add(flowLayoutPanel1);
            tabPersonal.Location = new Point(4, 29);
            tabPersonal.Margin = new Padding(3, 4, 3, 4);
            tabPersonal.Name = "tabPersonal";
            tabPersonal.Size = new Size(792, 418);
            tabPersonal.TabIndex = 6;
            tabPersonal.Text = "Личный кабинет";
            tabPersonal.UseVisualStyleBackColor = true;
            tabPersonal.Click += tabPersonal_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Location = new Point(132, 47);
            button5.Name = "button5";
            button5.Size = new Size(135, 29);
            button5.TabIndex = 4;
            button5.Text = "добавить карту";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(132, 3);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // pictureBoxLk
            // 
            pictureBoxLk.Image = (Image)resources.GetObject("pictureBoxLk.Image");
            pictureBoxLk.Location = new Point(8, 3);
            pictureBoxLk.Name = "pictureBoxLk";
            pictureBoxLk.Size = new Size(118, 124);
            pictureBoxLk.TabIndex = 2;
            pictureBoxLk.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 133);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(792, 285);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tabPayment
            // 
            tabPayment.Location = new Point(4, 29);
            tabPayment.Margin = new Padding(3, 4, 3, 4);
            tabPayment.Name = "tabPayment";
            tabPayment.Size = new Size(792, 418);
            tabPayment.TabIndex = 5;
            tabPayment.Text = "Платежи";
            tabPayment.UseVisualStyleBackColor = true;
            // 
            // tabBaslet
            // 
            tabBaslet.Controls.Add(basketPanel);
            tabBaslet.Location = new Point(4, 29);
            tabBaslet.Margin = new Padding(3, 4, 3, 4);
            tabBaslet.Name = "tabBaslet";
            tabBaslet.Size = new Size(792, 418);
            tabBaslet.TabIndex = 4;
            tabBaslet.Text = "Корзина";
            tabBaslet.UseVisualStyleBackColor = true;
            // 
            // basketPanel
            // 
            basketPanel.Dock = DockStyle.Fill;
            basketPanel.Location = new Point(0, 0);
            basketPanel.Name = "basketPanel";
            basketPanel.Size = new Size(792, 418);
            basketPanel.TabIndex = 0;
            // 
            // tabFin
            // 
            tabFin.Controls.Add(button4);
            tabFin.Controls.Add(button2);
            tabFin.Controls.Add(phinDataGridView);
            tabFin.Location = new Point(4, 29);
            tabFin.Name = "tabFin";
            tabFin.Size = new Size(792, 418);
            tabFin.TabIndex = 3;
            tabFin.Text = "Финансы";
            tabFin.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Location = new Point(7, 372);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(90, 31);
            button4.TabIndex = 4;
            button4.Text = "сохранить";
            button4.UseVisualStyleBackColor = false;
            button4.Click += saveButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(105, 372);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(90, 31);
            button2.TabIndex = 3;
            button2.Text = "загрузить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += loadButton_Click;
            // 
            // phinDataGridView
            // 
            phinDataGridView.BackgroundColor = Color.LightGray;
            phinDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phinDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnIdPhin, ColumnNamePhin, ColumnQuantPhin, ColumnSummPhin });
            phinDataGridView.Location = new Point(7, 4);
            phinDataGridView.Margin = new Padding(3, 4, 3, 4);
            phinDataGridView.Name = "phinDataGridView";
            phinDataGridView.RowHeadersWidth = 51;
            phinDataGridView.Size = new Size(775, 277);
            phinDataGridView.TabIndex = 0;
            // 
            // ColumnIdPhin
            // 
            ColumnIdPhin.HeaderText = "ID";
            ColumnIdPhin.MinimumWidth = 6;
            ColumnIdPhin.Name = "ColumnIdPhin";
            ColumnIdPhin.Width = 125;
            // 
            // ColumnNamePhin
            // 
            ColumnNamePhin.HeaderText = "Название";
            ColumnNamePhin.MinimumWidth = 6;
            ColumnNamePhin.Name = "ColumnNamePhin";
            ColumnNamePhin.Width = 125;
            // 
            // ColumnQuantPhin
            // 
            ColumnQuantPhin.HeaderText = "Количество";
            ColumnQuantPhin.MinimumWidth = 6;
            ColumnQuantPhin.Name = "ColumnQuantPhin";
            ColumnQuantPhin.Width = 125;
            // 
            // ColumnSummPhin
            // 
            ColumnSummPhin.HeaderText = "Сумма";
            ColumnSummPhin.MinimumWidth = 6;
            ColumnSummPhin.Name = "ColumnSummPhin";
            ColumnSummPhin.Width = 125;
            // 
            // tabSklad
            // 
            tabSklad.Controls.Add(button3);
            tabSklad.Controls.Add(button1);
            tabSklad.Controls.Add(skladDataGridView);
            tabSklad.Location = new Point(4, 29);
            tabSklad.Name = "tabSklad";
            tabSklad.Size = new Size(792, 418);
            tabSklad.TabIndex = 2;
            tabSklad.Text = "Склад";
            tabSklad.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(7, 372);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(90, 31);
            button3.TabIndex = 4;
            button3.Text = "сохранить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += saveButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(105, 372);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 3;
            button1.Text = "загрузить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += loadButton_Click;
            // 
            // skladDataGridView
            // 
            skladDataGridView.BackgroundColor = Color.LightGray;
            skladDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            skladDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnName, ColumnQuant, ColumnPoint, ColumnDepot, ColumnVehicle });
            skladDataGridView.Location = new Point(7, 4);
            skladDataGridView.Margin = new Padding(3, 4, 3, 4);
            skladDataGridView.Name = "skladDataGridView";
            skladDataGridView.RowHeadersWidth = 51;
            skladDataGridView.Size = new Size(775, 277);
            skladDataGridView.TabIndex = 0;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 125;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Название";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // ColumnQuant
            // 
            ColumnQuant.HeaderText = "Количество";
            ColumnQuant.MinimumWidth = 6;
            ColumnQuant.Name = "ColumnQuant";
            ColumnQuant.Width = 125;
            // 
            // ColumnPoint
            // 
            ColumnPoint.HeaderText = "Пункт Выдачи";
            ColumnPoint.MinimumWidth = 6;
            ColumnPoint.Name = "ColumnPoint";
            ColumnPoint.Width = 125;
            // 
            // ColumnDepot
            // 
            ColumnDepot.HeaderText = "Склад";
            ColumnDepot.MinimumWidth = 6;
            ColumnDepot.Name = "ColumnDepot";
            ColumnDepot.Width = 125;
            // 
            // ColumnVehicle
            // 
            ColumnVehicle.HeaderText = "Транспорт";
            ColumnVehicle.MinimumWidth = 6;
            ColumnVehicle.Name = "ColumnVehicle";
            ColumnVehicle.Width = 125;
            // 
            // tabOrder
            // 
            tabOrder.Controls.Add(loadButton);
            tabOrder.Controls.Add(saveButton);
            tabOrder.Controls.Add(ordersDataGridView);
            tabOrder.Location = new Point(4, 29);
            tabOrder.Name = "tabOrder";
            tabOrder.Padding = new Padding(3);
            tabOrder.Size = new Size(792, 418);
            tabOrder.TabIndex = 1;
            tabOrder.Text = "Заказы";
            tabOrder.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.LightGray;
            loadButton.Location = new Point(105, 376);
            loadButton.Margin = new Padding(3, 4, 3, 4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(90, 31);
            loadButton.TabIndex = 2;
            loadButton.Text = "загрузить";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGray;
            saveButton.Location = new Point(7, 376);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(90, 31);
            saveButton.TabIndex = 1;
            saveButton.Text = "сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.BackgroundColor = Color.LightGray;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Название, Цена, Пункт_выдачи, Количество });
            ordersDataGridView.Location = new Point(7, 7);
            ordersDataGridView.Margin = new Padding(3, 4, 3, 4);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.Size = new Size(775, 277);
            ordersDataGridView.TabIndex = 0;
            // 
            // Название
            // 
            Название.HeaderText = "Название";
            Название.MinimumWidth = 6;
            Название.Name = "Название";
            Название.Width = 125;
            // 
            // Цена
            // 
            Цена.HeaderText = "Цена";
            Цена.MinimumWidth = 6;
            Цена.Name = "Цена";
            Цена.Width = 125;
            // 
            // Пункт_выдачи
            // 
            Пункт_выдачи.HeaderText = "Пункт выдачи";
            Пункт_выдачи.MinimumWidth = 6;
            Пункт_выдачи.Name = "Пункт_выдачи";
            Пункт_выдачи.Width = 125;
            // 
            // Количество
            // 
            Количество.HeaderText = "Количество";
            Количество.MinimumWidth = 6;
            Количество.Name = "Количество";
            Количество.Width = 125;
            // 
            // tabCat
            // 
            tabCat.Controls.Add(butAdd);
            tabCat.Controls.Add(catalogPanel);
            tabCat.Location = new Point(4, 29);
            tabCat.Name = "tabCat";
            tabCat.Padding = new Padding(3);
            tabCat.Size = new Size(792, 418);
            tabCat.TabIndex = 0;
            tabCat.Text = "Каталог";
            tabCat.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            butAdd.BackColor = Color.LightGray;
            butAdd.Location = new Point(3, 4);
            butAdd.Margin = new Padding(3, 4, 3, 4);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(203, 31);
            butAdd.TabIndex = 3;
            butAdd.Text = "добавить";
            butAdd.UseVisualStyleBackColor = false;
            butAdd.Click += butAdd_Click;
            // 
            // catalogPanel
            // 
            catalogPanel.Dock = DockStyle.Bottom;
            catalogPanel.Location = new Point(3, 38);
            catalogPanel.Margin = new Padding(3, 4, 3, 4);
            catalogPanel.Name = "catalogPanel";
            catalogPanel.Size = new Size(786, 377);
            catalogPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCat);
            tabControl1.Controls.Add(tabOrder);
            tabControl1.Controls.Add(tabSklad);
            tabControl1.Controls.Add(tabFin);
            tabControl1.Controls.Add(tabBaslet);
            tabControl1.Controls.Add(tabPayment);
            tabControl1.Controls.Add(tabPersonal);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 451);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 451);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "MarketMouse";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            tabPersonal.ResumeLayout(false);
            tabPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLk).EndInit();
            tabBaslet.ResumeLayout(false);
            tabFin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)phinDataGridView).EndInit();
            tabSklad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)skladDataGridView).EndInit();
            tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            tabCat.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPersonal;
        private PictureBox pictureBoxLk;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabPayment;
        private TabPage tabBaslet;
        private FlowLayoutPanel basketPanel;
        private TabPage tabFin;
        private Button button4;
        private Button button2;
        private DataGridView phinDataGridView;
        private DataGridViewTextBoxColumn ColumnIdPhin;
        private DataGridViewTextBoxColumn ColumnNamePhin;
        private DataGridViewTextBoxColumn ColumnQuantPhin;
        private DataGridViewTextBoxColumn ColumnSummPhin;
        private TabPage tabSklad;
        private Button button3;
        private Button button1;
        private DataGridView skladDataGridView;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnQuant;
        private DataGridViewTextBoxColumn ColumnPoint;
        private DataGridViewTextBoxColumn ColumnDepot;
        private DataGridViewTextBoxColumn ColumnVehicle;
        private TabPage tabOrder;
        private Button loadButton;
        private Button saveButton;
        private DataGridView ordersDataGridView;
        private DataGridViewTextBoxColumn Название;
        private DataGridViewTextBoxColumn Цена;
        private DataGridViewTextBoxColumn Пункт_выдачи;
        private DataGridViewTextBoxColumn Количество;
        private TabPage tabCat;
        private Button butAdd;
        private FlowLayoutPanel catalogPanel;
        private TabControl tabControl1;
        private Label label1;
        private Button button5;
    }
}