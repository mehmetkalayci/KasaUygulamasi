using System;
using System.Windows.Forms;

namespace CashBookApp.WinForm.Helper
{
    public static class MessageHelper
    {
        private static string title = System.Windows.Forms.Application.ProductName;

        public static DialogResult AskMessage(string question)
        {
            return MessageBox.Show(question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static void InfoMessage(string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WarnMessage(string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErrorMessage(Exception ex = null)
        {
            MessageHelper.InfoMessage("İşlem sırasında hata oluştu!");
            if (ex != null)
                LogHelper.WriteLog(ex);
        }
    }
}
