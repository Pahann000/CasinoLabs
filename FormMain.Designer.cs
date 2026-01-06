namespace CasinoLabs
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.infoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.staffToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.playersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.positionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tablesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(549, 30);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.playersToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.сеансыToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gameToolStripMenuItem.Image")));
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.TasksToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("staffToolStripMenuItem.Image")));
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.ShortcutKeyDisplayString = "Alt+M";
            this.staffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playersToolStripMenuItem.Image")));
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.WorkerButton_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("должностиToolStripMenuItem.Image")));
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.должностиToolStripMenuItem.Text = "Positions";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // сеансыToolStripMenuItem
            // 
            this.сеансыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сеансыToolStripMenuItem.Image")));
            this.сеансыToolStripMenuItem.Name = "сеансыToolStripMenuItem";
            this.сеансыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.сеансыToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.сеансыToolStripMenuItem.Text = "Poker Tables";
            this.сеансыToolStripMenuItem.Click += new System.EventHandler(this.SessionButton_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.справочникToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(164, 52);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem1.Image")));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem1.Image")));
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem1
            // 
            this.справочникToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачиToolStripMenuItem1,
            this.сотрудникиToolStripMenuItem1,
            this.фильмыToolStripMenuItem1,
            this.сотрудникиToolStripMenuItem3,
            this.должностиToolStripMenuItem1,
            this.сеансыToolStripMenuItem1});
            this.справочникToolStripMenuItem1.Name = "справочникToolStripMenuItem1";
            this.справочникToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.справочникToolStripMenuItem1.Text = "Справочник";
            // 
            // задачиToolStripMenuItem1
            // 
            this.задачиToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("задачиToolStripMenuItem1.Image")));
            this.задачиToolStripMenuItem1.Name = "задачиToolStripMenuItem1";
            this.задачиToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.задачиToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.задачиToolStripMenuItem1.Text = "Заказчики";
            this.задачиToolStripMenuItem1.Click += new System.EventHandler(this.TasksToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникиToolStripMenuItem1.Image")));
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem1.Click += new System.EventHandler(this.EmployeesToolStripMenuItem_Click);
            // 
            // фильмыToolStripMenuItem1
            // 
            this.фильмыToolStripMenuItem1.Name = "фильмыToolStripMenuItem1";
            this.фильмыToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.фильмыToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.фильмыToolStripMenuItem1.Text = "Фильмы";
            this.фильмыToolStripMenuItem1.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem3
            // 
            this.сотрудникиToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникиToolStripMenuItem3.Image")));
            this.сотрудникиToolStripMenuItem3.Name = "сотрудникиToolStripMenuItem3";
            this.сотрудникиToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.сотрудникиToolStripMenuItem3.Size = new System.Drawing.Size(226, 26);
            this.сотрудникиToolStripMenuItem3.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem3.Click += new System.EventHandler(this.WorkerButton_Click);
            // 
            // должностиToolStripMenuItem1
            // 
            this.должностиToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("должностиToolStripMenuItem1.BackgroundImage")));
            this.должностиToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("должностиToolStripMenuItem1.Image")));
            this.должностиToolStripMenuItem1.Name = "должностиToolStripMenuItem1";
            this.должностиToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.должностиToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.должностиToolStripMenuItem1.Text = "Должности";
            this.должностиToolStripMenuItem1.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // сеансыToolStripMenuItem1
            // 
            this.сеансыToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("сеансыToolStripMenuItem1.Image")));
            this.сеансыToolStripMenuItem1.Name = "сеансыToolStripMenuItem1";
            this.сеансыToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.сеансыToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.сеансыToolStripMenuItem1.Text = "Сеансы";
            this.сеансыToolStripMenuItem1.Click += new System.EventHandler(this.SessionButton_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.infoToolStripButton,
            this.gameToolStripButton,
            this.staffToolStripButton,
            this.playersToolStripButton,
            this.positionsToolStripButton,
            this.tablesToolStripButton});
            this.toolStripMain.Location = new System.Drawing.Point(0, 30);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(549, 31);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Закрыть программу";
            this.toolStripButton1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // infoToolStripButton
            // 
            this.infoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripButton.Image")));
            this.infoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoToolStripButton.Name = "infoToolStripButton";
            this.infoToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.infoToolStripButton.Text = "toolStripButton2";
            this.infoToolStripButton.ToolTipText = "О программе";
            this.infoToolStripButton.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // gameToolStripButton
            // 
            this.gameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gameToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("gameToolStripButton.Image")));
            this.gameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameToolStripButton.Name = "gameToolStripButton";
            this.gameToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.gameToolStripButton.Text = "Game";
            this.gameToolStripButton.ToolTipText = "Game";
            this.gameToolStripButton.Click += new System.EventHandler(this.TasksToolStripMenuItem_Click);
            // 
            // staffToolStripButton
            // 
            this.staffToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.staffToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("staffToolStripButton.Image")));
            this.staffToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.staffToolStripButton.Name = "staffToolStripButton";
            this.staffToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.staffToolStripButton.Text = "Staff";
            this.staffToolStripButton.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // playersToolStripButton
            // 
            this.playersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("playersToolStripButton.Image")));
            this.playersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playersToolStripButton.Name = "playersToolStripButton";
            this.playersToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.playersToolStripButton.Text = "Players";
            this.playersToolStripButton.Click += new System.EventHandler(this.WorkerButton_Click);
            // 
            // positionsToolStripButton
            // 
            this.positionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.positionsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("positionsToolStripButton.Image")));
            this.positionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.positionsToolStripButton.Name = "positionsToolStripButton";
            this.positionsToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.positionsToolStripButton.Text = "Positions";
            this.positionsToolStripButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // tablesToolStripButton
            // 
            this.tablesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tablesToolStripButton.Image = global::CasinoLabs.Properties.Resources._631329317c28a17d3e632d0e3f61dd94;
            this.tablesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tablesToolStripButton.Name = "tablesToolStripButton";
            this.tablesToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.tablesToolStripButton.Text = "Tables";
            this.tablesToolStripButton.Click += new System.EventHandler(this.SessionButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 320);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::CasinoLabs.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.RightToLeftLayout = true;
            this.Text = "Программа для работы казино";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton infoToolStripButton;
        private System.Windows.Forms.ToolStripButton gameToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton staffToolStripButton;
        private System.Windows.Forms.ToolStripButton playersToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильмыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem3;
        private System.Windows.Forms.ToolStripButton positionsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tablesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem1;
    }
}

