namespace Storage
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuBar = new System.Windows.Forms.MenuStrip();
            this.системаХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьКаталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заблокироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newbtn = new System.Windows.Forms.Button();
            this.quantitynum = new System.Windows.Forms.NumericUpDown();
            this.savebtn = new System.Windows.Forms.Button();
            this.commenttxt = new System.Windows.Forms.RichTextBox();
            this.containercombo = new System.Windows.Forms.ComboBox();
            this.areacombo = new System.Windows.Forms.ComboBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.MainMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynum)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuBar
            // 
            this.MainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаХраненияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.MainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBar.Name = "MainMenuBar";
            this.MainMenuBar.Size = new System.Drawing.Size(754, 24);
            this.MainMenuBar.TabIndex = 1;
            this.MainMenuBar.Text = "MainMenuBar";
            // 
            // системаХраненияToolStripMenuItem
            // 
            this.системаХраненияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.обновитьКаталогToolStripMenuItem,
            this.toolStripSeparator1,
            this.настройкиToolStripMenuItem,
            this.toolStripSeparator2,
            this.заблокироватьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.системаХраненияToolStripMenuItem.Name = "системаХраненияToolStripMenuItem";
            this.системаХраненияToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.системаХраненияToolStripMenuItem.Text = "Система хранения";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поискToolStripMenuItem.Image")));
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            this.поискToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // обновитьКаталогToolStripMenuItem
            // 
            this.обновитьКаталогToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обновитьКаталогToolStripMenuItem.Image")));
            this.обновитьКаталогToolStripMenuItem.Name = "обновитьКаталогToolStripMenuItem";
            this.обновитьКаталогToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.обновитьКаталогToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.обновитьКаталогToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.обновитьКаталогToolStripMenuItem.Text = "Обновить каталог";
            this.обновитьКаталогToolStripMenuItem.Click += new System.EventHandler(this.обновитьКаталогToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыБазыДанныхToolStripMenuItem,
            this.сменитьПарольToolStripMenuItem});
            this.настройкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкиToolStripMenuItem.Image")));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // параметрыБазыДанныхToolStripMenuItem
            // 
            this.параметрыБазыДанныхToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("параметрыБазыДанныхToolStripMenuItem.Image")));
            this.параметрыБазыДанныхToolStripMenuItem.Name = "параметрыБазыДанныхToolStripMenuItem";
            this.параметрыБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.параметрыБазыДанныхToolStripMenuItem.Text = "Общие настройки";
            this.параметрыБазыДанныхToolStripMenuItem.Click += new System.EventHandler(this.параметрыБазыДанныхToolStripMenuItem_Click);
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сменитьПарольToolStripMenuItem.Image")));
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.сменитьПарольToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // заблокироватьToolStripMenuItem
            // 
            this.заблокироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заблокироватьToolStripMenuItem.Image")));
            this.заблокироватьToolStripMenuItem.Name = "заблокироватьToolStripMenuItem";
            this.заблокироватьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + L";
            this.заблокироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.заблокироватьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.заблокироватьToolStripMenuItem.Text = "Заблокировать";
            this.заблокироватьToolStripMenuItem.Click += new System.EventHandler(this.заблокироватьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("закрытьToolStripMenuItem.Image")));
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainGrid.Location = new System.Drawing.Point(12, 27);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.RowTemplate.ReadOnly = true;
            this.MainGrid.Size = new System.Drawing.Size(730, 257);
            this.MainGrid.TabIndex = 2;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellClick);
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.StatusBar.Location = new System.Drawing.Point(0, 384);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(754, 22);
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "StatusBar";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(45, 17);
            this.statuslbl.Text = "Готово";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.newbtn);
            this.panel1.Controls.Add(this.quantitynum);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.commenttxt);
            this.panel1.Controls.Add(this.containercombo);
            this.panel1.Controls.Add(this.areacombo);
            this.panel1.Controls.Add(this.titletxt);
            this.panel1.Location = new System.Drawing.Point(12, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 92);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(619, 5);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(106, 23);
            this.newbtn.TabIndex = 6;
            this.newbtn.Text = "Новый";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // quantitynum
            // 
            this.quantitynum.Location = new System.Drawing.Point(160, 5);
            this.quantitynum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantitynum.Name = "quantitynum";
            this.quantitynum.Size = new System.Drawing.Size(66, 20);
            this.quantitynum.TabIndex = 5;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(619, 32);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(106, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Сохранить";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // commenttxt
            // 
            this.commenttxt.Location = new System.Drawing.Point(232, 4);
            this.commenttxt.Name = "commenttxt";
            this.commenttxt.Size = new System.Drawing.Size(381, 79);
            this.commenttxt.TabIndex = 3;
            this.commenttxt.Text = "";
            // 
            // containercombo
            // 
            this.containercombo.FormattingEnabled = true;
            this.containercombo.Location = new System.Drawing.Point(4, 62);
            this.containercombo.Name = "containercombo";
            this.containercombo.Size = new System.Drawing.Size(222, 21);
            this.containercombo.TabIndex = 2;
            // 
            // areacombo
            // 
            this.areacombo.FormattingEnabled = true;
            this.areacombo.Location = new System.Drawing.Point(4, 34);
            this.areacombo.Name = "areacombo";
            this.areacombo.Size = new System.Drawing.Size(222, 21);
            this.areacombo.TabIndex = 1;
            // 
            // titletxt
            // 
            this.titletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titletxt.Location = new System.Drawing.Point(4, 4);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(150, 23);
            this.titletxt.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.MainMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenuBar;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Управление каталогом";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenuBar.ResumeLayout(false);
            this.MainMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem системаХраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыБазыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem заблокироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        private System.Windows.Forms.ToolStripMenuItem обновитьКаталогToolStripMenuItem;
        public System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.ComboBox containercombo;
        private System.Windows.Forms.ComboBox areacombo;
        private System.Windows.Forms.RichTextBox commenttxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.NumericUpDown quantitynum;
        private System.Windows.Forms.Button newbtn;
    }
}

