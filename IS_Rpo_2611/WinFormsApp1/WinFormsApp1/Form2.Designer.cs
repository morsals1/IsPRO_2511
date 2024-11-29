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
            tabControl1 = new TabControl();
            tabCat = new TabPage();
            butAdd = new Button();
            catalogPanel = new FlowLayoutPanel();
            tabOrder = new TabPage();
            loadButton = new Button();
            saveButton = new Button();
            ordersDataGridView = new DataGridView();
            Название = new DataGridViewTextBoxColumn();
            Цена = new DataGridViewTextBoxColumn();
            Пункт_выдачи = new DataGridViewTextBoxColumn();
            Количество = new DataGridViewTextBoxColumn();
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
            tabFin = new TabPage();
            button4 = new Button();
            button2 = new Button();
            phinDataGridView = new DataGridView();
            ColumnIdPhin = new DataGridViewTextBoxColumn();
            ColumnNamePhin = new DataGridViewTextBoxColumn();
            ColumnQuantPhin = new DataGridViewTextBoxColumn();
            ColumnSummPhin = new DataGridViewTextBoxColumn();
            tabBaslet = new TabPage();
            tabPayment = new TabPage();
            tabPersonal = new TabPage();
            tabControl1.SuspendLayout();
            tabCat.SuspendLayout();
            tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            tabSklad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skladDataGridView).BeginInit();
            tabFin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phinDataGridView).BeginInit();
            SuspendLayout();
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
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 338);
            tabControl1.TabIndex = 0;
            // 
            // tabCat
            // 
            tabCat.Controls.Add(butAdd);
            tabCat.Controls.Add(catalogPanel);
            tabCat.Location = new Point(4, 24);
            tabCat.Margin = new Padding(3, 2, 3, 2);
            tabCat.Name = "tabCat";
            tabCat.Padding = new Padding(3, 2, 3, 2);
            tabCat.Size = new Size(692, 310);
            tabCat.TabIndex = 0;
            tabCat.Text = "Каталог";
            tabCat.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            butAdd.Location = new Point(3, 0);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(178, 23);
            butAdd.TabIndex = 1;
            butAdd.Text = "добавить";
            butAdd.UseVisualStyleBackColor = true;
            butAdd.Click += butAdd_Click;
            // 
            // catalogPanel
            // 
            catalogPanel.Dock = DockStyle.Bottom;
            catalogPanel.Location = new Point(3, 25);
            catalogPanel.Name = "catalogPanel";
            catalogPanel.Size = new Size(686, 283);
            catalogPanel.TabIndex = 0;
            // 
            // tabOrder
            // 
            tabOrder.Controls.Add(loadButton);
            tabOrder.Controls.Add(saveButton);
            tabOrder.Controls.Add(ordersDataGridView);
            tabOrder.Location = new Point(4, 24);
            tabOrder.Margin = new Padding(3, 2, 3, 2);
            tabOrder.Name = "tabOrder";
            tabOrder.Padding = new Padding(3, 2, 3, 2);
            tabOrder.Size = new Size(692, 310);
            tabOrder.TabIndex = 1;
            tabOrder.Text = "Заказы";
            tabOrder.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(87, 282);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 2;
            loadButton.Text = "загрузить";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(6, 282);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Название, Цена, Пункт_выдачи, Количество });
            ordersDataGridView.Location = new Point(6, 5);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.Size = new Size(678, 208);
            ordersDataGridView.TabIndex = 0;
            // 
            // Название
            // 
            Название.HeaderText = "Название";
            Название.Name = "Название";
            // 
            // Цена
            // 
            Цена.HeaderText = "Цена";
            Цена.Name = "Цена";
            // 
            // Пункт_выдачи
            // 
            Пункт_выдачи.HeaderText = "Пункт выдачи";
            Пункт_выдачи.Name = "Пункт_выдачи";
            // 
            // Количество
            // 
            Количество.HeaderText = "Количество";
            Количество.Name = "Количество";
            // 
            // tabSklad
            // 
            tabSklad.Controls.Add(button3);
            tabSklad.Controls.Add(button1);
            tabSklad.Controls.Add(skladDataGridView);
            tabSklad.Location = new Point(4, 24);
            tabSklad.Margin = new Padding(3, 2, 3, 2);
            tabSklad.Name = "tabSklad";
            tabSklad.Size = new Size(692, 310);
            tabSklad.TabIndex = 2;
            tabSklad.Text = "Склад";
            tabSklad.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 279);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += saveButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(87, 279);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += loadButton_Click;
            // 
            // skladDataGridView
            // 
            skladDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            skladDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnName, ColumnQuant, ColumnPoint, ColumnDepot, ColumnVehicle });
            skladDataGridView.Location = new Point(6, 3);
            skladDataGridView.Name = "skladDataGridView";
            skladDataGridView.Size = new Size(678, 208);
            skladDataGridView.TabIndex = 0;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Название";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnQuant
            // 
            ColumnQuant.HeaderText = "Количество";
            ColumnQuant.Name = "ColumnQuant";
            // 
            // ColumnPoint
            // 
            ColumnPoint.HeaderText = "Пункт Выдачи";
            ColumnPoint.Name = "ColumnPoint";
            // 
            // ColumnDepot
            // 
            ColumnDepot.HeaderText = "Склад";
            ColumnDepot.Name = "ColumnDepot";
            // 
            // ColumnVehicle
            // 
            ColumnVehicle.HeaderText = "Транспорт";
            ColumnVehicle.Name = "ColumnVehicle";
            // 
            // tabFin
            // 
            tabFin.Controls.Add(button4);
            tabFin.Controls.Add(button2);
            tabFin.Controls.Add(phinDataGridView);
            tabFin.Location = new Point(4, 24);
            tabFin.Margin = new Padding(3, 2, 3, 2);
            tabFin.Name = "tabFin";
            tabFin.Size = new Size(692, 310);
            tabFin.TabIndex = 3;
            tabFin.Text = "Финансы";
            tabFin.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 279);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "сохранить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += saveButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 279);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "загрузить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += loadButton_Click;
            // 
            // phinDataGridView
            // 
            phinDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phinDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnIdPhin, ColumnNamePhin, ColumnQuantPhin, ColumnSummPhin });
            phinDataGridView.Location = new Point(6, 3);
            phinDataGridView.Name = "phinDataGridView";
            phinDataGridView.Size = new Size(678, 208);
            phinDataGridView.TabIndex = 0;
            // 
            // ColumnIdPhin
            // 
            ColumnIdPhin.HeaderText = "ID";
            ColumnIdPhin.Name = "ColumnIdPhin";
            // 
            // ColumnNamePhin
            // 
            ColumnNamePhin.HeaderText = "Название";
            ColumnNamePhin.Name = "ColumnNamePhin";
            // 
            // ColumnQuantPhin
            // 
            ColumnQuantPhin.HeaderText = "Количество";
            ColumnQuantPhin.Name = "ColumnQuantPhin";
            // 
            // ColumnSummPhin
            // 
            ColumnSummPhin.HeaderText = "Сумма";
            ColumnSummPhin.Name = "ColumnSummPhin";
            // 
            // tabBaslet
            // 
            tabBaslet.Location = new Point(4, 24);
            tabBaslet.Name = "tabBaslet";
            tabBaslet.Size = new Size(692, 310);
            tabBaslet.TabIndex = 4;
            tabBaslet.Text = "Корзина";
            tabBaslet.UseVisualStyleBackColor = true;
            // 
            // tabPayment
            // 
            tabPayment.Location = new Point(4, 24);
            tabPayment.Name = "tabPayment";
            tabPayment.Size = new Size(692, 310);
            tabPayment.TabIndex = 5;
            tabPayment.Text = "Платежи";
            tabPayment.UseVisualStyleBackColor = true;
            // 
            // tabPersonal
            // 
            tabPersonal.Location = new Point(4, 24);
            tabPersonal.Name = "tabPersonal";
            tabPersonal.Size = new Size(692, 310);
            tabPersonal.TabIndex = 6;
            tabPersonal.Text = "Личный кабинет";
            tabPersonal.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabCat.ResumeLayout(false);
            tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            tabSklad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)skladDataGridView).EndInit();
            tabFin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)phinDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCat;
        private TabPage tabOrder;
        private TabPage tabSklad;
        private TabPage tabFin;
        private FlowLayoutPanel catalogPanel;
        private DataGridView ordersDataGridView;
        private DataGridViewTextBoxColumn Название;
        private DataGridViewTextBoxColumn Цена;
        private DataGridViewTextBoxColumn Пункт_выдачи;
        private DataGridViewTextBoxColumn Количество;
        private Button loadButton;
        private Button saveButton;
        private DataGridView skladDataGridView;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnQuant;
        private DataGridViewTextBoxColumn ColumnPoint;
        private DataGridViewTextBoxColumn ColumnDepot;
        private DataGridViewTextBoxColumn ColumnVehicle;
        private DataGridView phinDataGridView;
        private DataGridViewTextBoxColumn ColumnIdPhin;
        private DataGridViewTextBoxColumn ColumnNamePhin;
        private DataGridViewTextBoxColumn ColumnQuantPhin;
        private DataGridViewTextBoxColumn ColumnSummPhin;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button butAdd;
        private TabPage tabBaslet;
        private TabPage tabPayment;
        private TabPage tabPersonal;
    }
}