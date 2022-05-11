namespace C968_Broussard_Joshua
{
    public partial class AddProduct : Form
    {
        Inventory inventory;
        Product product;
        public AddProduct(Inventory inventory)
        {
            this.inventory = inventory;
            this.product = new Product();
            InitializeComponent();
            allPartsGrid.DataSource = this.inventory.AllParts;

            associatedPartsGrid.DataSource = product.AssociatedParts;
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
                product.addAssocaitedPart(part);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // if no row selected throw an error messagebox
            if (associatedPartsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected! Please select a part to delete.", "Error");
            }
            // if row selected remove part from products asssociated parts
            else
            {
                Part part = (Part)associatedPartsGrid.SelectedRows[0].DataBoundItem;
                product.removeAssociatedPart(part.PartID);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
