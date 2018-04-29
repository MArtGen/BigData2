using System;
using ElectricData.BL;

namespace ElectricData
{
    //Класс Presenter (паттерн MVP) для связи интерфейса и бизнес-логики
    class MainPresenter
    {
        private readonly IFormOfConnection _connection;
        private readonly IFormOfSelect _select;
        private readonly IFormOfDataEditor _editor;
        private readonly IFormOfSearch _search;
        private readonly IMessageService _messageService;
        private readonly IDataBaseManager _manager;

        #region WinForm - объявление переменных
        FormOfDataEditor formOfDE = new FormOfDataEditor();
        FormOfSelect formOfSelect = new FormOfSelect();
        FormOfSearch formOfSearch = new FormOfSearch();
        #endregion

        public MainPresenter (IFormOfConnection connection, IFormOfSelect select, IFormOfDataEditor editor, IFormOfSearch search, IMessageService service, IDataBaseManager manager)
        {
            #region WinForm - инициализация переменных
            formOfDE = (FormOfDataEditor)editor;
            formOfSelect = (FormOfSelect)select;
            formOfSearch = (FormOfSearch)search;
            #endregion

            _connection = connection;
            _select = select;
            _editor = editor;
            _search = search;
            _messageService = service;
            _manager = manager;

            _connection.DBconnect += _connection_DBconnect;
            _connection.OpenSelect += _connection_OpenSelect;

            _select.OpenSearch += _select_OpenSearch;
            _select.ErrorOfSelect += _select_ErrorOfSelect;

            _search.OpenFolder += _search_OpenFolder;
            _search.Select_Extra += _search_SelectOfExtra;
            _search.OpenDataEditor += _search_OpenDataEditor;
            _search.BackToSelect += _connection_OpenSelect;
            _search.MessageOfSearch += _search_MessageOfSearch;
            _search.ErrorOfSearch += _search_ErrorOfSearch;

            _editor.BackToSearch += _editor_BackToSearch;
            _editor.ErrorOfDE += _editor_ErrorOfDE;
            _editor.MessageOfDE += _editor_MessageOfDE;
        }

        #region WinForm - события загрузки форм
        //Обработчик открытия редактора таблиц из формы поиска
        private void _search_OpenDataEditor(object sender, EventArgs e)
        {
            formOfDE.Show();
        }

        //Обработчик открытия формы выбора схем из формы подключения к базе данных
        private void _connection_OpenSelect(object sender, EventArgs e)
        {
            formOfSelect.Show();
        }

        //Обработчик открытия формы поиска из формы выбора схем
        private void _select_OpenSearch(object sender, EventArgs e)
        {
            formOfSearch.Show();
        }

        //Обработчик возврата в форму поиска из редактора таблиц
        private void _editor_BackToSearch(object sender, EventArgs e)
        {
            _search.Back_to_search = true;
            formOfSearch.Show();
        }
        #endregion

        #region События форм
        //Обработка события вызова сообщения об ошибке в форме выбора схем
        private void _select_ErrorOfSelect(object sender, EventArgs e)
        {
            _messageService.ShowError(_select.Message);
        }

        //Обработка события вызова сообщения в форме поиска
        private void _search_MessageOfSearch(object sender, EventArgs e)
        {
            _messageService.ShowMessage(_search.Message);
        }

        //Обработка события вызова сообщения об ошибке в форме поиска
        private void _search_ErrorOfSearch(object sender, EventArgs e)
        {
            _messageService.ShowError(_search.Message);
        }

        //Обработка события выбора дополнительной информации по базе данных
        private void _search_SelectOfExtra(object sender, EventArgs e)
        {
            _search.Extra = _manager.Select_Note(_search.PCAM_link, "extra");
        }

        //Обработка события выбора ссылки из базы данных для открытия папки с выбранной схемой
        private void _search_OpenFolder(object sender, EventArgs e)
        {
            _search.Link = _manager.Select_Note(_search.PCAM_link, "link");
        }

        //Обработка события вызова сообщения об ошибке в форме редактора таблиц
        private void _editor_ErrorOfDE(object sender, EventArgs e)
        {
            _messageService.ShowError(_editor.Message);
        }

        //Обработка события вызова сообщения в форме редактора таблиц
        private void _editor_MessageOfDE(object sender, EventArgs e)
        {
            _messageService.ShowMessage(_editor.Message);
        }

        //Обработка события подключения к базе данных
        private void _connection_DBconnect(object sender, EventArgs e)
        {
            try
            {
                _manager.ConnectionDB(_connection.Servername, _connection.DBname);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
                Globals.exit_app = true;
            }
        }
        #endregion
    }
}
