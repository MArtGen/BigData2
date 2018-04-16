using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ElectricData
{
    public interface IFormOfSelect
    {
        List<string> SearchSelection { get; set; }
        event EventHandler OpenSearch;
    }
    public partial class FormOfSelect : MetroForm, IFormOfSelect
    {
        List<string> items_select_box;

        public FormOfSelect()
        {
            InitializeComponent();
            SelectSort_button.Click += SelectSort_button_Click;
            ExitSelect_button.Click += ExitSelect_button_Click;
        }

        #region События формы Select
        private void ExitSelect_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormOfSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SelectSort_button_Click(object sender, EventArgs e)
        {
            if (SelectOfSort_box.Text == "Учет электроэнергии")
            {
                Hide();
                OpenSearch?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Интерфейс в разработке");
            }
        }

        private void FormOfSelect_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet_circuits.circuits". При необходимости она может быть перемещена или удалена.
            this.circuitsTableAdapter.Fill(this.mainDBDataSet.circuits);
        }
        #endregion

        #region IFormOfSelect
        public event EventHandler OpenSearch;

        public List<string> SearchSelection
        {
            get { return items_select_box; }
            set { items_select_box = value; }
        }
        #endregion
    }
}
