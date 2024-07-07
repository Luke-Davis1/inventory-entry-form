using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Utility
    {
        public static Organization.CategoryDataTable GetCategories()
        {
            // create the table
            Organization.CategoryDataTable dtCategoryTable = new Organization.CategoryDataTable();
            
            // Create the adapter
            OrganizationTableAdapters.CategoryTableAdapter categoryAdapter = new OrganizationTableAdapters.CategoryTableAdapter();
            
            // Implement SQl exception handling
            try
            {
                // Fill the adapter with the table
                categoryAdapter.Fill(dtCategoryTable);
            } catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }
            
            // Return the category table
            return dtCategoryTable;
        }

        public static Organization.CompaniesDataTable GetCompanies()
        {
            // create the table
            Organization.CompaniesDataTable dtCompaniesTable = new Organization.CompaniesDataTable();
           
            // Create the adapter
            OrganizationTableAdapters.CompaniesTableAdapter companiesAdapter = new OrganizationTableAdapters.CompaniesTableAdapter();
           
            // Implement sql exception handling
            try
            {
                // Fill the adapter with the table
                companiesAdapter.Fill(dtCompaniesTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // Return the companies table
            return dtCompaniesTable;
        }

        public static Organization.GroceryCategoryDataTable GetGroceryCategories()
        {
            // Build the table
            Organization.GroceryCategoryDataTable dtGroceryCategoryTable = new Organization.GroceryCategoryDataTable();
            
            // Build the adapter
            OrganizationTableAdapters.GroceryCategoryTableAdapter groceryCategoryAdapter = new OrganizationTableAdapters.GroceryCategoryTableAdapter();
            
            // Implement sql exception handling
            try
            {
                // Fill the adapter
                groceryCategoryAdapter.Fill(dtGroceryCategoryTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // return the table
            return dtGroceryCategoryTable;
        }

        public static Organization.BookTypeDataTable GetBookTypes() 
        {
            // Build the table
            Organization.BookTypeDataTable dtBookTypeTable = new Organization.BookTypeDataTable();

            // Build the adapter
            OrganizationTableAdapters.BookTypeTableAdapter bookTypeAdapter = new OrganizationTableAdapters.BookTypeTableAdapter();

            // Implement sql exception handling
            try
            {
                // Fill the adapter
                bookTypeAdapter.Fill(dtBookTypeTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // return the table
            return dtBookTypeTable;
        }

        public static void SaveInventoryItem(string itemTitle, string itemDescription, float price, int itemCategory, int companyID, float length, float width, float height, float weight, string isbn, string author, int bookType, DateTime packDate, DateTime expirationDate, int groceryCategory)
        {
            // EXTRA EXCEPTION HANDLING
            if (price < 0 || price > 100000)
            {
                // Price is out of range
                throw new ArgumentOutOfRangeException("Price", "Price cannot be negative or over $100,000");
            }
            // Build the inventory items table
            Organization.InventoryItemsDataTable dtInventoryItemsTable = new Organization.InventoryItemsDataTable();
            
            // Build the adapter
            OrganizationTableAdapters.InventoryItemsTableAdapter inventoryItemsAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            
            // Implement sql exception handling
            try
            {
                // Fill the adapter with the table
                inventoryItemsAdapter.Fill(dtInventoryItemsTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // Create a new instance of an item
            Organization.InventoryItemsRow newItem = dtInventoryItemsTable.NewInventoryItemsRow();

            // Set general fields
            newItem.ItemTitle = itemTitle;
            newItem.Description = itemDescription;
            newItem.Price = price;
            newItem.Category = itemCategory;
            newItem.CompanyID = companyID;

            // Check for what the item category is
            switch (itemCategory)
            {
                case 1:
                    // Item is a book
                    // Only set ISBN, Author, and BookType
                    newItem.Author = author;
                    newItem.ISBN = isbn;
                    newItem.BookType = bookType;
                    break;
                case 2:
                    // Item is furniture
                    // Set the length, width, height, and weight
                    newItem.Length = length;
                    newItem.Width = width;
                    newItem.Height = height;
                    newItem.Weight = weight;
                    break;
                case 3:
                    // Item is grocery
                    // Only set the pack date, expiration date, and grocery category
                    newItem.PackagingDate = packDate;
                    newItem.ExpirationDate = expirationDate;
                    newItem.GroceryCategory = groceryCategory;
                    break;
            }

            // Add item to table
            dtInventoryItemsTable.AddInventoryItemsRow(newItem);

            // Update to SQL Server
            inventoryItemsAdapter.Update(dtInventoryItemsTable);
        }

        public static void DeleteCompanyById(int companyID)
        {
            // Build the table
            Organization.CompaniesDataTable dtCompaniesTable = new Organization.CompaniesDataTable();
            // Create the adapter
            OrganizationTableAdapters.CompaniesTableAdapter companiesAdapter = new OrganizationTableAdapters.CompaniesTableAdapter();
            
            // Implement sql exception handling
            try
            {
                // Fill the adapter
                companiesAdapter.Fill(dtCompaniesTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // Loop through table to find the record to delete
            foreach (Organization.CompaniesRow row in dtCompaniesTable.Rows)
            {
                // Check the id
                if (row.ID == companyID)
                {
                    // Found the record, delete it
                    row.Delete();
                    // Update the table in SQL server
                    companiesAdapter.Update(dtCompaniesTable);
                    // Return because the record was found
                    return;
                }
            }
        }

        public static void UpdateCompanyById(int companyID, string companyName, string contactNumber, string address)
        {
            // Create the table
            Organization.CompaniesDataTable dtCompaniesTable = new Organization.CompaniesDataTable();
            // Create the adapter
            OrganizationTableAdapters.CompaniesTableAdapter companiesAdapter = new OrganizationTableAdapters.CompaniesTableAdapter();
           
            // Implement sql exception handling
            try
            {
                // Fill the adapter
                companiesAdapter.Fill(dtCompaniesTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // Loop through table to find company to update
            foreach (Organization.CompaniesRow row in dtCompaniesTable.Rows)
            {
                if (row.ID == companyID)
                {
                    // Found the record
                    // Update company name
                    row.CompanyName = companyName;
                    row.ContactNumber = contactNumber;
                    row.Address = address;

                    // Update the table
                    companiesAdapter.Update(dtCompaniesTable);

                    // Return because the record has been updated
                    return;
                }
            }
        } 

        public static Organization.InventoryItemsDataTable GetInventoryItems()
        {
            // Build a table
            Organization.InventoryItemsDataTable dtInventoryItemsTable = new Organization.InventoryItemsDataTable();
            // Build the adapter
            OrganizationTableAdapters.InventoryItemsTableAdapter inventoryItemsAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            
            // Implement Sql exception handling
            try
            {
                // Fill the adapter
                inventoryItemsAdapter.Fill(dtInventoryItemsTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // return the table
            return dtInventoryItemsTable;
        }

        public static void UpdateInventoryItemById(int itemId, string itemTitle, string itemDescription, float price, int itemCategory, int companyID, float length, float width, float height, float weight, string isbn, string author, int bookType, DateTime packDate, DateTime expirationDate, int groceryCategory)
        {
            // EXTRA EXCEPTION HANDLING
            if (price < 0 || price > 100000)
            {
                // Price is out of range
                throw new ArgumentOutOfRangeException("Price cannot be negative or over $100,000", "Price");
            }

            // Create the table
            Organization.InventoryItemsDataTable dtInventoryItemsTable = new Organization.InventoryItemsDataTable();
            // Create the adapter
            OrganizationTableAdapters.InventoryItemsTableAdapter inventoryItemsAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            
            // Implement sql exception handling
            try
            {
                // Fill the adapter
                inventoryItemsAdapter.Fill(dtInventoryItemsTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // Find the record to update
            foreach (Organization.InventoryItemsRow row in dtInventoryItemsTable.Rows)
            {
                // Check the id
                if (row.ID == itemId)
                {
                    // found the record, update fields
                    row.ItemTitle = itemTitle;
                    row.Category = itemCategory;
                    row.Description = itemDescription;
                    row.Price = price;
                    row.CompanyID = companyID;
                    row.Length = length;
                    row.Width = width;
                    row.Height = height;
                    row.Weight = weight;
                    row.ISBN = isbn;
                    row.Author = author;
                    row.BookType = bookType;
                    row.PackagingDate = packDate;
                    row.ExpirationDate = expirationDate;
                    row.GroceryCategory = groceryCategory;

                    // Update the table in SQl server
                    inventoryItemsAdapter.Update(dtInventoryItemsTable);

                    // return
                    return;
                }
            }
        }

        public static void DeleteInventoryItemById(int itemId)
        {
            // Create the table
            Organization.InventoryItemsDataTable dtInventoryItemsTable = new Organization.InventoryItemsDataTable();
            // Create the adapter
            OrganizationTableAdapters.InventoryItemsTableAdapter inventoryItemsAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            
            // Implement sql exception handling
            try
            {
                // Fill the adapter
                inventoryItemsAdapter.Fill(dtInventoryItemsTable);
            }
            catch (SqlException sqlException)
            {
                //Log as much information as possible for the development
                // or customer support team
                // using loggers
                System.Diagnostics.Debug.WriteLine(sqlException);
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                System.Diagnostics.Debug.WriteLine(sqlException.Server);
                System.Diagnostics.Debug.WriteLine(sqlException.Source);

                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

            // Loop through to find row to delete
            foreach (Organization.InventoryItemsRow row in dtInventoryItemsTable.Rows)
            {
                if (row.ID == itemId)
                {
                    // Found row to delete
                    row.Delete();

                    // Update table
                    inventoryItemsAdapter.Update(dtInventoryItemsTable);

                    return;
                }
            }
        }
    }
}
