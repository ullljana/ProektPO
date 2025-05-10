namespace ProektPO.Forms
{
    partial class EtapyProekta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtapyProekta));
			this.button4 = new System.Windows.Forms.Button();
			this.proektITDataSet = new ProektPO.ProektITDataSet();
			this.etapyProektaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.etapyProektaTableAdapter = new ProektPO.ProektITDataSetTableAdapters.EtapyProektaTableAdapter();
			this.tableAdapterManager = new ProektPO.ProektITDataSetTableAdapters.TableAdapterManager();
			this.etapyProektaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.etapyProektaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.etapyProektaDataGridView = new System.Windows.Forms.DataGridView();
			this.etapyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.etapyTableAdapter = new ProektPO.ProektITDataSetTableAdapters.EtapyTableAdapter();
			this.proektuBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proektuTableAdapter = new ProektPO.ProektITDataSetTableAdapters.ProektuTableAdapter();
			this.gryppuBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gryppuTableAdapter = new ProektPO.ProektITDataSetTableAdapters.GryppuTableAdapter();
			this.statysBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.statysTableAdapter = new ProektPO.ProektITDataSetTableAdapters.StatysTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.myTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etapyProektaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etapyProektaBindingNavigator)).BeginInit();
			this.etapyProektaBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.etapyProektaDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etapyBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proektuBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gryppuBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statysBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(697, 393);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 28);
			this.button4.TabIndex = 24;
			this.button4.Text = "На главную";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// proektITDataSet
			// 
			this.proektITDataSet.DataSetName = "ProektITDataSet";
			this.proektITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// etapyProektaBindingSource
			// 
			this.etapyProektaBindingSource.DataMember = "EtapyProekta";
			this.etapyProektaBindingSource.DataSource = this.proektITDataSet;
			// 
			// etapyProektaTableAdapter
			// 
			this.etapyProektaTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DoljnostiTableAdapter = null;
			this.tableAdapterManager.EtapyProektaTableAdapter = this.etapyProektaTableAdapter;
			this.tableAdapterManager.EtapyTableAdapter = this.etapyTableAdapter;
			this.tableAdapterManager.GruppaSotrudnikTableAdapter = null;
			this.tableAdapterManager.GryppuTableAdapter = this.gryppuTableAdapter;
			this.tableAdapterManager.OtdeluTableAdapter = null;
			this.tableAdapterManager.ProektuTableAdapter = this.proektuTableAdapter;
			this.tableAdapterManager.SotrydnikiTableAdapter = null;
			this.tableAdapterManager.StatysTableAdapter = this.statysTableAdapter;
			this.tableAdapterManager.UpdateOrder = ProektPO.ProektITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ZakazchikTableAdapter = null;
			// 
			// etapyProektaBindingNavigator
			// 
			this.etapyProektaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.etapyProektaBindingNavigator.BindingSource = this.etapyProektaBindingSource;
			this.etapyProektaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.etapyProektaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.etapyProektaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.etapyProektaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.etapyProektaBindingNavigatorSaveItem});
			this.etapyProektaBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.etapyProektaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.etapyProektaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.etapyProektaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.etapyProektaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.etapyProektaBindingNavigator.Name = "etapyProektaBindingNavigator";
			this.etapyProektaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.etapyProektaBindingNavigator.Size = new System.Drawing.Size(815, 27);
			this.etapyProektaBindingNavigator.TabIndex = 25;
			this.etapyProektaBindingNavigator.Text = "bindingNavigator1";
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
			// etapyProektaBindingNavigatorSaveItem
			// 
			this.etapyProektaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.etapyProektaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("etapyProektaBindingNavigatorSaveItem.Image")));
			this.etapyProektaBindingNavigatorSaveItem.Name = "etapyProektaBindingNavigatorSaveItem";
			this.etapyProektaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.etapyProektaBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.etapyProektaBindingNavigatorSaveItem.Click += new System.EventHandler(this.etapyProektaBindingNavigatorSaveItem_Click);
			// 
			// etapyProektaDataGridView
			// 
			this.etapyProektaDataGridView.AutoGenerateColumns = false;
			this.etapyProektaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.etapyProektaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.etapyProektaDataGridView.DataSource = this.etapyProektaBindingSource;
			this.etapyProektaDataGridView.Location = new System.Drawing.Point(12, 32);
			this.etapyProektaDataGridView.Name = "etapyProektaDataGridView";
			this.etapyProektaDataGridView.RowTemplate.Height = 24;
			this.etapyProektaDataGridView.Size = new System.Drawing.Size(785, 335);
			this.etapyProektaDataGridView.TabIndex = 25;
			// 
			// etapyBindingSource
			// 
			this.etapyBindingSource.DataMember = "Etapy";
			this.etapyBindingSource.DataSource = this.proektITDataSet;
			// 
			// etapyTableAdapter
			// 
			this.etapyTableAdapter.ClearBeforeFill = true;
			// 
			// proektuBindingSource
			// 
			this.proektuBindingSource.DataMember = "Proektu";
			this.proektuBindingSource.DataSource = this.proektITDataSet;
			// 
			// proektuTableAdapter
			// 
			this.proektuTableAdapter.ClearBeforeFill = true;
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
			// statysBindingSource
			// 
			this.statysBindingSource.DataMember = "Statys";
			this.statysBindingSource.DataSource = this.proektITDataSet;
			// 
			// statysTableAdapter
			// 
			this.statysTableAdapter.ClearBeforeFill = true;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "NazvanieEtapa";
			this.dataGridViewTextBoxColumn2.DataSource = this.etapyBindingSource;
			this.dataGridViewTextBoxColumn2.DisplayMember = "Nazvaniye";
			this.dataGridViewTextBoxColumn2.HeaderText = "Название этапа";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn2.ValueMember = "ID";
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "NomerProekta";
			this.dataGridViewTextBoxColumn3.DataSource = this.proektuBindingSource;
			this.dataGridViewTextBoxColumn3.DisplayMember = "NazvaniyeProekta";
			this.dataGridViewTextBoxColumn3.HeaderText = "Номер проекта";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn3.ValueMember = "ID";
			this.dataGridViewTextBoxColumn3.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "SostavGruppu";
			this.dataGridViewTextBoxColumn4.DataSource = this.gryppuBindingSource;
			this.dataGridViewTextBoxColumn4.DisplayMember = "Nazvanie";
			this.dataGridViewTextBoxColumn4.HeaderText = "Состав группы";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn4.ValueMember = "ID";
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "StatusEtapa";
			this.dataGridViewTextBoxColumn5.DataSource = this.statysBindingSource;
			this.dataGridViewTextBoxColumn5.DisplayMember = "Statys";
			this.dataGridViewTextBoxColumn5.HeaderText = "Статус этапа";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn5.ValueMember = "ID";
			this.dataGridViewTextBoxColumn5.Width = 150;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(327, 395);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 26);
			this.button1.TabIndex = 52;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 375);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(277, 17);
			this.label3.TabIndex = 51;
			this.label3.Text = "Введите слово или его часть для поиска";
			// 
			// myTextBox
			// 
			this.myTextBox.Location = new System.Drawing.Point(27, 396);
			this.myTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.myTextBox.Name = "myTextBox";
			this.myTextBox.Size = new System.Drawing.Size(279, 22);
			this.myTextBox.TabIndex = 50;
			// 
			// EtapyProekta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 434);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.myTextBox);
			this.Controls.Add(this.etapyProektaDataGridView);
			this.Controls.Add(this.etapyProektaBindingNavigator);
			this.Controls.Add(this.button4);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "EtapyProekta";
			this.Text = "Этапы проекта ";
			this.Load += new System.EventHandler(this.EtapyProekta_Load);
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etapyProektaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etapyProektaBindingNavigator)).EndInit();
			this.etapyProektaBindingNavigator.ResumeLayout(false);
			this.etapyProektaBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.etapyProektaDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etapyBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proektuBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gryppuBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statysBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
		private ProektITDataSet proektITDataSet;
		private System.Windows.Forms.BindingSource etapyProektaBindingSource;
		private ProektITDataSetTableAdapters.EtapyProektaTableAdapter etapyProektaTableAdapter;
		private ProektITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator etapyProektaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton etapyProektaBindingNavigatorSaveItem;
		private ProektITDataSetTableAdapters.EtapyTableAdapter etapyTableAdapter;
		private System.Windows.Forms.DataGridView etapyProektaDataGridView;
		private System.Windows.Forms.BindingSource etapyBindingSource;
		private ProektITDataSetTableAdapters.ProektuTableAdapter proektuTableAdapter;
		private System.Windows.Forms.BindingSource proektuBindingSource;
		private ProektITDataSetTableAdapters.GryppuTableAdapter gryppuTableAdapter;
		private System.Windows.Forms.BindingSource gryppuBindingSource;
		private ProektITDataSetTableAdapters.StatysTableAdapter statysTableAdapter;
		private System.Windows.Forms.BindingSource statysBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox myTextBox;
	}
}