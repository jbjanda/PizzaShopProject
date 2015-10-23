namespace JJanda_Assignment1
{
    partial class FormThinCrust
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPricing = new System.Windows.Forms.Label();
            this.listBoxSpecials = new System.Windows.Forms.ListBox();
            this.labelSpecials = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelOrderConfirm = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonFamily = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(345, 74);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Choose one of our delicious\r\nthin crust specials!";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPricing
            // 
            this.labelPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPricing.Location = new System.Drawing.Point(3, 78);
            this.labelPricing.Name = "labelPricing";
            this.labelPricing.Size = new System.Drawing.Size(341, 23);
            this.labelPricing.TabIndex = 1;
            this.labelPricing.Text = "Large: $11.00  Family:$13.00";
            this.labelPricing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxSpecials
            // 
            this.listBoxSpecials.FormattingEnabled = true;
            this.listBoxSpecials.Items.AddRange(new object[] {
            "Herb Chicken",
            "Chicken Bacon Artichoke",
            "Thai Chicken",
            "Gourmet Chicken Garlic",
            "Veggie",
            "Meat"});
            this.listBoxSpecials.Location = new System.Drawing.Point(7, 127);
            this.listBoxSpecials.Name = "listBoxSpecials";
            this.listBoxSpecials.Size = new System.Drawing.Size(134, 82);
            this.listBoxSpecials.TabIndex = 3;
            // 
            // labelSpecials
            // 
            this.labelSpecials.AutoSize = true;
            this.labelSpecials.Location = new System.Drawing.Point(39, 111);
            this.labelSpecials.Name = "labelSpecials";
            this.labelSpecials.Size = new System.Drawing.Size(50, 13);
            this.labelSpecials.TabIndex = 2;
            this.labelSpecials.Text = "Specials:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(260, 111);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 13);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "Size:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(149, 175);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantity:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(217, 175);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // labelOrderConfirm
            // 
            this.labelOrderConfirm.Location = new System.Drawing.Point(12, 236);
            this.labelOrderConfirm.Name = "labelOrderConfirm";
            this.labelOrderConfirm.Size = new System.Drawing.Size(326, 23);
            this.labelOrderConfirm.TabIndex = 9;
            this.labelOrderConfirm.Text = "Confirm Your Order Below\r\n";
            this.labelOrderConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessage
            // 
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMessage.Location = new System.Drawing.Point(12, 259);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(326, 77);
            this.labelMessage.TabIndex = 10;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(7, 376);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(140, 376);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "C&lear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(263, 376);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(250, 128);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(52, 17);
            this.radioButtonLarge.TabIndex = 5;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonFamily
            // 
            this.radioButtonFamily.AutoSize = true;
            this.radioButtonFamily.Location = new System.Drawing.Point(248, 152);
            this.radioButtonFamily.Name = "radioButtonFamily";
            this.radioButtonFamily.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFamily.TabIndex = 6;
            this.radioButtonFamily.TabStop = true;
            this.radioButtonFamily.Text = "Family";
            this.radioButtonFamily.UseVisualStyleBackColor = true;
            // 
            // FormThinCrust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 419);
            this.Controls.Add(this.radioButtonFamily);
            this.Controls.Add(this.radioButtonLarge);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelOrderConfirm);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelSpecials);
            this.Controls.Add(this.listBoxSpecials);
            this.Controls.Add(this.labelPricing);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormThinCrust";
            this.Text = "Thin Crust Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPricing;
        private System.Windows.Forms.ListBox listBoxSpecials;
        private System.Windows.Forms.Label labelSpecials;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelOrderConfirm;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonFamily;
    }
}