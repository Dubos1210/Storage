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
using MySql.Data.MySqlClient;

namespace Storage
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Variables
        public bool unlocked = false;
              
        public void GridRefresh() {
            string Connect = "Database="+Properties.Settings.Default.MySQLDatabase+";Data Source=" + Properties.Settings.Default.ServerIP + ";User Id=" + Properties.Settings.Default.MySQLUser + ";Password=" + Properties.Settings.Default.MySQLPassword;
            //string Connect = "Database=storage;Data Source=localhost;User Id=root;Password=";

            MySqlConnection myConnection = new MySqlConnection(Connect);
            try {
                myConnection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
                statuslbl.Text = "Jшибка подключения к базе данных";
            }

            MainGrid.ReadOnly = false;
            MainGrid.Rows.Clear();

            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM  `mainstorage`", myConnection);
            MySqlDataReader MyDataReader;
            try {
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    //MainGrid.Rows.Add(MyDataReader.GetString(1), MyDataReader.GetString(2), MyDataReader.GetString(3), MyDataReader.GetString(4), MyDataReader.GetString(5), MyDataReader.GetString(6));
                    MainGrid.Rows.Add(MyDataReader.GetString(0), MyDataReader.GetString(1), MyDataReader.GetString(2), MyDataReader.GetString(3), MyDataReader.GetString(4), MyDataReader.GetString(5));
                }
                MyDataReader.Close();
            }
            catch (System.InvalidOperationException ex) {
                statuslbl.Text = "Ошибка работы с MySQL";
            }

            MainGrid.ReadOnly = true;

            myConnection.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //login
            statuslbl.Text = "Введите пароль";
            MD5 md5Hash = MD5.Create();
            while (!unlocked)
            {
                InputBox.InputBox inputBox = new InputBox.InputBox("Введите пароль:");
                if (GetMd5Hash(md5Hash, inputBox.getString()) == Properties.Settings.Default.Password)
                {
                    unlocked = true;
                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода пароля!", "Вход в систему", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }               
            }


            //Grid
            var id = new DataGridViewColumn();
            id.HeaderText = "ID";
            id.Width = 30;
            id.ReadOnly = true;
            id.Name = "id";
            id.Frozen = true;
            id.CellTemplate = new DataGridViewTextBoxCell();
            MainGrid.Columns.Add(id); 

             var column1 = new DataGridViewColumn();
            column1.HeaderText = "Наименование";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "title";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();
            MainGrid.Columns.Add(column1);

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Кол-во";
            column2.Width = 50;
            column2.ReadOnly = true;
            column2.Name = "comment";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();
            MainGrid.Columns.Add(column2);

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Комментарий";
            column3.Width = 200;
            column3.ReadOnly = true;
            column3.Name = "comment";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();
            MainGrid.Columns.Add(column3);

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Область хранения";
            column4.Width = 100;
            column4.ReadOnly = true;
            column4.Name = "area";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();
            MainGrid.Columns.Add(column4);

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Ячейка";
            column5.Width = 100;
            column5.ReadOnly = true;
            column5.Name = "container";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();
            MainGrid.Columns.Add(column5);

           /* var column6 = new DataGridViewColumn();
            column6.HeaderText = "Дата последнего обращения";
            column6.Width = 100;
            column6.ReadOnly = true;
            column6.Name = "date";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();
            MainGrid.Columns.Add(column6);*/

            MainGrid.ReadOnly = true;
            GridRefresh();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void обновитьКаталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridRefresh();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            if (search.DialogResult == DialogResult.OK) {
                find(search.searchquery());
            }
        }

        public void find(string[] data) {
            string Connect = "Database=" + Properties.Settings.Default.MySQLDatabase + ";Data Source=" + Properties.Settings.Default.ServerIP + ";User Id=" + Properties.Settings.Default.MySQLUser + ";Password=" + Properties.Settings.Default.MySQLPassword;
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();

            MainGrid.ReadOnly = false;
            MainGrid.Rows.Clear();

            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM mainstorage WHERE(LOCATE(LOWER('" + data[0] + "'), LOWER(" + data[1] + ")) > 0)", myConnection);
            MySqlDataReader MyDataReader;
            try
            {
                MyDataReader = myCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    //MainGrid.Rows.Add(MyDataReader.GetString(1), MyDataReader.GetString(2), MyDataReader.GetString(3), MyDataReader.GetString(4), MyDataReader.GetString(5), MyDataReader.GetString(6));
                    MainGrid.Rows.Add(MyDataReader.GetString(0), MyDataReader.GetString(1), MyDataReader.GetString(2), MyDataReader.GetString(3), MyDataReader.GetString(4), MyDataReader.GetString(5));
                }
                MyDataReader.Close();
            }
            catch (System.InvalidOperationException ex)
            {
                statuslbl.Text = "Ошибка работы с MySQL";
            }

            MainGrid.ReadOnly = true;

            myConnection.Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://dubos.esy.es/", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void заблокироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            unlocked = false;
            statuslbl.Text = "Введите пароль";
            MD5 md5Hash = MD5.Create();
            while (!unlocked)
            {
                InputBox.InputBox inputBox = new InputBox.InputBox("Введите пароль:");
                if (GetMd5Hash(md5Hash, inputBox.getString()) == Properties.Settings.Default.Password)
                {
                    unlocked = true;
                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода пароля!", "Вход в систему", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            }
            this.Enabled = true;
        }

        private void MainGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            titletxt.Text = MainGrid[1, MainGrid.CurrentRow.Index].Value.ToString();
            quantitynum.Value = Convert.ToInt32(MainGrid[2, MainGrid.CurrentRow.Index].Value.ToString());
            commenttxt.Text = MainGrid[3, MainGrid.CurrentRow.Index].Value.ToString();
            areacombo.Text = MainGrid[4, MainGrid.CurrentRow.Index].Value.ToString();
            containercombo.Text = MainGrid[5, MainGrid.CurrentRow.Index].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            string Connect = "Database=" + Properties.Settings.Default.MySQLDatabase + ";Data Source=" + Properties.Settings.Default.ServerIP + ";User Id=" + Properties.Settings.Default.MySQLUser + ";Password=" + Properties.Settings.Default.MySQLPassword;
            MySqlConnection myConnection = new MySqlConnection(Connect);
            try {
                myConnection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
                statuslbl.Text = "Ошибка подключения к базе данных";
            }

            MySqlCommand myCommand = new MySqlCommand("INSERT INTO `storage`.`mainstorage` (`id` , `title` , `quantity` , `comment` , `area` , `container` , `date`) VALUES (NULL, '"+titletxt.Text+"', '"+quantitynum.Value.ToString()+"', '"+commenttxt.Text+"', '"+areacombo.Text+"', '"+containercombo.Text+"', '')", myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            
            GridRefresh();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string Connect = "Database=" + Properties.Settings.Default.MySQLDatabase + ";Data Source=" + Properties.Settings.Default.ServerIP + ";User Id=" + Properties.Settings.Default.MySQLUser + ";Password=" + Properties.Settings.Default.MySQLPassword;
            MySqlConnection myConnection = new MySqlConnection(Connect);
            try
            {
                myConnection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                statuslbl.Text = "Ошибка подключения к базе данных";
            }

            MySqlCommand myCommand = new MySqlCommand("INSERT INTO `storage`.`mainstorage` (`id` , `title` , `quantity` , `comment` , `area` , `container` , `date`) VALUES (NULL, '" + titletxt.Text + "', '" + quantitynum.Value.ToString() + "', '" + commenttxt.Text + "', '" + areacombo.Text + "', '" + containercombo.Text + "', '')", myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();

            GridRefresh();
        }
    }
}
