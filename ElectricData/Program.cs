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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormOfConnectionDB formConnection = new FormOfConnectionDB();
            FormOfDataEditor formEditor = new FormOfDataEditor();
            FormOfSearch formSearch = new FormOfSearch();
            FormOfSelect formSelect = new FormOfSelect();
            MessageService service = new MessageService();
            DataBaseManager DBmanager = new DataBaseManager();

            MainPresenter presenter = new MainPresenter(formConnection, formEditor, formSearch, formSelect, service, DBmanager);

            Application.Run(formConnection);
        }
    }
}
