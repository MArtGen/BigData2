using System;
using ElectricData.BL;

namespace ElectricData
{
    class MainPresenter
    {
        private readonly IFormOfConnection _connection;
        private readonly IFormOfDataEditor _editor;
        private readonly IFormOfSearch _search;
        private readonly IFormOfSelect _select;
        private readonly IMessageService _messageService;
        private readonly IDataBaseManager _manager;

        public MainPresenter (IFormOfConnection connection, IFormOfDataEditor editor, IFormOfSearch search,
                              IFormOfSelect select, IMessageService service, IDataBaseManager manager)
        {
            _connection = connection;
            _editor = editor;
            _search = search;
            _select = select;
            _messageService = service;
            _manager = manager;

            _connection.DBconnect += _connection_DBconnect;

            _select.SelectOfSort += _select_SelectOfSort;

            _search.ItemSelect += _search_ItemSelect;
            _search.OpenEditor += _search_OpenEditor;
            _search.OpenFolder += _search_OpenFolder;

            _editor.SaveChanges += _editor_SaveChanges;
            _editor.TableChange += _editor_TableChange;
        }

        private void _select_SelectOfSort(object sender, EventArgs e)
        {
            _select.SearchSelection = _manager.Selection("circuits");       
        }

        private void _search_OpenFolder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _search_OpenEditor(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _search_ItemSelect(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
