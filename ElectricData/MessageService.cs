﻿using System.Windows.Forms;

namespace ElectricData
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string exclamation);
        void ShowError(string error);
    }

    //Класс вывода сообщений, предупреждений и ошибок
    public class MessageService: IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation (string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError (string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
