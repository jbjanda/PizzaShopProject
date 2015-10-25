namespace JJanda_Assignment1
{
    partial class FormNavigation
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelPizzaSign = new System.Windows.Forms.Label();
            this.menuStripDirectory = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createYourOwnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMasterpiece = new System.Windows.Forms.Label();
            this.menuStripDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(36, 175);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(142, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Create Your Own";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(36, 302);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomer.TabIndex = 15;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(256, 302);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelPizzaSign
            // 
            this.labelPizzaSign.AutoSize = true;
            this.labelPizzaSign.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzaSign.Location = new System.Drawing.Point(33, 108);
            this.labelPizzaSign.Name = "labelPizzaSign";
            this.labelPizzaSign.Size = new System.Drawing.Size(298, 17);
            this.labelPizzaSign.TabIndex = 11;
            this.labelPizzaSign.Text = "Welcome to Jeff Janda\'s Pizza Shop";
            // 
            // menuStripDirectory
            // 
            this.menuStripDirectory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripDirectory.Location = new System.Drawing.Point(0, 0);
            this.menuStripDirectory.Name = "menuStripDirectory";
            this.menuStripDirectory.Size = new System.Drawing.Size(376, 24);
            this.menuStripDirectory.TabIndex = 17;
            this.menuStripDirectory.Text = "Directory";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createYourOwnToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.confirmationToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // createYourOwnToolStripMenuItem
            // 
            this.createYourOwnToolStripMenuItem.Name = "createYourOwnToolStripMenuItem";
            this.createYourOwnToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createYourOwnToolStripMenuItem.Text = "Create Your Own";
            this.createYourOwnToolStripMenuItem.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // confirmationToolStripMenuItem
            // 
            this.confirmationToolStripMenuItem.Name = "confirmationToolStripMenuItem";
            this.confirmationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.confirmationToolStripMenuItem.Text = "Confirmation";
            this.confirmationToolStripMenuItem.Click += new System.EventHandler(this.confirmationToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelMasterpiece
            // 
            this.labelMasterpiece.AutoSize = true;
            this.labelMasterpiece.Location = new System.Drawing.Point(196, 180);
            this.labelMasterpiece.Name = "labelMasterpiece";
            this.labelMasterpiece.Size = new System.Drawing.Size(96, 13);
            this.labelMasterpiece.TabIndex = 18;
            this.labelMasterpiece.Text = "Pizza Masterpiece!";
            // 
            // FormNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 350);
            this.Controls.Add(this.labelMasterpiece);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelPizzaSign);
            this.Controls.Add(this.menuStripDirectory);
            this.MainMenuStrip = this.menuStripDirectory;
            this.Name = "FormNavigation";
            this.Text = "Navigation Form";
            this.menuStripDirectory.ResumeLayout(false);
            this.menuStripDirectory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelPizzaSign;
        private System.Windows.Forms.MenuStrip menuStripDirectory;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createYourOwnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.Label labelMasterpiece;
    }
}