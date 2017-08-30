namespace Storage
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.oldtxt = new System.Windows.Forms.TextBox();
            this.oldlbl = new System.Windows.Forms.Label();
            this.newlbl = new System.Windows.Forms.Label();
            this.newtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newtxt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldtxt
            // 
            this.oldtxt.Location = new System.Drawing.Point(206, 9);
            this.oldtxt.Name = "oldtxt";
            this.oldtxt.Size = new System.Drawing.Size(159, 20);
            this.oldtxt.TabIndex = 0;
            // 
            // oldlbl
            // 
            this.oldlbl.AutoSize = true;
            this.oldlbl.Location = new System.Drawing.Point(12, 12);
            this.oldlbl.Name = "oldlbl";
            this.oldlbl.Size = new System.Drawing.Size(188, 13);
            this.oldlbl.TabIndex = 1;
            this.oldlbl.Text = "Старый пароль (по умолчанию: 111)";
            // 
            // newlbl
            // 
            this.newlbl.AutoSize = true;
            this.newlbl.Location = new System.Drawing.Point(12, 38);
            this.newlbl.Name = "newlbl";
            this.newlbl.Size = new System.Drawing.Size(80, 13);
            this.newlbl.TabIndex = 2;
            this.newlbl.Text = "Новый пароль";
            // 
            // newtxt
            // 
            this.newtxt.Location = new System.Drawing.Point(206, 35);
            this.newtxt.Name = "newtxt";
            this.newtxt.Size = new System.Drawing.Size(159, 20);
            this.newtxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Новый пароль (повтор)";
            // 
            // newtxt2
            // 
            this.newtxt2.Location = new System.Drawing.Point(206, 61);
            this.newtxt2.Name = "newtxt2";
            this.newtxt2.Size = new System.Drawing.Size(159, 20);
            this.newtxt2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(15, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сменить пароль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 119);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newtxt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newtxt);
            this.Controls.Add(this.newlbl);
            this.Controls.Add(this.oldlbl);
            this.Controls.Add(this.oldtxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldtxt;
        private System.Windows.Forms.Label oldlbl;
        private System.Windows.Forms.Label newlbl;
        private System.Windows.Forms.TextBox newtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newtxt2;
        private System.Windows.Forms.Button button1;
    }
}