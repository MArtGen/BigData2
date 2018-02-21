using System;
using System.IO;
using ElectricData.BL;
using System.Data.SqlClient;
using System.Xml.Serialization;

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

            _search.ItemSelect += _search_ItemSelect;
            _search.OpenEditor += _search_OpenEditor;
            _search.OpenFolder += _search_OpenFolder;

            _select.OkClick += _select_OkClick;
            _select.SelectSort += _select_SelectSort;
        }


        public MainPresenter()
        {

        }

        private void _connection_ExitApp(object sender, EventArgs e)
        {
            
        }

        private void _select_SelectSort(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _select_OkClick(object sender, EventArgs e)
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
                string connectionString = _manager.ConnectionDB(_connection.Servername, _connection.DBname);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
                _connection_ExitApp(this, e);
            }
        }
    }
}
