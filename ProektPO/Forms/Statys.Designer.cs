namespace ProektPO.Forms
{
    partial class Statys
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statys));
			this.button4 = new System.Windows.Forms.Button();
			this.proektITDataSet = new ProektPO.ProektITDataSet();
			this.statysBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.statysTableAdapter = new ProektPO.ProektITDataSetTableAdapters.StatysTableAdapter();
			this.tableAdapterManager = new ProektPO.ProektITDataSetTableAdapters.TableAdapterManager();
			this.statysBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.statysBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.statysDataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.myTextBox = new System.Windows.Forms.TextBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statysBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statysBindingNavigator)).BeginInit();
			this.statysBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statysDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(402, 391);
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
			// statysBindingSource
			// 
			this.statysBindingSource.DataMember = "Statys";
			this.statysBindingSource.DataSource = this.proektITDataSet;
			// 
			// statysTableAdapter
			// 
			this.statysTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.ProektuTableAdapter = null;
			this.tableAdapterManager.SotrydnikiTableAdapter = null;
			this.tableAdapterManager.StatysTableAdapter = this.statysTableAdapter;
			this.tableAdapterManager.UpdateOrder = ProektPO.ProektITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ZakazchikTableAdapter = null;
			// 
			// statysBindingNavigator
			// 
			this.statysBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.statysBindingNavigator.BindingSource = this.statysBindingSource;
			this.statysBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.statysBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.statysBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statysBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.statysBindingNavigatorSaveItem});
			this.statysBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.statysBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.statysBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.statysBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.statysBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.statysBindingNavigator.Name = "statysBindingNavigator";
			this.statysBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.statysBindingNavigator.Size = new System.Drawing.Size(515, 27);
			this.statysBindingNavigator.TabIndex = 25;
			this.statysBindingNavigator.Text = "bindingNavigator1";
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
			// statysBindingNavigatorSaveItem
			// 
			this.statysBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.statysBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statysBindingNavigatorSaveItem.Image")));
			this.statysBindingNavigatorSaveItem.Name = "statysBindingNavigatorSaveItem";
			this.statysBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.statysBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.statysBindingNavigatorSaveItem.Click += new System.EventHandler(this.statysBindingNavigatorSaveItem_Click);
			// 
			// statysDataGridView
			// 
			this.statysDataGridView.AutoGenerateColumns = false;
			this.statysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.statysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.statysDataGridView.DataSource = this.statysBindingSource;
			this.statysDataGridView.Location = new System.Drawing.Point(12, 30);
			this.statysDataGridView.Name = "statysDataGridView";
			this.statysDataGridView.RowTemplate.Height = 24;
			this.statysDataGridView.Size = new System.Drawing.Size(490, 331);
			this.statysDataGridView.TabIndex = 25;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 393);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 27);
			this.button1.TabIndex = 67;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 372);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(277, 17);
			this.label3.TabIndex = 66;
			this.label3.Text = "Введите слово или его часть для поиска";
			// 
			// myTextBox
			// 
			this.myTextBox.Location = new System.Drawing.Point(20, 393);
			this.myTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.myTextBox.Name = "myTextBox";
			this.myTextBox.Size = new System.Drawing.Size(279, 22);
			this.myTextBox.TabIndex = 65;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Statys";
			this.dataGridViewTextBoxColumn2.HeaderText = "Статус";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// Statys
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 430);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.myTextBox);
			this.Controls.Add(this.statysDataGridView);
			this.Controls.Add(this.statysBindingNavigator);
			this.Controls.Add(this.button4);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Statys";
			this.Text = "Статус";
			this.Load += new System.EventHandler(this.Statys_Load);
			((System.ComponentModel.ISupportInitialize)(this.proektITDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statysBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statysBindingNavigator)).EndInit();
			this.statysBindingNavigator.ResumeLayout(false);
			this.statysBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.statysDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
		private ProektITDataSet proektITDataSet;
		private System.Windows.Forms.BindingSource statysBindingSource;
		private ProektITDataSetTableAdapters.StatysTableAdapter statysTableAdapter;
		private ProektITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator statysBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton statysBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView statysDataGridView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox myTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}