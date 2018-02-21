using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ElectricData
{
    public interface IFormOfSelect
    {
        List<string> ItemsBox { get; set; }
        event EventHandler OkClick;
        event EventHandler SelectSort;
    }
    public partial class FormOfSelect : MetroForm, IFormOfSelect
    {
        List<string> items_select_box;

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
            Application.Exit();
        }

        private void SelectSort_button_Click(object sender, EventArgs e)
        {
            OkClick?.Invoke(this, EventArgs.Empty);
        }

        private void SelectOfSort_box_Click(object sender, EventArgs e)
        {
            SelectOfSort_box.DataSource = items_select_box;
        }
        #endregion

        #region IFormOfSelect
        public event EventHandler OkClick;
        public event EventHandler SelectSort;


        public List<string> ItemsBox
        {
            get { return items_select_box; }
            set { items_select_box = value; }
        }
        #endregion
    }
}
