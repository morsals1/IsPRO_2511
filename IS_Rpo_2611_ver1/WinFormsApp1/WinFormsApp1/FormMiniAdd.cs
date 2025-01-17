using Microsoft.VisualBasic.ApplicationServices;

using System;
using System.IO;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FormMiniAdd : Form
    {
        public FormMiniAdd()
        {
            InitializeComponent();
            this.Load += FormMiniAdd_Load;
            this.Resize += FormMiniAdd_Resize;
        }

        private void FormMiniAdd_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void FormMiniAdd_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int margin = 10;

            //pic
            txtImagePath.Left = (this.ClientSize.Width - txtImagePath.Width) / 2;
            txtImagePath.Top = (this.ClientSize.Height - txtImagePath.Height) / 2 - margin;

            labelPic.Left = (this.ClientSize.Width - labelPic.Width) / 2;
            labelPic.Top = txtImagePath.Top - labelPic.Height - margin;

            //name
            txtProductName.Left = (this.ClientSize.Width - txtProductName.Width) / 2;
            txtProductName.Top = txtImagePath.Top - margin * 4 - txtProductName.Height;

            labelName.Left = (this.ClientSize.Width - labelName.Width) / 2;
            labelName.Top = txtProductName.Top - labelName.Height - margin;

            //price
            txtPrice.Left = (this.ClientSize.Width - txtPrice.Width) / 2;
            txtPrice.Top = txtProductName.Top - margin * 4 - txtPrice.Height;

            labelPrice.Left = (this.ClientSize.Width - labelPrice.Width) / 2;
            labelPrice.Top = txtPrice.Top - labelPrice.Height - margin;

            //qunatity
            txtQuantity.Left = (this.ClientSize.Width - txtQuantity.Width) / 2;
            txtQuantity.Top = txtPrice.Top - margin * 4 - txtQuantity.Height;

            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = txtQuantity.Top - label1.Height - margin;

            //manufacturer
            txtManufacturer.Left = (this.ClientSize.Width - txtManufacturer.Width) / 2;
            txtManufacturer.Top = txtQuantity.Top - margin * 4 - txtManufacturer.Height;

            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            label2.Top = txtManufacturer.Top - label2.Height - margin;

            butSave.Left = (this.ClientSize.Width - butSave.Width) / 2;
            butSave.Top = txtImagePath.Bottom + margin;

            button1.Left = txtImagePath.Right + button1.Width;
            button1.Top = txtManufacturer.Top;

            butExit.Left = (this.ClientSize.Width - butSave.Width) / 2;
            butExit.Top = butSave.Bottom + margin;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Изображения (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|Все файлы (*.*)|*.*",
                Title = "Выберите изображение"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string imagePath = txtImagePath.Text;
            string productName = txtProductName.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;
            string manufacturer = txtManufacturer.Text;
            string buy = "Добавить";

            if (string.IsNullOrEmpty(imagePath) || string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(price) ||
                string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(manufacturer) || string.IsNullOrEmpty(buy))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string data = $"{imagePath},{productName},{price},{quantity},{manufacturer},{buy}";

            string filePath = "products.txt";
            File.AppendAllLines(filePath, new[] { data });

            MessageBox.Show("Продукт успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(ClassData.Dealerch, ClassData.Userch, ClassData.E_mail);
            this.Hide();
            f.FormClosing += (s, args) => this.Close();
            f.Show();
        }
    }
}
