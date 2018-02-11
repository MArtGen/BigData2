using System;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfSelect
    {
        event EventHandler OkClick;
        event EventHandler ExitApp;
        event EventHandler SelectSort;
    }
    public partial class FormOfSelect : MetroForm, IFormOfSelect
    {
        public FormOfSelect()
        {
            InitializeComponent();
            SelectOfSort_box.Click += SelectOfSort_box_Click;
            SelectSort_button.Click += SelectSort_button_Click;
            ExitSelect_button.Click += ExitSelect_button_Click;
        }

        #region События формы Select
        private void ExitSelect_button_Click(object sender, EventArgs e)
        {
            ExitApp?.Invoke(this, EventArgs.Empty);
        }

        private void SelectSort_button_Click(object sender, EventArgs e)
        {
            OkClick?.Invoke(this, EventArgs.Empty);
        }

        private void SelectOfSort_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IFormOfSelect
        public event EventHandler OkClick;
        public event EventHandler ExitApp;
        public event EventHandler SelectSort;
        #endregion
    }
}
