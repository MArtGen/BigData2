using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Collections.Generic;

namespace ElectricData
{
    public interface IFormOfSearch
    {
        List<string> Search_of_items { get; set; }
        string Search_box { get; }
        string Extra { set; }
        string Link { set; }
        string PCAM_link { get; set; }
        DataGridView SearchView { get; }
        event EventHandler OpenFolder;
        event EventHandler ItemSelect;
        event EventHandler Select_Extra;
    }
    public partial class FormOfSearch : MetroForm, IFormOfSearch
    {
        List<string> item_search;
        string search_box, link, pcam_link, extra;

        public FormOfSearch()
        {
            InitializeComponent();
            pcam_box.Click += Pcam_box_Click;
            pcam_box.SelectedIndexChanged += Pcam_box_SelectedIndexChanged;
            counters_box.Click += Counters_box_Click;
            inputs_box.Click += Inputs_box_Click;
            bloks_box.Click += Bloks_box_Click;
            amper_box.Click += Amper_box_Click;
            volt_box.Click += Volt_box_Click;
            convertI_box.Click += ConvertI_box_Click;
            convertU_box.Click += ConvertU_box_Click;
            krm_box.Click += Krm_box_Click;
            country_box.Click += Country_box_Click;
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
            FormOfDataEditor formOfDE = new FormOfDataEditor();
            formOfDE.ShowDialog();
        }

        private void Country_box_Click(object sender, EventArgs e)
        {
            search_box = "country";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            country_box.DataSource = item_search;
        }

        private void Krm_box_Click(object sender, EventArgs e)
        {
            search_box = "krm";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            krm_box.DataSource = item_search;
        }

        private void ConvertU_box_Click(object sender, EventArgs e)
        {
            search_box = "conv_u";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            convertU_box.DataSource = item_search;
        }

        private void ConvertI_box_Click(object sender, EventArgs e)
        {
            search_box = "conv_i";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            convertI_box.DataSource = item_search;
        }

        private void Volt_box_Click(object sender, EventArgs e)
        {
            search_box = "voltmeters";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            volt_box.DataSource = item_search;
        }

        private void Amper_box_Click(object sender, EventArgs e)
        {
            search_box = "ammeters";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            amper_box.DataSource = item_search;
        }

        private void Bloks_box_Click(object sender, EventArgs e)
        {
            search_box = "bloks";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            bloks_box.DataSource = item_search;
        }

        private void Inputs_box_Click(object sender, EventArgs e)
        {
            search_box = "inputs";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            inputs_box.DataSource = item_search;
        }

        private void Counters_box_Click(object sender, EventArgs e)
        {
            search_box = "counters";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            counters_box.DataSource = item_search;
        }

        private void Pcam_box_Click(object sender, EventArgs e)
        {
            search_box = "pcam";
            ItemSelect?.Invoke(this, EventArgs.Empty);
            pcam_box.DataSource = item_search;
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
        public string Search_box
        {
            get { return search_box; }
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
        public event EventHandler ItemSelect;
        public event EventHandler Select_Extra;
        #endregion
    }
}
