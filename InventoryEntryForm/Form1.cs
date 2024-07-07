using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace InventoryEntryForm
{
    public partial class frmInventoryItemAdd : Form
    {
        public frmInventoryItemAdd()
        {
            InitializeComponent();

            // Initially hide all group boxes
            grpBoxBook.Visible = false;
            grpBoxFurniture.Visible = false;
            grpBoxGrocery.Visible = false;
            #region Data Binding
            // Add handling for sql exception
            try
            {
                // Set the combo box (Category)
                // Get the category table
                Organization.CategoryDataTable dtCategoryTable = Utility.GetCategories();
                cmbItemType.DataSource = dtCategoryTable;
                // Update display member
                cmbItemType.DisplayMember = dtCategoryTable.CategoryColumn.ColumnName; // "Furniture, Grocery, Book"
                cmbItemType.ValueMember = dtCategoryTable.IDColumn.ColumnName; // 1, 2, 3, etc. (Primary Key)

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
            }

            try
            {
                // Set the combo box (Category)
                // Get the category table
                Organization.CategoryDataTable dtCategoryTable = Utility.GetCategories();
                cmbSearchItemType.DataSource = dtCategoryTable;
                // Update display member
                cmbSearchItemType.DisplayMember = dtCategoryTable.CategoryColumn.ColumnName; // "Furniture, Grocery, Book"
                cmbSearchItemType.ValueMember = dtCategoryTable.IDColumn.ColumnName; // 1, 2, 3, etc. (Primary Key)

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
            }

            try
            {
                // Set the companies combo box
                // Get the companies table
                Organization.CompaniesDataTable dtCompaniesTable = Utility.GetCompanies();
                // Set the data source
                cmbCompanies.DataSource = dtCompaniesTable;
                // update display and value member
                cmbCompanies.DisplayMember = dtCompaniesTable.CompanyNameColumn.ColumnName; // "ex. Nike"
                cmbCompanies.ValueMember = dtCompaniesTable.IDColumn.ColumnName; // Primary key
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
            }

            try
            {
                // Set the Grocery Category combo box
                Organization.GroceryCategoryDataTable dtGroceryCategoryTable = Utility.GetGroceryCategories();
                // Set the data source
                cmbGroceryCategory.DataSource = dtGroceryCategoryTable;
                // Update display and value member
                cmbGroceryCategory.DisplayMember = dtGroceryCategoryTable.CategoryTypeColumn.ColumnName; // "Produce, Dairy, etc."
                cmbGroceryCategory.ValueMember = dtGroceryCategoryTable.IDColumn.ColumnName; // Primary key
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
            }

            try
            {
                // Set the book type combo box
                Organization.BookTypeDataTable dtBookTypeTable = Utility.GetBookTypes();
                cmbBookType.DataSource = dtBookTypeTable;
                // Update display and value member
                cmbBookType.DisplayMember = dtBookTypeTable.BookGenreColumn.ColumnName;
                cmbBookType.ValueMember = dtBookTypeTable.IDColumn.ColumnName;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
            }

            // Set combo boxes to -1 initially
            cmbCompanies.SelectedIndex = -1;
            cmbItemType.SelectedIndex = -1;
            cmbSearchItemType.SelectedIndex = -1;
            cmbGroceryCategory.SelectedIndex = -1;
            cmbBookType.SelectedIndex = -1;

            try
            {
                // Set the data grid source
                dgInventoryItems.DataSource = Utility.GetInventoryItems();
                // Hide unneccessary fields
                dgInventoryItems.Columns["ID"].Visible = false;
                dgInventoryItems.Columns["CompanyID"].Visible = false;
                dgInventoryItems.Columns["Length"].Visible = false;
                dgInventoryItems.Columns["Width"].Visible = false;
                dgInventoryItems.Columns["Height"].Visible = false;
                dgInventoryItems.Columns["Weight"].Visible = false;
                dgInventoryItems.Columns["ISBN"].Visible = false;
                dgInventoryItems.Columns["Author"].Visible = false;
                dgInventoryItems.Columns["BookType"].Visible = false;
                dgInventoryItems.Columns["PackagingDate"].Visible = false;
                dgInventoryItems.Columns["ExpirationDate"].Visible = false;
                dgInventoryItems.Columns["GroceryCategory"].Visible = false;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
            }

            // Create delete column
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            // Set the header text
            deleteColumn.HeaderText = "Use to Delete";
            // Set the cell text
            deleteColumn.Text = "Delete";
            // Make sure the button uses the cell text as its own text
            deleteColumn.UseColumnTextForButtonValue = true;
            // Add the column to the data grid
            dgInventoryItems.Columns.Add(deleteColumn);

            // Create update column
            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            // Set the header text
            updateColumn.HeaderText = "Use to Update";
            // Set the cell text
            updateColumn.Text = "Update";
            // Have button use cell text
            updateColumn.UseColumnTextForButtonValue = true;
            // Add column to data grid
            dgInventoryItems.Columns.Add(updateColumn);

            // Add event listener for buttons
            dgInventoryItems.CellClick += dgInventoryItems_CellClick;

            #endregion

            // Set the format of the dateTimePickers
            dtpPackDate.Format = DateTimePickerFormat.Custom;
            dtpPackDate.CustomFormat = "MM'/'dd'/'yyyy";
            dtpExpirationDate.Format = DateTimePickerFormat.Custom;
            dtpExpirationDate.CustomFormat = "MM'/'dd'/'yyyy";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region Verify fields are filled out
            // Make sure the user entered an item name price and description
            if (txtItemName.Text.Length == 0)
            {
                MessageBox.Show("Item must have a name!");
                txtItemName.Focus();
                return;
            }

            // Check the price field
            if (txtItemPrice.Text.Length == 0)
            {
                MessageBox.Show("Item must have a price!");
                txtItemPrice.Focus();
                return;
            }
           
            // Check the description field
            if (txtItemDescription.Text.Length == 0)
            {
                MessageBox.Show("Item must have a description!");
                txtItemDescription.Focus();
                return;
            }
            // Make sure the user selects an item type
            if (cmbItemType.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose an item type!"); //Warn the user of the issue
                cmbItemType.Focus();
                return; //Returns so the program does not continue
            }

            // Make sure the user selects a company
            if (cmbCompanies.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a company!"); //Warn the user of the issue
                cmbCompanies.Focus();
                return; //Returns so the program does not continue
            }
            #endregion

            #region Verify Group Box Fields
            // Make sure that if an item type is selected, the appropriate fields are filled out
            if (cmbItemType.SelectedItem.ToString() == "Furniture")
            {
                // Check that furniture fields are filled out
                if (txtLength.Text.Length == 0)
                {
                    MessageBox.Show("If you select Furniture, you have to input a length!");
                    txtLength.Focus(); 
                    return;
                } else if (txtWidth.Text.Length == 0)
                {
                    MessageBox.Show("If you select Furniture, you have to input a width!");
                    txtWidth.Focus();
                    return;
                } else if (txtHeight.Text.Length == 0)
                {
                    MessageBox.Show("If you select Furniture, you have to input a height!");
                    txtHeight.Focus();
                    return;
                } else if (txtWeight.Text.Length == 0)
                {
                    MessageBox.Show("If you select Furniture, you have to input a weight!");
                    txtWeight.Focus();
                    return;
                }
            } else if (cmbItemType.SelectedItem.ToString() == "Grocery")
            {
                if (dtpPackDate.Value == DateTime.Now)
                {
                    MessageBox.Show("If you select Grocery, you have to input a package date!");
                    dtpPackDate.Focus();
                    return;
                }
                else if (dtpExpirationDate.Value == DateTime.Now)
                {
                    MessageBox.Show("If you select Grocery, you have to input an expiration date!");
                    dtpExpirationDate.Focus();
                    return;
                } else if (cmbGroceryCategory.SelectedIndex < 0)
                {
                    MessageBox.Show("If you select Grocery, you have to select a grocery category!");
                    cmbGroceryCategory.Focus();
                    return;
                }
            } else if (cmbItemType.SelectedItem.ToString() == "Book")
            {
                 if (txtISBN.Text.Length == 0)
                {
                    MessageBox.Show("If you select Book, you have to input an ISBN number!");
                    txtISBN.Focus();
                    return;
                } else if (cmbBookType.SelectedIndex < 0)
                {
                    MessageBox.Show("If you select Book, you have to input a book type!");
                    cmbBookType.Focus();
                    return;
                } else if (txtAuthor.Text.Length == 0)
                {
                    MessageBox.Show("If you select Book, you have to input an Author!");
                    txtAuthor.Focus();
                    return;
                }
            }
            #endregion

            // Verify Quantity Field
            if (txtQuantity.Text.Length == 0)
            {
                MessageBox.Show("You must specify a quantity!");
                txtQuantity.Focus();
                return;
            }

            #region Gather User Input
            // Cast the item type combo box to a datarowview then to a string (ItemName)
            var selectedDataRowView = (DataRowView)cmbItemType.SelectedItem;
            string selectedItemCategory = selectedDataRowView["Category"].ToString();

            // Cast the item type combo box to a datarowview then to a string (ID)
            int itemCategoryID = int.Parse(selectedDataRowView["ID"].ToString());

            // Cast the Company type combo box to a string
            var selectedCompanyView = (DataRowView)cmbCompanies.SelectedItem;
            int companyID = int.Parse(selectedCompanyView["ID"].ToString());

            // Set up variables for grocery combo box
            DataRowView selectedGroceryCategoryView;
            int groceryCategoryID = 0;
            // Only assign if grocery category is selected
            if (cmbGroceryCategory.SelectedIndex > -1)
            {
                // Cast the grocery type combo box to a string
                selectedGroceryCategoryView = (DataRowView)cmbGroceryCategory.SelectedItem;
                groceryCategoryID = int.Parse(selectedGroceryCategoryView["ID"].ToString());
            }

            // Set up variables for book type combo box
            DataRowView selectedBookTypeView;
            int bookType = 0;
            // Only assign if book type is selected
            if (cmbBookType.SelectedIndex > -1)
            {
                // Cast the Book Type combo box to a string
                selectedBookTypeView = (DataRowView)cmbBookType.SelectedItem;
                bookType = int.Parse(selectedBookTypeView["ID"].ToString());
            }

            // Set all the fields to variables
            string itemTitle = txtItemName.Text;
            float itemPrice = float.Parse(txtItemPrice.Text);
            string itemDescription = txtItemDescription.Text;
            float itemLength = 0;
            float itemWidth = 0;
            float itemHeight = 0;
            float itemWeight = 0;
            DateTime packDate = dtpPackDate.Value;
            DateTime expirationdate = dtpExpirationDate.Value;
            string isbn = txtISBN.Text;
            string author = txtAuthor.Text;
            int quantity = int.Parse(txtQuantity.Text);

            // Find out what is showing
            if (selectedItemCategory == "Furniture")
            {
                // Furniture group is showing
                itemLength = float.Parse(txtLength.Text);
                itemWidth = float.Parse(txtWidth.Text);
                itemHeight = float.Parse(txtHeight.Text);
                itemWeight = float.Parse(txtWeight.Text);              
            }
            #endregion

            // Verify if user wants to update or add a new record
            if (dgInventoryItems.SelectedRows.Count == 1)
            {
                int itemId = -1;
                // Get the item title from data grid
                itemId = int.Parse(dgInventoryItems.SelectedRows[0].Cells["ID"].Value.ToString());
                // update by id
                try
                {
                    Utility.UpdateInventoryItemById(itemId, itemTitle, itemDescription, itemPrice, itemCategoryID, companyID, itemLength, itemWidth, itemHeight, itemWeight, isbn, author, bookType, packDate, expirationdate, groceryCategoryID);
                }
                catch (ArgumentOutOfRangeException argEx)
                {
                    MessageBox.Show("Price error. " + argEx.Message);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
                }
            } else
            {
                // Send number of items user specified in quanity
                for (int i = 0; i < quantity; i++)
                {
                    try
                    {
                        // Send the item to the database
                        Utility.SaveInventoryItem(itemTitle, itemDescription, itemPrice, itemCategoryID, companyID, itemLength, itemWidth, itemHeight, itemWeight, isbn, author, bookType, packDate, expirationdate, groceryCategoryID);
                    }
                    catch (ArgumentOutOfRangeException argEx)
                    {
                        MessageBox.Show("Price error. " + argEx.Message);
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
                    }
                }
            }
            // Refresh the grid
            RefreshGridData();
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItemType.BackColor = Color.White;

            // Check when combo box is reset
            if (cmbItemType.SelectedIndex < 0)
            {
                cmbItemType.Text = "--Select One--";
                // Hide everything and return
                grpBoxBook.Visible = false;
                grpBoxFurniture.Visible = false;
                grpBoxGrocery.Visible = false;

                return;
            }
            #region Hide/Show Group Boxes
            // Cast the combo box to a datarowview then to a string
            var selectedDataRowView = (DataRowView)cmbItemType.SelectedItem;
            string selectedValue = selectedDataRowView["Category"].ToString();
            // Check what was selected to show group boxes
            if (selectedValue == "Furniture")
            {
                // Furniture should be showing
                grpBoxFurniture.Visible = true;
                
                // Hide the other group boxes
                grpBoxGrocery.Visible = false;
                grpBoxBook.Visible = false;
            } else if (selectedValue == "Grocery")
            {
                // Grocery should be showing
                grpBoxGrocery.Visible = true;

                // Hide the other group boxes
                grpBoxFurniture.Visible = false;
                grpBoxBook.Visible = false;
            } else if (selectedValue == "Book")
            {
                // Book should be showing
                grpBoxBook.Visible = true;

                // Hide the other group boxes
                grpBoxGrocery.Visible = false;
                grpBoxFurniture.Visible = false;
            }
            #endregion
        }

        private void cmbItemType_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all fields
            // Clear item field, price, description, and quantity
            txtItemName.Clear();
            txtItemPrice.Clear();
            txtItemDescription.Clear();
            txtQuantity.Clear();
            txtSearchText.Clear();

            #region Clear Group Boxes
            if (cmbItemType.SelectedIndex >= 0)
            {
                // Cast the combo box to a datarowview then to a string
                var selectedDataRowView = (DataRowView)cmbItemType.SelectedItem;
                string selectedValue = selectedDataRowView["Category"].ToString();
                // Find what is showing
                if (selectedValue == "Furniture")
                {
                    // Furniture group is showing
                    // Clear all fields in furniture group box
                    txtLength.Clear();
                    txtWidth.Clear();
                    txtHeight.Clear();
                    txtWeight.Clear();
                } else if (selectedValue == "Grocery")
                {
                    // Grocery Group is showing
                    // Clear all fields in grocery group box
                    dtpPackDate.Value = DateTime.Now;
                    dtpExpirationDate.Value = DateTime.Now;    
                    cmbGroceryCategory.SelectedIndex = -1;
                } else if (selectedValue == "Book")
                {
                    // Book group is showing
                    // Clear all fields in book group box
                    txtISBN.Clear();
                    cmbBookType.SelectedIndex = -1;
                    txtAuthor.Clear();
                }
            }
            #endregion

            // Reset combo box
            cmbItemType.SelectedIndex = -1;
            cmbSearchItemType.SelectedIndex = -1;
            cmbCompanies.SelectedIndex = -1;

            // Refresh grid data
            RefreshGridData();

            // Place focus back on item name
            txtItemName.Focus();
        }

        private void cmbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add functionality for when the reset button is clicked
            if ( cmbCompanies.SelectedIndex < 0)
            {
                cmbCompanies.Text = "--Select One--";
            }
        }

        private void cmbGroceryCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroceryCategory.SelectedIndex < 0)
            {
                cmbGroceryCategory.Text = "--Select One--";
            }
        }

        private void cmbBookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBookType.SelectedIndex < 0)
            {
                cmbBookType.Text = "--Select One--";
            }
        }

        private void dgInventoryItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemId = -1;

            if (e.RowIndex < 0)
            {
                return;
            }

            // Cast the sender as a datagrid
            DataGridView dg = (DataGridView)sender;

            // Get the selected row
            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];

            // get the item id
            itemId = int.Parse(rowToBeOperatedUpon.Cells["ID"].Value.ToString());

            // Check if the user selected a cell in the dummy column
            if (e.ColumnIndex == -1)
            {
                #region Display Item Info
                // Set the item title
                txtItemName.Text = rowToBeOperatedUpon.Cells["ItemTitle"].Value.ToString();
                // set the price
                txtItemPrice.Text = rowToBeOperatedUpon.Cells["Price"].Value.ToString();
                // Set the description
                txtItemDescription.Text = rowToBeOperatedUpon.Cells["Description"].Value.ToString();
                // set item category
                cmbItemType.SelectedValue = rowToBeOperatedUpon.Cells["Category"].Value.ToString();
                // Set the company
                cmbCompanies.SelectedValue = rowToBeOperatedUpon.Cells["CompanyID"].Value.ToString();
                // Set the quantity to 1 for all
                txtQuantity.Text = "1";
                // Find out which group box is showing
                if (grpBoxFurniture.Visible)
                {
                    // Item is Furniture
                    // Length
                    txtLength.Text = rowToBeOperatedUpon.Cells["Length"].Value.ToString();
                    // Width
                    txtWidth.Text = rowToBeOperatedUpon.Cells["Width"].Value.ToString();
                    // Height
                    txtHeight.Text = rowToBeOperatedUpon.Cells["Height"].Value.ToString();
                    // Weight
                    txtWeight.Text = rowToBeOperatedUpon.Cells["Weight"].Value.ToString();
                } else if (grpBoxBook.Visible)
                {
                    // Item is a book
                    // ISBN
                    txtISBN.Text = rowToBeOperatedUpon.Cells["ISBN"].Value.ToString();
                    // Author
                    txtAuthor.Text = rowToBeOperatedUpon.Cells["Author"].Value.ToString();
                    // Book type combo box
                    cmbBookType.SelectedValue = rowToBeOperatedUpon.Cells["BookType"].Value.ToString();
                } else if(grpBoxGrocery.Visible) 
                {
                    // Item is grocery
                    // Pack Date
                    dtpPackDate.Value = DateTime.Parse(rowToBeOperatedUpon.Cells["PackagingDate"].Value.ToString());
                    // Expiration Date
                    dtpExpirationDate.Value = DateTime.Parse(rowToBeOperatedUpon.Cells["ExpirationDate"].Value.ToString());
                    // Grocery Category combo box
                    cmbGroceryCategory.SelectedValue = rowToBeOperatedUpon.Cells["GroceryCategory"].Value.ToString();
                }
                #endregion
                return;
            }

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
                        try
                        {
                            // Delete button was selected
                            Utility.DeleteInventoryItemById(itemId);
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
                        }

                        // Refresh the grid data
                        RefreshGridData();
                    }
                    else if (selectedButton.Value.Equals("Update"))
                    {
                        #region Gather Item Info
                        // Update button was selected
                        // Get all the values
                        string itemTitle = rowToBeOperatedUpon.Cells["ItemTitle"].Value.ToString();
                        int itemCategory = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["Category"].Value.ToString()) ? 0 : int.Parse(rowToBeOperatedUpon.Cells["Category"].Value.ToString());
                        string itemDescription = rowToBeOperatedUpon.Cells["Description"].Value.ToString();
                        float price = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["Price"].Value.ToString()) ? 0 : float.Parse(rowToBeOperatedUpon.Cells["Price"].Value.ToString());
                        int companyId = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["CompanyID"].Value.ToString()) ? 0 : int.Parse(rowToBeOperatedUpon.Cells["CompanyID"].Value.ToString());
                        float length = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["Length"].Value.ToString()) ? 0 : float.Parse(rowToBeOperatedUpon.Cells["Length"].Value.ToString());
                        float width = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["Width"].Value.ToString()) ? 0 : float.Parse(rowToBeOperatedUpon.Cells["Width"].Value.ToString());
                        float height = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["Height"].Value.ToString()) ? 0 : float.Parse(rowToBeOperatedUpon.Cells["Height"].Value.ToString());
                        float weight = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["Weight"].Value.ToString()) ? 0 : float.Parse(rowToBeOperatedUpon.Cells["Weight"].Value.ToString());
                        string isbn = rowToBeOperatedUpon.Cells["ISBN"].Value.ToString();
                        string author = rowToBeOperatedUpon.Cells["Author"].Value.ToString();
                        int bookType = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["BookType"].Value.ToString()) ? 0 : int.Parse(rowToBeOperatedUpon.Cells["BookType"].Value.ToString());
                        DateTime packDate = DateTime.Parse(rowToBeOperatedUpon.Cells["PackagingDate"].Value.ToString());
                        DateTime expirationDate = DateTime.Parse(rowToBeOperatedUpon.Cells["ExpirationDate"].Value.ToString());
                        int groceryCategory = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["GroceryCategory"].Value.ToString()) ? 0 : int.Parse(rowToBeOperatedUpon.Cells["GroceryCategory"].Value.ToString());
                        #endregion
                        try
                        {
                            // Call the updatebyId function
                            Utility.UpdateInventoryItemById(itemId, itemTitle, itemDescription, price, itemCategory, companyId, length, width, height, weight, isbn, author, bookType, packDate, expirationDate, groceryCategory); ;
                        }
                        catch (ArgumentOutOfRangeException argEx) 
                        {
                            MessageBox.Show("Price error. " + argEx.Message);
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
                        }

                        // Refresh the data grid
                        RefreshGridData();
                    }
                    return;
                }
            }
        }

        private void RefreshGridData()
        {
            // Set the data source of the grid to the updated inventory items table
            try
            {
                dgInventoryItems.DataSource = Utility.GetInventoryItems();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number. Or Email address\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email address\n" + ex.Message);
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            // Check if user enter anything or selected anything
            if (txtSearchText.Text.Length == 0 && cmbSearchItemType.SelectedIndex < 0)
            {
                // Verify user to enter information
                MessageBox.Show("Must enter text or select an item type to filter results.");
                txtSearchText.Focus();
                return;
            }

            // User entered text and selected from drop down
            if (txtSearchText.Text.Length > 0 && cmbSearchItemType.SelectedIndex >= 0)
            {
                // Filter the datagrid view by both item title and item category
                if (dgInventoryItems.DataSource is DataTable dataTable)
                {
                    dataTable.DefaultView.RowFilter = $"ItemTitle LIKE '%{txtSearchText.Text}%' AND Category = {(int)cmbSearchItemType.SelectedValue}";
                }
                return;
            }

            // User just entered text
            if (txtSearchText.Text.Length > 0 && cmbSearchItemType.SelectedIndex < 0)
            {
                // Filter the datagrid view by item title
                if (dgInventoryItems.DataSource is DataTable dataTable)
                {
                    dataTable.DefaultView.RowFilter = $"ItemTitle LIKE '%{txtSearchText.Text}%'";
                }
                return;
            }

            // User just entered text
            if (txtSearchText.Text.Length == 0 && cmbSearchItemType.SelectedIndex >= 0)
            {
                // Filter the datagrid view by item category
                if (dgInventoryItems.DataSource is DataTable dataTable)
                {
                    dataTable.DefaultView.RowFilter = $"Category = {(int)cmbSearchItemType.SelectedValue}";
                }
            }
        }

        private void cmbSearchItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchItemType.SelectedIndex < 0)
            {
                cmbSearchItemType.Text = "--Select One--";
            }
        }
    }
}
