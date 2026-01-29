namespace CasinoLabs
{
    partial class PokerTableForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label table_idLabel1;
            System.Windows.Forms.Label table_numberLabel1;
            System.Windows.Forms.Label table_typeLabel1;
            System.Windows.Forms.Label statusLabel1;
            System.Windows.Forms.Label max_playersLabel1;
            System.Windows.Forms.Label is_reservedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokerTableForm));
            this.казиноDataSet = new CasinoLabs.КазиноDataSet1();
            this.pokerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokerTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pokerTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gameParticipationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openPlayerButton = new System.Windows.Forms.Button();
            this.pokerTableTableAdapter = new CasinoLabs.КазиноDataSet1TableAdapters.PokerTableTableAdapter();
            this.tableAdapterManager = new CasinoLabs.КазиноDataSet1TableAdapters.TableAdapterManager();
            this.table_idTextBox1 = new System.Windows.Forms.TextBox();
            this.table_numberTextBox1 = new System.Windows.Forms.TextBox();
            this.table_typeTextBox1 = new System.Windows.Forms.TextBox();
            this.statusTextBox1 = new System.Windows.Forms.TextBox();
            this.max_playersTextBox1 = new System.Windows.Forms.TextBox();
            this.is_reservedCheckBox = new System.Windows.Forms.CheckBox();
            this.gameParticipationTableAdapter = new CasinoLabs.КазиноDataSet1TableAdapters.GameParticipationTableAdapter();
            this.gameParticipationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            table_idLabel1 = new System.Windows.Forms.Label();
            table_numberLabel1 = new System.Windows.Forms.Label();
            table_typeLabel1 = new System.Windows.Forms.Label();
            statusLabel1 = new System.Windows.Forms.Label();
            max_playersLabel1 = new System.Windows.Forms.Label();
            is_reservedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.казиноDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerTableBindingNavigator)).BeginInit();
            this.pokerTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameParticipationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameParticipationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // table_idLabel1
            // 
            table_idLabel1.AutoSize = true;
            table_idLabel1.Location = new System.Drawing.Point(8, 38);
            table_idLabel1.Name = "table_idLabel1";
            table_idLabel1.Size = new System.Drawing.Size(54, 16);
            table_idLabel1.TabIndex = 16;
            table_idLabel1.Text = "table id:";
            // 
            // table_numberLabel1
            // 
            table_numberLabel1.AutoSize = true;
            table_numberLabel1.Location = new System.Drawing.Point(8, 66);
            table_numberLabel1.Name = "table_numberLabel1";
            table_numberLabel1.Size = new System.Drawing.Size(88, 16);
            table_numberLabel1.TabIndex = 18;
            table_numberLabel1.Text = "table number:";
            // 
            // table_typeLabel1
            // 
            table_typeLabel1.AutoSize = true;
            table_typeLabel1.Location = new System.Drawing.Point(8, 94);
            table_typeLabel1.Name = "table_typeLabel1";
            table_typeLabel1.Size = new System.Drawing.Size(69, 16);
            table_typeLabel1.TabIndex = 20;
            table_typeLabel1.Text = "table type:";
            // 
            // statusLabel1
            // 
            statusLabel1.AutoSize = true;
            statusLabel1.Location = new System.Drawing.Point(8, 122);
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new System.Drawing.Size(45, 16);
            statusLabel1.TabIndex = 22;
            statusLabel1.Text = "status:";
            // 
            // max_playersLabel1
            // 
            max_playersLabel1.AutoSize = true;
            max_playersLabel1.Location = new System.Drawing.Point(8, 150);
            max_playersLabel1.Name = "max_playersLabel1";
            max_playersLabel1.Size = new System.Drawing.Size(83, 16);
            max_playersLabel1.TabIndex = 24;
            max_playersLabel1.Text = "max players:";
            // 
            // is_reservedLabel
            // 
            is_reservedLabel.AutoSize = true;
            is_reservedLabel.Location = new System.Drawing.Point(8, 180);
            is_reservedLabel.Name = "is_reservedLabel";
            is_reservedLabel.Size = new System.Drawing.Size(77, 16);
            is_reservedLabel.TabIndex = 26;
            is_reservedLabel.Text = "is reserved:";
            // 
            // казиноDataSet
            // 
            this.казиноDataSet.DataSetName = "КазиноDataSet";
            this.казиноDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokerTableBindingSource
            // 
            this.pokerTableBindingSource.DataMember = "PokerTable";
            this.pokerTableBindingSource.DataSource = this.казиноDataSet;
            // 
            // pokerTableBindingNavigator
            // 
            this.pokerTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pokerTableBindingNavigator.BindingSource = this.pokerTableBindingSource;
            this.pokerTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pokerTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pokerTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pokerTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pokerTableBindingNavigatorSaveItem});
            this.pokerTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pokerTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pokerTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pokerTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pokerTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pokerTableBindingNavigator.Name = "pokerTableBindingNavigator";
            this.pokerTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pokerTableBindingNavigator.Size = new System.Drawing.Size(1068, 31);
            this.pokerTableBindingNavigator.TabIndex = 0;
            this.pokerTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // pokerTableBindingNavigatorSaveItem
            // 
            this.pokerTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pokerTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pokerTableBindingNavigatorSaveItem.Image")));
            this.pokerTableBindingNavigatorSaveItem.Name = "pokerTableBindingNavigatorSaveItem";
            this.pokerTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.pokerTableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.pokerTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.pokerTableBindingNavigatorSaveItem_Click);
            // 
            // gameParticipationBindingSource
            // 
            this.gameParticipationBindingSource.DataMember = "GameParticipation";
            this.gameParticipationBindingSource.DataSource = this.казиноDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator1.BindingSource = this.gameParticipationBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(22, 240);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(312, 31);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // openPlayerButton
            // 
            this.openPlayerButton.Location = new System.Drawing.Point(404, 63);
            this.openPlayerButton.Name = "openPlayerButton";
            this.openPlayerButton.Size = new System.Drawing.Size(134, 23);
            this.openPlayerButton.TabIndex = 16;
            this.openPlayerButton.Text = "Открыть игроков";
            this.openPlayerButton.UseVisualStyleBackColor = true;
            this.openPlayerButton.Click += new System.EventHandler(this.openPlayerButton_Click);
            // 
            // pokerTableTableAdapter
            // 
            this.pokerTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GameParticipationTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.PlayerTableAdapter = null;
            this.tableAdapterManager.PokerTableTableAdapter = this.pokerTableTableAdapter;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CasinoLabs.КазиноDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_idTextBox1
            // 
            this.table_idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokerTableBindingSource, "table_id", true));
            this.table_idTextBox1.Location = new System.Drawing.Point(102, 35);
            this.table_idTextBox1.Name = "table_idTextBox1";
            this.table_idTextBox1.Size = new System.Drawing.Size(104, 22);
            this.table_idTextBox1.TabIndex = 17;
            // 
            // table_numberTextBox1
            // 
            this.table_numberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokerTableBindingSource, "table_number", true));
            this.table_numberTextBox1.Location = new System.Drawing.Point(102, 63);
            this.table_numberTextBox1.Name = "table_numberTextBox1";
            this.table_numberTextBox1.Size = new System.Drawing.Size(104, 22);
            this.table_numberTextBox1.TabIndex = 19;
            // 
            // table_typeTextBox1
            // 
            this.table_typeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokerTableBindingSource, "table_type", true));
            this.table_typeTextBox1.Location = new System.Drawing.Point(102, 91);
            this.table_typeTextBox1.Name = "table_typeTextBox1";
            this.table_typeTextBox1.Size = new System.Drawing.Size(104, 22);
            this.table_typeTextBox1.TabIndex = 21;
            // 
            // statusTextBox1
            // 
            this.statusTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokerTableBindingSource, "status", true));
            this.statusTextBox1.Location = new System.Drawing.Point(102, 119);
            this.statusTextBox1.Name = "statusTextBox1";
            this.statusTextBox1.Size = new System.Drawing.Size(104, 22);
            this.statusTextBox1.TabIndex = 23;
            // 
            // max_playersTextBox1
            // 
            this.max_playersTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokerTableBindingSource, "max_players", true));
            this.max_playersTextBox1.Location = new System.Drawing.Point(102, 147);
            this.max_playersTextBox1.Name = "max_playersTextBox1";
            this.max_playersTextBox1.Size = new System.Drawing.Size(104, 22);
            this.max_playersTextBox1.TabIndex = 25;
            // 
            // is_reservedCheckBox
            // 
            this.is_reservedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pokerTableBindingSource, "is_reserved", true));
            this.is_reservedCheckBox.Location = new System.Drawing.Point(102, 175);
            this.is_reservedCheckBox.Name = "is_reservedCheckBox";
            this.is_reservedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.is_reservedCheckBox.TabIndex = 27;
            this.is_reservedCheckBox.Text = "checkBox1";
            this.is_reservedCheckBox.UseVisualStyleBackColor = true;
            // 
            // gameParticipationTableAdapter
            // 
            this.gameParticipationTableAdapter.ClearBeforeFill = true;
            // 
            // gameParticipationDataGridView
            // 
            this.gameParticipationDataGridView.AutoGenerateColumns = false;
            this.gameParticipationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameParticipationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gameParticipationDataGridView.DataSource = this.gameParticipationBindingSource;
            this.gameParticipationDataGridView.Location = new System.Drawing.Point(11, 270);
            this.gameParticipationDataGridView.Name = "gameParticipationDataGridView";
            this.gameParticipationDataGridView.RowHeadersWidth = 51;
            this.gameParticipationDataGridView.RowTemplate.Height = 24;
            this.gameParticipationDataGridView.Size = new System.Drawing.Size(1057, 220);
            this.gameParticipationDataGridView.TabIndex = 27;
            this.gameParticipationDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gameParticipationDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "game_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "game_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "player_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "player_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "seat_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "seat_number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "buy_in";
            this.dataGridViewTextBoxColumn4.HeaderText = "buy_in";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cash_out";
            this.dataGridViewTextBoxColumn5.HeaderText = "cash_out";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "entry_time";
            this.dataGridViewTextBoxColumn6.HeaderText = "entry_time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "exit_time";
            this.dataGridViewTextBoxColumn7.HeaderText = "exit_time";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "net_result";
            this.dataGridViewTextBoxColumn8.HeaderText = "net_result";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // PokerTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 592);
            this.Controls.Add(this.gameParticipationDataGridView);
            this.Controls.Add(table_idLabel1);
            this.Controls.Add(this.table_idTextBox1);
            this.Controls.Add(table_numberLabel1);
            this.Controls.Add(this.table_numberTextBox1);
            this.Controls.Add(table_typeLabel1);
            this.Controls.Add(this.table_typeTextBox1);
            this.Controls.Add(statusLabel1);
            this.Controls.Add(this.statusTextBox1);
            this.Controls.Add(max_playersLabel1);
            this.Controls.Add(this.max_playersTextBox1);
            this.Controls.Add(is_reservedLabel);
            this.Controls.Add(this.is_reservedCheckBox);
            this.Controls.Add(this.openPlayerButton);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pokerTableBindingNavigator);
            this.Name = "PokerTableForm";
            this.Text = "Игровые столы";
            this.Load += new System.EventHandler(this.PokerTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.казиноDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerTableBindingNavigator)).EndInit();
            this.pokerTableBindingNavigator.ResumeLayout(false);
            this.pokerTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameParticipationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameParticipationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КазиноDataSet1 казиноDataSet;
        private System.Windows.Forms.BindingSource pokerTableBindingSource;
        private System.Windows.Forms.BindingNavigator pokerTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pokerTableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource gameParticipationBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Button openPlayerButton;
        private КазиноDataSet1TableAdapters.PokerTableTableAdapter pokerTableTableAdapter;
        private КазиноDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox table_idTextBox1;
        private System.Windows.Forms.TextBox table_numberTextBox1;
        private System.Windows.Forms.TextBox table_typeTextBox1;
        private System.Windows.Forms.TextBox statusTextBox1;
        private System.Windows.Forms.TextBox max_playersTextBox1;
        private System.Windows.Forms.CheckBox is_reservedCheckBox;
        private КазиноDataSet1TableAdapters.GameParticipationTableAdapter gameParticipationTableAdapter;
        private System.Windows.Forms.DataGridView gameParticipationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}