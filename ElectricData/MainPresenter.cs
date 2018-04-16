using System;
using ElectricData.BL;

namespace ElectricData
{
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
            formOfSelect = (FormOfSelect) select;
            formOfSearch = (FormOfSearch) search;
            formOfDE = (FormOfDataEditor) editor;
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

            _search.OpenFolder += _search_OpenFolder;
            _search.Select_Extra += _search_SelectOfExtra;
            _search.OpenDataEditor += _search_OpenDataEditor;
            _search.BackToSelect += _connection_OpenSelect;
            _search.MessageOfSearch += _search_MessageOfSearch;

            _editor.SaveChanges += _editor_SaveChanges;
            _editor.TableChange += _editor_TableChange;
            _editor.BackToSearch += _select_OpenSearch;
        }

        #region WinForm - события загрузки форм
        private void _search_OpenDataEditor(object sender, EventArgs e)
        {
            formOfDE.Show();
        }

        private void _connection_OpenSelect(object sender, EventArgs e)
        {
            formOfSelect.Show();
        }

        private void _select_OpenSearch(object sender, EventArgs e)
        {
            formOfSearch.Show();
        }
        #endregion

        private void _search_MessageOfSearch(object sender, EventArgs e)
        {
            _messageService.ShowMessage(_search.Message);
        }

        private void _search_SelectOfExtra(object sender, EventArgs e)
        {
            _search.Extra = _manager.Select_Note(_search.PCAM_link, "extra");
        }

        private void _search_OpenFolder(object sender, EventArgs e)
        {
            _search.Link = _manager.Select_Note(_search.PCAM_link, "link");
        }

        private void _editor_TableChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _editor_SaveChanges(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

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
    }
}
