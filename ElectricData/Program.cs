using System;
using System.Windows.Forms;
using ElectricData.BL;

namespace ElectricData
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormOfConnectionDB formConnection = new FormOfConnectionDB();
            FormOfSelect formSelect = new FormOfSelect();
            FormOfDataEditor formEditor = new FormOfDataEditor();
            FormOfSearch formSearch = new FormOfSearch();
            MessageService service = new MessageService();
            DataBaseManager DBmanager = new DataBaseManager();
            Application.EnableVisualStyles();

            MainPresenter presenter = new MainPresenter(formConnection, formSelect, formEditor, formSearch, service, DBmanager);

            try
            {
                Application.Run(formConnection);
            }
            catch (Exception ex)
            {
                service.ShowError(ex.Message);
            }
        }
    }
}
