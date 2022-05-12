using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Broussard_Joshua
{
    internal class ProductValidator : Validator
    {
        public bool Validate(string name, string price, string inventory, string min, string max)
        {
            if (name.Length == 0) ErrorMessage += "Error: Part Must Have A Name.\n";
            if (price.Length == 0) ErrorMessage += "Error: Part Must Have A Price.\n";
            if (inventory.Length == 0) ErrorMessage += "Error: Part Must Have An Inventory Amount.\n";
            if (min.Length == 0) ErrorMessage += "Error: Part Must Have A Min Stock.\n";
            if (max.Length == 0) ErrorMessage += "Error: Part Must Have A Max Stock.\n";
            if (!IsDecimal(price)) ErrorMessage += "Error: Price Must Be a Number.\n";
            if (!IsInt(inventory)) ErrorMessage += "Error: Inventory Must Be a Whole Number.\n";
            if (!IsInt(min)) ErrorMessage += "Error: Min Must Be a Whole Number.\n";
            if (!IsInt(max)) ErrorMessage += "Error: Max Must Be a Whole Number.\n";

            if (ErrorMessage == "" && int.Parse(max) < int.Parse(min)) ErrorMessage += "Error: Max Must Be Greater Than Min\n";

            if (ErrorMessage == "" && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                ErrorMessage += "Error: Inventory Must Be Between Min and Max Values\n";
            }
            return ErrorMessage.Length == 0;
        }
    }
}
