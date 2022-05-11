using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Broussard_Joshua
{
    internal class PartValidator : Validator
    {
        public bool Validate(string name, string price, string inventory, string min, string max, string changing, bool inhouse)
        {
            if(inhouse) ErrorMessage = VerifyInhouse(name, price, inventory, min, max, changing);
            else ErrorMessage = VerifyOutsourced(name, price, inventory, min, max, changing);
            return ErrorMessage.Length == 0;
        }



        public override bool Validate(string s)
        {
            throw new NotImplementedException();
        }
        private string VerifyOutsourced(string name, string price, string inventory, string min, string max, string companyName)
        {
            string errorText = "";

            if (name.Length == 0) errorText += "Error: Part Must Have A Name.\n";
            if (price.Length == 0) errorText += "Error: Part Must Have A Price.\n";
            if (inventory.Length == 0) errorText += "Error: Part Must Have An Inventory Amount.\n";
            if (min.Length == 0) errorText += "Error: Part Must Have A Min Stock.\n";
            if (max.Length == 0) errorText += "Error: Part Must Have A Max Stock.\n";
            if (companyName.Length == 0) errorText += "Error: Part Must Have A Machine ID.\n";

            if (!IsDecimal(price)) errorText += "Error: Price Must Be a Number.\n";
            if (!IsInt(inventory)) errorText += "Error: Inventory Must Be a Number.\n";
            if (!IsInt(min)) errorText += "Error: Min Must Be a Number.\n";
            if (!IsInt(max)) errorText += "Error: Max Must Be a Number.\n";

            if (errorText == "" && int.Parse(max) < int.Parse(min)) errorText += "Error: Max Must Be Greater Than Min\n";

            if (errorText == "" && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                errorText += "Error: Max Must Be Greater Than Min\n";
            }

            return errorText;
        }
        private string VerifyInhouse(string name, string price, string inventory, string min, string max, string machineID)
        {
            string errorText = "";

            if (name.Length == 0) errorText += "Error: Part Must Have A Name.\n";
            if (price.Length == 0) errorText += "Error: Part Must Have A Price.\n";
            if (inventory.Length == 0) errorText += "Error: Part Must Have An Inventory Amount.\n";
            if (min.Length == 0) errorText += "Error: Part Must Have A Min Stock.\n";
            if (max.Length == 0) errorText += "Error: Part Must Have A Max Stock.\n";
            if (machineID.Length == 0) errorText += "Error: Part Must Have A Machine ID.\n";

            if (!IsDecimal(price)) errorText += "Error: Price Must Be a Number.\n";
            if (!IsInt(inventory)) errorText += "Error: Inventory Must Be a Number.\n";
            if (!IsInt(min)) errorText += "Error: Min Must Be a Number.\n";
            if (!IsInt(max)) errorText += "Error: Max Must Be a Number.\n";
            if (!IsInt(machineID)) errorText += "Error: Machine ID Must Be a Number.\n";

            if (errorText == "" && int.Parse(max) < int.Parse(min)) errorText += "Error: Max Must Be Greater Than Min\n";

            if (errorText == "" && (int.Parse(inventory) < int.Parse(min) || int.Parse(inventory) > int.Parse(max)))
            {
                errorText += "Error: Inventory must be between Min and Max\n";
            }

            return errorText;
        }
    }
}
