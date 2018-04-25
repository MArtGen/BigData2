using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfDataEditor
    {
        event EventHandler BackToSearch;
    }
    public partial class FormOfDataEditor : MetroForm, IFormOfDataEditor
    {
        DataView view = new DataView();
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
            this.countryTableAdapter.Fill(this.mainDBDataSet.country);
            this.voltmetersTableAdapter.Fill(this.mainDBDataSet.voltmeters);
            this.krmTableAdapter.Fill(this.mainDBDataSet.krm);
            this.converters_uTableAdapter.Fill(this.mainDBDataSet.converters_u);
            this.converters_iTableAdapter.Fill(this.mainDBDataSet.converters_i);
            this.bloksTableAdapter.Fill(this.mainDBDataSet.bloks);
            this.ammetersTableAdapter.Fill(this.mainDBDataSet.ammeters);
            this.inputsTableAdapter.Fill(this.mainDBDataSet.inputs);
            this.countersTableAdapter.Fill(this.mainDBDataSet.counters);
            this.registTableAdapter.Fill(this.mainDBDataSet.regist);
            GridViewOfDataEditor.AllowUserToAddRows = false;
            table_select_box.SelectedIndex = 0;
        }
        #endregion

        #region IFormOfDataEditor
        public event EventHandler BackToSearch;
        #endregion

        private void table_select_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Move_table(table_select_box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Select_table(BindingSource binding, string columns_name)
        {
            GridViewOfDataEditor.Columns.Clear();
            GridViewOfDataEditor.DataSource = binding;
            bindingNavigatorOfDataEditor.BindingSource = binding;
            GridViewOfDataEditor.AutoGenerateColumns = true;
            GridViewOfDataEditor.AutoResizeColumns();
            GridViewOfDataEditor.Columns[0].Visible = false;
            GridViewOfDataEditor.Columns[1].HeaderText = columns_name;
            GridViewOfDataEditor.AllowUserToAddRows = false;
        }

        private void Select_PCAMtable()
        {
            Select_table(registBindingSource, "PCAM");
        }

        private void Move_table (string box_name)
        {
            switch (box_name)
            {
                case "Счётчики": Select_table(countersBindingSource, "Счётчик"); break;
                case "Колодки": Select_table(bloksBindingSource, "Колодка"); break;
                case "Ввод": Select_table(inputsBindingSource, "Кол-во вводов"); break;
                case "Амперметры": Select_table(ammetersBindingSource, "Кол-во амперметров"); break;
                case "Вольтметры": Select_table(voltmetersBindingSource, "Кол-во вольтметров"); break;
                case "Преобразователи I": Select_table(convertersiBindingSource, "Наличие преобразователей тока"); break;
                case "Преобразователи U": Select_table(convertersuBindingSource, "Наличие преобразователей напряжения"); break;
                case "КРМ": Select_table(krmBindingSource, "Наличие клемм для КРМ"); break;
                case "Страна": Select_table(countryBindingSource, "Страна"); break;
                default: Select_PCAMtable(); break;
            }
        }
    }
}
