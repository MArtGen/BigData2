using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Collections.Generic;

namespace ElectricData
{
    public interface IFormOfSearch
    {
        List<string> Search_of_items { get; set; }
        string Extra { set; }
        string Link { set; }
        string PCAM_link { get; set; }
        DataGridView SearchView { get; }
        event EventHandler OpenFolder;
        event EventHandler Select_Extra;
        event EventHandler OpenDataEditor;
        event EventHandler BackToSelect;
    }
    public partial class FormOfSearch : MetroForm, IFormOfSearch
    {
        List<string> item_search;
        string link, pcam_link, extra;

        public FormOfSearch()
        {
            InitializeComponent();
            pcam_box.SelectedIndexChanged += Pcam_box_SelectedIndexChanged;
            DataEditor_button.Click += DataEditor_button_Click;
            OpenFolder_button.Click += OpenFolder_button_Click;
            ExitOfSearch_button.Click += ExitOfSearch_button_Click;
        }

        private void Pcam_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            pcam_link = pcam_box.Text;
            Select_Extra?.Invoke(this, EventArgs.Empty);
            extra_text.Text = extra;
        }

        #region События формы Search
        private void ExitOfSearch_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFolder_button_Click(object sender, EventArgs e)
        {
            pcam_link = pcam_box.Text;
            OpenFolder?.Invoke(this, EventArgs.Empty);
            if (link != null && link !="NULL" && link !="")
                System.Diagnostics.Process.Start("explorer", @link);
            else MessageBox.Show("Для данного РСАМ нет ссылки на папку");
        }

        private void DataEditor_button_Click(object sender, EventArgs e)
        {
            OpenDataEditor?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        private void FormOfSearch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.mainDBDataSet.country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.krm". При необходимости она может быть перемещена или удалена.
            this.krmTableAdapter.Fill(this.mainDBDataSet.krm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.converters_u". При необходимости она может быть перемещена или удалена.
            this.converters_uTableAdapter.Fill(this.mainDBDataSet.converters_u);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.converters_i". При необходимости она может быть перемещена или удалена.
            this.converters_iTableAdapter.Fill(this.mainDBDataSet.converters_i);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.inputs". При необходимости она может быть перемещена или удалена.
            this.inputsTableAdapter.Fill(this.mainDBDataSet.inputs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.voltmeters". При необходимости она может быть перемещена или удалена.
            this.voltmetersTableAdapter.Fill(this.mainDBDataSet.voltmeters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.ammeters". При необходимости она может быть перемещена или удалена.
            this.ammetersTableAdapter.Fill(this.mainDBDataSet.ammeters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.SelectPCAM". При необходимости она может быть перемещена или удалена.
            this.selectPCAMTableAdapter.Fill(this.mainDBDataSet.SelectPCAM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.bloks". При необходимости она может быть перемещена или удалена.
            this.bloksTableAdapter.Fill(this.mainDBDataSet.bloks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.counters". При необходимости она может быть перемещена или удалена.
            this.countersTableAdapter.Fill(this.mainDBDataSet.counters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.regist". При необходимости она может быть перемещена или удалена.
            this.registTableAdapter.Fill(this.mainDBDataSet.regist);

            pcam_link = pcam_box.Text;
            Select_Extra?.Invoke(this, EventArgs.Empty);
            extra_text.Text = extra;

        }

        private void SelectCircuit_button_Click(object sender, EventArgs e)
        {
            BackToSelect?.Invoke(this, EventArgs.Empty);
            Hide();
        }
        #endregion

        #region IFormOfSearch
        public DataGridView SearchView
        {
            get => throw new NotImplementedException();
        }
        public List<string> Search_of_items
        {
            get { return item_search; }
            set { item_search = value; }
        }
        public string Link
        {
            set { link = value; }
        }
        public string Extra
        {
            set { extra = value; }
        }
        public string PCAM_link
        {
            get { return pcam_link; }
            set { pcam_link = value; }
        }

        public event EventHandler OpenFolder;
        public event EventHandler Select_Extra;
        public event EventHandler OpenDataEditor;
        public event EventHandler BackToSelect;
        #endregion
    }
}
