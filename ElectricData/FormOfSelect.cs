using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ElectricData
{
    public interface IFormOfSelect
    {
        List<string> SearchSelection { get; set; }
        event EventHandler SelectOfSort;
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
            if (SelectOfSort_box.Text == "Учет электроэнергии")
            {
                FormOfSearch search = new FormOfSearch();
                search.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Интерфейс в разработке");
            }
        }

        private void SelectOfSort_box_Click(object sender, EventArgs e)
        {
            SelectOfSort?.Invoke(this, EventArgs.Empty);
            SelectOfSort_box.DataSource = items_select_box;
        }
        #endregion

        #region IFormOfSelect
        public event EventHandler SelectOfSort;

        public List<string> SearchSelection
        {
            get { return items_select_box; }
            set { items_select_box = value; }
        }
        #endregion
    }
}
