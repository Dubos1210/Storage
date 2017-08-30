using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace InputBox
{
    public class InputBox : Form
    {
        TextBox textBox;

        public InputBox(string text)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Size = new Size(300, 150);
            this.Text = "";

            /* Создаем текстовое поле. -> */

            textBox = new TextBox();
            textBox.Size = new Size(250, 25);
            textBox.Font = new Font(TextBox.DefaultFont, FontStyle.Regular);
            textBox.Location = new Point(20, 50);
            textBox.Text = "";

            this.Controls.Add(textBox);

            textBox.Show();

            textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            /* Создаем текстовое поле. <- */

            /* Создаем метку. -> */

            Label label = new Label();
            label.AutoSize = false;
            label.Size = new Size(250, 25);
            label.Font = new Font(label.Font, FontStyle.Regular);
            label.Location = new Point(20, 25);
            label.Text = text;

            this.Controls.Add(label);

            label.Show();

            /* Создаем метку. <- */

            /* Создаем кнопку "OK". -> */

            Button buttonOK = new Button();
            buttonOK.Size = new Size(80, 25);
            buttonOK.Location = new Point(105, 75);
            buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonOK.Text = "OK";

            this.Controls.Add(buttonOK);

            buttonOK.Show();

            /* Создаем кнопку "OK". <- */

            /* Создаем кнопку "Cancel". -> */

            Button buttonCancel = new Button();
            buttonCancel.Size = new Size(80, 25);
            buttonCancel.Location = new Point(190, 75);
            buttonCancel.Text = "Cancel";

            this.Controls.Add(buttonCancel);

            buttonCancel.Show();

            buttonCancel.Click += new EventHandler(buttonCancel_Click);

            /* Создаем кнопку "OK". <- */
        }

        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this.Close();
            }
        }

        public void buttonCancel_Click(object sander, EventArgs e)
        {
                 Process.GetCurrentProcess().Kill();
        }

        public string getString()
        {
            if (this.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return null;

            return textBox.Text;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputBox";
            this.ResumeLayout(false);

        }
    }
}
