﻿namespace ElectricData
{
    partial class FormOfSearch
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
            this.pcam_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_PCAM = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new ElectricData.MainDBDataSet();
            this.pcam_label = new MetroFramework.Controls.MetroLabel();
            this.counters_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_counters = new System.Windows.Forms.BindingSource(this.components);
            this.counters_label = new MetroFramework.Controls.MetroLabel();
            this.bloks_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_bloks = new System.Windows.Forms.BindingSource(this.components);
            this.bloks_label = new MetroFramework.Controls.MetroLabel();
            this.amper_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_ammeters = new System.Windows.Forms.BindingSource(this.components);
            this.amper_label = new MetroFramework.Controls.MetroLabel();
            this.inputs_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_inputs = new System.Windows.Forms.BindingSource(this.components);
            this.inputs_label = new MetroFramework.Controls.MetroLabel();
            this.convertI_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_conv_I = new System.Windows.Forms.BindingSource(this.components);
            this.convertI_label = new MetroFramework.Controls.MetroLabel();
            this.convertU_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_conv_U = new System.Windows.Forms.BindingSource(this.components);
            this.convertU_label = new MetroFramework.Controls.MetroLabel();
            this.krm_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_krm = new System.Windows.Forms.BindingSource(this.components);
            this.krm_label = new MetroFramework.Controls.MetroLabel();
            this.volt_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_voltmeters = new System.Windows.Forms.BindingSource(this.components);
            this.volt_label = new MetroFramework.Controls.MetroLabel();
            this.country_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_country = new System.Windows.Forms.BindingSource(this.components);
            this.country_label = new MetroFramework.Controls.MetroLabel();
            this.DataEditor_button = new MetroFramework.Controls.MetroButton();
            this.OpenFolder_button = new MetroFramework.Controls.MetroButton();
            this.ExitOfSearch_button = new MetroFramework.Controls.MetroButton();
            this.GridViewOfSearch = new System.Windows.Forms.DataGridView();
            this.selectPCAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extra_text = new MetroFramework.Controls.MetroTextBox();
            this.orders_label = new MetroFramework.Controls.MetroLabel();
            this.extra_label = new MetroFramework.Controls.MetroLabel();
            this.registTableAdapter = new ElectricData.MainDBDataSetTableAdapters.registTableAdapter();
            this.countersTableAdapter = new ElectricData.MainDBDataSetTableAdapters.countersTableAdapter();
            this.bloksTableAdapter = new ElectricData.MainDBDataSetTableAdapters.bloksTableAdapter();
            this.selectPCAMTableAdapter = new ElectricData.MainDBDataSetTableAdapters.SelectPCAMTableAdapter();
            this.ammetersTableAdapter = new ElectricData.MainDBDataSetTableAdapters.ammetersTableAdapter();
            this.voltmetersTableAdapter = new ElectricData.MainDBDataSetTableAdapters.voltmetersTableAdapter();
            this.inputsTableAdapter = new ElectricData.MainDBDataSetTableAdapters.inputsTableAdapter();
            this.converters_iTableAdapter = new ElectricData.MainDBDataSetTableAdapters.converters_iTableAdapter();
            this.converters_uTableAdapter = new ElectricData.MainDBDataSetTableAdapters.converters_uTableAdapter();
            this.krmTableAdapter = new ElectricData.MainDBDataSetTableAdapters.krmTableAdapter();
            this.countryTableAdapter = new ElectricData.MainDBDataSetTableAdapters.countryTableAdapter();
            this.selectPCAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pCAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectCircuit_button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PCAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_counters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_bloks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_ammeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_inputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_conv_I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_conv_U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_krm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_voltmeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_country)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOfSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPCAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPCAMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcam_box
            // 
            this.pcam_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcam_box.DataSource = this.bindingSource_PCAM;
            this.pcam_box.DisplayMember = "PCAM";
            this.pcam_box.FormattingEnabled = true;
            this.pcam_box.ItemHeight = 23;
            this.pcam_box.Location = new System.Drawing.Point(157, 63);
            this.pcam_box.Name = "pcam_box";
            this.pcam_box.Size = new System.Drawing.Size(405, 29);
            this.pcam_box.TabIndex = 0;
            // 
            // bindingSource_PCAM
            // 
            this.bindingSource_PCAM.DataMember = "regist";
            this.bindingSource_PCAM.DataSource = this.mainDBDataSet;
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "MainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcam_label
            // 
            this.pcam_label.AutoSize = true;
            this.pcam_label.Location = new System.Drawing.Point(25, 63);
            this.pcam_label.Name = "pcam_label";
            this.pcam_label.Size = new System.Drawing.Size(47, 19);
            this.pcam_label.TabIndex = 1;
            this.pcam_label.Text = "PCAM";
            // 
            // counters_box
            // 
            this.counters_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.counters_box.DataSource = this.bindingSource_counters;
            this.counters_box.DisplayMember = "counter_name";
            this.counters_box.FormattingEnabled = true;
            this.counters_box.ItemHeight = 23;
            this.counters_box.Location = new System.Drawing.Point(157, 98);
            this.counters_box.Name = "counters_box";
            this.counters_box.Size = new System.Drawing.Size(405, 29);
            this.counters_box.TabIndex = 2;
            // 
            // bindingSource_counters
            // 
            this.bindingSource_counters.DataMember = "counters";
            this.bindingSource_counters.DataSource = this.mainDBDataSet;
            // 
            // counters_label
            // 
            this.counters_label.AutoSize = true;
            this.counters_label.Location = new System.Drawing.Point(25, 98);
            this.counters_label.Name = "counters_label";
            this.counters_label.Size = new System.Drawing.Size(66, 19);
            this.counters_label.TabIndex = 3;
            this.counters_label.Text = "Счётчики";
            // 
            // bloks_box
            // 
            this.bloks_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bloks_box.DataSource = this.bindingSource_bloks;
            this.bloks_box.DisplayMember = "bloks_name";
            this.bloks_box.FormattingEnabled = true;
            this.bloks_box.ItemHeight = 23;
            this.bloks_box.Location = new System.Drawing.Point(157, 133);
            this.bloks_box.Name = "bloks_box";
            this.bloks_box.Size = new System.Drawing.Size(405, 29);
            this.bloks_box.TabIndex = 4;
            // 
            // bindingSource_bloks
            // 
            this.bindingSource_bloks.DataMember = "bloks";
            this.bindingSource_bloks.DataSource = this.mainDBDataSet;
            // 
            // bloks_label
            // 
            this.bloks_label.AutoSize = true;
            this.bloks_label.Location = new System.Drawing.Point(25, 133);
            this.bloks_label.Name = "bloks_label";
            this.bloks_label.Size = new System.Drawing.Size(59, 19);
            this.bloks_label.TabIndex = 5;
            this.bloks_label.Text = "Колодка";
            // 
            // amper_box
            // 
            this.amper_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.amper_box.DataSource = this.bindingSource_ammeters;
            this.amper_box.DisplayMember = "ammeters_count";
            this.amper_box.FormattingEnabled = true;
            this.amper_box.ItemHeight = 23;
            this.amper_box.Location = new System.Drawing.Point(157, 168);
            this.amper_box.Name = "amper_box";
            this.amper_box.Size = new System.Drawing.Size(172, 29);
            this.amper_box.TabIndex = 6;
            // 
            // bindingSource_ammeters
            // 
            this.bindingSource_ammeters.DataMember = "ammeters";
            this.bindingSource_ammeters.DataSource = this.mainDBDataSet;
            // 
            // amper_label
            // 
            this.amper_label.AutoSize = true;
            this.amper_label.Location = new System.Drawing.Point(24, 168);
            this.amper_label.Name = "amper_label";
            this.amper_label.Size = new System.Drawing.Size(88, 19);
            this.amper_label.TabIndex = 7;
            this.amper_label.Text = "Амперметры";
            // 
            // inputs_box
            // 
            this.inputs_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputs_box.DataSource = this.bindingSource_inputs;
            this.inputs_box.DisplayMember = "inputs_count";
            this.inputs_box.FormattingEnabled = true;
            this.inputs_box.ItemHeight = 23;
            this.inputs_box.Location = new System.Drawing.Point(157, 241);
            this.inputs_box.Name = "inputs_box";
            this.inputs_box.Size = new System.Drawing.Size(172, 29);
            this.inputs_box.TabIndex = 8;
            // 
            // bindingSource_inputs
            // 
            this.bindingSource_inputs.DataMember = "inputs";
            this.bindingSource_inputs.DataSource = this.mainDBDataSet;
            // 
            // inputs_label
            // 
            this.inputs_label.AutoSize = true;
            this.inputs_label.Location = new System.Drawing.Point(24, 244);
            this.inputs_label.Name = "inputs_label";
            this.inputs_label.Size = new System.Drawing.Size(39, 19);
            this.inputs_label.TabIndex = 9;
            this.inputs_label.Text = "Ввод";
            // 
            // convertI_box
            // 
            this.convertI_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.convertI_box.DataSource = this.bindingSource_conv_I;
            this.convertI_box.DisplayMember = "conv_i";
            this.convertI_box.FormattingEnabled = true;
            this.convertI_box.ItemHeight = 23;
            this.convertI_box.Location = new System.Drawing.Point(157, 277);
            this.convertI_box.Name = "convertI_box";
            this.convertI_box.Size = new System.Drawing.Size(172, 29);
            this.convertI_box.TabIndex = 10;
            // 
            // bindingSource_conv_I
            // 
            this.bindingSource_conv_I.DataMember = "converters_i";
            this.bindingSource_conv_I.DataSource = this.mainDBDataSet;
            // 
            // convertI_label
            // 
            this.convertI_label.AutoSize = true;
            this.convertI_label.Location = new System.Drawing.Point(24, 280);
            this.convertI_label.Name = "convertI_label";
            this.convertI_label.Size = new System.Drawing.Size(126, 19);
            this.convertI_label.TabIndex = 11;
            this.convertI_label.Text = "Преобразователи I";
            // 
            // convertU_box
            // 
            this.convertU_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.convertU_box.DataSource = this.bindingSource_conv_U;
            this.convertU_box.DisplayMember = "conv_u";
            this.convertU_box.FormattingEnabled = true;
            this.convertU_box.ItemHeight = 23;
            this.convertU_box.Location = new System.Drawing.Point(157, 313);
            this.convertU_box.Name = "convertU_box";
            this.convertU_box.Size = new System.Drawing.Size(172, 29);
            this.convertU_box.TabIndex = 12;
            // 
            // bindingSource_conv_U
            // 
            this.bindingSource_conv_U.DataMember = "converters_u";
            this.bindingSource_conv_U.DataSource = this.mainDBDataSet;
            // 
            // convertU_label
            // 
            this.convertU_label.AutoSize = true;
            this.convertU_label.Location = new System.Drawing.Point(24, 315);
            this.convertU_label.Name = "convertU_label";
            this.convertU_label.Size = new System.Drawing.Size(132, 19);
            this.convertU_label.TabIndex = 13;
            this.convertU_label.Text = "Преобразователи U";
            // 
            // krm_box
            // 
            this.krm_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.krm_box.DataSource = this.bindingSource_krm;
            this.krm_box.DisplayMember = "krm_ind";
            this.krm_box.FormattingEnabled = true;
            this.krm_box.ItemHeight = 23;
            this.krm_box.Location = new System.Drawing.Point(157, 349);
            this.krm_box.Name = "krm_box";
            this.krm_box.Size = new System.Drawing.Size(172, 29);
            this.krm_box.TabIndex = 14;
            // 
            // bindingSource_krm
            // 
            this.bindingSource_krm.DataMember = "krm";
            this.bindingSource_krm.DataSource = this.mainDBDataSet;
            // 
            // krm_label
            // 
            this.krm_label.AutoSize = true;
            this.krm_label.Location = new System.Drawing.Point(24, 352);
            this.krm_label.Name = "krm_label";
            this.krm_label.Size = new System.Drawing.Size(36, 19);
            this.krm_label.TabIndex = 15;
            this.krm_label.Text = "КРМ";
            // 
            // volt_box
            // 
            this.volt_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.volt_box.DataSource = this.bindingSource_voltmeters;
            this.volt_box.DisplayMember = "volt_ind";
            this.volt_box.FormattingEnabled = true;
            this.volt_box.ItemHeight = 23;
            this.volt_box.Location = new System.Drawing.Point(157, 204);
            this.volt_box.Name = "volt_box";
            this.volt_box.Size = new System.Drawing.Size(172, 29);
            this.volt_box.TabIndex = 17;
            // 
            // bindingSource_voltmeters
            // 
            this.bindingSource_voltmeters.DataMember = "voltmeters";
            this.bindingSource_voltmeters.DataSource = this.mainDBDataSet;
            // 
            // volt_label
            // 
            this.volt_label.AutoSize = true;
            this.volt_label.Location = new System.Drawing.Point(24, 206);
            this.volt_label.Name = "volt_label";
            this.volt_label.Size = new System.Drawing.Size(71, 19);
            this.volt_label.TabIndex = 18;
            this.volt_label.Text = "Вольтметр";
            // 
            // country_box
            // 
            this.country_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.country_box.DataSource = this.bindingSource_country;
            this.country_box.DisplayMember = "country_name";
            this.country_box.FormattingEnabled = true;
            this.country_box.ItemHeight = 23;
            this.country_box.Location = new System.Drawing.Point(157, 385);
            this.country_box.Name = "country_box";
            this.country_box.Size = new System.Drawing.Size(172, 29);
            this.country_box.TabIndex = 19;
            // 
            // bindingSource_country
            // 
            this.bindingSource_country.DataMember = "country";
            this.bindingSource_country.DataSource = this.mainDBDataSet;
            // 
            // country_label
            // 
            this.country_label.AutoSize = true;
            this.country_label.Location = new System.Drawing.Point(24, 387);
            this.country_label.Name = "country_label";
            this.country_label.Size = new System.Drawing.Size(53, 19);
            this.country_label.TabIndex = 20;
            this.country_label.Text = "Страна";
            // 
            // DataEditor_button
            // 
            this.DataEditor_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DataEditor_button.Location = new System.Drawing.Point(24, 429);
            this.DataEditor_button.Name = "DataEditor_button";
            this.DataEditor_button.Size = new System.Drawing.Size(120, 70);
            this.DataEditor_button.TabIndex = 21;
            this.DataEditor_button.Text = "База данных";
            // 
            // OpenFolder_button
            // 
            this.OpenFolder_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OpenFolder_button.Location = new System.Drawing.Point(167, 429);
            this.OpenFolder_button.Name = "OpenFolder_button";
            this.OpenFolder_button.Size = new System.Drawing.Size(120, 70);
            this.OpenFolder_button.TabIndex = 22;
            this.OpenFolder_button.Text = "Открыть папку\r\nс учётом";
            // 
            // ExitOfSearch_button
            // 
            this.ExitOfSearch_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitOfSearch_button.Location = new System.Drawing.Point(444, 429);
            this.ExitOfSearch_button.Name = "ExitOfSearch_button";
            this.ExitOfSearch_button.Size = new System.Drawing.Size(120, 70);
            this.ExitOfSearch_button.TabIndex = 24;
            this.ExitOfSearch_button.Text = "Выход";
            // 
            // GridViewOfSearch
            // 
            this.GridViewOfSearch.AllowUserToAddRows = false;
            this.GridViewOfSearch.AllowUserToDeleteRows = false;
            this.GridViewOfSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewOfSearch.AutoGenerateColumns = false;
            this.GridViewOfSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOfSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCAMDataGridViewTextBoxColumn,
            this.ordersnameDataGridViewTextBoxColumn});
            this.GridViewOfSearch.DataSource = this.selectPCAMBindingSource1;
            this.GridViewOfSearch.Location = new System.Drawing.Point(350, 202);
            this.GridViewOfSearch.Name = "GridViewOfSearch";
            this.GridViewOfSearch.ReadOnly = true;
            this.GridViewOfSearch.RowHeadersVisible = false;
            this.GridViewOfSearch.Size = new System.Drawing.Size(211, 140);
            this.GridViewOfSearch.TabIndex = 24;
            // 
            // extra_text
            // 
            this.extra_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extra_text.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.extra_text.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.extra_text.Location = new System.Drawing.Point(350, 384);
            this.extra_text.Name = "extra_text";
            this.extra_text.Size = new System.Drawing.Size(211, 30);
            this.extra_text.TabIndex = 25;
            // 
            // orders_label
            // 
            this.orders_label.AutoSize = true;
            this.orders_label.Location = new System.Drawing.Point(350, 168);
            this.orders_label.Name = "orders_label";
            this.orders_label.Size = new System.Drawing.Size(55, 19);
            this.orders_label.TabIndex = 26;
            this.orders_label.Text = "Заказы:";
            // 
            // extra_label
            // 
            this.extra_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.extra_label.AutoSize = true;
            this.extra_label.Location = new System.Drawing.Point(350, 349);
            this.extra_label.Name = "extra_label";
            this.extra_label.Size = new System.Drawing.Size(109, 19);
            this.extra_label.TabIndex = 27;
            this.extra_label.Text = "Дополнительно:";
            // 
            // registTableAdapter
            // 
            this.registTableAdapter.ClearBeforeFill = true;
            // 
            // countersTableAdapter
            // 
            this.countersTableAdapter.ClearBeforeFill = true;
            // 
            // bloksTableAdapter
            // 
            this.bloksTableAdapter.ClearBeforeFill = true;
            // 
            // selectPCAMTableAdapter
            // 
            this.selectPCAMTableAdapter.ClearBeforeFill = true;
            // 
            // ammetersTableAdapter
            // 
            this.ammetersTableAdapter.ClearBeforeFill = true;
            // 
            // voltmetersTableAdapter
            // 
            this.voltmetersTableAdapter.ClearBeforeFill = true;
            // 
            // inputsTableAdapter
            // 
            this.inputsTableAdapter.ClearBeforeFill = true;
            // 
            // converters_iTableAdapter
            // 
            this.converters_iTableAdapter.ClearBeforeFill = true;
            // 
            // converters_uTableAdapter
            // 
            this.converters_uTableAdapter.ClearBeforeFill = true;
            // 
            // krmTableAdapter
            // 
            this.krmTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // selectPCAMBindingSource1
            // 
            this.selectPCAMBindingSource1.DataMember = "SelectPCAM";
            this.selectPCAMBindingSource1.DataSource = this.mainDBDataSet;
            // 
            // pCAMDataGridViewTextBoxColumn
            // 
            this.pCAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pCAMDataGridViewTextBoxColumn.DataPropertyName = "PCAM";
            this.pCAMDataGridViewTextBoxColumn.HeaderText = "PCAM";
            this.pCAMDataGridViewTextBoxColumn.Name = "pCAMDataGridViewTextBoxColumn";
            this.pCAMDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCAMDataGridViewTextBoxColumn.Width = 62;
            // 
            // ordersnameDataGridViewTextBoxColumn
            // 
            this.ordersnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ordersnameDataGridViewTextBoxColumn.DataPropertyName = "orders_name";
            this.ordersnameDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.ordersnameDataGridViewTextBoxColumn.Name = "ordersnameDataGridViewTextBoxColumn";
            this.ordersnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordersnameDataGridViewTextBoxColumn.Width = 96;
            // 
            // SelectCircuit_button
            // 
            this.SelectCircuit_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SelectCircuit_button.Location = new System.Drawing.Point(305, 429);
            this.SelectCircuit_button.Name = "SelectCircuit_button";
            this.SelectCircuit_button.Size = new System.Drawing.Size(120, 70);
            this.SelectCircuit_button.TabIndex = 23;
            this.SelectCircuit_button.Text = "Выбрать схему";
            this.SelectCircuit_button.Click += new System.EventHandler(this.SelectCircuit_button_Click);
            // 
            // FormOfSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 520);
            this.Controls.Add(this.SelectCircuit_button);
            this.Controls.Add(this.extra_label);
            this.Controls.Add(this.orders_label);
            this.Controls.Add(this.extra_text);
            this.Controls.Add(this.GridViewOfSearch);
            this.Controls.Add(this.ExitOfSearch_button);
            this.Controls.Add(this.OpenFolder_button);
            this.Controls.Add(this.DataEditor_button);
            this.Controls.Add(this.country_label);
            this.Controls.Add(this.country_box);
            this.Controls.Add(this.volt_label);
            this.Controls.Add(this.volt_box);
            this.Controls.Add(this.krm_label);
            this.Controls.Add(this.krm_box);
            this.Controls.Add(this.convertU_label);
            this.Controls.Add(this.convertU_box);
            this.Controls.Add(this.convertI_label);
            this.Controls.Add(this.convertI_box);
            this.Controls.Add(this.inputs_label);
            this.Controls.Add(this.inputs_box);
            this.Controls.Add(this.amper_label);
            this.Controls.Add(this.amper_box);
            this.Controls.Add(this.bloks_label);
            this.Controls.Add(this.bloks_box);
            this.Controls.Add(this.counters_label);
            this.Controls.Add(this.counters_box);
            this.Controls.Add(this.pcam_label);
            this.Controls.Add(this.pcam_box);
            this.MinimumSize = new System.Drawing.Size(570, 520);
            this.Name = "FormOfSearch";
            this.Text = "Учёт электроэнергии";
            this.Load += new System.EventHandler(this.FormOfSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PCAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_counters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_bloks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_ammeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_inputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_conv_I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_conv_U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_krm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_voltmeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_country)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOfSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPCAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPCAMBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox pcam_box;
        private MetroFramework.Controls.MetroLabel pcam_label;
        private MetroFramework.Controls.MetroComboBox counters_box;
        private MetroFramework.Controls.MetroLabel counters_label;
        private MetroFramework.Controls.MetroComboBox bloks_box;
        private MetroFramework.Controls.MetroLabel bloks_label;
        private MetroFramework.Controls.MetroComboBox amper_box;
        private MetroFramework.Controls.MetroLabel amper_label;
        private MetroFramework.Controls.MetroComboBox inputs_box;
        private MetroFramework.Controls.MetroLabel inputs_label;
        private MetroFramework.Controls.MetroComboBox convertI_box;
        private MetroFramework.Controls.MetroLabel convertI_label;
        private MetroFramework.Controls.MetroComboBox convertU_box;
        private MetroFramework.Controls.MetroLabel convertU_label;
        private MetroFramework.Controls.MetroComboBox krm_box;
        private MetroFramework.Controls.MetroLabel krm_label;
        private MetroFramework.Controls.MetroComboBox volt_box;
        private MetroFramework.Controls.MetroLabel volt_label;
        private MetroFramework.Controls.MetroComboBox country_box;
        private MetroFramework.Controls.MetroLabel country_label;
        private MetroFramework.Controls.MetroButton DataEditor_button;
        private MetroFramework.Controls.MetroButton OpenFolder_button;
        private MetroFramework.Controls.MetroButton ExitOfSearch_button;
        private System.Windows.Forms.DataGridView GridViewOfSearch;
        private MetroFramework.Controls.MetroTextBox extra_text;
        private MetroFramework.Controls.MetroLabel orders_label;
        private MetroFramework.Controls.MetroLabel extra_label;
        private System.Windows.Forms.BindingSource bindingSource_PCAM;
        private MainDBDataSet mainDBDataSet;
        private MainDBDataSetTableAdapters.registTableAdapter registTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_counters;
        private MainDBDataSetTableAdapters.countersTableAdapter countersTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_bloks;
        private MainDBDataSetTableAdapters.bloksTableAdapter bloksTableAdapter;
        private System.Windows.Forms.BindingSource selectPCAMBindingSource;
        private MainDBDataSetTableAdapters.SelectPCAMTableAdapter selectPCAMTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_ammeters;
        private MainDBDataSetTableAdapters.ammetersTableAdapter ammetersTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_voltmeters;
        private MainDBDataSetTableAdapters.voltmetersTableAdapter voltmetersTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_inputs;
        private MainDBDataSetTableAdapters.inputsTableAdapter inputsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_conv_I;
        private MainDBDataSetTableAdapters.converters_iTableAdapter converters_iTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_conv_U;
        private MainDBDataSetTableAdapters.converters_uTableAdapter converters_uTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_krm;
        private MainDBDataSetTableAdapters.krmTableAdapter krmTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource_country;
        private MainDBDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource selectPCAMBindingSource1;
        private MetroFramework.Controls.MetroButton SelectCircuit_button;
    }
}

