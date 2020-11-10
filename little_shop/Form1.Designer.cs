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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDeleteId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDeleteType = new System.Windows.Forms.ComboBox();
            this.grpPrintItem = new System.Windows.Forms.GroupBox();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.btnPrintProduct = new System.Windows.Forms.Button();
            this.btnPrintUsers = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputOrderProductId = new System.Windows.Forms.TextBox();
            this.inputOrderUserId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.inputDollarDays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpCreateUser.SuspendLayout();
            this.grpCreateProduct.SuspendLayout();
            this.grpDeleteItem.SuspendLayout();
            this.grpPrintItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
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
            this.inputProductName.TextChanged += new System.EventHandler(this.inputProductName_TextChanged);
            // 
            // grpDeleteItem
            // 
            this.grpDeleteItem.Controls.Add(this.btnDelete);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Slet";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
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
            // grpPrintItem
            // 
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
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(327, 38);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(92, 46);
            this.btnPrintOrder.TabIndex = 2;
            this.btnPrintOrder.Text = "Ordrer";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.Location = new System.Drawing.Point(158, 38);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(139, 46);
            this.btnPrintProduct.TabIndex = 1;
            this.btnPrintProduct.Text = "Produkter";
            this.btnPrintProduct.UseVisualStyleBackColor = true;
            this.btnPrintProduct.Click += new System.EventHandler(this.btnPrintProduct_Click);
            // 
            // btnPrintUsers
            // 
            this.btnPrintUsers.Location = new System.Drawing.Point(25, 38);
            this.btnPrintUsers.Name = "btnPrintUsers";
            this.btnPrintUsers.Size = new System.Drawing.Size(111, 46);
            this.btnPrintUsers.TabIndex = 0;
            this.btnPrintUsers.Text = "Brugere";
            this.btnPrintUsers.UseVisualStyleBackColor = true;
            this.btnPrintUsers.Click += new System.EventHandler(this.btnPrintUsers_Click);
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.ItemHeight = 30;
            this.output.Location = new System.Drawing.Point(504, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(710, 394);
            this.output.TabIndex = 5;
            this.output.SelectedIndexChanged += new System.EventHandler(this.output_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.inputOrderProductId);
            this.groupBox1.Controls.Add(this.inputOrderUserId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(504, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opret Ordre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Opret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // inputOrderProductId
            // 
            this.inputOrderProductId.Location = new System.Drawing.Point(178, 127);
            this.inputOrderProductId.Name = "inputOrderProductId";
            this.inputOrderProductId.Size = new System.Drawing.Size(200, 39);
            this.inputOrderProductId.TabIndex = 3;
            // 
            // inputOrderUserId
            // 
            this.inputOrderUserId.Location = new System.Drawing.Point(178, 51);
            this.inputOrderUserId.Name = "inputOrderUserId";
            this.inputOrderUserId.Size = new System.Drawing.Size(200, 39);
            this.inputOrderUserId.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bruger id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 30);
            this.label9.TabIndex = 4;
            this.label9.Text = "Separate with comma if multiple";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.inputDollarDays);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(1034, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "$$$$";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputDollarDays
            // 
            this.inputDollarDays.Location = new System.Drawing.Point(40, 74);
            this.inputDollarDays.Name = "inputDollarDays";
            this.inputDollarDays.Size = new System.Drawing.Size(86, 36);
            this.inputDollarDays.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Days";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.grpPrintItem);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputDeleteId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputDeleteType;
        private System.Windows.Forms.GroupBox grpPrintItem;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button btnPrintProduct;
        private System.Windows.Forms.Button btnPrintUsers;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputOrderProductId;
        private System.Windows.Forms.TextBox inputOrderUserId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputDollarDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}

