namespace Storage
{
    partial class Bugreport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bugreport));
            this.label1 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modulecombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.abouttxt = new System.Windows.Forms.RichTextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваше имя";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(15, 26);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(257, 20);
            this.usertxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail для ответа";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(15, 70);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(257, 20);
            this.emailtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Модуль, в котором произошла ошибка";
            // 
            // modulecombo
            // 
            this.modulecombo.FormattingEnabled = true;
            this.modulecombo.Items.AddRange(new object[] {
            "Таблица",
            "Редактор",
            "Настройки",
            "Смена пароля",
            "Парольная защита",
            "Справка",
            "Прочее"});
            this.modulecombo.Location = new System.Drawing.Point(15, 114);
            this.modulecombo.Name = "modulecombo";
            this.modulecombo.Size = new System.Drawing.Size(257, 21);
            this.modulecombo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание ошибки";
            // 
            // abouttxt
            // 
            this.abouttxt.Location = new System.Drawing.Point(15, 159);
            this.abouttxt.Name = "abouttxt";
            this.abouttxt.Size = new System.Drawing.Size(257, 96);
            this.abouttxt.TabIndex = 7;
            this.abouttxt.Text = "";
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(13, 262);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(259, 23);
            this.sendbtn.TabIndex = 8;
            this.sendbtn.Text = "Отправить";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // Bugreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.abouttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modulecombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bugreport";
            this.Text = "Сообщить об ошибке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox modulecombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox abouttxt;
        private System.Windows.Forms.Button sendbtn;
    }
}