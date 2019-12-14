using System;
using System.Windows.Forms;

namespace CashBookApp.WinForm.Helper
{
    public static class FormHelper
    {
        private static TForm GetForm<TForm>(params object[] contructorParams) where TForm : Form
        {
            return (TForm)Activator.CreateInstance(typeof(TForm), contructorParams);
        }

        public static void Show<TForm>(Form parent, FormWindowState windowState, params object[] contructorParams) where TForm : Form
        {
            foreach (Form selectedForm in Application.OpenForms)
            {
                if (selectedForm.GetType() == typeof(TForm))
                {
                    selectedForm.Activate();
                    return;
                }
            }

            var form = GetForm<TForm>(contructorParams);
            form.WindowState = windowState;
            form.MdiParent = parent;
            form.Show();
        }

        public static void Show<TForm>(params object[] contructorParams) where TForm : Form
        {
            var form = GetForm<TForm>(contructorParams);
            form.Show();
        }

        public static void ShowDialog<TForm>(params object[] contructorParams) where TForm : Form
        {
            var form = GetForm<TForm>(contructorParams);
            form.ShowDialog();
        }
    }
}
