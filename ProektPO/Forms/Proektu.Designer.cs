namespace ProektPO.Forms
{
    partial class Proektu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proektu));
			this.button4 = new System.Windows.Forms.Button();
			this.proektITDataSet = new ProektPO.ProektITDataSet();
			this.proektuBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proektuTableAdapter = new ProektPO.ProektITDataSetTableAdapters.ProektuTableAdapter();
			this.tableAdapterManager = new ProektPO.ProektITDataSetTableAdapters.TableAdapterManager();
			this.proektuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.proektuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.proektuDataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.myTextBox = new System.Windows.Forms.TextBox();
			this.zakazchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.zakazchikTableAdapter = new ProektPO.ProektITDataSetTableAdapters.ZakazchikTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proektuBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proektuBindingNavigator)).BeginInit();
			this.proektuBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.proektuDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zakazchikBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(760, 452);
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
			// proektuBindingSource
			// 
			this.proektuBindingSource.DataMember = "Proektu";
			this.proektuBindingSource.DataSource = this.proektITDataSet;
			// 
			// proektuTableAdapter
			// 
			this.proektuTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DoljnostiTableAdapter = null;
			this.tableAdapterManager.EtapyProektaTableAdapter = null;
			this.tableAdapterManager.EtapyTableAdapter = null;
			this.tableAdapterManager.GruppaSotrudnikTableAdapter = null;
			this.tableAdapterManager.GryppuTableAdapter = null;
			this.tableAdapterManager.OtdeluTableAdapter = null;
			this.tableAdapterManager.ProektuTableAdapter = this.proektuTableAdapter;
			this.tableAdapterManager.SotrydnikiTableAdapter = null;
			this.tableAdapterManager.StatysTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ProektPO.ProektITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ZakazchikTableAdapter = this.zakazchikTableAdapter;
			// 
			// proektuBindingNavigator
			// 
			this.proektuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.proektuBindingNavigator.BindingSource = this.proektuBindingSource;
			this.proektuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.proektuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.proektuBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.proektuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.proektuBindingNavigatorSaveItem});
			this.proektuBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.proektuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.proektuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.proektuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.proektuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.proektuBindingNavigator.Name = "proektuBindingNavigator";
			this.proektuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.proektuBindingNavigator.Size = new System.Drawing.Size(889, 27);
			this.proektuBindingNavigator.TabIndex = 13;
			this.proektuBindingNavigator.Text = "bindingNavigator1";
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
			// proektuBindingNavigatorSaveItem
			// 
			this.proektuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.proektuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proektuBindingNavigatorSaveItem.Image")));
			this.proektuBindingNavigatorSaveItem.Name = "proektuBindingNavigatorSaveItem";
			this.proektuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.proektuBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.proektuBindingNavigatorSaveItem.Click += new System.EventHandler(this.proektuBindingNavigatorSaveItem_Click);
			// 
			// proektuDataGridView
			// 
			this.proektuDataGridView.AutoGenerateColumns = false;
			this.proektuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.proektuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.proektuDataGridView.DataSource = this.proektuBindingSource;
			this.proektuDataGridView.Location = new System.Drawing.Point(12, 30);
			this.proektuDataGridView.Name = "proektuDataGridView";
			this.proektuDataGridView.RowTemplate.Height = 24;
			this.proektuDataGridView.Size = new System.Drawing.Size(865, 401);
			this.proektuDataGridView.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(374, 455);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 26);
			this.button1.TabIndex = 61;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(70, 435);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(277, 17);
			this.label3.TabIndex = 60;
			this.label3.Text = "Введите слово или его часть для поиска";
			// 
			// myTextBox
			// 
			this.myTextBox.Location = new System.Drawing.Point(74, 456);
			this.myTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.myTextBox.Name = "myTextBox";
			this.myTextBox.Size = new System.Drawing.Size(279, 22);
			this.myTextBox.TabIndex = 59;
			// 
			// zakazchikBindingSource
			// 
			this.zakazchikBindingSource.DataMember = "Zakazchik";
			this.zakazchikBindingSource.DataSource = this.proektITDataSet;
			// 
			// zakazchikTableAdapter
			// 
			this.zakazchikTableAdapter.ClearBeforeFill = true;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "NazvaniyeProekta";
			this.dataGridViewTextBoxColumn2.HeaderText = "Название проекта";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Zakazchik";
			this.dataGridViewTextBoxColumn3.DataSource = this.zakazchikBindingSource;
			this.dataGridViewTextBoxColumn3.DisplayMember = "FIOZakazchika";
			this.dataGridViewTextBoxColumn3.HeaderText = "Заказчик";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn3.ValueMember = "ID";
			this.dataGridViewTextBoxColumn3.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "DataNachala";
			this.dataGridViewTextBoxColumn4.HeaderText = "Дата начала";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "DlitelnostDney";
			this.dataGridViewTextBoxColumn5.HeaderText = "Длительность дней";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "SroimostProekta";
			this.dataGridViewTextBoxColumn6.HeaderText = "Стоимость проекта";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// Proektu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 493);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.myTextBox);
			this.Controls.Add(this.proektuDataGridView);
			this.Controls.Add(this.proektuBindingNavigator);
			this.Controls.Add(this.button4);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Proektu";
			this.Text = "Проекты";
			this.Load += new System.EventHandler(this.Proektu_Load);
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proektuBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proektuBindingNavigator)).EndInit();
			this.proektuBindingNavigator.ResumeLayout(false);
			this.proektuBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.proektuDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zakazchikBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
		private ProektITDataSet proektITDataSet;
		private System.Windows.Forms.BindingSource proektuBindingSource;
		private ProektITDataSetTableAdapters.ProektuTableAdapter proektuTableAdapter;
		private ProektITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator proektuBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton proektuBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView proektuDataGridView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox myTextBox;
		private ProektITDataSetTableAdapters.ZakazchikTableAdapter zakazchikTableAdapter;
		private System.Windows.Forms.BindingSource zakazchikBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}