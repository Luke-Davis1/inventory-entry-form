using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryEntryForm
{

    public partial class MainWindow : Form
    {
        private frmInventoryItemAdd inventoryAddWin;
        private CompaniesForm companyWin;
        
        public MainWindow()
        {
            InitializeComponent();

            // Create an inventory add window
            inventoryAddWin = new frmInventoryItemAdd();
            inventoryAddWin.MdiParent = this;
            // Show inventory add form as the default
            inventoryAddWin.Show();

            // Create company window
            companyWin = new CompaniesForm();
            companyWin.MdiParent = this; // This will not be showing initially
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inventoryAddWin.IsDisposed)
            {
                // Recreate the window
                inventoryAddWin = new frmInventoryItemAdd();
                // Set the relationship
                inventoryAddWin.MdiParent = this;
            }
            // Show the inventory add form
            inventoryAddWin.Show();
            // Hide the companies form
            companyWin.Hide();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (companyWin.IsDisposed)
            {
                // Recreate window
                companyWin = new CompaniesForm();
                // Set the relationship
                companyWin.MdiParent = this;
            }
            // Show the company form
            companyWin.Show();
            // Hide the inventory add form
            inventoryAddWin.Hide();
        }
    }
}
