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
            BindingList<Product> products = new();
            products.Add(new Product(GenerateParts(allParts), 1, "Just a Computer1", 999.99m, 7, 1, 5));
            products.Add(new Product(GenerateParts(allParts), 2, "Just a Computer2", 1999.99m, 7, 1, 5));
            products.Add(new Product(GenerateParts(allParts), 3, "Just a Computer3", 2999.99m, 7, 1, 5));
            products.Add(new Product(GenerateParts(allParts), 4, "Just a Computer4", 3999.99m, 7, 1, 5));
            products.Add(new Product(GenerateParts(allParts), 5, "Just a Computer5", 4999.99m, 7, 1, 5));
            products.Add(new Product(GenerateParts(allParts), 6, "Just a Computer6", 5999.99m, 7, 1, 5));
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
            if (partGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in partGrid.SelectedRows)
                {
                    partGrid.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Row To Delete", "Error");
            }
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partGrid.SelectedRows.Count > 0)
            {
                var modifyPartForm = new ModifyPart(inventory, partGrid.SelectedRows[0].DataBoundItem as Part);
                modifyPartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select A Row To Modify", "Error");
            }

        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            if (partSearchTextBox.Text == "") { MessageBox.Show("Please Enter A Search Term", "Error"); return; }
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
    }
}