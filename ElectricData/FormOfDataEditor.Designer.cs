namespace ElectricData
{
    partial class FormOfDataEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfDataEditor));
            this.GridViewOfDataEditor = new System.Windows.Forms.DataGridView();
            this.bindingSource_SelectAll = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new ElectricData.MainDBDataSet();
            this.bindingNavigatorOfDataEditor = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.SaveData_button = new MetroFramework.Controls.MetroButton();
            this.ExitOfDataEditor_button = new MetroFramework.Controls.MetroButton();
            this.SelectOfTable_box = new MetroFramework.Controls.MetroComboBox();
            this.mainDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableName_label = new MetroFramework.Controls.MetroLabel();
            this.selectAllTableAdapter = new ElectricData.MainDBDataSetTableAdapters.SelectAllTableAdapter();
            this.pCAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counternameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloksnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammeterscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krmindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOfDataEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SelectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOfDataEditor)).BeginInit();
            this.bindingNavigatorOfDataEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewOfDataEditor
            // 
            this.GridViewOfDataEditor.AllowUserToOrderColumns = true;
            this.GridViewOfDataEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewOfDataEditor.AutoGenerateColumns = false;
            this.GridViewOfDataEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOfDataEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCAMDataGridViewTextBoxColumn,
            this.counternameDataGridViewTextBoxColumn,
            this.inputscountDataGridViewTextBoxColumn,
            this.bloksnameDataGridViewTextBoxColumn,
            this.ammeterscountDataGridViewTextBoxColumn,
            this.conviDataGridViewTextBoxColumn,
            this.convuDataGridViewTextBoxColumn,
            this.countrynameDataGridViewTextBoxColumn,
            this.krmindDataGridViewTextBoxColumn,
            this.voltindDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.note});
            this.GridViewOfDataEditor.DataSource = this.bindingSource_SelectAll;
            this.GridViewOfDataEditor.Location = new System.Drawing.Point(24, 86);
            this.GridViewOfDataEditor.Name = "GridViewOfDataEditor";
            this.GridViewOfDataEditor.Size = new System.Drawing.Size(523, 208);
            this.GridViewOfDataEditor.TabIndex = 0;
            // 
            // bindingSource_SelectAll
            // 
            this.bindingSource_SelectAll.DataMember = "SelectAll";
            this.bindingSource_SelectAll.DataSource = this.mainDBDataSet;
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "MainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorOfDataEditor
            // 
            this.bindingNavigatorOfDataEditor.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorOfDataEditor.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorOfDataEditor.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorOfDataEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorOfDataEditor.Location = new System.Drawing.Point(20, 60);
            this.bindingNavigatorOfDataEditor.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorOfDataEditor.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorOfDataEditor.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorOfDataEditor.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorOfDataEditor.Name = "bindingNavigatorOfDataEditor";
            this.bindingNavigatorOfDataEditor.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorOfDataEditor.Size = new System.Drawing.Size(530, 25);
            this.bindingNavigatorOfDataEditor.TabIndex = 1;
            this.bindingNavigatorOfDataEditor.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveData_button
            // 
            this.SaveData_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveData_button.Location = new System.Drawing.Point(207, 343);
            this.SaveData_button.Name = "SaveData_button";
            this.SaveData_button.Size = new System.Drawing.Size(171, 66);
            this.SaveData_button.TabIndex = 2;
            this.SaveData_button.Text = "Сохранить";
            // 
            // ExitOfDataEditor_button
            // 
            this.ExitOfDataEditor_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitOfDataEditor_button.Location = new System.Drawing.Point(384, 343);
            this.ExitOfDataEditor_button.Name = "ExitOfDataEditor_button";
            this.ExitOfDataEditor_button.Size = new System.Drawing.Size(163, 66);
            this.ExitOfDataEditor_button.TabIndex = 4;
            this.ExitOfDataEditor_button.Text = "Выход";
            // 
            // SelectOfTable_box
            // 
            this.SelectOfTable_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectOfTable_box.DataSource = this.mainDBDataSetBindingSource;
            this.SelectOfTable_box.FormattingEnabled = true;
            this.SelectOfTable_box.ItemHeight = 23;
            this.SelectOfTable_box.Location = new System.Drawing.Point(94, 300);
            this.SelectOfTable_box.Name = "SelectOfTable_box";
            this.SelectOfTable_box.Size = new System.Drawing.Size(453, 29);
            this.SelectOfTable_box.TabIndex = 5;
            // 
            // mainDBDataSetBindingSource
            // 
            this.mainDBDataSetBindingSource.DataSource = this.mainDBDataSet;
            this.mainDBDataSetBindingSource.Position = 0;
            // 
            // tableName_label
            // 
            this.tableName_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableName_label.AutoSize = true;
            this.tableName_label.Location = new System.Drawing.Point(24, 310);
            this.tableName_label.Name = "tableName_label";
            this.tableName_label.Size = new System.Drawing.Size(64, 19);
            this.tableName_label.TabIndex = 8;
            this.tableName_label.Text = "Таблица:";
            // 
            // selectAllTableAdapter
            // 
            this.selectAllTableAdapter.ClearBeforeFill = true;
            // 
            // pCAMDataGridViewTextBoxColumn
            // 
            this.pCAMDataGridViewTextBoxColumn.DataPropertyName = "PCAM";
            this.pCAMDataGridViewTextBoxColumn.HeaderText = "PCAM";
            this.pCAMDataGridViewTextBoxColumn.Name = "pCAMDataGridViewTextBoxColumn";
            // 
            // counternameDataGridViewTextBoxColumn
            // 
            this.counternameDataGridViewTextBoxColumn.DataPropertyName = "counter_name";
            this.counternameDataGridViewTextBoxColumn.HeaderText = "Счётчик";
            this.counternameDataGridViewTextBoxColumn.Name = "counternameDataGridViewTextBoxColumn";
            // 
            // inputscountDataGridViewTextBoxColumn
            // 
            this.inputscountDataGridViewTextBoxColumn.DataPropertyName = "inputs_count";
            this.inputscountDataGridViewTextBoxColumn.HeaderText = "Ввод";
            this.inputscountDataGridViewTextBoxColumn.Name = "inputscountDataGridViewTextBoxColumn";
            // 
            // bloksnameDataGridViewTextBoxColumn
            // 
            this.bloksnameDataGridViewTextBoxColumn.DataPropertyName = "bloks_name";
            this.bloksnameDataGridViewTextBoxColumn.HeaderText = "Колодка";
            this.bloksnameDataGridViewTextBoxColumn.Name = "bloksnameDataGridViewTextBoxColumn";
            // 
            // ammeterscountDataGridViewTextBoxColumn
            // 
            this.ammeterscountDataGridViewTextBoxColumn.DataPropertyName = "ammeters_count";
            this.ammeterscountDataGridViewTextBoxColumn.HeaderText = "Амперметры";
            this.ammeterscountDataGridViewTextBoxColumn.Name = "ammeterscountDataGridViewTextBoxColumn";
            // 
            // conviDataGridViewTextBoxColumn
            // 
            this.conviDataGridViewTextBoxColumn.DataPropertyName = "conv_i";
            this.conviDataGridViewTextBoxColumn.HeaderText = "Преобразователи тока";
            this.conviDataGridViewTextBoxColumn.Name = "conviDataGridViewTextBoxColumn";
            // 
            // convuDataGridViewTextBoxColumn
            // 
            this.convuDataGridViewTextBoxColumn.DataPropertyName = "conv_u";
            this.convuDataGridViewTextBoxColumn.HeaderText = "Преобразователи напряжения";
            this.convuDataGridViewTextBoxColumn.Name = "convuDataGridViewTextBoxColumn";
            // 
            // countrynameDataGridViewTextBoxColumn
            // 
            this.countrynameDataGridViewTextBoxColumn.DataPropertyName = "country_name";
            this.countrynameDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countrynameDataGridViewTextBoxColumn.Name = "countrynameDataGridViewTextBoxColumn";
            // 
            // krmindDataGridViewTextBoxColumn
            // 
            this.krmindDataGridViewTextBoxColumn.DataPropertyName = "krm_ind";
            this.krmindDataGridViewTextBoxColumn.HeaderText = "КРМ";
            this.krmindDataGridViewTextBoxColumn.Name = "krmindDataGridViewTextBoxColumn";
            // 
            // voltindDataGridViewTextBoxColumn
            // 
            this.voltindDataGridViewTextBoxColumn.DataPropertyName = "volt_ind";
            this.voltindDataGridViewTextBoxColumn.HeaderText = "Вольтметр";
            this.voltindDataGridViewTextBoxColumn.Name = "voltindDataGridViewTextBoxColumn";
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Ссылка";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Дополнительно";
            this.note.Name = "note";
            // 
            // FormOfDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.tableName_label);
            this.Controls.Add(this.SelectOfTable_box);
            this.Controls.Add(this.ExitOfDataEditor_button);
            this.Controls.Add(this.SaveData_button);
            this.Controls.Add(this.bindingNavigatorOfDataEditor);
            this.Controls.Add(this.GridViewOfDataEditor);
            this.MinimumSize = new System.Drawing.Size(570, 420);
            this.Name = "FormOfDataEditor";
            this.Text = "Редактор базы данных";
            this.Load += new System.EventHandler(this.FormOfDataEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOfDataEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SelectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOfDataEditor)).EndInit();
            this.bindingNavigatorOfDataEditor.ResumeLayout(false);
            this.bindingNavigatorOfDataEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewOfDataEditor;
        private System.Windows.Forms.BindingNavigator bindingNavigatorOfDataEditor;
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
        private MetroFramework.Controls.MetroButton SaveData_button;
        private MetroFramework.Controls.MetroButton ExitOfDataEditor_button;
        private MetroFramework.Controls.MetroComboBox SelectOfTable_box;
        private MetroFramework.Controls.MetroLabel tableName_label;
        private System.Windows.Forms.BindingSource mainDBDataSetBindingSource;
        private MainDBDataSet mainDBDataSet;
        private System.Windows.Forms.BindingSource bindingSource_SelectAll;
        private MainDBDataSetTableAdapters.SelectAllTableAdapter selectAllTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counternameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloksnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammeterscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn convuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krmindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}