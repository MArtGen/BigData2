using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfDataEditor
    {
        string Message { get; set; }
        event EventHandler BackToSearch;
        event EventHandler ErrorOfDE;
        event EventHandler MessageOfDE;
    }

    //Форма редактора баз данных (редактора таблиц)
    public partial class FormOfDataEditor : MetroForm, IFormOfDataEditor
    {
        string message;

        public FormOfDataEditor()
        {
            InitializeComponent();
            Exit_button.Click += ExitOfDataEditor_button_Click;
            GridViewOfDataEditor.DataError += GridViewOfDataEditor_DataError;
        }

        #region События формы DataEditor
        //Обработка кнопки возврата в поисковую форму
        private void ExitOfDataEditor_button_Click(object sender, EventArgs e)
        {
            BackToSearch?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        //Обработка закрытия формы редактора
        private void FormOfDataEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.Exit();
        }

        //Обработка кнопки сохранения
        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                registTableAdapter.Update(mainDBDataSet);
                countersTableAdapter.Update(mainDBDataSet);
                bloksTableAdapter.Update(mainDBDataSet);
                inputsTableAdapter.Update(mainDBDataSet);
                ammetersTableAdapter.Update(mainDBDataSet);
                voltmetersTableAdapter.Update(mainDBDataSet);
                converters_iTableAdapter.Update(mainDBDataSet);
                converters_uTableAdapter.Update(mainDBDataSet);
                krmTableAdapter.Update(mainDBDataSet);
                countryTableAdapter.Update(mainDBDataSet);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                ErrorOfDE?.Invoke(this, EventArgs.Empty);
            }
        }

        //Событие по изменению выбора таблиц в combobox
        private void table_select_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Move_table(table_select_box.Text);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                ErrorOfDE?.Invoke(this, EventArgs.Empty);
            }
        }

        //Событие загрузки формы
        private void FormOfDataEditor_Load(object sender, EventArgs e)
        {
            try
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
                GridViewOfDataEditor.AllowUserToAddRows = false; //Удаление строки добавления в конце основной таблицы
                table_select_box.SelectedIndex = 0;
                table_select_box.DropDownStyle = ComboBoxStyle.DropDownList; //Запрет на запись в combobox
            }
            catch (Exception ex)
            {
                message = ex.Message;
                ErrorOfDE?.Invoke(this, EventArgs.Empty);
            }
        }

        //Обработчик события ошибки DataGridView
        private void GridViewOfDataEditor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            message = "Ошибка ввода. Основные поля поиска не должны быть пустыми";
            ErrorOfDE?.Invoke(this, EventArgs.Empty);
            e.ThrowException = false;
        }
        #endregion

        #region IFormOfDataEditor
        //Передаваемое сообщение
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //Проброс событий формы
        public event EventHandler BackToSearch;
        public event EventHandler ErrorOfDE;
        public event EventHandler MessageOfDE;
        #endregion

        #region Методы DataEditor
        //Формирование вспомогательных таблиц
        private void Select_table(BindingSource binding, string columns_name)
        {
            GridViewOfDataEditor.Columns.Clear();
            GridViewOfDataEditor.DataSource = binding;
            bindingNavigatorOfDataEditor.BindingSource = binding;
            GridViewOfDataEditor.AutoGenerateColumns = true;
            GridViewOfDataEditor.Columns[0].Visible = false;
            GridViewOfDataEditor.Columns[1].HeaderText = columns_name;
            GridViewOfDataEditor.AutoResizeColumns();
            GridViewOfDataEditor.AllowUserToAddRows = false;
        }

        //Формирование основной таблицы
        private void Select_PCAMtable()
        {
            GridViewOfDataEditor.DataSource = registBindingSource;
            bindingNavigatorOfDataEditor.BindingSource = registBindingSource;
            GridViewOfDataEditor.Columns.Clear();
            Fill_textbox("id", "id");
            Fill_textbox("РСАМ", "PCAM");
            Fill_combobox("Счётчики", "id_counters", countersBindingSource, "counter_name");
            Fill_combobox("Колодки", "id_bloks", bloksBindingSource, "bloks_name");
            Fill_combobox("Амперметры", "id_ammeters", ammetersBindingSource, "ammeters_count");
            Fill_combobox("Вольтметры", "id_voltmeters", voltmetersBindingSource, "volt_ind");
            Fill_combobox("Ввод", "id_inputs", inputsBindingSource, "inputs_count");
            Fill_combobox("Преобразователи I", "id_converters_i", convertersiBindingSource, "conv_i");
            Fill_combobox("Преобразователи U", "id_converters_u", convertersuBindingSource, "conv_u");
            Fill_combobox("КРМ", "id_krm", krmBindingSource, "krm_ind");
            Fill_combobox("Страна", "id_country", countryBindingSource, "country_name");
            Fill_textbox("Номер заказа", "number_of_order");
            Fill_textbox("Ссылка", "link");
            Fill_textbox("Дополнительно", "note");
            GridViewOfDataEditor.AutoResizeColumns();
            GridViewOfDataEditor.Columns[0].Visible = false;
            GridViewOfDataEditor.AllowUserToAddRows = false;
        }

        //Заполнение combobox основной таблицы
        private void Fill_combobox(string header, string name, BindingSource source, string d_member)
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = header;
            combo.DataPropertyName = name;
            combo.DataSource = source;
            combo.DisplayMember = d_member;
            combo.ValueMember = "id";
            GridViewOfDataEditor.Columns.Add(combo);
        }

        //Заполнение textbox основной таблицы
        private void Fill_textbox(string header, string name)
        {
            DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn();
            text.HeaderText = header;
            text.DataPropertyName = name;
            GridViewOfDataEditor.Columns.Add(text);
        }

        //Выборка таблиц из combobox
        private void Move_table (string box_name)
        {
            switch (box_name)
            {
                case "Счётчики": Select_table(countersBindingSource, "Счётчик"); break;
                case "Колодки": Select_table(bloksBindingSource, "Колодка"); break;
                case "Ввод": Select_table(inputsBindingSource, "Кол-во вводов"); break;
                case "Амперметры": Select_table(ammetersBindingSource, "Кол-во амперметров"); break;
                case "Вольтметры": Select_table(voltmetersBindingSource, "Вольтметры"); break;
                case "Преобразователи I": Select_table(convertersiBindingSource, "Наличие преобразователей тока"); break;
                case "Преобразователи U": Select_table(convertersuBindingSource, "Наличие преобразователей напряжения"); break;
                case "КРМ": Select_table(krmBindingSource, "Наличие клемм для КРМ"); break;
                case "Страна": Select_table(countryBindingSource, "Страна"); break;
                default: Select_PCAMtable(); break;
            }
        }
        #endregion
    }
}
