using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfDataEditor
    {
        DataGridView TableView { get; }
        event EventHandler TableChange;
        event EventHandler ExitApp;
        event EventHandler SaveChanges;
    }
    public partial class FormOfDataEditor : MetroForm, IFormOfDataEditor
    {
        public FormOfDataEditor()
        {
            InitializeComponent();
            SelectOfTable_box.Click += SelectOfTable_box_Click;
            SaveData_button.Click += SaveData_button_Click;
            ExitOfDataEditor_button.Click += ExitOfDataEditor_button_Click;
        }

        #region События формы DataEditor
        private void ExitOfDataEditor_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveData_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SelectOfTable_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IFormOfDataEditor
        public DataGridView TableView
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler TableChange;
        public event EventHandler ExitApp;
        public event EventHandler SaveChanges;
        #endregion
    }
}
