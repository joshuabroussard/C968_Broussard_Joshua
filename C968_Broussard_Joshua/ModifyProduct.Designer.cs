namespace C968_Broussard_Joshua
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allPartsGrid = new System.Windows.Forms.DataGridView();
            this.partIDAllParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAllParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryAllParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceAllParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minAllParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAllParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.partIDAssociatedParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAssociatedParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryAssociatedParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceAssociatedParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minAssociatedParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAssociatedParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allPartsGrid
            // 
            this.allPartsGrid.AllowUserToAddRows = false;
            this.allPartsGrid.AllowUserToDeleteRows = false;
            this.allPartsGrid.AllowUserToResizeColumns = false;
            this.allPartsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDAllParts,
            this.nameAllParts,
            this.inventoryAllParts,
            this.priceAllParts,
            this.minAllParts,
            this.maxAllParts});
            this.allPartsGrid.Location = new System.Drawing.Point(24, 107);
            this.allPartsGrid.MultiSelect = false;
            this.allPartsGrid.Name = "allPartsGrid";
            this.allPartsGrid.RowHeadersVisible = false;
            this.allPartsGrid.RowTemplate.Height = 25;
            this.allPartsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsGrid.Size = new System.Drawing.Size(378, 193);
            this.allPartsGrid.TabIndex = 1;
            this.allPartsGrid.TabStop = false;
            // 
            // partIDAllParts
            // 
            this.partIDAllParts.DataPropertyName = "PartID";
            this.partIDAllParts.HeaderText = "Part ID";
            this.partIDAllParts.Name = "partIDAllParts";
            this.partIDAllParts.ReadOnly = true;
            this.partIDAllParts.Width = 50;
            // 
            // nameAllParts
            // 
            this.nameAllParts.DataPropertyName = "Name";
            this.nameAllParts.HeaderText = "Name";
            this.nameAllParts.Name = "nameAllParts";
            this.nameAllParts.ReadOnly = true;
            // 
            // inventoryAllParts
            // 
            this.inventoryAllParts.DataPropertyName = "InStock";
            this.inventoryAllParts.HeaderText = "Inventory";
            this.inventoryAllParts.Name = "inventoryAllParts";
            this.inventoryAllParts.ReadOnly = true;
            this.inventoryAllParts.Width = 75;
            // 
            // priceAllParts
            // 
            this.priceAllParts.DataPropertyName = "Price";
            this.priceAllParts.HeaderText = "Price";
            this.priceAllParts.Name = "priceAllParts";
            this.priceAllParts.ReadOnly = true;
            this.priceAllParts.Width = 50;
            // 
            // minAllParts
            // 
            this.minAllParts.DataPropertyName = "Min";
            this.minAllParts.HeaderText = "Min";
            this.minAllParts.Name = "minAllParts";
            this.minAllParts.ReadOnly = true;
            this.minAllParts.Width = 50;
            // 
            // maxAllParts
            // 
            this.maxAllParts.DataPropertyName = "Max";
            this.maxAllParts.HeaderText = "Max";
            this.maxAllParts.Name = "maxAllParts";
            this.maxAllParts.ReadOnly = true;
            this.maxAllParts.Width = 50;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(429, 306);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 999;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductLabel.Location = new System.Drawing.Point(12, 9);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(129, 21);
            this.addProductLabel.TabIndex = 4;
            this.addProductLabel.Text = "Modify Product";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(161, 12);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 21);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(192, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(136, 23);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(192, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(136, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(134, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 21);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(429, 11);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(136, 23);
            this.inventoryTextBox.TabIndex = 2;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryLabel.Location = new System.Drawing.Point(347, 11);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 21);
            this.inventoryLabel.TabIndex = 9;
            this.inventoryLabel.Text = "Inventory";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(429, 43);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(136, 23);
            this.priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(379, 41);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 21);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(652, 14);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(136, 23);
            this.minTextBox.TabIndex = 4;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minLabel.Location = new System.Drawing.Point(609, 14);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 21);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(652, 43);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(136, 23);
            this.maxTextBox.TabIndex = 5;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxLabel.Location = new System.Drawing.Point(607, 43);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(39, 21);
            this.maxLabel.TabIndex = 15;
            this.maxLabel.Text = "Max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(329, 306);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(664, 330);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(745, 330);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allPartsLabel.Location = new System.Drawing.Point(24, 83);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(140, 21);
            this.allPartsLabel.TabIndex = 19;
            this.allPartsLabel.Text = "All Candidate Parts";
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.associatedPartsLabel.Location = new System.Drawing.Point(429, 83);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(249, 21);
            this.associatedPartsLabel.TabIndex = 20;
            this.associatedPartsLabel.Text = "Parts Associated With This Product";
            // 
            // associatedPartsGrid
            // 
            this.associatedPartsGrid.AllowUserToAddRows = false;
            this.associatedPartsGrid.AllowUserToDeleteRows = false;
            this.associatedPartsGrid.AllowUserToResizeColumns = false;
            this.associatedPartsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.associatedPartsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.associatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDAssociatedParts,
            this.nameAssociatedParts,
            this.inventoryAssociatedParts,
            this.priceAssociatedParts,
            this.minAssociatedParts,
            this.maxAssociatedParts});
            this.associatedPartsGrid.Location = new System.Drawing.Point(429, 107);
            this.associatedPartsGrid.MultiSelect = false;
            this.associatedPartsGrid.Name = "associatedPartsGrid";
            this.associatedPartsGrid.RowHeadersVisible = false;
            this.associatedPartsGrid.RowTemplate.Height = 25;
            this.associatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGrid.Size = new System.Drawing.Size(378, 193);
            this.associatedPartsGrid.TabIndex = 21;
            this.associatedPartsGrid.TabStop = false;
            // 
            // partIDAssociatedParts
            // 
            this.partIDAssociatedParts.DataPropertyName = "PartID";
            this.partIDAssociatedParts.HeaderText = "Part ID";
            this.partIDAssociatedParts.Name = "partIDAssociatedParts";
            this.partIDAssociatedParts.ReadOnly = true;
            this.partIDAssociatedParts.Width = 50;
            // 
            // nameAssociatedParts
            // 
            this.nameAssociatedParts.DataPropertyName = "Name";
            this.nameAssociatedParts.HeaderText = "Name";
            this.nameAssociatedParts.Name = "nameAssociatedParts";
            this.nameAssociatedParts.ReadOnly = true;
            // 
            // inventoryAssociatedParts
            // 
            this.inventoryAssociatedParts.DataPropertyName = "InStock";
            this.inventoryAssociatedParts.HeaderText = "Inventory";
            this.inventoryAssociatedParts.Name = "inventoryAssociatedParts";
            this.inventoryAssociatedParts.ReadOnly = true;
            this.inventoryAssociatedParts.Width = 75;
            // 
            // priceAssociatedParts
            // 
            this.priceAssociatedParts.DataPropertyName = "Price";
            this.priceAssociatedParts.HeaderText = "Price";
            this.priceAssociatedParts.Name = "priceAssociatedParts";
            this.priceAssociatedParts.ReadOnly = true;
            this.priceAssociatedParts.Width = 50;
            // 
            // minAssociatedParts
            // 
            this.minAssociatedParts.DataPropertyName = "Min";
            this.minAssociatedParts.HeaderText = "Min";
            this.minAssociatedParts.Name = "minAssociatedParts";
            this.minAssociatedParts.ReadOnly = true;
            this.minAssociatedParts.Width = 50;
            // 
            // maxAssociatedParts
            // 
            this.maxAssociatedParts.DataPropertyName = "Max";
            this.maxAssociatedParts.HeaderText = "Max";
            this.maxAssociatedParts.Name = "maxAssociatedParts";
            this.maxAssociatedParts.ReadOnly = true;
            this.maxAssociatedParts.Width = 50;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(142, 306);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 23);
            this.searchBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(248, 306);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 360);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.associatedPartsGrid);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addProductLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.allPartsGrid);
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView allPartsGrid;
        private Button deleteButton;
        private Label addProductLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox inventoryTextBox;
        private Label inventoryLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox minTextBox;
        private Label minLabel;
        private TextBox maxTextBox;
        private Label maxLabel;
        private Button addButton;
        private Button saveButton;
        private Button cancelButton;
        private Label allPartsLabel;
        private Label associatedPartsLabel;
        private DataGridView associatedPartsGrid;
        private DataGridViewTextBoxColumn partIDAllParts;
        private DataGridViewTextBoxColumn nameAllParts;
        private DataGridViewTextBoxColumn inventoryAllParts;
        private DataGridViewTextBoxColumn priceAllParts;
        private DataGridViewTextBoxColumn minAllParts;
        private DataGridViewTextBoxColumn maxAllParts;
        private DataGridViewTextBoxColumn partIDAssociatedParts;
        private DataGridViewTextBoxColumn nameAssociatedParts;
        private DataGridViewTextBoxColumn inventoryAssociatedParts;
        private DataGridViewTextBoxColumn priceAssociatedParts;
        private DataGridViewTextBoxColumn minAssociatedParts;
        private DataGridViewTextBoxColumn maxAssociatedParts;
        private TextBox searchBox;
        private Button searchButton;
    }
}