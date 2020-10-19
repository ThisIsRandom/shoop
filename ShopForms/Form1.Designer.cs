namespace ShopForms
{
    partial class Form1
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
            this.UsersGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.UsersGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersGroup
            // 
            this.UsersGroup.Controls.Add(this.username);
            this.UsersGroup.Controls.Add(this.richTextBox1);
            this.UsersGroup.Controls.Add(this.textBox4);
            this.UsersGroup.Controls.Add(this.textBox3);
            this.UsersGroup.Controls.Add(this.textBox2);
            this.UsersGroup.Controls.Add(this.textBox1);
            this.UsersGroup.Controls.Add(this.label1);
            this.UsersGroup.Location = new System.Drawing.Point(185, 78);
            this.UsersGroup.Name = "UsersGroup";
            this.UsersGroup.Size = new System.Drawing.Size(400, 200);
            this.UsersGroup.TabIndex = 0;
            this.UsersGroup.TabStop = false;
            this.UsersGroup.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-5446, -130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 78);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 78);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-5478, -156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 78);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-5988, -148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1968, 78);
            this.textBox4.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(164, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 384);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(252, 186);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(32, 78);
            this.username.TabIndex = 5;
            this.username.Text = "Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 482);
            this.Controls.Add(this.UsersGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UsersGroup.ResumeLayout(false);
            this.UsersGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsersGroup;
        private System.Windows.Forms.Label label1;
       
        
        
    }
}

