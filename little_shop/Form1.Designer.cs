namespace little_shop
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCreateUser = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.grpCreateProduct = new System.Windows.Forms.GroupBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputProductDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputProductName = new System.Windows.Forms.TextBox();
            this.grpDeleteItem = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDeleteId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDeleteType = new System.Windows.Forms.ComboBox();
            this.OutputContainer = new System.Windows.Forms.GroupBox();
            this.grpPrintItem = new System.Windows.Forms.GroupBox();
            this.btnPrintIncome = new System.Windows.Forms.Button();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.btnPrintProduct = new System.Windows.Forms.Button();
            this.btnPrintUsers = new System.Windows.Forms.Button();
            this.grpCreateUser.SuspendLayout();
            this.grpCreateProduct.SuspendLayout();
            this.grpDeleteItem.SuspendLayout();
            this.grpPrintItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreateUser
            // 
            this.grpCreateUser.Controls.Add(this.label1);
            this.grpCreateUser.Controls.Add(this.inputUsername);
            this.grpCreateUser.Controls.Add(this.btnCreateCustomer);
            this.grpCreateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCreateUser.Location = new System.Drawing.Point(11, 11);
            this.grpCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.grpCreateUser.Name = "grpCreateUser";
            this.grpCreateUser.Padding = new System.Windows.Forms.Padding(2);
            this.grpCreateUser.Size = new System.Drawing.Size(445, 96);
            this.grpCreateUser.TabIndex = 0;
            this.grpCreateUser.TabStop = false;
            this.grpCreateUser.Text = "Opret bruger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brugernavn";
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(154, 46);
            this.inputUsername.Margin = new System.Windows.Forms.Padding(2);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(144, 39);
            this.inputUsername.TabIndex = 1;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(308, 46);
            this.btnCreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(112, 39);
            this.btnCreateCustomer.TabIndex = 0;
            this.btnCreateCustomer.Text = "Opret";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // grpCreateProduct
            // 
            this.grpCreateProduct.Controls.Add(this.btnCreateProduct);
            this.grpCreateProduct.Controls.Add(this.label4);
            this.grpCreateProduct.Controls.Add(this.inputProductPrice);
            this.grpCreateProduct.Controls.Add(this.label3);
            this.grpCreateProduct.Controls.Add(this.inputProductDesc);
            this.grpCreateProduct.Controls.Add(this.label2);
            this.grpCreateProduct.Controls.Add(this.inputProductName);
            this.grpCreateProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCreateProduct.Location = new System.Drawing.Point(11, 112);
            this.grpCreateProduct.Name = "grpCreateProduct";
            this.grpCreateProduct.Size = new System.Drawing.Size(445, 246);
            this.grpCreateProduct.TabIndex = 1;
            this.grpCreateProduct.TabStop = false;
            this.grpCreateProduct.Text = "Opret product";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(154, 190);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(200, 40);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Opret";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pris";
            // 
            // inputProductPrice
            // 
            this.inputProductPrice.Location = new System.Drawing.Point(154, 145);
            this.inputProductPrice.Name = "inputProductPrice";
            this.inputProductPrice.Size = new System.Drawing.Size(200, 39);
            this.inputProductPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beskrivelse";
            // 
            // inputProductDesc
            // 
            this.inputProductDesc.Location = new System.Drawing.Point(154, 94);
            this.inputProductDesc.Name = "inputProductDesc";
            this.inputProductDesc.Size = new System.Drawing.Size(200, 39);
            this.inputProductDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navn";
            // 
            // inputProductName
            // 
            this.inputProductName.Location = new System.Drawing.Point(154, 42);
            this.inputProductName.Name = "inputProductName";
            this.inputProductName.Size = new System.Drawing.Size(200, 39);
            this.inputProductName.TabIndex = 0;
            // 
            // grpDeleteItem
            // 
            this.grpDeleteItem.Controls.Add(this.button1);
            this.grpDeleteItem.Controls.Add(this.label6);
            this.grpDeleteItem.Controls.Add(this.inputDeleteId);
            this.grpDeleteItem.Controls.Add(this.label5);
            this.grpDeleteItem.Controls.Add(this.inputDeleteType);
            this.grpDeleteItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDeleteItem.Location = new System.Drawing.Point(11, 364);
            this.grpDeleteItem.Name = "grpDeleteItem";
            this.grpDeleteItem.Size = new System.Drawing.Size(445, 147);
            this.grpDeleteItem.TabIndex = 2;
            this.grpDeleteItem.TabStop = false;
            this.grpDeleteItem.Text = "Slet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Slet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID";
            // 
            // inputDeleteId
            // 
            this.inputDeleteId.Location = new System.Drawing.Point(77, 84);
            this.inputDeleteId.Name = "inputDeleteId";
            this.inputDeleteId.Size = new System.Drawing.Size(185, 39);
            this.inputDeleteId.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type";
            // 
            // inputDeleteType
            // 
            this.inputDeleteType.FormattingEnabled = true;
            this.inputDeleteType.Items.AddRange(new object[] {
            "Product",
            "User",
            "Order"});
            this.inputDeleteType.Location = new System.Drawing.Point(77, 38);
            this.inputDeleteType.Name = "inputDeleteType";
            this.inputDeleteType.Size = new System.Drawing.Size(185, 40);
            this.inputDeleteType.TabIndex = 0;
            // 
            // OutputContainer
            // 
            this.OutputContainer.Location = new System.Drawing.Point(462, 12);
            this.OutputContainer.Name = "OutputContainer";
            this.OutputContainer.Size = new System.Drawing.Size(742, 613);
            this.OutputContainer.TabIndex = 3;
            this.OutputContainer.TabStop = false;
            this.OutputContainer.Text = "Output";
            // 
            // grpPrintItem
            // 
            this.grpPrintItem.Controls.Add(this.btnPrintIncome);
            this.grpPrintItem.Controls.Add(this.btnPrintOrder);
            this.grpPrintItem.Controls.Add(this.btnPrintProduct);
            this.grpPrintItem.Controls.Add(this.btnPrintUsers);
            this.grpPrintItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPrintItem.Location = new System.Drawing.Point(12, 517);
            this.grpPrintItem.Name = "grpPrintItem";
            this.grpPrintItem.Size = new System.Drawing.Size(444, 108);
            this.grpPrintItem.TabIndex = 4;
            this.grpPrintItem.TabStop = false;
            this.grpPrintItem.Text = "Print";
            // 
            // btnPrintIncome
            // 
            this.btnPrintIncome.Location = new System.Drawing.Point(380, 38);
            this.btnPrintIncome.Name = "btnPrintIncome";
            this.btnPrintIncome.Size = new System.Drawing.Size(39, 46);
            this.btnPrintIncome.TabIndex = 3;
            this.btnPrintIncome.Text = "$";
            this.btnPrintIncome.UseVisualStyleBackColor = true;
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(267, 38);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(92, 46);
            this.btnPrintOrder.TabIndex = 2;
            this.btnPrintOrder.Text = "Ordrer";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.Location = new System.Drawing.Point(122, 38);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(139, 46);
            this.btnPrintProduct.TabIndex = 1;
            this.btnPrintProduct.Text = "Produkter";
            this.btnPrintProduct.UseVisualStyleBackColor = true;
            // 
            // btnPrintUsers
            // 
            this.btnPrintUsers.Location = new System.Drawing.Point(5, 38);
            this.btnPrintUsers.Name = "btnPrintUsers";
            this.btnPrintUsers.Size = new System.Drawing.Size(111, 46);
            this.btnPrintUsers.TabIndex = 0;
            this.btnPrintUsers.Text = "Brugere";
            this.btnPrintUsers.UseVisualStyleBackColor = true;
            this.btnPrintUsers.Click += new System.EventHandler(this.btnPrintUsers_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 669);
            this.Controls.Add(this.grpPrintItem);
            this.Controls.Add(this.OutputContainer);
            this.Controls.Add(this.grpDeleteItem);
            this.Controls.Add(this.grpCreateProduct);
            this.Controls.Add(this.grpCreateUser);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.grpCreateUser.ResumeLayout(false);
            this.grpCreateUser.PerformLayout();
            this.grpCreateProduct.ResumeLayout(false);
            this.grpCreateProduct.PerformLayout();
            this.grpDeleteItem.ResumeLayout(false);
            this.grpDeleteItem.PerformLayout();
            this.grpPrintItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.GroupBox grpCreateProduct;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputProductDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputProductName;
        private System.Windows.Forms.GroupBox grpDeleteItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputDeleteId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputDeleteType;
        private System.Windows.Forms.GroupBox OutputContainer;
        private System.Windows.Forms.GroupBox grpPrintItem;
        private System.Windows.Forms.Button btnPrintIncome;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button btnPrintProduct;
        private System.Windows.Forms.Button btnPrintUsers;
    }
}

