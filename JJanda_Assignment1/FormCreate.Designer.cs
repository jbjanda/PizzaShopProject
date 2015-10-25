namespace JJanda_Assignment1
{
    partial class FormCreate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.submitOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCrust = new System.Windows.Forms.GroupBox();
            this.radioButtonPan = new System.Windows.Forms.RadioButton();
            this.radioButtonOriginal = new System.Windows.Forms.RadioButton();
            this.radioButtonThin = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioButtonFamily = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonSwtChili = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonHerbTom = new System.Windows.Forms.RadioButton();
            this.groupBoxSauce = new System.Windows.Forms.GroupBox();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonCrmGarl = new System.Windows.Forms.RadioButton();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelToppingsTitle = new System.Windows.Forms.Label();
            this.listBoxCheese = new System.Windows.Forms.ListBox();
            this.labelCheese = new System.Windows.Forms.Label();
            this.labelMeat = new System.Windows.Forms.Label();
            this.listBoxMeat = new System.Windows.Forms.ListBox();
            this.labelVegetable = new System.Windows.Forms.Label();
            this.listBoxVeg = new System.Windows.Forms.ListBox();
            this.listBoxToppings = new System.Windows.Forms.ListBox();
            this.labelToppings = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.checkBoxNoTop = new System.Windows.Forms.CheckBox();
            this.buttonRemoveTop = new System.Windows.Forms.Button();
            this.labelCredit = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCrust.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxSauce.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitOrderToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.clearOrderToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // submitOrderToolStripMenuItem
            // 
            this.submitOrderToolStripMenuItem.Name = "submitOrderToolStripMenuItem";
            this.submitOrderToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.submitOrderToolStripMenuItem.Text = "Submit Order";
            this.submitOrderToolStripMenuItem.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toppingToolStripMenuItem,
            this.allToolStripMenuItem});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // toppingToolStripMenuItem
            // 
            this.toppingToolStripMenuItem.Name = "toppingToolStripMenuItem";
            this.toppingToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.toppingToolStripMenuItem.Text = "One topping";
            this.toppingToolStripMenuItem.Click += new System.EventHandler(this.buttonRemoveTop_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // clearOrderToolStripMenuItem
            // 
            this.clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            this.clearOrderToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.clearOrderToolStripMenuItem.Text = "Clear Order";
            this.clearOrderToolStripMenuItem.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(145, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(116, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Create Your Own Pizza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick Your Base Pizza";
            // 
            // groupBoxCrust
            // 
            this.groupBoxCrust.Controls.Add(this.radioButtonPan);
            this.groupBoxCrust.Controls.Add(this.radioButtonOriginal);
            this.groupBoxCrust.Controls.Add(this.radioButtonThin);
            this.groupBoxCrust.Location = new System.Drawing.Point(134, 101);
            this.groupBoxCrust.Name = "groupBoxCrust";
            this.groupBoxCrust.Size = new System.Drawing.Size(86, 100);
            this.groupBoxCrust.TabIndex = 3;
            this.groupBoxCrust.TabStop = false;
            this.groupBoxCrust.Text = "Crust";
            // 
            // radioButtonPan
            // 
            this.radioButtonPan.AutoSize = true;
            this.radioButtonPan.Location = new System.Drawing.Point(7, 68);
            this.radioButtonPan.Name = "radioButtonPan";
            this.radioButtonPan.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPan.TabIndex = 2;
            this.radioButtonPan.TabStop = true;
            this.radioButtonPan.Text = "Pan";
            this.radioButtonPan.UseVisualStyleBackColor = true;
            // 
            // radioButtonOriginal
            // 
            this.radioButtonOriginal.AutoSize = true;
            this.radioButtonOriginal.Location = new System.Drawing.Point(7, 22);
            this.radioButtonOriginal.Name = "radioButtonOriginal";
            this.radioButtonOriginal.Size = new System.Drawing.Size(60, 17);
            this.radioButtonOriginal.TabIndex = 1;
            this.radioButtonOriginal.TabStop = true;
            this.radioButtonOriginal.Text = "Original";
            this.radioButtonOriginal.UseVisualStyleBackColor = true;
            // 
            // radioButtonThin
            // 
            this.radioButtonThin.AutoSize = true;
            this.radioButtonThin.Location = new System.Drawing.Point(6, 45);
            this.radioButtonThin.Name = "radioButtonThin";
            this.radioButtonThin.Size = new System.Drawing.Size(73, 17);
            this.radioButtonThin.TabIndex = 0;
            this.radioButtonThin.TabStop = true;
            this.radioButtonThin.Text = "Thin Crust";
            this.radioButtonThin.UseVisualStyleBackColor = true;
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioButtonFamily);
            this.groupBoxSize.Controls.Add(this.radioButtonLarge);
            this.groupBoxSize.Location = new System.Drawing.Point(12, 101);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(99, 73);
            this.groupBoxSize.TabIndex = 4;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // radioButtonFamily
            // 
            this.radioButtonFamily.AutoSize = true;
            this.radioButtonFamily.Location = new System.Drawing.Point(7, 44);
            this.radioButtonFamily.Name = "radioButtonFamily";
            this.radioButtonFamily.Size = new System.Drawing.Size(90, 17);
            this.radioButtonFamily.TabIndex = 1;
            this.radioButtonFamily.TabStop = true;
            this.radioButtonFamily.Text = "Family $13.00";
            this.radioButtonFamily.UseVisualStyleBackColor = true;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(7, 20);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(88, 17);
            this.radioButtonLarge.TabIndex = 0;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large $10.00";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwtChili
            // 
            this.radioButtonSwtChili.AutoSize = true;
            this.radioButtonSwtChili.Location = new System.Drawing.Point(101, 44);
            this.radioButtonSwtChili.Name = "radioButtonSwtChili";
            this.radioButtonSwtChili.Size = new System.Drawing.Size(77, 17);
            this.radioButtonSwtChili.TabIndex = 0;
            this.radioButtonSwtChili.TabStop = true;
            this.radioButtonSwtChili.Text = "Sweet Chili";
            this.radioButtonSwtChili.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 21);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonHerbTom
            // 
            this.radioButtonHerbTom.AutoSize = true;
            this.radioButtonHerbTom.Location = new System.Drawing.Point(101, 21);
            this.radioButtonHerbTom.Name = "radioButtonHerbTom";
            this.radioButtonHerbTom.Size = new System.Drawing.Size(87, 17);
            this.radioButtonHerbTom.TabIndex = 2;
            this.radioButtonHerbTom.TabStop = true;
            this.radioButtonHerbTom.Text = "Herb Tomato";
            this.radioButtonHerbTom.UseVisualStyleBackColor = true;
            // 
            // groupBoxSauce
            // 
            this.groupBoxSauce.Controls.Add(this.radioButtonNone);
            this.groupBoxSauce.Controls.Add(this.radioButtonCrmGarl);
            this.groupBoxSauce.Controls.Add(this.radioButtonHerbTom);
            this.groupBoxSauce.Controls.Add(this.radioButtonRed);
            this.groupBoxSauce.Controls.Add(this.radioButtonSwtChili);
            this.groupBoxSauce.Location = new System.Drawing.Point(243, 101);
            this.groupBoxSauce.Name = "groupBoxSauce";
            this.groupBoxSauce.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSauce.TabIndex = 5;
            this.groupBoxSauce.TabStop = false;
            this.groupBoxSauce.Text = "Sauce";
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(7, 68);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNone.TabIndex = 4;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonCrmGarl
            // 
            this.radioButtonCrmGarl.AutoSize = true;
            this.radioButtonCrmGarl.Location = new System.Drawing.Point(6, 44);
            this.radioButtonCrmGarl.Name = "radioButtonCrmGarl";
            this.radioButtonCrmGarl.Size = new System.Drawing.Size(90, 17);
            this.radioButtonCrmGarl.TabIndex = 3;
            this.radioButtonCrmGarl.TabStop = true;
            this.radioButtonCrmGarl.Text = "Creamy Garlic";
            this.radioButtonCrmGarl.UseVisualStyleBackColor = true;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 187);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelToppingsTitle
            // 
            this.labelToppingsTitle.AutoSize = true;
            this.labelToppingsTitle.Location = new System.Drawing.Point(106, 216);
            this.labelToppingsTitle.Name = "labelToppingsTitle";
            this.labelToppingsTitle.Size = new System.Drawing.Size(155, 13);
            this.labelToppingsTitle.TabIndex = 8;
            this.labelToppingsTitle.Text = "Add Your Toppings $0.30 each";
            // 
            // listBoxCheese
            // 
            this.listBoxCheese.FormattingEnabled = true;
            this.listBoxCheese.Location = new System.Drawing.Point(0, 250);
            this.listBoxCheese.Name = "listBoxCheese";
            this.listBoxCheese.Size = new System.Drawing.Size(129, 95);
            this.listBoxCheese.TabIndex = 9;
            // 
            // labelCheese
            // 
            this.labelCheese.AutoSize = true;
            this.labelCheese.Location = new System.Drawing.Point(19, 231);
            this.labelCheese.Name = "labelCheese";
            this.labelCheese.Size = new System.Drawing.Size(43, 13);
            this.labelCheese.TabIndex = 10;
            this.labelCheese.Text = "Cheese";
            // 
            // labelMeat
            // 
            this.labelMeat.AutoSize = true;
            this.labelMeat.Location = new System.Drawing.Point(123, 229);
            this.labelMeat.Name = "labelMeat";
            this.labelMeat.Size = new System.Drawing.Size(31, 13);
            this.labelMeat.TabIndex = 12;
            this.labelMeat.Text = "Meat";
            // 
            // listBoxMeat
            // 
            this.listBoxMeat.FormattingEnabled = true;
            this.listBoxMeat.Location = new System.Drawing.Point(135, 250);
            this.listBoxMeat.Name = "listBoxMeat";
            this.listBoxMeat.Size = new System.Drawing.Size(88, 95);
            this.listBoxMeat.TabIndex = 11;
            // 
            // labelVegetable
            // 
            this.labelVegetable.AutoSize = true;
            this.labelVegetable.Location = new System.Drawing.Point(226, 231);
            this.labelVegetable.Name = "labelVegetable";
            this.labelVegetable.Size = new System.Drawing.Size(55, 13);
            this.labelVegetable.TabIndex = 14;
            this.labelVegetable.Text = "Vegetable";
            // 
            // listBoxVeg
            // 
            this.listBoxVeg.FormattingEnabled = true;
            this.listBoxVeg.Location = new System.Drawing.Point(229, 250);
            this.listBoxVeg.Name = "listBoxVeg";
            this.listBoxVeg.Size = new System.Drawing.Size(88, 95);
            this.listBoxVeg.TabIndex = 13;
            // 
            // listBoxToppings
            // 
            this.listBoxToppings.FormattingEnabled = true;
            this.listBoxToppings.Location = new System.Drawing.Point(334, 250);
            this.listBoxToppings.Name = "listBoxToppings";
            this.listBoxToppings.Size = new System.Drawing.Size(109, 95);
            this.listBoxToppings.TabIndex = 15;
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.Location = new System.Drawing.Point(331, 229);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(76, 13);
            this.labelToppings.TabIndex = 16;
            this.labelToppings.Text = "Your Toppings";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 351);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(92, 23);
            this.buttonSubmit.TabIndex = 17;
            this.buttonSubmit.Text = "Submit Order";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(333, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add Topping";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(12, 442);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAll.TabIndex = 19;
            this.buttonRemoveAll.Text = "Remove All";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(264, 442);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear Order";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(65, 180);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(46, 20);
            this.textBoxQty.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(346, 442);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(12, 391);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(409, 48);
            this.labelMessage.TabIndex = 22;
            // 
            // checkBoxNoTop
            // 
            this.checkBoxNoTop.AutoSize = true;
            this.checkBoxNoTop.Location = new System.Drawing.Point(229, 356);
            this.checkBoxNoTop.Name = "checkBoxNoTop";
            this.checkBoxNoTop.Size = new System.Drawing.Size(87, 17);
            this.checkBoxNoTop.TabIndex = 23;
            this.checkBoxNoTop.Text = "No Toppings";
            this.checkBoxNoTop.UseVisualStyleBackColor = true;
            this.checkBoxNoTop.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonRemoveTop
            // 
            this.buttonRemoveTop.Location = new System.Drawing.Point(93, 442);
            this.buttonRemoveTop.Name = "buttonRemoveTop";
            this.buttonRemoveTop.Size = new System.Drawing.Size(98, 23);
            this.buttonRemoveTop.TabIndex = 24;
            this.buttonRemoveTop.Text = "Remove Topping";
            this.buttonRemoveTop.UseVisualStyleBackColor = true;
            this.buttonRemoveTop.Click += new System.EventHandler(this.buttonRemoveTop_Click);
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(12, 468);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(238, 13);
            this.labelCredit.TabIndex = 25;
            this.labelCredit.Text = "Pizza Shop v 2.1 Developed by Jeff Janda, 2015";
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 489);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.buttonRemoveTop);
            this.Controls.Add(this.checkBoxNoTop);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelToppings);
            this.Controls.Add(this.listBoxToppings);
            this.Controls.Add(this.labelVegetable);
            this.Controls.Add(this.listBoxVeg);
            this.Controls.Add(this.labelMeat);
            this.Controls.Add(this.listBoxMeat);
            this.Controls.Add(this.labelCheese);
            this.Controls.Add(this.listBoxCheese);
            this.Controls.Add(this.labelToppingsTitle);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.groupBoxSauce);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxCrust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCreate";
            this.Text = "Create Your Own Form";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCrust.ResumeLayout(false);
            this.groupBoxCrust.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxSauce.ResumeLayout(false);
            this.groupBoxSauce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCrust;
        private System.Windows.Forms.RadioButton radioButtonPan;
        private System.Windows.Forms.RadioButton radioButtonOriginal;
        private System.Windows.Forms.RadioButton radioButtonThin;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radioButtonFamily;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonSwtChili;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonHerbTom;
        private System.Windows.Forms.GroupBox groupBoxSauce;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonCrmGarl;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelToppingsTitle;
        private System.Windows.Forms.ListBox listBoxCheese;
        private System.Windows.Forms.Label labelCheese;
        private System.Windows.Forms.Label labelMeat;
        private System.Windows.Forms.ListBox listBoxMeat;
        private System.Windows.Forms.Label labelVegetable;
        private System.Windows.Forms.ListBox listBoxVeg;
        private System.Windows.Forms.ListBox listBoxToppings;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.CheckBox checkBoxNoTop;
        private System.Windows.Forms.Button buttonRemoveTop;
        private System.Windows.Forms.ToolStripMenuItem submitOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toppingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label labelCredit;
    }
}