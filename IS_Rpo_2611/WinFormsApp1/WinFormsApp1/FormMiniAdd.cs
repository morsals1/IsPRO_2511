using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMiniAdd : Form
    {
        public FormMiniAdd()
        {
            InitializeComponent();
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
    }
}
