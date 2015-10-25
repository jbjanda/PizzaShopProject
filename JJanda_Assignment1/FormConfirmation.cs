using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJanda_Assignment1
{
    public partial class FormConfirmation : Form
    {
        private Item myItem;

        public FormConfirmation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded Constructor that allows an Item to be passed to the
        /// Confirmation Form.
        /// </summary>
        /// <param name="myItem">An Item Object</param>
        public FormConfirmation(Item myItem)
        {
            InitializeComponent();
          
            this.myItem = myItem;
            
        }

        private void FormConfirmation_Load(object sender, EventArgs e)
        {
            labelMessage.Text=myItem.ToString();
        }
    }
}
