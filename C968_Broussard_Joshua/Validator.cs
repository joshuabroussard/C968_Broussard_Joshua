using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Broussard_Joshua
{
    abstract class Validator
    {
        protected string ErrorMessage { get; set; }

        public Validator()
        {
            ErrorMessage = "";
        }

        public static bool IsInt(string s)
        {
            return int.TryParse(s, out int i);
        }
        public static bool IsDecimal(string s)
        {
            return decimal.TryParse(s, out decimal i);
        }
        public void Show()
        {
            MessageBox.Show(ErrorMessage, "Error");
        }
    }

}
