using System.Reflection;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool who;
        public Form1()
        {
            InitializeComponent();
            Buyer.Visible = true;
            dealer.Visible = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Buyer_Click(object sender, EventArgs e)
        {
            Buyer.Visible = false;
            dealer.Visible = false;
            who = true;
        }

        private void dealer_Click(object sender, EventArgs e)
        {
            Buyer.Visible = false;
            dealer.Visible = false;
            who = false;
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null) 
            {
                string alltext = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\n";
                if(who == true)
                {
                    if (File.Exists("Users.txt"))
                    {
                        string fileText = File.ReadAllText("Users.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1 || fileText.IndexOf(textBox3.Text) != -1)
                        {
                            RegBut.Text = "Войти";
                            if (fileText.Contains(alltext))
                            {
                                MessageBox.Show("вы вошли");
                            }
                            else
                            {
                                MessageBox.Show("не верный логин, праоль или телефон");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Новый пользователь сохранен");
                            File.AppendAllText("Users.txt", alltext);
                        }
                    }
                }
                else if (who == false) 
                {
                    if (File.Exists("Dealers.txt"))
                    {
                        string fileText = File.ReadAllText("Dealers.txt");
                        if (fileText.IndexOf(textBox1.Text) != -1 || fileText.IndexOf(textBox3.Text) != -1)
                        {
                            RegBut.Text = "Войти";
                            if (fileText.Contains(alltext))
                            {
                                MessageBox.Show("вы вошли");
                            }
                            else
                            {
                                MessageBox.Show("не верный логин, праоль или телефон");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Новый пользователь сохранен");
                            File.AppendAllText("Dealers.txt", alltext);
                        }
                    }
                }


            }
        }
    }
}
