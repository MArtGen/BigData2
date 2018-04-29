using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ElectricData
{
    public interface IFormOfSelect
    {
        List<string> SearchSelection { get; set; }
        string Message { get; set; }
        event EventHandler OpenSearch;
        event EventHandler ErrorOfSelect;
    }

    //Форма выбора схемы
    public partial class FormOfSelect : MetroForm, IFormOfSelect
    {
        List<string> items_select_box;
        string message;

        public FormOfSelect()
        {
            InitializeComponent();
            SelectSort_button.Click += SelectSort_button_Click;
            ExitSelect_button.Click += ExitSelect_button_Click;
        }

        #region События формы Select
        //Обработка кнопки "Выход"
        private void ExitSelect_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Обработка закрытия формы
        private void FormOfSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Обработка кнопки перехода к форме поиска (временное решение)
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

        //Загрузка формы
        private void FormOfSelect_Load(object sender, EventArgs e)
        {
            try
            {
                this.circuitsTableAdapter.Fill(this.mainDBDataSet.circuits);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                ErrorOfSelect?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion

        #region IFormOfSelect
        //Поиск списка схем по базе данных (сейчас в коде не задействовано, используется BindingSource и TableAdapter)
        public List<string> SearchSelection
        {
            get { return items_select_box; }
            set { items_select_box = value; }
        }

        //Передаваемое сообщение
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //Проброс событий формы
        public event EventHandler ErrorOfSelect;
        public event EventHandler OpenSearch;
        #endregion
    }
}
