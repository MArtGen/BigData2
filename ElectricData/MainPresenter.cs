using System;
using ElectricData.BL;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            _connection.ExitApp += _connection_ExitApp;

            _editor.SaveChanges += _editor_SaveChanges;
            _editor.TableChange += _editor_TableChange;
            _editor.ExitApp += _editor_ExitApp;

            _search.ItemSelect += _search_ItemSelect;
            _search.OpenEditor += _search_OpenEditor;
            _search.OpenFolder += _search_OpenFolder;
            _search.ExitApp += _search_ExitApp;

            _select.OkClick += _select_OkClick;
            _select.SelectSort += _select_SelectSort;
            _select.ExitApp += _select_ExitApp;
        }

        private void _select_ExitApp(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _select_SelectSort(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _select_OkClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _search_ExitApp(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        private void _editor_ExitApp(object sender, EventArgs e)
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

        private void _connection_ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _connection_DBconnect(object sender, EventArgs e)
        {
            try
            {
                string connectionString = _manager.ConnectionDB(_connection.Servername, _connection.DBname);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}
