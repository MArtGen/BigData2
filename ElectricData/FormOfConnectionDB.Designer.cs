namespace ElectricData
{
    partial class FormOfConnectionDB
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
            this.serverName_text = new MetroFramework.Controls.MetroTextBox();
            this.serverName_label = new MetroFramework.Controls.MetroLabel();
            this.dbname_label = new MetroFramework.Controls.MetroLabel();
            this.nameDB_text = new MetroFramework.Controls.MetroTextBox();
            this.Connection_button = new MetroFramework.Controls.MetroButton();
            this.ExitOfConnection_button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // serverName_text
            // 
            this.serverName_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverName_text.Location = new System.Drawing.Point(132, 74);
            this.serverName_text.MinimumSize = new System.Drawing.Size(229, 23);
            this.serverName_text.Name = "serverName_text";
            this.serverName_text.Size = new System.Drawing.Size(229, 23);
            this.serverName_text.TabIndex = 0;
            // 
            // serverName_label
            // 
            this.serverName_label.AutoSize = true;
            this.serverName_label.Location = new System.Drawing.Point(24, 78);
            this.serverName_label.Name = "serverName_label";
            this.serverName_label.Size = new System.Drawing.Size(92, 19);
            this.serverName_label.TabIndex = 1;
            this.serverName_label.Text = "Имя сервера:";
            // 
            // dbname_label
            // 
            this.dbname_label.AutoSize = true;
            this.dbname_label.Location = new System.Drawing.Point(24, 122);
            this.dbname_label.Name = "dbname_label";
            this.dbname_label.Size = new System.Drawing.Size(59, 19);
            this.dbname_label.TabIndex = 2;
            this.dbname_label.Text = "Имя БД:";
            // 
            // nameDB_text
            // 
            this.nameDB_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameDB_text.Location = new System.Drawing.Point(132, 118);
            this.nameDB_text.MinimumSize = new System.Drawing.Size(229, 23);
            this.nameDB_text.Name = "nameDB_text";
            this.nameDB_text.Size = new System.Drawing.Size(229, 23);
            this.nameDB_text.TabIndex = 3;
            // 
            // Connection_button
            // 
            this.Connection_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Connection_button.Location = new System.Drawing.Point(24, 158);
            this.Connection_button.Name = "Connection_button";
            this.Connection_button.Size = new System.Drawing.Size(153, 58);
            this.Connection_button.TabIndex = 4;
            this.Connection_button.Text = "Подключиться";
            // 
            // ExitOfConnection_button
            // 
            this.ExitOfConnection_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitOfConnection_button.Location = new System.Drawing.Point(208, 158);
            this.ExitOfConnection_button.Name = "ExitOfConnection_button";
            this.ExitOfConnection_button.Size = new System.Drawing.Size(153, 58);
            this.ExitOfConnection_button.TabIndex = 5;
            this.ExitOfConnection_button.Text = "Выход";
            // 
            // FormOfConnectionDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 237);
            this.Controls.Add(this.ExitOfConnection_button);
            this.Controls.Add(this.Connection_button);
            this.Controls.Add(this.nameDB_text);
            this.Controls.Add(this.dbname_label);
            this.Controls.Add(this.serverName_label);
            this.Controls.Add(this.serverName_text);
            this.MaximumSize = new System.Drawing.Size(900, 237);
            this.MinimumSize = new System.Drawing.Size(382, 237);
            this.Name = "FormOfConnectionDB";
            this.Text = "Подключение к базе данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox serverName_text;
        private MetroFramework.Controls.MetroLabel serverName_label;
        private MetroFramework.Controls.MetroLabel dbname_label;
        private MetroFramework.Controls.MetroTextBox nameDB_text;
        private MetroFramework.Controls.MetroButton Connection_button;
        private MetroFramework.Controls.MetroButton ExitOfConnection_button;
    }
}