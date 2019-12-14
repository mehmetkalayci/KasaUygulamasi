using System.Globalization;
using System.Windows.Forms;

namespace CashBookApp.WinForm.Helper
{
    public static class StringHelper
    {
        public static bool IsDecimal(this string text)
        {
            decimal temp = 0;
            return decimal.TryParse(text, out temp);
        }

        public static bool IsInt(this string text)
        {
            int temp = 0;
            return int.TryParse(text, out temp);
        }

        public static bool IsNotNull(this string text)
        {
            return text != null && text.Trim().Length > 0;
        }

        public static string TitleCase(this string text)
        {
            if (!text.IsNotNull())
            {
                return text;
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower()); ;
        }

        public static string CapitalizeFirstLetter(this string text)
        {
            if (!text.IsNotNull())
            {
                return text;
            }
            return text.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + text.Substring(1);
        }

        public static void TitleCaseTextBox(TextBox txt)
        {
            var location = txt.SelectionStart;
            txt.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt.Text.ToLower());
            txt.SelectionStart = location;
        }
    }
}
