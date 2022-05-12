using System.ComponentModel;

namespace C968_Broussard_Joshua
{
    public partial class MainForm : Form
    {
        private Inventory inventory;
        public MainForm()
        {
            inventory = CreateInventory();
            InitializeComponent();
            partGrid.DataSource = inventory.AllParts;
            productGrid.DataSource = inventory.Products;


        }

        private static Inventory CreateInventory()
        {
            BindingList<Part> allParts = new();
            allParts.Add(new OutsourcedPart(1, "Crazy Good CPU", 16.22m, 5, 1, 5, "AMD"));
            allParts.Add(new OutsourcedPart(2, "Crazy Okay CPU", 15.2m, 4, 2, 6, "Intel"));
            allParts.Add(new OutsourcedPart(3, "Crazy Bad CPU", 14.22m, 3, 3, 7, "Apple"));
            allParts.Add(new InhousePart(4, "Crazy Good GPU", 16.22m, 5, 1, 5, 1));
            allParts.Add(new InhousePart(5, "Crazy Okay GPU", 15.22m, 4, 2, 6, 2));
            allParts.Add(new InhousePart(6, "Crazy Bad GPU", 14.22m, 3, 3, 7, 3));
            BindingList<Product> products = new()
            {
                new Product(GenerateParts(allParts), 1, "Just a Computer1", 999.99m, 3, 1, 5),
                new Product(GenerateParts(allParts), 2, "Just a Computer2", 1999.99m, 3, 1, 5),
                new Product(GenerateParts(allParts), 3, "Just a Computer3", 2999.99m, 3, 1, 5),
                new Product(GenerateParts(allParts), 4, "Just a Computer4", 3999.99m, 3, 1, 5),
                new Product(GenerateParts(allParts), 5, "Just a Computer5", 4999.99m, 3, 1, 5),
                new Product(GenerateParts(allParts), 6, "Just a Computer6", 5999.99m, 3, 1, 5)
            };
            return new Inventory(products, allParts);
        }
        private static BindingList<Part> GenerateParts(BindingList<Part> allParts)
        {
            BindingList<Part> parts = new();
            Random random = new();
            int partOne = random.Next(0, 2);
            int partTwo = random.Next(3, 5);
            parts.Add(allParts[partOne]);
            parts.Add(allParts[partTwo]);
            return parts;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void partsAddButton_Click(object sender, EventArgs e)
        {
            var addPartForm = new AddPart(inventory);
            addPartForm.ShowDialog();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (partGrid.SelectedRows.Count == 0) { MessageBox.Show("Please Select A Row To Delete", "Error"); return; }
            var part = (Part)partGrid.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Please confirm that you want to delete the part {part.Name}(ID:{part.PartID})", "Delete Part?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.deletePart(part);
            }

        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partGrid.SelectedRows.Count > 0)
            {
                var modifyPartForm = new ModifyPart(inventory, (Part)partGrid.SelectedRows[0].DataBoundItem);
                modifyPartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select A Row To Modify", "Error");
            }

        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            if (partSearchTextBox.Text == "") { MessageBox.Show("Please Enter A Numeric ID", "Error"); return; }
            if (!int.TryParse(partSearchTextBox.Text, out int id)) { MessageBox.Show("Please Enter A Numeric ID", "Error"); return; }
            foreach (DataGridViewRow row in partGrid.Rows)
            {
                if (row.DataBoundItem is Part part)
                {
                    if (part.PartID == id)
                    {
                        partGrid.ClearSelection();
                        row.Selected = true;
                        return;
                    }
                }
            }
            MessageBox.Show("No Matching Parts Found", "Error");

        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct(inventory);
            addProductForm.ShowDialog();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            // if no row selected show an error message
            if (productGrid.SelectedRows.Count == 0) { MessageBox.Show("Please Select A Product To Modify", "Error"); return; }
            var modifyProductForm = new ModifyProduct(inventory, (Product)productGrid.SelectedRows[0].DataBoundItem);
            modifyProductForm.ShowDialog();
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            if (productGrid.SelectedRows.Count == 0) { MessageBox.Show("Please Select A Row To Delete", "Error"); return; }
            var product = (Product)productGrid.SelectedRows[0].DataBoundItem;
            if (product.AssociatedParts.Count != 0) { MessageBox.Show("Product cannot be deleted because a part is still assigned to it!", "Error"); return; }
            
            if (MessageBox.Show($"Please confirm that you want to delete the product {product.Name}(ID:{product.ProductID})", "Delete Product?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.removeProduct(product.ProductID);
            }
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            if (productsSearchBox.Text == "") { MessageBox.Show("Please Enter A Numeric ID", "Error"); return; }
            if (!int.TryParse(productsSearchBox.Text, out int id)) { MessageBox.Show("Please Enter A Numeric ID", "Error"); return; }
            foreach (DataGridViewRow row in productGrid.Rows)
            {
                if (row.DataBoundItem is Product product)
                {
                    if (product.ProductID == id)
                    {
                        productGrid.ClearSelection();
                        row.Selected = true;
                        return;
                    }
                }
            }
            MessageBox.Show("No Matching Products Found", "Error");
        }
    }
}