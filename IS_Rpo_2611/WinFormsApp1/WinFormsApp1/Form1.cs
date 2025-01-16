using System.Reflection;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool dealerCh;
        bool userCh;

        bool length;
        bool empty;
        bool symbol;
        public Form1()
        {
            InitializeComponent();
            Buyer.Visible = true;
            dealer.Visible = true;
            textBox2.UseSystemPasswordChar = true;
            panel1.Visible = false;
        }


        private static bool IsValidPassword(string password)
        {
            // Проверка смежных клавиш на англоязычной раскладке
            for (int i = 0; i < password.Length - 1; i++)
            {
                char currentChar = password[i];
                char nextChar = password[i + 1];

                if ((currentChar + 1) == nextChar || (nextChar + 1) == currentChar)
                {
                    if (!((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z')) ||
                        !((nextChar >= 'a' && nextChar <= 'z') || (nextChar >= 'A' && nextChar <= 'Z')))
                    {
                        return false;
                    }
                }
            }

            return true;
        }



        private void Buyer_Click(object sender, EventArgs e)
        {
            Buyer.Visible = false;
            dealer.Visible = false;
            userCh = true;
        }



        private void dealer_Click(object sender, EventArgs e)
        {
            Buyer.Visible = false;
            dealer.Visible = false;
            dealerCh = true;
        }



        private void RegBut_Click(object sender, EventArgs e)
        {
            empty = true;
            symbol = true;
            length = true;


            if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                length = false;
            }

            if (textBox2.Text.Contains(" "))
            {
                MessageBox.Show("Пароль не должен содержать пробелов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                empty = false;
            }



            var specialChars = "!��;@%;?:";
            if (!textBox2.Text.Any(char.IsUpper) || !textBox2.Text.Any(char.IsLower) || !textBox2.Text.Any(char.IsDigit) || !textBox2.Text.Any(c => specialChars.Contains(c)))
            {
                MessageBox.Show("Пароль должен содержать цифры, буквы разного регистра и хотя бы один спецсимвол (!»№;@%;?:).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                symbol = false;
            }


            if (textBox1.Text != null && textBox2.Text != null)
            {
                string alltext = textBox1.Text + " " + textBox2.Text + "\n";
                if (userCh == true)
                {
                    if (File.Exists("Users.txt"))
                    {
                        string fileText = File.ReadAllText("Users.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1)
                        {
                            MessageBox.Show("Такой пользователь уже существует");
                        }
                        else if (IsValidEmail(textBox1.Text) && length != false && empty != false && symbol != false && IsValidPassword(textBox2.Text) && textBox1.Text != textBox2.Text)
                        {
                            MessageBox.Show("Новый пользователь сохранен");
                            File.AppendAllText("Users.txt", alltext);
                        }
                    }
                }
                else if (dealerCh == true)
                {
                    if (File.Exists("Dealers.txt"))
                    {
                        string fileText = File.ReadAllText("Dealers.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1)
                        {
                            MessageBox.Show("Такой пользователь уже существует");
                        }
                        else if (IsValidEmail(textBox1.Text) && length != false && empty != false && symbol != false && IsValidPassword(textBox2.Text) && textBox1.Text != textBox2.Text)
                        {
                            MessageBox.Show("Новый пользователь сохранен");
                            File.AppendAllText("Dealers.txt", alltext);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Вам нужно выбрать: покупатель/продавец");
                }
            }
        }



        private void EntraceBut_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                string inputEmail = textBox1.Text.Trim();
                string inputPassword = textBox2.Text.Trim();
                string alltext = inputEmail + " " + inputPassword + "\n";

                string fileName = "no.txt";

                if (dealerCh == true)
                {
                    fileName = "Dealers.txt";
                }
                else if (userCh == true)
                {
                    fileName = "Users.txt";
                }

                if (File.Exists(fileName))
                {
                    string[] fileLines = File.ReadAllLines(fileName);

                    bool userExists = false;
                    foreach (var line in fileLines)
                    {
                        var parts = line.Split(' ');
                        if (parts.Length == 2 && parts[0] == inputEmail && parts[1] == inputPassword)
                        {
                            userExists = true;
                            break;
                        }
                    }

                    if (userExists)
                    {
                        MessageBox.Show("Добро пожаловать");
                        Form2 f = new Form2(dealerCh, userCh, textBox1.Text);
                        this.Hide();
                        f.FormClosing += (s, args) => this.Close();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("неправильный логин или пароль");
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
            }
        }





        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                MessageBox.Show("норм почта");
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("плохая почта");
                return false;
            }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
