using Microsoft.VisualBasic.ApplicationServices;

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
    public partial class FormCard : Form
    {
        public FormCard()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("chip.png");
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("данные сохранены");
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
