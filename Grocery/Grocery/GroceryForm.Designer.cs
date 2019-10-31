namespace Grocery
{
    partial class GroceryForm
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
            this.components = new System.ComponentModel.Container();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.showItemsButton = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.productAddedComboBox = new System.Windows.Forms.ComboBox();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.getPhoneButton = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.phoneDisplayTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.groceryDataSet = new Grocery.GroceryDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Grocery.GroceryDataSetTableAdapters.ProductTableAdapter();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDataSet1 = new Grocery.GroceryDataSet1();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new Grocery.GroceryDataSet1TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.customerInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(23, 227);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 24;
            this.orderDataGridView.Size = new System.Drawing.Size(526, 237);
            this.orderDataGridView.TabIndex = 2;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(26, 161);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(162, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add item to order";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showItemsButton
            // 
            this.showItemsButton.Location = new System.Drawing.Point(251, 161);
            this.showItemsButton.Name = "showItemsButton";
            this.showItemsButton.Size = new System.Drawing.Size(172, 23);
            this.showItemsButton.TabIndex = 6;
            this.showItemsButton.Text = "Show Items in order";
            this.showItemsButton.UseVisualStyleBackColor = true;
            this.showItemsButton.Click += new System.EventHandler(this.showItemsButton_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(23, 72);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(57, 17);
            this.productLabel.TabIndex = 7;
            this.productLabel.Text = "Product";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(23, 119);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(56, 17);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(23, 24);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(62, 17);
            this.orderIdLabel.TabIndex = 9;
            this.orderIdLabel.Text = "Order ID";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(141, 21);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(120, 22);
            this.orderIdTextBox.TabIndex = 10;
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.productAddedComboBox);
            this.orderGroupBox.Controls.Add(this.showItemsButton);
            this.orderGroupBox.Controls.Add(this.amount);
            this.orderGroupBox.Controls.Add(this.deleteButton);
            this.orderGroupBox.Controls.Add(this.orderIdTextBox);
            this.orderGroupBox.Controls.Add(this.addButton);
            this.orderGroupBox.Controls.Add(this.orderIdLabel);
            this.orderGroupBox.Controls.Add(this.amountLabel);
            this.orderGroupBox.Controls.Add(this.productLabel);
            this.orderGroupBox.Location = new System.Drawing.Point(23, 12);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(451, 190);
            this.orderGroupBox.TabIndex = 12;
            this.orderGroupBox.TabStop = false;
            // 
            // productAddedComboBox
            // 
            this.productAddedComboBox.FormattingEnabled = true;
            this.productAddedComboBox.Location = new System.Drawing.Point(141, 72);
            this.productAddedComboBox.Name = "productAddedComboBox";
            this.productAddedComboBox.Size = new System.Drawing.Size(121, 24);
            this.productAddedComboBox.TabIndex = 15;
            this.productAddedComboBox.SelectedIndexChanged += new System.EventHandler(this.productAddedComboBox_SelectedIndexChanged);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(141, 112);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(120, 22);
            this.amount.TabIndex = 14;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(284, 17);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 24);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete order";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // getPhoneButton
            // 
            this.getPhoneButton.Location = new System.Drawing.Point(263, 17);
            this.getPhoneButton.Name = "getPhoneButton";
            this.getPhoneButton.Size = new System.Drawing.Size(209, 26);
            this.getPhoneButton.TabIndex = 10;
            this.getPhoneButton.Text = "Get customer\'s phone";
            this.getPhoneButton.UseVisualStyleBackColor = true;
            this.getPhoneButton.Click += new System.EventHandler(this.getPhoneButton_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(6, 16);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(68, 17);
            this.customerLabel.TabIndex = 14;
            this.customerLabel.Text = "Customer";
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.customerComboBox);
            this.customerInfoGroupBox.Controls.Add(this.phoneDisplayTextBox);
            this.customerInfoGroupBox.Controls.Add(this.phoneLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerLabel);
            this.customerInfoGroupBox.Controls.Add(this.getPhoneButton);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(480, 12);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(524, 190);
            this.customerInfoGroupBox.TabIndex = 16;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Enter += new System.EventHandler(this.customerInfoGroupBox_Enter);
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(93, 16);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(121, 24);
            this.customerComboBox.TabIndex = 18;
            // 
            // phoneDisplayTextBox
            // 
            this.phoneDisplayTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneDisplayTextBox.Location = new System.Drawing.Point(93, 128);
            this.phoneDisplayTextBox.Name = "phoneDisplayTextBox";
            this.phoneDisplayTextBox.Size = new System.Drawing.Size(165, 22);
            this.phoneDisplayTextBox.TabIndex = 17;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(6, 131);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Phone";
            // 
            // groceryDataSet
            // 
            this.groceryDataSet.DataSetName = "GroceryDataSet";
            this.groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.groceryDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.groceryDataSet;
            // 
            // groceryDataSet1
            // 
            this.groceryDataSet1.DataSetName = "GroceryDataSet1";
            this.groceryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.groceryDataSet1;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // GroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 476);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.orderGroupBox);
            this.Controls.Add(this.orderDataGridView);
            this.Name = "GroceryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GroceryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showItemsButton;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button getPhoneButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.TextBox phoneDisplayTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.ComboBox productAddedComboBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private GroceryDataSet groceryDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private GroceryDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private GroceryDataSet1 groceryDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private GroceryDataSet1TableAdapters.ProductTableAdapter productTableAdapter1;
    }
}

