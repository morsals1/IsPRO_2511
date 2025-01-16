using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        private List<Product> basket = new List<Product>();
        private bool _dealerCh;
        private bool _userCh;
        private string _userEmail;

        public Form2(bool dealerCh, bool userCh, string userEmail)
        {
            InitializeComponent();
            LoadProducts();
            _dealerCh = dealerCh;
            _userCh = userCh;
            _userEmail = userEmail;
            pictureBoxLk.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLk.Image = Image.FromFile("stockUser.png");
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = _userEmail;
            if (_userCh == true)
            {
                tabFin.Parent = null;
                tabOrder.Parent = null;
                tabSklad.Parent = null;
                tabBaslet.Parent = tabControl1;
                tabPayment.Parent = tabControl1;
                tabPersonal.Parent = tabControl1;
                butAdd.Visible = false;
            }
            else if (_dealerCh == true)
            {
                tabFin.Parent = tabControl1;
                tabOrder.Parent = tabControl1;
                tabSklad.Parent = tabControl1;
                tabBaslet.Parent = null;
                tabPayment.Parent = null;
                tabPersonal.Parent = null;
                butAdd.Visible = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabOrder)
            {
                var lines = new List<string>();

                foreach (DataGridViewRow row in ordersDataGridView.Rows)
                {
                    if (row.Cells[0].Value == null) continue;

                    var name = row.Cells[0].Value.ToString();
                    var price = row.Cells[1].Value.ToString();
                    var pickupPoint = row.Cells[2].Value.ToString();
                    var quantity = row.Cells[3].Value.ToString();

                    lines.Add($"{name},{price},{pickupPoint},{quantity}");
                }

                File.WriteAllLines("orders.txt", lines);
                MessageBox.Show("Данные сохранены в файл orders.txt!");
            }
            if (tabControl1.SelectedTab == tabSklad)
            {
                var lines = new List<string>();

                foreach (DataGridViewRow row in skladDataGridView.Rows)
                {
                    if (row.Cells[0].Value == null) continue;

                    var id = row.Cells[0].Value.ToString();
                    var name = row.Cells[1].Value.ToString();
                    var quantity = row.Cells[2].Value.ToString();
                    var point = row.Cells[3].Value.ToString();
                    var depot = row.Cells[4].Value.ToString();
                    var transport = row.Cells[5].Value.ToString();

                    lines.Add($"{id},{name},{quantity},{point}, {depot}, {transport}");
                }

                File.WriteAllLines("orders.txt", lines);
                MessageBox.Show("Данные сохранены в файл sklad.txt!");
            }
            if (tabControl1.SelectedTab == tabFin)
            {
                var lines = new List<string>();

                foreach (DataGridViewRow row in phinDataGridView.Rows)
                {
                    if (row.Cells[0].Value == null) continue;

                    var id = row.Cells[0].Value.ToString();
                    var name = row.Cells[1].Value.ToString();
                    var quantity = row.Cells[2].Value.ToString();
                    var summ = row.Cells[3].Value.ToString();

                    lines.Add($"{id},{name},{quantity},{summ}");
                }

                File.WriteAllLines("orders.txt", lines);
                MessageBox.Show("Данные сохранены в файл fin.txt!");
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabOrder)
            {
                if (!File.Exists("orders.txt"))
                {
                    MessageBox.Show("Файл не найден!");
                    return;
                }

                var lines = File.ReadAllLines("orders.txt");
                ordersDataGridView.Rows.Clear();

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length == 4)
                    {
                        ordersDataGridView.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                    }
                }

                MessageBox.Show("Данные загружены из файла orders.txt!");
            }
            if (tabControl1.SelectedTab == tabSklad)
            {
                if (!File.Exists("sklad.txt"))
                {
                    MessageBox.Show("Файл не найден!");
                    return;
                }

                var lines = File.ReadAllLines("sklad.txt");
                skladDataGridView.Rows.Clear();

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length == 6)
                    {
                        skladDataGridView.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                    }
                }

                MessageBox.Show("Данные загружены из файла sklad.txt!");
            }
            if (tabControl1.SelectedTab == tabFin)
            {
                if (!File.Exists("fin.txt"))
                {
                    MessageBox.Show("Файл не найден!");
                    return;
                }

                var lines = File.ReadAllLines("fin.txt");
                phinDataGridView.Rows.Clear();

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length == 4)
                    {
                        phinDataGridView.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                    }
                }

                MessageBox.Show("Данные загружены из файла fin.txt!");
            }

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            FormMiniAdd miniAdd = new FormMiniAdd();
            miniAdd.ShowDialog();
            LoadProducts();
        }

        private void LoadProducts()
        {
            string filePath = "products.txt";
            if (System.IO.File.Exists(filePath))
            {
                string[] products = System.IO.File.ReadAllLines(filePath);
                catalogPanel.Controls.Clear();

                foreach (var product in products)
                {
                    string[] details = product.Split(',');
                    if (details.Length < 6) continue;

                    string imagePath = details[0];
                    string name = details[1];
                    string price = details[2];
                    string quantity = details[3];
                    string manufacturer = details[4];
                    string buy = details[5];

                    Panel productPanel = new Panel
                    {
                        BackColor = Color.LightGray,
                        Size = new Size(250, 350),
                        Margin = new Padding(6),
                        BorderStyle = BorderStyle.FixedSingle
                    };


                    PictureBox productImage = new PictureBox
                    {
                        Size = new Size(200, 150),
                        Location = new Point(25, 10),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    if (System.IO.File.Exists(imagePath))
                    {
                        productImage.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        productImage.Image = SystemIcons.Error.ToBitmap();
                    }

                    Label nameLabel = new Label
                    {
                        Text = $"Название: {name}",
                        AutoSize = true,
                        Location = new Point(10, 170)
                    };

                    Label priceLabel = new Label
                    {
                        Text = $"Цена: {price}",
                        AutoSize = true,
                        Location = new Point(10, 200)
                    };

                    Label quantityLabel = new Label
                    {
                        Text = $"Кол-во: {quantity}",
                        AutoSize = true,
                        Location = new Point(10, 230)
                    };

                    Label manufacturerLabel = new Label
                    {
                        Text = $"Изготовитель: {manufacturer}",
                        AutoSize = true,
                        Location = new Point(10, 260)
                    };

                    Button buyButton = new Button
                    {
                        Text = $"{buy}",
                        AutoSize = true,
                        BackColor = Color.Yellow,
                        Location = new Point(10, 290),
                        Tag = new Product
                        {
                            ImagePath = imagePath,
                            Name = name,
                            Price = price,
                            Quantity = "1",
                            Manufacturer = manufacturer
                        }
                    };

                    buyButton.Click += buyButton_Click;

                    productPanel.Controls.Add(productImage);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(quantityLabel);
                    productPanel.Controls.Add(manufacturerLabel);
                    productPanel.Controls.Add(buyButton);

                    catalogPanel.Controls.Add(productPanel);
                }
            }
            else
            {
                MessageBox.Show("Файл с продуктами не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button buyButton && buyButton.Tag is Product product)
            {
                string filePath = "basket.txt";
                List<string> lines = File.Exists(filePath) ? File.ReadAllLines(filePath).ToList() : new List<string>();
                bool found = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] details = lines[i].Split(',');
                    if (details.Length < 5) continue;

                    if (details[1] == product.Name)
                    {
                        int quantity = int.Parse(details[3]) + 1;
                        details[3] = quantity.ToString();
                        lines[i] = string.Join(",", details);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    lines.Add($"{product.ImagePath},{product.Name},{product.Price},1,{product.Manufacturer}");
                }

                File.WriteAllLines(filePath, lines);
                MessageBox.Show($"Товар {product.Name} добавлен в корзину");
                LoadBasket();
            }
        }

        private void LoadBasket()
        {
            string filePath = "basket.txt";
            if (File.Exists(filePath))
            {
                string[] products = File.ReadAllLines(filePath);
                basketPanel.Controls.Clear();

                foreach (var product in products)
                {
                    string[] details = product.Split(',');
                    if (details.Length < 5) continue;

                    string imagePath = details[0];
                    string name = details[1];
                    string price = details[2];
                    int quantity = int.Parse(details[3]);
                    string manufacturer = details[4];

                    Panel productPanel = new Panel
                    {
                        BackColor = Color.LightGray,
                        Size = new Size(300, 400),
                        Margin = new Padding(6),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox productImage = new PictureBox
                    {
                        Size = new Size(200, 150),
                        Location = new Point(25, 10),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle,
                        Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : SystemIcons.Error.ToBitmap()
                    };

                    Label nameLabel = new Label { Text = $"{name}", AutoSize = true, Location = new Point(10, 170) };
                    Label priceLabel = new Label { Text = $"Цена: {price}", AutoSize = true, Location = new Point(10, 200) };
                    Label quantityLabel = new Label { Text = $"Кол-во: {quantity}", AutoSize = true, Location = new Point(10, 230) };

                    Button plusButton = new Button
                    {
                        Text = "+",
                        BackColor = Color.White,
                        Location = new Point(10, 260),
                        Size = new Size(50, 30),
                        Tag = name
                    };

                    Button minusButton = new Button
                    {
                        Text = "-",
                        BackColor = Color.White,
                        Location = new Point(70, 260),
                        Size = new Size(50, 30),
                        Tag = name
                    };

                    Button deleteButton = new Button
                    {
                        Text = "Удалить",
                        BackColor = Color.White,
                        Location = new Point(130, 260),
                        Size = new Size(100, 30),
                        Tag = name
                    };


                    plusButton.Click += (s, e) => UpdateQuantity(name, 1);
                    minusButton.Click += (s, e) => UpdateQuantity(name, -1);
                    deleteButton.Click += (s, e) => DeleteProduct(name);

                    productPanel.Controls.Add(productImage);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(quantityLabel);
                    productPanel.Controls.Add(plusButton);
                    productPanel.Controls.Add(minusButton);
                    productPanel.Controls.Add(deleteButton);

                    basketPanel.Controls.Add(productPanel);
                }
            }
        }

        private void UpdateQuantity(string productName, int change)
        {
            string filePath = "basket.txt";
            if (!File.Exists(filePath)) return;

            List<string> lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] details = lines[i].Split(',');
                if (details.Length < 5) continue;

                if (details[1] == productName)
                {
                    int quantity = int.Parse(details[3]) + change;
                    if (quantity <= 0)
                    {
                        lines.RemoveAt(i);
                    }
                    else
                    {
                        details[3] = quantity.ToString();
                        lines[i] = string.Join(",", details);
                    }
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);
            LoadBasket();
        }

        private void DeleteProduct(string productName)
        {
            string filePath = "basket.txt";
            if (!File.Exists(filePath)) return;

            List<string> lines = File.ReadAllLines(filePath).Where(line => !line.Contains($",{productName},")).ToList();
            File.WriteAllLines(filePath, lines);
            LoadBasket();
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadBasket();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBasket();
        }


        public class Product
        {
            public string ImagePath { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Manufacturer { get; set; }

            public override string ToString()
            {
                return $"{ImagePath},{Name},{Price},{Quantity}, {Manufacturer}";
            }
        }

        private void tabPersonal_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCard formCard = new FormCard();
            this.Hide();
            formCard.FormClosing += (s, args) => this.Close();
            formCard.Show();

        }
    }
}
