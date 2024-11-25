using System.Reflection;
using System.IO;

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
                string alltext = textBox1.Text + " " + textBox2.Text;
                File.AppendAllText("Users.txt", alltext);
            }
        }
    }
}
