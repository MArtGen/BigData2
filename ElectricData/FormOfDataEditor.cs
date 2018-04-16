using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfDataEditor
    {
        event EventHandler TableChange;
        event EventHandler SaveChanges;
        event EventHandler BackToSearch;
    }
    public partial class FormOfDataEditor : MetroForm, IFormOfDataEditor
    {
        public FormOfDataEditor()
        {
            InitializeComponent();
            Exit_button.Click += ExitOfDataEditor_button_Click;
        }

        #region События формы DataEditor
        private void ExitOfDataEditor_button_Click(object sender, EventArgs e)
        {
            BackToSearch?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        private void FormOfDataEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            registTableAdapter.Update(mainDBDataSet);
        }

        private void FormOfDataEditor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.mainDBDataSet.country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.voltmeters". При необходимости она может быть перемещена или удалена.
            this.voltmetersTableAdapter.Fill(this.mainDBDataSet.voltmeters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.krm". При необходимости она может быть перемещена или удалена.
            this.krmTableAdapter.Fill(this.mainDBDataSet.krm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.converters_u". При необходимости она может быть перемещена или удалена.
            this.converters_uTableAdapter.Fill(this.mainDBDataSet.converters_u);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.converters_i". При необходимости она может быть перемещена или удалена.
            this.converters_iTableAdapter.Fill(this.mainDBDataSet.converters_i);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.bloks". При необходимости она может быть перемещена или удалена.
            this.bloksTableAdapter.Fill(this.mainDBDataSet.bloks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.ammeters". При необходимости она может быть перемещена или удалена.
            this.ammetersTableAdapter.Fill(this.mainDBDataSet.ammeters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.inputs". При необходимости она может быть перемещена или удалена.
            this.inputsTableAdapter.Fill(this.mainDBDataSet.inputs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.counters". При необходимости она может быть перемещена или удалена.
            this.countersTableAdapter.Fill(this.mainDBDataSet.counters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.regist". При необходимости она может быть перемещена или удалена.
            this.registTableAdapter.Fill(this.mainDBDataSet.regist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.SelectAll". При необходимости она может быть перемещена или удалена.
        }
        #endregion

        #region IFormOfDataEditor
        public event EventHandler BackToSearch;
        public event EventHandler TableChange;
        public event EventHandler SaveChanges;
        #endregion
    }
}
