namespace ProektPO.Forms
{
    partial class Gryppu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gryppu));
			this.button4 = new System.Windows.Forms.Button();
			this.proektITDataSet = new ProektPO.ProektITDataSet();
			this.gryppuBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gryppuTableAdapter = new ProektPO.ProektITDataSetTableAdapters.GryppuTableAdapter();
			this.tableAdapterManager = new ProektPO.ProektITDataSetTableAdapters.TableAdapterManager();
			this.gryppuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.gryppuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.gryppuDataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.myTextBox = new System.Windows.Forms.TextBox();
			this.sotrydnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sotrydnikiTableAdapter = new ProektPO.ProektITDataSetTableAdapters.SotrydnikiTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gryppuBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gryppuBindingNavigator)).BeginInit();
			this.gryppuBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gryppuDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(447, 402);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 28);
			this.button4.TabIndex = 21;
			this.button4.Text = "На главную";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// proektITDataSet
			// 
			this.proektITDataSet.DataSetName = "ProektITDataSet";
			this.proektITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gryppuBindingSource
			// 
			this.gryppuBindingSource.DataMember = "Gryppu";
			this.gryppuBindingSource.DataSource = this.proektITDataSet;
			// 
			// gryppuTableAdapter
			// 
			this.gryppuTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DoljnostiTableAdapter = null;
			this.tableAdapterManager.EtapyProektaTableAdapter = null;
			this.tableAdapterManager.EtapyTableAdapter = null;
			this.tableAdapterManager.GruppaSotrudnikTableAdapter = null;
			this.tableAdapterManager.GryppuTableAdapter = this.gryppuTableAdapter;
			this.tableAdapterManager.OtdeluTableAdapter = null;
			this.tableAdapterManager.ProektuTableAdapter = null;
			this.tableAdapterManager.SotrydnikiTableAdapter = this.sotrydnikiTableAdapter;
			this.tableAdapterManager.StatysTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ProektPO.ProektITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ZakazchikTableAdapter = null;
			// 
			// gryppuBindingNavigator
			// 
			this.gryppuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.gryppuBindingNavigator.BindingSource = this.gryppuBindingSource;
			this.gryppuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.gryppuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.gryppuBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.gryppuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gryppuBindingNavigatorSaveItem});
			this.gryppuBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.gryppuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.gryppuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.gryppuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.gryppuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.gryppuBindingNavigator.Name = "gryppuBindingNavigator";
			this.gryppuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.gryppuBindingNavigator.Size = new System.Drawing.Size(573, 27);
			this.gryppuBindingNavigator.TabIndex = 22;
			this.gryppuBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
			// gryppuBindingNavigatorSaveItem
			// 
			this.gryppuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.gryppuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gryppuBindingNavigatorSaveItem.Image")));
			this.gryppuBindingNavigatorSaveItem.Name = "gryppuBindingNavigatorSaveItem";
			this.gryppuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.gryppuBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.gryppuBindingNavigatorSaveItem.Click += new System.EventHandler(this.gryppuBindingNavigatorSaveItem_Click);
			// 
			// gryppuDataGridView
			// 
			this.gryppuDataGridView.AutoGenerateColumns = false;
			this.gryppuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gryppuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.gryppuDataGridView.DataSource = this.gryppuBindingSource;
			this.gryppuDataGridView.Location = new System.Drawing.Point(12, 32);
			this.gryppuDataGridView.Name = "gryppuDataGridView";
			this.gryppuDataGridView.RowTemplate.Height = 24;
			this.gryppuDataGridView.Size = new System.Drawing.Size(535, 342);
			this.gryppuDataGridView.TabIndex = 22;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(323, 404);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 26);
			this.button1.TabIndex = 55;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 384);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(277, 17);
			this.label3.TabIndex = 54;
			this.label3.Text = "Введите слово или его часть для поиска";
			// 
			// myTextBox
			// 
			this.myTextBox.Location = new System.Drawing.Point(23, 405);
			this.myTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.myTextBox.Name = "myTextBox";
			this.myTextBox.Size = new System.Drawing.Size(279, 22);
			this.myTextBox.TabIndex = 53;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "NachalnikGruppu";
			this.dataGridViewTextBoxColumn2.DataSource = this.sotrydnikiBindingSource;
			this.dataGridViewTextBoxColumn2.DisplayMember = "FIOSotrudnika";
			this.dataGridViewTextBoxColumn2.HeaderText = "Начальник группы";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn2.ValueMember = "ID";
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Nazvanie";
			this.dataGridViewTextBoxColumn3.HeaderText = "Название";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 150;
			// 
			// Gryppu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 447);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.myTextBox);
			this.Controls.Add(this.gryppuDataGridView);
			this.Controls.Add(this.gryppuBindingNavigator);
			this.Controls.Add(this.button4);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Gryppu";
			this.Text = "Группа";
			this.Load += new System.EventHandler(this.Gryppu_Load);
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gryppuBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gryppuBindingNavigator)).EndInit();
			this.gryppuBindingNavigator.ResumeLayout(false);
			this.gryppuBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gryppuDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
		private ProektITDataSet proektITDataSet;
		private System.Windows.Forms.BindingSource gryppuBindingSource;
		private ProektITDataSetTableAdapters.GryppuTableAdapter gryppuTableAdapter;
		private ProektITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator gryppuBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton gryppuBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView gryppuDataGridView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox myTextBox;
		private ProektITDataSetTableAdapters.SotrydnikiTableAdapter sotrydnikiTableAdapter;
		private System.Windows.Forms.BindingSource sotrydnikiBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}