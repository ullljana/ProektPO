namespace ProektPO.Forms
{
    partial class Sotrydniki
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sotrydniki));
			this.button4 = new System.Windows.Forms.Button();
			this.proektITDataSet = new ProektPO.ProektITDataSet();
			this.sotrydnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sotrydnikiTableAdapter = new ProektPO.ProektITDataSetTableAdapters.SotrydnikiTableAdapter();
			this.tableAdapterManager = new ProektPO.ProektITDataSetTableAdapters.TableAdapterManager();
			this.sotrydnikiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.sotrydnikiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.sotrydnikiDataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.myTextBox = new System.Windows.Forms.TextBox();
			this.otdeluBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.otdeluTableAdapter = new ProektPO.ProektITDataSetTableAdapters.OtdeluTableAdapter();
			this.doljnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.doljnostiTableAdapter = new ProektPO.ProektITDataSetTableAdapters.DoljnostiTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingNavigator)).BeginInit();
			this.sotrydnikiBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otdeluBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(950, 494);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 28);
			this.button4.TabIndex = 12;
			this.button4.Text = "На главную";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// proektITDataSet
			// 
			this.proektITDataSet.DataSetName = "ProektITDataSet";
			this.proektITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sotrydnikiBindingSource
			// 
			this.sotrydnikiBindingSource.DataMember = "Sotrydniki";
			this.sotrydnikiBindingSource.DataSource = this.proektITDataSet;
			// 
			// sotrydnikiTableAdapter
			// 
			this.sotrydnikiTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DoljnostiTableAdapter = this.doljnostiTableAdapter;
			this.tableAdapterManager.EtapyProektaTableAdapter = null;
			this.tableAdapterManager.EtapyTableAdapter = null;
			this.tableAdapterManager.GruppaSotrudnikTableAdapter = null;
			this.tableAdapterManager.GryppuTableAdapter = null;
			this.tableAdapterManager.OtdeluTableAdapter = this.otdeluTableAdapter;
			this.tableAdapterManager.ProektuTableAdapter = null;
			this.tableAdapterManager.SotrydnikiTableAdapter = this.sotrydnikiTableAdapter;
			this.tableAdapterManager.StatysTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ProektPO.ProektITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ZakazchikTableAdapter = null;
			// 
			// sotrydnikiBindingNavigator
			// 
			this.sotrydnikiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.sotrydnikiBindingNavigator.BindingSource = this.sotrydnikiBindingSource;
			this.sotrydnikiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.sotrydnikiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.sotrydnikiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.sotrydnikiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sotrydnikiBindingNavigatorSaveItem});
			this.sotrydnikiBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.sotrydnikiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.sotrydnikiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.sotrydnikiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.sotrydnikiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.sotrydnikiBindingNavigator.Name = "sotrydnikiBindingNavigator";
			this.sotrydnikiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.sotrydnikiBindingNavigator.Size = new System.Drawing.Size(1073, 27);
			this.sotrydnikiBindingNavigator.TabIndex = 13;
			this.sotrydnikiBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// sotrydnikiBindingNavigatorSaveItem
			// 
			this.sotrydnikiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sotrydnikiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sotrydnikiBindingNavigatorSaveItem.Image")));
			this.sotrydnikiBindingNavigatorSaveItem.Name = "sotrydnikiBindingNavigatorSaveItem";
			this.sotrydnikiBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.sotrydnikiBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.sotrydnikiBindingNavigatorSaveItem.Click += new System.EventHandler(this.sotrydnikiBindingNavigatorSaveItem_Click);
			// 
			// sotrydnikiDataGridView
			// 
			this.sotrydnikiDataGridView.AutoGenerateColumns = false;
			this.sotrydnikiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sotrydnikiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
			this.sotrydnikiDataGridView.DataSource = this.sotrydnikiBindingSource;
			this.sotrydnikiDataGridView.Location = new System.Drawing.Point(12, 30);
			this.sotrydnikiDataGridView.Name = "sotrydnikiDataGridView";
			this.sotrydnikiDataGridView.RowTemplate.Height = 24;
			this.sotrydnikiDataGridView.Size = new System.Drawing.Size(1049, 444);
			this.sotrydnikiDataGridView.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(492, 497);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 26);
			this.button1.TabIndex = 64;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(188, 477);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(277, 17);
			this.label3.TabIndex = 63;
			this.label3.Text = "Введите слово или его часть для поиска";
			// 
			// myTextBox
			// 
			this.myTextBox.Location = new System.Drawing.Point(192, 498);
			this.myTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.myTextBox.Name = "myTextBox";
			this.myTextBox.Size = new System.Drawing.Size(279, 22);
			this.myTextBox.TabIndex = 62;
			// 
			// otdeluBindingSource
			// 
			this.otdeluBindingSource.DataMember = "Otdelu";
			this.otdeluBindingSource.DataSource = this.proektITDataSet;
			// 
			// otdeluTableAdapter
			// 
			this.otdeluTableAdapter.ClearBeforeFill = true;
			// 
			// doljnostiBindingSource
			// 
			this.doljnostiBindingSource.DataMember = "Doljnosti";
			this.doljnostiBindingSource.DataSource = this.proektITDataSet;
			// 
			// doljnostiTableAdapter
			// 
			this.doljnostiTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "FIOSotrudnika";
			this.dataGridViewTextBoxColumn2.HeaderText = "ФИО сотрудника";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "DataRojdeniya";
			this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Pol";
			this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "NomerOtdela";
			this.dataGridViewTextBoxColumn5.DataSource = this.otdeluBindingSource;
			this.dataGridViewTextBoxColumn5.DisplayMember = "Nazvaniye";
			this.dataGridViewTextBoxColumn5.HeaderText = "Отдел";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn5.ValueMember = "ID";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Doljnost";
			this.dataGridViewTextBoxColumn6.DataSource = this.doljnostiBindingSource;
			this.dataGridViewTextBoxColumn6.DisplayMember = "Doljnost";
			this.dataGridViewTextBoxColumn6.HeaderText = "Должность";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn6.ValueMember = "ID";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Zarplata";
			this.dataGridViewTextBoxColumn7.HeaderText = "Зарплата";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefon";
			this.dataGridViewTextBoxColumn8.HeaderText = "Телефон";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Adres";
			this.dataGridViewTextBoxColumn9.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// Sotrydniki
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 535);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.myTextBox);
			this.Controls.Add(this.sotrydnikiDataGridView);
			this.Controls.Add(this.sotrydnikiBindingNavigator);
			this.Controls.Add(this.button4);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Sotrydniki";
			this.Text = "Сотрудники";
			this.Load += new System.EventHandler(this.Sotrydniki_Load);
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingNavigator)).EndInit();
			this.sotrydnikiBindingNavigator.ResumeLayout(false);
			this.sotrydnikiBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otdeluBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
		private ProektITDataSet proektITDataSet;
		private System.Windows.Forms.BindingSource sotrydnikiBindingSource;
		private ProektITDataSetTableAdapters.SotrydnikiTableAdapter sotrydnikiTableAdapter;
		private ProektITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator sotrydnikiBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton sotrydnikiBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView sotrydnikiDataGridView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox myTextBox;
		private ProektITDataSetTableAdapters.OtdeluTableAdapter otdeluTableAdapter;
		private System.Windows.Forms.BindingSource otdeluBindingSource;
		private ProektITDataSetTableAdapters.DoljnostiTableAdapter doljnostiTableAdapter;
		private System.Windows.Forms.BindingSource doljnostiBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
	}
}