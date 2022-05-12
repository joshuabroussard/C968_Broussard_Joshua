namespace C968_Broussard_Joshua
{
    partial class ModifyPart
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.inhouseButton = new System.Windows.Forms.RadioButton();
            this.outsourcedButton = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.changingTextBox = new System.Windows.Forms.TextBox();
            this.changingLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPartLabel.Location = new System.Drawing.Point(22, 15);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(90, 21);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Modify Part";
            // 
            // inhouseButton
            // 
            this.inhouseButton.AutoSize = true;
            this.inhouseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inhouseButton.Location = new System.Drawing.Point(22, 39);
            this.inhouseButton.Name = "inhouseButton";
            this.inhouseButton.Size = new System.Drawing.Size(91, 25);
            this.inhouseButton.TabIndex = 999;
            this.inhouseButton.Text = "In-House";
            this.inhouseButton.UseVisualStyleBackColor = true;
            this.inhouseButton.CheckedChanged += new System.EventHandler(this.inhouseButton_CheckedChanged);
            // 
            // outsourcedButton
            // 
            this.outsourcedButton.AutoSize = true;
            this.outsourcedButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outsourcedButton.Location = new System.Drawing.Point(119, 39);
            this.outsourcedButton.Name = "outsourcedButton";
            this.outsourcedButton.Size = new System.Drawing.Size(109, 25);
            this.outsourcedButton.TabIndex = 999;
            this.outsourcedButton.Text = "Outsourced";
            this.outsourcedButton.UseVisualStyleBackColor = true;
            this.outsourcedButton.CheckedChanged += new System.EventHandler(this.outsourcedButton_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(104, 72);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 21);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(135, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.TabStop = false;
            // 
            // changingTextBox
            // 
            this.changingTextBox.Location = new System.Drawing.Point(135, 244);
            this.changingTextBox.Name = "changingTextBox";
            this.changingTextBox.Size = new System.Drawing.Size(100, 23);
            this.changingTextBox.TabIndex = 6;
            // 
            // changingLabel
            // 
            this.changingLabel.AutoSize = true;
            this.changingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changingLabel.Location = new System.Drawing.Point(40, 246);
            this.changingLabel.Name = "changingLabel";
            this.changingLabel.Size = new System.Drawing.Size(88, 21);
            this.changingLabel.TabIndex = 5;
            this.changingLabel.Text = "Machine ID";
            this.changingLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(135, 215);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 23);
            this.minTextBox.TabIndex = 5;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minLabel.Location = new System.Drawing.Point(92, 217);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 21);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "Min";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(135, 186);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 23);
            this.maxTextBox.TabIndex = 4;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxLabel.Location = new System.Drawing.Point(90, 188);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(39, 21);
            this.maxLabel.TabIndex = 9;
            this.maxLabel.Text = "Max";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(135, 157);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(40, 159);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(89, 21);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price / Cost";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(135, 128);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 23);
            this.inventoryTextBox.TabIndex = 2;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryLabel.Location = new System.Drawing.Point(53, 130);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 21);
            this.inventoryLabel.TabIndex = 13;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(135, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(77, 101);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 21);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(135, 294);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(216, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 338);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.changingTextBox);
            this.Controls.Add(this.changingLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.outsourcedButton);
            this.Controls.Add(this.inhouseButton);
            this.Controls.Add(this.addPartLabel);
            this.Name = "ModifyPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addPartLabel;
        private RadioButton inhouseButton;
        private RadioButton outsourcedButton;
        private Label idLabel;
        private TextBox idTextBox;
        private TextBox changingTextBox;
        private Label changingLabel;
        private TextBox minTextBox;
        private Label minLabel;
        private TextBox maxTextBox;
        private Label maxLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox inventoryTextBox;
        private Label inventoryLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Button saveButton;
        private Button cancelButton;
    }
}