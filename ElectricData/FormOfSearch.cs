using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Collections.Generic;

namespace ElectricData
{
    public interface IFormOfSearch
    {
        List<string> Search_of_items { get; set; }
        bool Back_to_search { get; set; }
        string Extra { set; }
        string Link { set; }
        string PCAM_link { get; set; }
        string Message { get; set; }
        event EventHandler OpenFolder;
        event EventHandler Select_Extra;
        event EventHandler OpenDataEditor;
        event EventHandler BackToSelect;
        event EventHandler MessageOfSearch;
    }

    public partial class FormOfSearch : MetroForm, IFormOfSearch
    {
        List<string> item_search;
        string link, pcam_link, extra, message, pcam_sel;
        bool back = false;

        public FormOfSearch()
        {
            InitializeComponent();
            pcam_box.SelectedIndexChanged += Pcam_box_SelectedIndexChanged;
            DataEditor_button.Click += DataEditor_button_Click;
            OpenFolder_button.Click += OpenFolder_button_Click;
            ExitOfSearch_button.Click += ExitOfSearch_button_Click;
        }

        #region События формы Search
        private void Pcam_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            pcam_link = pcam_box.Text;
            Select_Extra?.Invoke(this, EventArgs.Empty);
            extra_text.Text = extra;
            selectAllBindingSource.Filter = "[PCAM] LIKE'" + pcam_link +"%'";
        }

        private void ExitOfSearch_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormOfSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenFolder_button_Click(object sender, EventArgs e)
        {
            pcam_link = pcam_box.Text;
            OpenFolder?.Invoke(this, EventArgs.Empty);
            if (link != null && link != "NULL" && link != "")
                System.Diagnostics.Process.Start("explorer", @link);
            else
            {
                message = "Нет ссылки для данного РСАМа";
                MessageOfSearch?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DataEditor_button_Click(object sender, EventArgs e)
        {
            OpenDataEditor?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        private void FormOfSearch_Load(object sender, EventArgs e)
        {
            selectAllTableAdapter.Fill(mainDBDataSet.SelectAll);
            this.countryTableAdapter.Fill(this.mainDBDataSet.country);
            country_box.SelectedIndex = -1;

            this.krmTableAdapter.Fill(this.mainDBDataSet.krm);
            krm_box.SelectedIndex = -1;

            this.converters_uTableAdapter.Fill(this.mainDBDataSet.converters_u);
            convertU_box.SelectedIndex = -1;

            this.converters_iTableAdapter.Fill(this.mainDBDataSet.converters_i);
            convertI_box.SelectedIndex = -1;

            this.inputsTableAdapter.Fill(this.mainDBDataSet.inputs);
            inputs_box.SelectedIndex = -1;

            this.voltmetersTableAdapter.Fill(this.mainDBDataSet.voltmeters);
            volt_box.SelectedIndex = -1;

            this.ammetersTableAdapter.Fill(this.mainDBDataSet.ammeters);
            amper_box.SelectedIndex = -1;

            this.bloksTableAdapter.Fill(this.mainDBDataSet.bloks);
            bloks_box.SelectedIndex = -1;

            this.countersTableAdapter.Fill(this.mainDBDataSet.counters);
            counters_box.SelectedIndex = -1;

            this.registTableAdapter.Fill(this.mainDBDataSet.regist);
            pcam_box.SelectedIndex = -1;

            this.selectPCAMTableAdapter.Fill(this.mainDBDataSet.SelectPCAM);
            Load_extra();
        }

        private void SelectCircuit_button_Click(object sender, EventArgs e)
        {
            BackToSelect?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (counters_box.Text != "" && bloks_box.Text !="" && amper_box.Text != "" && 
                volt_box.Text !="" && inputs_box.Text != "" && convertI_box.Text !="" && 
                convertU_box.Text != "" && krm_box.Text != "" && country_box.Text != "")
            {
                AllSelection();

                if (GridViewOfSearch.Rows.Count != 0)
                {
                    pcam_sel = GridViewOfSearch[0, GridViewOfSearch.CurrentRow.Index].Value.ToString();
                    pcam_box.Text = pcam_sel;
                    pcam_box.Enabled = false;
                }
                else
                {
                    pcam_box.Enabled = true;
                    pcam_box.SelectedIndex = -1;
                    pcam_box.Refresh();
                    AllSelection();
                }
            }
            else
            {
                message = "Заполните все поля (РСАМ можно не заполнять)";
                MessageOfSearch?.Invoke(this, EventArgs.Empty);
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            pcam_box.SelectedIndex = -1;
            counters_box.SelectedIndex = -1;
            bloks_box.SelectedIndex = -1;
            amper_box.SelectedIndex = -1;
            volt_box.SelectedIndex = -1;
            inputs_box.SelectedIndex = -1;
            convertI_box.SelectedIndex = -1;
            convertU_box.SelectedIndex = -1;
            krm_box.SelectedIndex = -1;
            country_box.SelectedIndex = -1;
            pcam_box.Refresh();
            counters_box.Refresh();
            bloks_box.Refresh();
            amper_box.Refresh();
            volt_box.Refresh();
            inputs_box.Refresh();
            convertI_box.Refresh();
            convertU_box.Refresh();
            krm_box.Refresh();
            country_box.Refresh();
            extra_text.Text = "";
            selectAllBindingSource.RemoveFilter();
            pcam_box.Enabled = true;
        }

        private void FormOfSearch_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true && back == true)
            {
                registTableAdapter.Fill(mainDBDataSet.regist);
                bindingSource_PCAM.ResetBindings(false);
                pcam_box.SelectedIndex = -1;

                countersTableAdapter.Fill(mainDBDataSet.counters);
                bindingSource_counters.ResetBindings(false);
                counters_box.SelectedIndex = -1;

                bloksTableAdapter.Fill(mainDBDataSet.bloks);
                bindingSource_bloks.ResetBindings(false);
                bloks_box.SelectedIndex = -1;

                ammetersTableAdapter.Fill(mainDBDataSet.ammeters);
                bindingSource_ammeters.ResetBindings(false);
                amper_box.SelectedIndex = -1;

                voltmetersTableAdapter.Fill(mainDBDataSet.voltmeters);
                bindingSource_voltmeters.ResetBindings(false);
                volt_box.SelectedIndex = -1;

                inputsTableAdapter.Fill(mainDBDataSet.inputs);
                bindingSource_inputs.ResetBindings(false);
                inputs_box.SelectedIndex = -1;

                converters_iTableAdapter.Fill(mainDBDataSet.converters_i);
                bindingSource_conv_I.ResetBindings(false);
                convertI_box.SelectedIndex = -1;

                converters_uTableAdapter.Fill(mainDBDataSet.converters_u);
                bindingSource_conv_U.ResetBindings(false);
                convertU_box.SelectedIndex = -1;

                krmTableAdapter.Fill(mainDBDataSet.krm);
                bindingSource_krm.ResetBindings(false);
                krm_box.SelectedIndex = -1;

                countryTableAdapter.Fill(mainDBDataSet.country);
                bindingSource_country.ResetBindings(false);
                country_box.SelectedIndex = -1;

                selectAllTableAdapter.Fill(mainDBDataSet.SelectAll);
                selectAllBindingSource.ResetBindings(false);
                back = false;
            }
        }
        #endregion

        #region IFormOfSearch
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

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool Back_to_search
        {
            get { return back; }
            set { back = value; }
        }

        public event EventHandler OpenFolder;
        public event EventHandler Select_Extra;
        public event EventHandler OpenDataEditor;
        public event EventHandler BackToSelect;
        public event EventHandler MessageOfSearch;
        #endregion

        private void Load_extra()
        {
            try
            {
                FileStream stream = new FileStream("Note.txt", FileMode.Open);
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.GetEncoding(1251));
                Note_textbox.Font = new System.Drawing.Font("Arial", 8);
                Note_textbox.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectTableString(ComboBox box, string select_row)
        {
            selectAllBindingSource.Filter += "AND [" + select_row + "] LIKE '" + box.Text + "%'";
        }

        private void SelectTableInt(ComboBox box, string select_row)
        {
            selectAllBindingSource.Filter += "AND Convert([" + select_row + "],'System.String') LIKE '" + box.Text + "%'";
        }

        private void AllSelection()
        {
            selectAllBindingSource.Filter = "[counter_name] LIKE'" + counters_box.Text + "%'";
            SelectTableString(bloks_box, "bloks_name");
            SelectTableInt(amper_box, "ammeters_count");
            SelectTableString(volt_box, "volt_ind");
            SelectTableInt(inputs_box, "inputs_count");
            SelectTableString(convertI_box, "conv_i");
            SelectTableString(convertU_box, "conv_u");
            SelectTableString(krm_box, "krm_ind");
            SelectTableString(country_box, "country_name");
        }
    }
}
