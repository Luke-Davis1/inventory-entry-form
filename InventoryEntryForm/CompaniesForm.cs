using DataAccessLayer;
using System;
using System.CodeDom;
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
    public partial class CompaniesForm : Form
    {
        public CompaniesForm()
        {
            InitializeComponent();

            // Set the data source to the companies table
            Organization.CompaniesDataTable dtCompaniesTable = Utility.GetCompanies();
            dgCompanies.DataSource = dtCompaniesTable;

            // Hide the company ID column
            dgCompanies.Columns["ID"].Visible = false;

            // Create additional button columns

            // Create delete column
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            // Set the header text
            deleteColumn.HeaderText = "Use to Delete";
            // Set the cell text
            deleteColumn.Text = "Delete";
            // Make sure the button uses the cell text as its own text
            deleteColumn.UseColumnTextForButtonValue = true;
            // Add the column to the data grid
            dgCompanies.Columns.Add(deleteColumn);

            // Create update column
            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            // Set the header text
            updateColumn.HeaderText = "Use to Update";
            // Set the cell text
            updateColumn.Text = "Update";
            // Have button use cell text
            updateColumn.UseColumnTextForButtonValue = true;
            // Add column to data grid
            dgCompanies.Columns.Add(updateColumn);

            // Add event to cell clicks
            dgCompanies.CellClick += dgCompanies_CellClick;

        }

        private void dgCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int companyId = -1;

            if (e.RowIndex < 0)
            {
                return;
            }

            // Cast the sender as a datagrid
            DataGridView dg = (DataGridView)sender;

            // Get the selected row
            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];

            // get the company id
            companyId = int.Parse(rowToBeOperatedUpon.Cells["ID"].Value.ToString());

            // check if a button was clicked
            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    // A button was clicked
                    DataGridViewButtonCell selectedButton = (DataGridViewButtonCell)dg.SelectedCells[0];

                    // Check if it was the delete button
                    if (selectedButton.Value.Equals("Delete"))
                    {
                        // Delete button was selected
                        Utility.DeleteCompanyById(companyId);

                        // Refresh the grid data
                        RefreshGridData();
                    } else if (selectedButton.Value.Equals("Update"))
                    {
                        // Update button was selected
                        // Get all the values
                        string companyName = rowToBeOperatedUpon.Cells["CompanyName"].Value.ToString();
                        string companyNumber = rowToBeOperatedUpon.Cells["ContactNumber"].Value.ToString();
                        string companyAddress = rowToBeOperatedUpon.Cells["Address"].Value.ToString();

                        // Call the updatebyId function
                        Utility.UpdateCompanyById(companyId, companyName, companyNumber, companyAddress);

                        // Refresh the data grid
                        RefreshGridData();
                    }
                    return;
                }
            }
        }

        private void RefreshGridData()
        {
            // Set the data source of the grid to the updated companies table
            dgCompanies.DataSource = Utility.GetCompanies();
        }
    }
}
