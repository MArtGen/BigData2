using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfSearch
    {
        string Extra { get;}
        DataGridView SearchView { get;}
        event EventHandler OpenEditor;
        event EventHandler OpenFolder;
        event EventHandler ItemSelect;
    }
    public partial class FormOfSearch : MetroForm, IFormOfSearch
    {
        public FormOfSearch()
        {
            InitializeComponent();
            pcam_box.Click += Pcam_box_Click;
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

        #region События формы Search
        private void ExitOfSearch_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFolder_button_Click(object sender, EventArgs e)
        {
            OpenFolder?.Invoke(this, EventArgs.Empty);
        }

        private void DataEditor_button_Click(object sender, EventArgs e)
        {
            OpenEditor?.Invoke(this, EventArgs.Empty);
        }

        private void Country_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Krm_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ConvertU_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ConvertI_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Volt_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Amper_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Bloks_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Inputs_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Counters_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Pcam_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IFormOfSearch
        public string Extra
        {
            get => throw new NotImplementedException();
        }
        public DataGridView SearchView
        {
            get => throw new NotImplementedException();
        }

        public event EventHandler OpenEditor;
        public event EventHandler OpenFolder;
        public event EventHandler ItemSelect;
        #endregion
    }
}
