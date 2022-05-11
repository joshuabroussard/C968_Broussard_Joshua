namespace C968_Broussard_Joshua
{
    public partial class AddPart : Form
    {
        Inventory inventory;
        public AddPart(Inventory inventory)
        {
            this.inventory = inventory;
            InitializeComponent();
            idTextBox.Text = GetNextID().ToString();
        }
        private int GetNextID() 
        {
            var map = new Dictionary<int, int>();
            foreach (Part part in inventory.AllParts)
            {
                map.Add(part.PartID, part.PartID);
            }
            for (int i = 1; i <= inventory.AllParts.Count; i++) 
            {
                bool inUse = map.TryGetValue(i, out int j);
                if (!inUse) return i;
            }
            return inventory.AllParts.Count + 1;
            
        }
        private void inhouseButton_CheckedChanged(object sender, EventArgs e)
        {
            changingLabel.Text = "Machine ID";
            // changingTextBox.Text = "Machine ID";
            changingLabel.Location = new Point(40, 246);
        }

        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            changingLabel.Text = "Company Name";
            // changingTextBox.Text = "Company Name";
            changingLabel.Location = new Point(6, 246);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //check if inhouse or outsoruced radio button checked
            if (inhouseButton.Checked)
            {
                saveInhouse();

            }
            else
            {
                saveOutsourced();
            }
            
        }
        private void saveInhouse()
        {
            var validator = new PartValidator();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                changingTextBox.Text,
                true
                );
            if (!valid) { validator.Show(); return; }
            inventory.addPart(
                new InhousePart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    int.Parse(changingTextBox.Text)
                    )
            );
            this.Close();
        }

        private void saveOutsourced()
        {
            var validator = new PartValidator();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                changingTextBox.Text,
                false
                );
            if (!valid) { validator.Show(); return; }
            inventory.addPart(
                new OutsourcedPart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    changingTextBox.Text
                    )
            );
            this.Close();
        }

        public static bool IsInt(string s)
        {
            return int.TryParse(s, out int i);
        }
        public static bool IsDecimal(string s)
        {
            return decimal.TryParse(s, out decimal i);
        }

    }
}
