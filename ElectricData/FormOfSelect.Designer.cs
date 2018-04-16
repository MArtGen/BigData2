namespace ElectricData
{
    partial class FormOfSelect
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
            this.SelectOfSort_box = new MetroFramework.Controls.MetroComboBox();
            this.bindingSource_circuits = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new ElectricData.MainDBDataSet();
            this.SelectSort_button = new MetroFramework.Controls.MetroButton();
            this.ExitSelect_button = new MetroFramework.Controls.MetroButton();
            this.circuitsTableAdapter = new ElectricData.MainDBDataSetTableAdapters.circuitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_circuits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectOfSort_box
            // 
            this.SelectOfSort_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectOfSort_box.DataSource = this.bindingSource_circuits;
            this.SelectOfSort_box.DisplayMember = "c_name";
            this.SelectOfSort_box.FormattingEnabled = true;
            this.SelectOfSort_box.ItemHeight = 23;
            this.SelectOfSort_box.Location = new System.Drawing.Point(24, 75);
            this.SelectOfSort_box.Name = "SelectOfSort_box";
            this.SelectOfSort_box.Size = new System.Drawing.Size(321, 29);
            this.SelectOfSort_box.TabIndex = 0;
            // 
            // bindingSource_circuits
            // 
            this.bindingSource_circuits.DataMember = "circuits";
            this.bindingSource_circuits.DataSource = this.mainDBDataSet;
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "MainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectSort_button
            // 
            this.SelectSort_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectSort_button.Location = new System.Drawing.Point(24, 122);
            this.SelectSort_button.Name = "SelectSort_button";
            this.SelectSort_button.Size = new System.Drawing.Size(153, 58);
            this.SelectSort_button.TabIndex = 5;
            this.SelectSort_button.Text = "OK";
            // 
            // ExitSelect_button
            // 
            this.ExitSelect_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitSelect_button.Location = new System.Drawing.Point(192, 122);
            this.ExitSelect_button.Name = "ExitSelect_button";
            this.ExitSelect_button.Size = new System.Drawing.Size(153, 58);
            this.ExitSelect_button.TabIndex = 6;
            this.ExitSelect_button.Text = "Выход";
            // 
            // circuitsTableAdapter
            // 
            this.circuitsTableAdapter.ClearBeforeFill = true;
            // 
            // FormOfSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 198);
            this.Controls.Add(this.ExitSelect_button);
            this.Controls.Add(this.SelectSort_button);
            this.Controls.Add(this.SelectOfSort_box);
            this.MaximumSize = new System.Drawing.Size(900, 198);
            this.MinimumSize = new System.Drawing.Size(368, 198);
            this.Name = "FormOfSelect";
            this.Text = "Выберите тип схемы:";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOfSelect_FormClosed);
            this.Load += new System.EventHandler(this.FormOfSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_circuits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox SelectOfSort_box;
        private MetroFramework.Controls.MetroButton SelectSort_button;
        private MetroFramework.Controls.MetroButton ExitSelect_button;
        private System.Windows.Forms.BindingSource bindingSource_circuits;
        private MainDBDataSet mainDBDataSet;
        private MainDBDataSetTableAdapters.circuitsTableAdapter circuitsTableAdapter;
    }
}