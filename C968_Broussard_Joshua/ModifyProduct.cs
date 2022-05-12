using System.ComponentModel;

namespace C968_Broussard_Joshua
{
    public partial class ModifyProduct : Form
    {
        Inventory inventory;
        Product product;
        BindingList<Part> parts;
        public ModifyProduct(Inventory inventory, Product product)
        {
            this.inventory = inventory;
            this.product = product;
            InitializeComponent();
            idTextBox.Text = this.product.ProductID.ToString();
            nameTextBox.Text = this.product.Name;
            priceTextBox.Text = this.product.Price.ToString();
            inventoryTextBox.Text = this.product.InStock.ToString();
            minTextBox.Text = this.product.Min.ToString();
            maxTextBox.Text = this.product.Max.ToString();
            allPartsGrid.DataSource = this.inventory.AllParts;
            parts = new();
            foreach (Part part in this.product.AssociatedParts)
            {
                parts.Add(part);
            }
            associatedPartsGrid.DataSource = parts;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // if no row selected throw an error messagebox
            if (allPartsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected! Please select a part to add.", "Error");
            }
            // if row selected add part to products asssociated parts
            else
            {
                Part part = (Part)allPartsGrid.SelectedRows[0].DataBoundItem;
                parts.Add(part);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // if no row selected throw an error messagebox
            if (associatedPartsGrid.SelectedRows.Count == 0) { MessageBox.Show("No part selected! Please select a part to delete.", "Error"); return; }
            Part part = (Part)associatedPartsGrid.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Please confirm that you want to delete the part {part.Name}(ID:{part.PartID})", "Delete Part?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                parts.Remove(part);
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            var validator = new ProductValidator();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text
                );
            if (!valid) { validator.Show(); return; }
            this.product.AssociatedParts = parts;
            this.product.ProductID = int.Parse(idTextBox.Text);
            this.product.Name = nameTextBox.Text;
            this.product.Price = decimal.Parse(priceTextBox.Text);
            this.product.InStock = int.Parse(inventoryTextBox.Text);
            this.product.Min = int.Parse(minTextBox.Text);
            this.product.Max = int.Parse(maxTextBox.Text);
            this.inventory.updateProduct(this.product.ProductID, this.product);
            this.Close();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "") { MessageBox.Show("Please Enter A Numeric ID", "Error"); return; }
            if (!int.TryParse(searchBox.Text, out int id)) { MessageBox.Show("Please Enter A Numeric ID", "Error"); return; }
            foreach (DataGridViewRow row in allPartsGrid.Rows)
            {
                if (row.DataBoundItem is Part part)
                {
                    if (part.PartID == id)
                    {
                        allPartsGrid.ClearSelection();
                        row.Selected = true;
                        return;
                    }
                }
            }
            MessageBox.Show("No Matching Parts Found", "Error");
        }
    }
}
