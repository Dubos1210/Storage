using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Storage
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            if (oldtxt.Text == "" || newtxt.Text == "" || newtxt2.Text == "") {
                MessageBox.Show("Необходимо заполнить все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (GetMd5Hash(md5Hash, oldtxt.Text) == Properties.Settings.Default.Password && newtxt.Text == newtxt2.Text)
            {
                Properties.Settings.Default.Password = GetMd5Hash(md5Hash, newtxt.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Пароль изменен", "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else {
                MessageBox.Show("Проверьте правильность ввода паролей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
